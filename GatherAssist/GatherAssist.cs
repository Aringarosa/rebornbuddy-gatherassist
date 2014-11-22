using System.Threading;
using ff14bot;
using ff14bot.Enums;
using ff14bot.Helpers;
using ff14bot.Interfaces;
using ff14bot.Managers;
using GatherAssist.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Media;

using Action = TreeSharp.Action;
using System.Xml.Linq;
using ff14bot.NeoProfiles;
using System.Data;

namespace GatherAssist
{
    public class GatherAssist : IBotPlugin
    {
        const string pluginName = "GatherAssist";
        Color LogMajorColor = Colors.SkyBlue;
        Color LogMinorColor = Colors.Teal;
        Color LogErrorColor = Colors.Red;

        public string Author { get { return " Zane McFate"; } }
        public string Description { get { return "Extends OrderBot gathering functionality to seek multiple items with a single command."; } }
        public Version Version { get { return new Version(0, 1, 0); } }
        public string Name { get { return pluginName; } }

        public static GatherAssistSettings settings = GatherAssistSettings.instance;
        private List<GatherRequest> requestList;
        private int killRadius = 50;
        private string gatheringSpell = "Sharp Vision II"; // spell to idly fire when resources allow.  TODO: add level-based flexibility.
        private GatherRequest currentGatherRequest = null;
        private static System.Timers.Timer GatherAssistTimer = new System.Timers.Timer();
        private DataTable mapsTable;
        private DataTable itemsTable;

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public bool WantButton
        {
            get { return true; }
        }
        public string ButtonText
        {
            get { return pluginName; }
        }
        public void OnButtonPress()
        {
            try
            {
                if (_form == null || _form.IsDisposed || _form.Disposing)
                    _form = new GatherAssist_Form(itemsTable);

                _form.ShowDialog();
                if (_form.DialogResult == DialogResult.OK) // don't alter anything if the user cancelled the form
                {
                    InitializeRequestList(_form.requestTable); // reinitialize from updated settings
                    GatherAssistTimer.Interval = (settings.UpdateIntervalMinutes * 60000);
                    GatherAssistTimer.Start();
                    ElapseTimer(); // immediately elapse timer to check item counts and set correct profile
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }
        public bool Equals(IBotPlugin other)
        {
            throw new NotImplementedException();
        }

        private GatherAssist_Form _form;

        public void OnInitialize()
        {
            try
            {
                InitializeItems();
                InitializeMaps();

                if (settings.UpdateIntervalMinutes == 0)
                {
                    settings.UpdateIntervalMinutes = 1;
                }

                GatherAssistTimer.Elapsed += GatherAssistTimer_Elapsed;
                GatherAssistTimer.Interval = (settings.UpdateIntervalMinutes * 60000);
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        public void OnShutdown()
        {
        }
        public void OnEnabled()
        {
            try
            {
                Logging.Write(LogMajorColor, "[" + pluginName + "] v" + Version.ToString() + " Enabled");
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        void GatherAssistTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                ElapseTimer();
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        void ElapseTimer()
        {
            try
            {
                string lastRequest = currentGatherRequest == null ? "" : currentGatherRequest.ItemName;
                UpdateRequestedItemCounts();
                ReportGatheringStatus();

                if (currentGatherRequest == null) // if no valid gather requests remain
                {
                    Logging.Write(LogMajorColor, "Gather requests complete!  GatherAssist will stop now.");
                    GatherAssistTimer.Stop();
                    TreeRoot.Stop(); // stop the bot
                    return;
                }
                else if (currentGatherRequest.ItemName != lastRequest) // keeps profile from needlessly reloading
                {
                    LoadProfile();
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        public void OnDisabled()
        {
            try
            {
                Logging.Write(LogMajorColor, "[" + pluginName + "] v" + Version.ToString() + " Disabled");
                GatherAssistTimer.Stop();
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        public void OnPulse()
        {
        }

        public void InitializeRequestList(DataTable requestTable)
        {
            try
            {
                requestList = new List<GatherRequest>();

                foreach (DataRow dataRow in requestTable.Rows)
                {
                    Logging.Write(LogMajorColor, "DEBUG: Adding " + dataRow["ItemName"] + " to request list");
                    requestList.Add(new GatherRequest(Convert.ToString(dataRow["ItemName"]), Convert.ToInt32(dataRow["Count"])));
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        /// <summary>
        /// Updates item counts for all requested items.  Assigns a valid gather request for continuing work.
        /// If all gather requests have been fulfilled, moves plugin to finished state.
        /// </summary>
        public void UpdateRequestedItemCounts()
        {
            try
            {
                currentGatherRequest = null; // reset current gather request, will be set to first valid request below

                foreach (GatherRequest curRequest in requestList)
                {
                    curRequest.CurrentCount = 0;
                }

                List<InventoryBagId> validBags = new List<InventoryBagId>();
                validBags.Add(InventoryBagId.Bag1);
                validBags.Add(InventoryBagId.Bag2);
                validBags.Add(InventoryBagId.Bag3);
                validBags.Add(InventoryBagId.Bag4);
                validBags.Add(InventoryBagId.Crystals);

                foreach (InventoryBagId curBagId in validBags)
                {
                    Logging.Write(LogMajorColor, curBagId.ToString()); // debug
                    foreach (BagSlot curSlot in InventoryManager.GetBagByInventoryBagId(curBagId))
                    {
                        var obj = requestList.FirstOrDefault(x => x.ItemName == curSlot.Name);
                        if (obj != null)
                        {
                            Logging.Write(LogMajorColor, "DEBUG: Updating count");
                            obj.CurrentCount += curSlot.Count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        /// <summary>
        /// Lists the gathering status of all requested items.
        /// </summary>
        public void ReportGatheringStatus()
        {
            try
            {
                foreach (GatherRequest curRequest in requestList)
                {
                    Color logColor = curRequest.RequestedTotal <= curRequest.CurrentCount ? LogMinorColor : LogMajorColor;
                    Logging.Write(logColor, string.Format("Item: {0}, Count: {1}, Requested: {2}", curRequest.ItemName, curRequest.CurrentCount, curRequest.RequestedTotal));
                    if (currentGatherRequest == null && curRequest.CurrentCount < curRequest.RequestedTotal)
                    {
                        Logging.Write(LogMajorColor, string.Format("DEBUG: Updating gather request to {0}", curRequest.ItemName));
                        currentGatherRequest = curRequest;
                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        public void LoadProfile()
        {
            try
            {
                bool isValid = true;

                if (currentGatherRequest == null)
                {
                    Logging.Write(LogErrorColor, string.Format("Error: LoadProfile was executed without an active gather request; this should not be done.  Shutting down {0} plugin."));
                    isValid = false;
                }

                Logging.Write(LogMajorColor, string.Format("DEBUG: Current Gather Request is {0}", currentGatherRequest.ItemName));
                ItemRecord itemRecord = GetItemRecord(currentGatherRequest.ItemName);
                if (itemRecord == null)
                {
                    Logging.Write(LogErrorColor, string.Format("Error: item {0} cannot be located.  A new items entry must be created for this gather request to function properly.", currentGatherRequest.ItemName));
                    isValid = false;
                }

                if (!isValid)
                {
                    GatherAssistTimer.Stop();
                }
                else
                {
                    //string aetheryteName = itemRecord.AetheryteName;
                    //string aetheryteId = "5";
                    //string gatherObject = "Mineral Deposit";
                    //string hotspotRadius = "60";
                    //string location = "353.7134, -3.617686, 58.73518";

                    // TODO: Add this section to job change
            //</If>
            //    <If Condition="Core.Me.CurrentJob != ClassJobType.Miner">
            //    <ChangeJob Type="Miner" />
            // </If>

                    // get profile variables for the requested item name
                    string xmlContent = string.Format("<Profile><Name>{0}</Name><KillRadius>{1}</KillRadius><Order><If Condition=\"not IsOnMap({2}" +
                        ")\"><TeleportTo Name=\"{3}\" AetheryteId=\"{4}\" /></If><Gather while=\"True\"><GatherObject>{5}</GatherObject><HotSpots>" +
                        "<HotSpot Radius=\"{6}\" XYZ=\"{7}\" /></HotSpots><ItemNames><ItemName>{8}</ItemName></ItemNames><GatheringSkillOrder>" +
                        "<GatheringSkill SpellName=\"{9}\" TimesToCast=\"1\" /></GatheringSkillOrder></Gather></Order></Profile>",
                        "Mining: " + itemRecord.ItemName,
                        killRadius,
                        itemRecord.MapNumber,
                        itemRecord.AetheryteName,
                        itemRecord.AetheryteId,
                        itemRecord.GatherObject,
                        itemRecord.HotspotRadius,
                        itemRecord.Location,
                        itemRecord.ItemName,
                        gatheringSpell
                        );

                    string targetXmlName = "currentProfile.xml";
                    string profilePath = "C:/Programs/RebornBuddy/Plugins/GatherAssist"; // TODO: Get temp folder or actual plugins folder
                    string targetXmlFile = profilePath + "/" + targetXmlName;
                    File.WriteAllText(targetXmlFile, xmlContent);
                    NeoProfileManager.Load(targetXmlFile, true); // profile will automatically switch to the new gathering profile at this point

                    // reboot the bot; this is a workaround for the profile loader not properly updating item names.
                    TreeRoot.Stop();
                    Thread.Sleep(1000);
                    TreeRoot.Start();
    //                ProfileManager.LoadNew(xmlContent, true);
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        /// <summary>
        /// Populates map records for aetheryte teleporting.
        /// </summary>
        public void InitializeMaps()
        {
            try
            {
                mapsTable = new DataTable("maps");
                mapsTable.Columns.Add("AetheryteId");
                mapsTable.Columns.Add("AetheryteName");
                mapsTable.Columns.Add("MapNumber");

                mapsTable.Rows.Add(2, "New Gridania", 132);
                mapsTable.Rows.Add(3, "Bentbranch Meadows", 148);
                mapsTable.Rows.Add(4, "Hawthorne Hut", 152);
                mapsTable.Rows.Add(5, "Quarrymill", 153);
                mapsTable.Rows.Add(6, "Camp Tranquil", 153);
                mapsTable.Rows.Add(7, "Fallgourd Float", 154);
                mapsTable.Rows.Add(8, "Limsa Lominsa", 129);
                mapsTable.Rows.Add(9, "Ul'dah", 130);
                mapsTable.Rows.Add(10, "Moraby drydocks", 135);
                mapsTable.Rows.Add(11, "Costa Del Sol", 137);
                mapsTable.Rows.Add(12, "Wineport", 137);
                mapsTable.Rows.Add(13, "Swiftperch", 138);
                mapsTable.Rows.Add(14, "Aleport", 138);
                mapsTable.Rows.Add(15, "Camp Bronze Lake", 139);
                mapsTable.Rows.Add(16, "Camp Overlook", 180);
                mapsTable.Rows.Add(17, "Horizon", 140);
                mapsTable.Rows.Add(18, "Camp Drybone", 145);
                mapsTable.Rows.Add(19, "Little Ala Mhigo", 146);
                mapsTable.Rows.Add(20, "Forgotten Springs", 146);
                mapsTable.Rows.Add(21, "Camp Bluefog", 147);
                mapsTable.Rows.Add(22, "Ceruleum Processing Plant", 147);
                mapsTable.Rows.Add(23, "Camp Dragonhead", 155);
                mapsTable.Rows.Add(24, "Revenant's Toll", 154);
                mapsTable.Rows.Add(52, "Summerford Farms", 134);
                mapsTable.Rows.Add(53, "Black Brush Station", 141);
                mapsTable.Rows.Add(55, "Wolves' Den Pier", 250);
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        /// <summary>
        /// Populates the items table with gatherable items and various required values on where/how to obtain them.
        /// </summary>
        public void InitializeItems()
        {
            try
            {
                itemsTable = new DataTable("items");
                itemsTable.Columns.Add("ItemName");
                itemsTable.Columns.Add("AetheryteId");
                itemsTable.Columns.Add("GatherObject");
                itemsTable.Columns.Add("HotspotRadius");
                itemsTable.Columns.Add("Location");

                itemsTable.Rows.Add("Alumen", 18, "Mineral Deposit", 95, "-183.1978, -34.69329, -37.8227");
                itemsTable.Rows.Add("Black Alumen", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518");
                itemsTable.Rows.Add("Bomb Ash", 20, "Rocky Outcrop", 95, "26.02704, 8.851164, 399.923");
                itemsTable.Rows.Add("Brown Pigment", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752");
                itemsTable.Rows.Add("Copper Ore", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519");
                //itemsTable.Rows.Add("Earth Cluster", 10, "Rocky Outcrop", 60, "30.000,700.000,40.000");
                itemsTable.Rows.Add("Earth Crystal", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752");
                itemsTable.Rows.Add("Earth Shard", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752");
                itemsTable.Rows.Add("Electrum Ore", 15, "Mineral Deposit", 60, "431.936371, 6.170725, 153.524521");
                itemsTable.Rows.Add("Electrum Sand", 15, "Rocky Outcrop", 60, "350.000,-3.000,40.000");
                itemsTable.Rows.Add("Fire Crystal", 18, "Rocky Outcrop", 95, "140.7642, 7.528731, -98.47753");
                itemsTable.Rows.Add("Fire Shard", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519");
                itemsTable.Rows.Add("Grade 2 Carbonized Matter", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752");
                itemsTable.Rows.Add("Grade 3 Carbonized Matter", 10, "Rocky Outcrop", 60, "21.32569, 43.12733, 717.137");
                itemsTable.Rows.Add("Ice Shard", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518");
                itemsTable.Rows.Add("Iron Ore", 17, "Mineral Deposit", 95, "288.9167, 62.34205, -218.6282");
                itemsTable.Rows.Add("Lightning Shard", 53, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551");
                itemsTable.Rows.Add("Marble", 15, "Rocky Outcrop", 60, "350.000,-3.000,40.000");
                itemsTable.Rows.Add("Muddy Water", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519");
                itemsTable.Rows.Add("Mythril Ore", 20, "Mineral Deposit", 95, "181.7675, 3.287047, 962.0443");
                itemsTable.Rows.Add("Obsidian", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928");
                itemsTable.Rows.Add("Raw Fluorite", 18, "Mineral Deposit", 95, "-183.1978, -34.69329, -37.8227");
                itemsTable.Rows.Add("Raw Heliodor", 20, "Mineral Deposit", 95, "181.7675, 3.287047, 962.0443");
                itemsTable.Rows.Add("Raw Malachite", 18, "Mineral Deposit", 95, "-183.1978, -34.69329, -37.8227");
                itemsTable.Rows.Add("Raw Spinel", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518");
                itemsTable.Rows.Add("Raw Tourmaline", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518");
                itemsTable.Rows.Add("Silex", 20, "Rocky Outcrop", 95, "26.02704, 8.851164, 399.923");
                itemsTable.Rows.Add("Soiled Femur", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928");
                itemsTable.Rows.Add("Tin Ore", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928");
                itemsTable.Rows.Add("Water Shard", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519");
                //itemsTable.Rows.Add("Wind Rock", 5, "Rocky Outcrop", 95, "45.63465, 6.407045, 8.635086");
                itemsTable.Rows.Add("Wind Shard", 53, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551");
                itemsTable.Rows.Add("Wyvern Obsidian", 18, "Mineral Deposit", 60, "250.000,5.000,230.000");
                itemsTable.Rows.Add("Yellow Pigment", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752");
                itemsTable.Rows.Add("Zinc Ore", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928");
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        /// <summary>
        /// Retrieves the full item record for the supplied item name.
        /// </summary>
        /// <param name="itemName">The name of the item being searched.</param>
        /// <returns>The ItemRecord for the supplied item name.  Null if no item name can be found in the item table.</returns>
        public ItemRecord GetItemRecord(string itemName)
        {
            try
            {
                bool isValid = true;
                DataRow[] itemRows = itemsTable.Select(string.Format("ItemName = '{0}'", itemName));
                int itemCount = itemRows.Count<DataRow>();
                if (itemCount > 1)
                {
                    Logging.Write(LogErrorColor, string.Format("CONTACT DEVELOPER! Requested item record {0} exists in {1} records; remove duplicates for this item before continuing.", itemName, itemCount));
                    isValid = false;
                }
                else if (itemCount == 0)
                {
                    Logging.Write(LogErrorColor, string.Format("CONTACT DEVELOPER! Requested item name {0} does not exist in the item table; plesae create a record for this item before continuing.", itemName));
                    isValid = false;
                }

                if (!isValid)
                {
                    GatherAssistTimer.Stop();
                }
                else
                {
                    DataRow itemRow = itemRows[0];
                    ItemRecord itemRecord = new ItemRecord();
                    itemRecord.ItemName = Convert.ToString(itemRow["ItemName"]);
                    itemRecord.AetheryteId = Convert.ToInt32(itemRow["AetheryteId"]);

                    itemRecord.GatherObject = Convert.ToString(itemRow["GatherObject"]);
                    itemRecord.HotspotRadius = Convert.ToInt32(itemRow["HotspotRadius"]);
                    itemRecord.Location = Convert.ToString(itemRow["Location"]);

                    DataRow[] mapRows = mapsTable.Select(string.Format("AetheryteId = '{0}'", itemRecord.AetheryteId));
                    int mapCount = mapRows.Count<DataRow>();

                    if (mapCount > 1)
                    {
                        Logging.Write(LogErrorColor, string.Format("CONTACT DEVELOPER!  Requested Aetheryte ID {0} exists in {1} records; remove duplicates for this aetheryte before continuing.", itemRecord.AetheryteId, mapCount));
                        isValid = false;
                    }
                    else if (mapCount == 0)
                    {
                        Logging.Write(LogErrorColor, string.Format("CONTACT DEVELOPER!  Requested Aetheryte ID {0} does not exist in the maps table; please create a record for this aetheryte before continuing.", itemRecord.AetheryteId));
                        isValid = false;
                    }

                    if (!isValid)
                    {
                        GatherAssistTimer.Stop();
                    }
                    else
                    {
                        DataRow mapRow = mapRows[0];
                        itemRecord.AetheryteName = Convert.ToString(mapRow["AetheryteName"]);
                        itemRecord.MapNumber = Convert.ToInt32(mapRow["MapNumber"]);
                        return itemRecord; // return completed itemRow
                    }
                }

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            return null; // if valid ItemRecord was not returned or error was thrown, return null here
        }

        public void LogException(Exception ex)
        {
            Logging.Write(LogErrorColor, string.Format("Exception in plugin {0}: {1} {2}", pluginName, ex.Message, ex.StackTrace));
            GatherAssistTimer.Stop();
        }

        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
