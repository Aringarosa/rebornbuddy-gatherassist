//-----------------------------------------------------------------------
// <copyright file="ItemRecord.cs" company="Zane McFate">
//      This code file, and this entire plugin, is uncopyrighted.  This means
//       I've put them in the public domain, and released my copyright on all
//       these works.  There is no need to email me for permission -- use my
//       content however you want!  Email it, share it, reprint it with or
//       without credit.  Change it around, break it, and attribute it to me.
//       It's okay.  Attribution is appreciated, but not required.
// </copyright>
// <author>Zane McFate</author>
//-----------------------------------------------------------------------
namespace GatherAssist
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Contains information required to gather a specific item, to be used in generating profiles.  ItemName is used in comparison operations.
    /// </summary>
    public class ItemRecord
    {
        /// <summary>
        /// Gets or sets the name of the gatherable item.
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the class required to gather the item.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets the aethernet ID, which corresponds to the map number.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Aethernet is a FFXIV term.")]
        public int AetheryteId { get; set; }

        /// <summary>
        /// Gets or sets the map code for the area where the item can be found.
        /// </summary>
        public int MapNumber { get; set; }

        /// <summary>
        /// Gets or sets the aethernet name, corresponds to the aethernet ID.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Aethenet is a FFXIV term.")]
        public string AetheryteName { get; set; }

        /// <summary>
        /// Gets or sets the object where the gatherable item can be found.
        /// </summary>
        public string GatherObject { get; set; }

        /// <summary>
        /// Gets or sets the level of the gather object.
        /// </summary>
        public int ObjectLevel { get; set; }

        /// <summary>
        /// Gets or sets the radius from the target location where gather objects should be searched.
        /// </summary>
        public int HotspotRadius { get; set; }

        /// <summary>
        /// Gets or sets the target location to begin searching for gatherable objects.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the slot number in the gather window where this item can be found.  This will allow
        ///  the bot to work even if the item has never been gathered by the current character.
        /// </summary>
        public int SlotNumber { get; set; }
    }
}
