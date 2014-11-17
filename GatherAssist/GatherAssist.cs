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

namespace GatherAssist
{
    public class GatherAssist : IBotPlugin
    {
        const string pluginName = "GatherAssist";

        #region Initialization Information
        public string Author { get { return " Zane McFate"; } }
        public string Description { get { return "Extends OrderBot gathering functionality to seek multiple items with a single command."; } }
        public Version Version { get { return new Version(0, 1, 0); } }
        public string Name { get { return pluginName; } }

        public static GatherAssistSettings settings = GatherAssistSettings.instance;
        private List<GatherRequest> crystalList;
        private int killRadius = 50;
        private string gatheringSpell = "Sharp Vision II"; // spell to idly fire when resources allow.  TODO: add level-based flexibility.
        private GatherRequest currentGatherRequest = null;
        private static System.Timers.Timer GatherAssistTimer;

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
        #endregion

        private GatherAssist_Form _form;

        #region Init
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
                LoadProfile(currentGatherRequest);
            }
        }

        public void OnDisabled()
        {
            Logging.Write(Colors.SkyBlue, "[" + pluginName + "] v" + Version.ToString() + " Disabled");
            GatherAssistTimer.Stop();
        }
        #endregion

        #region Pulse
        public void OnPulse()
        {
        }
        #endregion
        public void InitializeCrystalList()
        {
            crystalList = new List<GatherRequest>();
            crystalList.Add(new GatherRequest("Fire Shard", settings.ShardTarget));
            crystalList.Add(new GatherRequest("Ice Shard", settings.ShardTarget));
            crystalList.Add(new GatherRequest("Wind Shard", settings.ShardTarget));
            //            crystalList.Add(new GatherRequest("Earth Shard", settings.ShardTarget));
            crystalList.Add(new GatherRequest("Lightning Shard", settings.ShardTarget));
            crystalList.Add(new GatherRequest("Water Shard", settings.ShardTarget));
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
                var obj = crystalList.FirstOrDefault(x => x.ItemName == curSlot.Name);
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
            foreach (GatherRequest curRequest in crystalList)
            {
                Color logColor = curRequest.RequestedTotal < curRequest.CurrentCount ? Colors.Teal : Colors.SkyBlue;
                Logging.Write(logColor, string.Format("Item: {0}, Count: {1}, Requested: {2}", curRequest.ItemName, curRequest.CurrentCount, curRequest.RequestedTotal));
            }
        }

        public void LoadProfile(GatherRequest gatherRequest)
        {
            string itemName = gatherRequest.ItemName;
            string mapNumber = "153"; // TODO: map to item name
            string aethernetName = "Quarrymill";
            string aethernetID = "5";
            string gatherObject = "Mineral Deposit";
            string hotspotRadius = "60";
            string location = "353.7134, -3.617686, 58.73518";

            // get profile variables for the requested item name
            string xmlContent = string.Format("<Profile><Name>{0}</Name><KillRadius>{1}</KillRadius><Order><If Condition=\"not IsOnMap({2}" +
                ")\"><TeleportTo Name=\"{3}\" AetheryteId=\"{4}\" /></If><Gather while=\"True\"><GatherObject>{5}</GatherObject><HotSpots>" +
                "<HotSpot Radius=\"{6}\" XYZ=\"{7}\" /></HotSpots><ItemNames><ItemName>{8}</ItemName></ItemNames><GatheringSkillOrder>" + 
                "<GatheringSkill SpellName=\"{9}\" TimesToCast=\"1\" /></GatheringSkillOrder></Gather></Order></Profile>",
                "Mining: " + itemName,
                killRadius,
                mapNumber,
                aethernetName,
                aethernetID,
                gatherObject,
                hotspotRadius,
                location,
                itemName,
                gatheringSpell
                );

            string targetXmlName = "currentProfile.xml";
            string profilePath = "C:/Programs/RebornBuddy/Plugins/GatherAssist"; // TODO: Get temp folder or actual plugins folder
            string targetXmlFile = profilePath + "/" + targetXmlName;
            File.WriteAllText(targetXmlFile, xmlContent);
            NeoProfileManager.Load(targetXmlFile, true); // profile will automatically switch to the new gathering profile at this point
        }
    }
}
