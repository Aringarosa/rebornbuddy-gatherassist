using System.Diagnostics;
using System.Threading;
using System.Xml;
using ff14bot;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Helpers;
using ff14bot.Interfaces;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using ff14bot.Settings;
using Clio.Utilities;
using GatherAssist.Settings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using TreeSharp;

using Action = TreeSharp.Action;
using System.Xml.Linq;
using ff14bot.NeoProfiles;
using System.Data;

namespace GatherAssist
{
    public class GatherAssist : IBotPlugin
    {
        const string pluginName = "GatherAssist";

        public string Author { get { return " Zane McFate"; } }
        public string Description { get { return "Extends OrderBot gathering functionality to seek multiple items with a single command."; } }
        public Version Version { get { return new Version(0, 1, 0); } }
        public string Name { get { return pluginName; } }

        public static GatherAssistSettings settings = GatherAssistSettings.instance;
        private List<GatherRequest> requestList;
        private int killRadius = 50;
        private string gatheringSpell = "Sharp Vision II"; // spell to idly fire when resources allow.  TODO: add level-based flexibility.
        private GatherRequest currentGatherRequest = null;
        private static System.Timers.Timer GatherAssistTimer;
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
            if (_form == null || _form.IsDisposed || _form.Disposing)
                _form = new GatherAssist_Form();

            _form.ShowDialog();
            InitializeCrystalList(); // reinitialize from updated settings

            GatherAssistTimer.Interval = (settings.UpdateIntervalMinutes * 60000);
            GatherAssistTimer.Start();
        }
        public bool Equals(IBotPlugin other)
        {
            throw new NotImplementedException();
        }

        private GatherAssist_Form _form;

        public void OnInitialize()
        {
            // default settings values
            if (settings.ShardTarget == 0)
            {
                settings.ShardTarget = 500;
            }

            if (settings.UpdateIntervalMinutes == 0)
            {
                settings.UpdateIntervalMinutes = 1;
            }

            GatherAssistTimer.Elapsed += GatherAssistTimer_Elapsed;
            GatherAssistTimer.Interval = (settings.UpdateIntervalMinutes * 60000);
        }
        public void OnShutdown()
        {
        }
        public void OnEnabled()
        {
            Logging.Write(Colors.SkyBlue, "[" + pluginName + "] v" + Version.ToString() + " Enabled");
            InitializeCrystalList();
        }

        void GatherAssistTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            UpdateRequestedItemCounts();
            ReportGatheringStatus();

