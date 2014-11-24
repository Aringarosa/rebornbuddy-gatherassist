﻿namespace GatherAssist
{
    /// <summary>
    /// Contains information required to gather a specific item, to be used in generating profiles.  ItemName is used in comparison operations.
    /// </summary>
    public class ItemRecord
    {
        /// <summary>
        /// Name of the gatherable item.
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Class required to gather the item.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Aethernet ID, corresponds to the map number.
        /// </summary>
        public int AetheryteId { get; set; }

        /// <summary>
        /// Map code for the area where the item can be found.
        /// </summary>
        public int MapNumber { get; set; }

        /// <summary>
        /// Aethernet name, corresponds to the aethernet ID.
        /// </summary>
        public string AetheryteName { get; set; }

        /// <summary>
        /// The object where the gatherable item can be found.
        /// </summary>
        public string GatherObject { get; set; }

        /// <summary>
        /// Radius from the target location where gather objects should be searched.
        /// </summary>
        public int HotspotRadius { get; set; }

        /// <summary>
        /// Target location to begin searching for gatherable objects.
        /// </summary>
        public string Location { get; set; }
    }
}
