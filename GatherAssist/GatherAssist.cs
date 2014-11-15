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

namespace GatherAssist
{
    public class GatherAssist : IBotPlugin
    {
        const string pluginName = "GatherAssist";

        #region Initialization Information
        public string Author { get { return " Zane McFate"; } }
        public string Description { get { return "Adds chat-based functionality."; } }
        public Version Version { get { return new Version(0, 1, 0); } }
        public string Name { get { return pluginName; } }

        public static GatherAssistSettings settings = GatherAssistSettings.instance;
        private List<GatherRequest> crystalList;

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
            InitializeCrystalList();
            UpdateItemCount();
            ReportGatheringStatus();
            
            XElement curElement = NeoProfileManager.CurrentProfile.Element;
            curElement.Remove
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
        }
        public void OnShutdown()
        {

        }
        public void OnEnabled()
        {
            Logging.Write(Colors.SkyBlue, "[" + pluginName + "] v" + Version.ToString() + " Enabled");
            InitializeCrystalList();
            UpdateItemCount();
            ReportGatheringStatus();
        }
        public void OnDisabled()
        {
            Logging.Write(Colors.SkyBlue, "[" + pluginName + "] v" + Version.ToString() + " Disabled");
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
        public void UpdateItemCount()
        {
            foreach (BagSlot curSlot in InventoryManager.GetBagByInventoryBagId(InventoryBagId.Crystals))
            {
                var obj = crystalList.FirstOrDefault(x => x.ItemName == curSlot.Name);
                if (obj != null) obj.CurrentCount = curSlot.Count;
            }
        }

        public void ReportGatheringStatus()
        {
            foreach (GatherRequest curRequest in crystalList)
            {
                Color logColor = curRequest.RequestedTotal < curRequest.CurrentCount ? Colors.Teal : Colors.SkyBlue;
                Logging.Write(logColor, string.Format("Item: {0}, Count: {1}, Requested: {2}", curRequest.ItemName, curRequest.CurrentCount, curRequest.RequestedTotal));
            }
        }
    }
}
