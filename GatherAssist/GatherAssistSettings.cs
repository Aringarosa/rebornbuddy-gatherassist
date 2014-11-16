using ff14bot;
using ff14bot.Helpers;
using Clio.Utilities;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;

namespace GatherAssist.Settings
{
    public class GatherAssistSettings : JsonSettings
    {
        [JsonIgnore]
        private static GatherAssistSettings _instance;
        public static GatherAssistSettings instance { get { return _instance ?? (_instance = new GatherAssistSettings("GatherAssistSettings")); } }
        public GatherAssistSettings(string filename) : base(Path.Combine(CharacterSettingsDirectory, "GatherAssist.json")) { }

        [Setting]
        public int ShardTarget { get; set; }
        public int UpdateIntervalMinutes { get; set; }
    }
}