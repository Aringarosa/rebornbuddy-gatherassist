//-----------------------------------------------------------------------
// <copyright file="GatherAssistSettings.cs" company="Zane McFate">
//      This code file, and this entire plugin, is uncopyrighted.  This means
//       I've put them in the public domain, and released my copyright on all
//       these works.  There is no need to email me for permission -- use my
//       content however you want!  Email it, share it, reprint it with or
//       without credit.  Change it around, break it, and attribute it to me.
//       It's okay.  Attribution is appreciated, but not required.
// </copyright>
// <author>Zane McFate</author>
//-----------------------------------------------------------------------
using ff14bot.Helpers;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;

namespace GatherAssist.Settings
{
    /// <summary>
    /// Holds all settings for this plugin which must be saved and restored.
    /// </summary>
    public class GatherAssistSettings : JsonSettings
    {
        /// <summary>
        /// The single instance of these settings, allowing multiple classes to call the single set of plugin settings.
        /// </summary>
        [JsonIgnore]
        private static GatherAssistSettings _instance;

        /// <summary>
        /// A property for accessing the single settings instance for this plugin.  Creates a new settings instance if it does not exist.
        /// </summary>
        public static GatherAssistSettings instance { get { return _instance ?? (_instance = new GatherAssistSettings("GatherAssistSettings")); } }

        /// <summary>
        /// The constructor for GatherAssistSettings class.  Sets the appropriate files location for these settings (per character).
        /// </summary>
        /// <param name="filename">The parameter is not used.</param>
        public GatherAssistSettings(string filename) : base(Path.Combine(CharacterSettingsDirectory, "GatherAssist.json")) { }

        /// <summary>
        /// The interval, in minutes, when the gathering status should be checked, and the engine routines change to continue execution.
        /// </summary>
        [Setting]
        public int UpdateIntervalMinutes { get; set; }

        /// <summary>
        /// The list of available gear sets.  Used when the plugin must swtich classes to gather items from different class skill sets.
        /// </summary>
        [Setting]
        public string[] gearSets { get; set; }
    }
}