            if (currentGatherRequest == null) // if no valid gather requests remain
            {
                Logging.Write(Colors.Teal, "Gather requests complete!  GatherAssist will stop now.");
                GatherAssistTimer.Stop();
                // TODO: find a way to stop the bot
                return;
            }
            else
            {
                LoadProfile();
            }
        }

        public void OnDisabled()
        {
            Logging.Write(Colors.SkyBlue, "[" + pluginName + "] v" + Version.ToString() + " Disabled");
            GatherAssistTimer.Stop();
        }

        public void OnPulse()
        {
        }

        public void InitializeCrystalList()
        {
            requestList = new List<GatherRequest>();
            requestList.Add(new GatherRequest("Fire Shard", settings.ShardTarget));
            requestList.Add(new GatherRequest("Ice Shard", settings.ShardTarget));
            requestList.Add(new GatherRequest("Wind Shard", settings.ShardTarget));
            //            crystalList.Add(new GatherRequest("Earth Shard", settings.ShardTarget));
            requestList.Add(new GatherRequest("Lightning Shard", settings.ShardTarget));
            requestList.Add(new GatherRequest("Water Shard", settings.ShardTarget));
            // crystal
            // cluster
        }

        /// <summary>
        /// Updates item counts for all requested items.  Assigns a valid gather request for continuing work.
        /// If all gather requests have been fulfilled, moves plugin to finished state.
        /// </summary>
        public void UpdateRequestedItemCounts()
        {
            currentGatherRequest = null; // reset current gather request, will be set to first valid request below


            foreach (BagSlot curSlot in InventoryManager.GetBagByInventoryBagId(InventoryBagId.Crystals))
            {
                var obj = requestList.FirstOrDefault(x => x.ItemName == curSlot.Name);
                if (obj != null)
                {
                    obj.CurrentCount = curSlot.Count;
                    if (currentGatherRequest == null && obj.RequestedTotal < obj.CurrentCount)
                    {
                        currentGatherRequest = obj as GatherRequest;
                    }
                }
            }
        }

        /// <summary>
        /// Lists the gathering status of all requested items.
        /// </summary>
        public void ReportGatheringStatus()
        {
            foreach (GatherRequest curRequest in requestList)
            {
                Color logColor = curRequest.RequestedTotal < curRequest.CurrentCount ? Colors.Teal : Colors.SkyBlue;
                Logging.Write(logColor, string.Format("Item: {0}, Count: {1}, Requested: {2}", curRequest.ItemName, curRequest.CurrentCount, curRequest.RequestedTotal));
            }
        }

        public void LoadProfile()
        {
            bool isValid = true;

            if (currentGatherRequest == null)
            {
                Logging.Write(Colors.Red, string.Format("Error: LoadProfile was executed without an active gather request; this should not be done.  Shutting down {0} plugin."));
                isValid = false;
            }

            ItemRecord itemRecord = GetItemRecord(currentGatherRequest.ItemName);
            if (itemRecord == null)
            {
                Logging.Write(Colors.Red, string.Format("Error: item {0} cannot be located.  A new items entry must be created for this gather request to function properly.", currentGatherRequest.ItemName));
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
            }
        }

        /// <summary>
        /// Populates map records for aetheryte teleporting.
        /// </summary>
        public void InitializeMaps()
        {
            mapsTable = new DataTable("maps");
            mapsTable.Columns.Add("AetheryteId");
            mapsTable.Columns.Add("AetheryteName");
            mapsTable.Columns.Add("MapNumber");

            mapsTable.Rows.Add(2, "New Gridania", 132);
            mapsTable.Rows.Add(3, "Bentbranch Meadows", 148);
            mapsTable.Rows.Add(4, "Hawthorne Hut", 152);
            mapsTable.Rows.Add(5, "Querrymill", 153);
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

        /// <summary>
        /// Populates the items table with gatherable items and various required values on where/how to obtain them.
        /// </summary>
        public void InitializeItems()
        {
            itemsTable = new DataTable("items");
            itemsTable.Columns.Add("ItemName");
            itemsTable.Columns.Add("AetheryteId");
            itemsTable.Columns.Add("GatherObject");
            itemsTable.Columns.Add("HotspotRadius");
            itemsTable.Columns.Add("Location");

            itemsTable.Rows.Add("Fire Shard", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519");
            itemsTable.Rows.Add("Ice Shard", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518");
            itemsTable.Rows.Add("Wind Shard", 95, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551");
            itemsTable.Rows.Add("Lightning Shard", 53, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551");
            itemsTable.Rows.Add("Water Shard", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519");
            //itemsTable.Rows.Add("Wind Rock", 5, "Rocky Outcrop", 95, "45.63465, 6.407045, 8.635086");
        }

        /// <summary>
        /// Retrieves the full item record for the supplied item name.
        /// </summary>
        /// <param name="itemName">The name of the item being searched.</param>
        /// <returns>The ItemRecord for the supplied item name.  Null if no item name can be found in the item table.</returns>
        public ItemRecord GetItemRecord(string itemName)
        {
            bool isValid = false;
            DataRow[] itemRows = itemsTable.Select("ItemName = \"" + itemName + "\"");
            int itemCount = itemRows.Count<DataRow>();
            if (itemCount > 1)
            {
                Logging.Write(Colors.Red, string.Format("Requested item record {0} exists in {1} records; remove duplicates for this item before continuing.", itemName, itemCount));
                isValid = false;
            }
            else if (itemCount == 0)
            {
                Logging.Write(Colors.Red, string.Format("Requested item name {0} does not exist in the item table; plesae create a record for this item before continuing.", itemName));
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

                DataRow[] mapRows = mapsTable.Select("AetheryteId = " + itemRecord.AetheryteId);
                int mapCount = mapRows.Count<DataRow>();

                if (mapCount > 1)
                {
                    Logging.Write(Colors.Red, string.Format("Requested Aetheryte ID {0} exists in {1} records; remove duplicates for this aetheryte before continuing.", itemRecord.AetheryteId, mapCount));
                    isValid = false;
                }
                else if (mapCount == 0)
                {
                    Logging.Write(Colors.Red, string.Format("Requested Aetheryte ID {0} does not exist in the maps table; please create a record for this aetheryte before continuing.", itemRecord.AetheryteId));
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

            return null; // if valid ItemRecord was not returned, return null here
        }
    }
}
