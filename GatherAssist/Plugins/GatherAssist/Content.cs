﻿//-----------------------------------------------------------------------
// <copyright file="Content.cs" company="Zane McFate">
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
    using System.Data;

    /// <summary>
    /// Contains the ever changing world content used to power the GatherAssist plugin.  This is kept separately to
    ///  keep the primary code files from constantly changing every time new content is added or fixed.
    /// </summary>
    public static class Content
    {
        /// <summary>
        /// Creates and populates the Items Table.
        /// </summary>
        /// <returns>A newly populated Items Table.</returns>
        public static DataTable CreateItemsTable()
        {
            DataTable itemsTable = new DataTable();

            itemsTable = new DataTable("items");
            itemsTable.Columns.Add("ItemName");
            itemsTable.Columns.Add("Information");
            itemsTable.Columns.Add("ClassName");
            itemsTable.Columns.Add("AetheryteId");
            itemsTable.Columns.Add("GatherObject");
            itemsTable.Columns.Add("ObjectLevel");
            itemsTable.Columns.Add("HotspotRadius");
            itemsTable.Columns.Add("Location");
            itemsTable.Columns.Add("SlotNumber");
            itemsTable.Columns.Add("Stealth");
            itemsTable.Columns.Add("StealthPoint");

            // Misc
            ////itemsTable.Rows.Add("Earth Cluster", "", "Miner", 10, "Rocky Outcrop", 60, "30.000,700.000,40.000", GatherAssist.NOSLOT, 0, ""); // fix
            ////itemsTable.Rows.Add("Garlean Garlic", "", "Botanist", 17, "Lush Vegetation Patch", 80, "89.10497, 20.50989, 99.95108", GatherAssist.NOSLOT, 0, "");
            ////itemsTable.Rows.Add("Ice Shard", "", "Miner", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518", GatherAssist.NOSLOT, 0, "");
            ////itemsTable.Rows.Add("Lightning Shard", "", "Miner", 53, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551", GatherAssist.NOSLOT, 0, "");
            ////itemsTable.Rows.Add("Ruby Tomato", "", "Botanist", 52, "Lush Vegetation Patch", 80, "42.27345, 52.46003, -117.3225", GatherAssist.NOSLOT, 0, "");


            //templates
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            // BotaneiLevQuest
            // 1-5
            itemsTable.Rows.Add("Chopped Firewood 1", "We couldent start the Fire", "Botanist", 3, "Mature Tree", 2, 80, "149.4821, -6.983638, -57.72332", 5, 0, "");
            itemsTable.Rows.Add("Pure Latex", "Lovely Latex", "Botanist", 3, "Mature Tree", 3, 80, "168.7536, -1.239101, -115.3219", 3, 0, "");
            itemsTable.Rows.Add("Ash Sapling", "East Bank Story", "Botanist", 3, "Mature Tree", 3, 80, "62.56903, -7.659698, -64.60542", 5, 0, "");
            itemsTable.Rows.Add("East Bank Mistletoe", "East Bank Story", "Botanist", 3, "Mature Tree", 5, 80, "62.56903, -7.659698, -64.60542", 7, 0, "");
            itemsTable.Rows.Add("Throbbing Maple Log", "Waking Wood", "Botanist", 3, "Mature Tree", 3, 80, "8.650797, 6.298589, -241.6973", 5, 0, "");
            itemsTable.Rows.Add("Treant Acorn", "Waking Wood", "Botanist", 3, "Mature Tree", 5, 80, "8.650797, 6.298589, -241.6973", 1, 0, "");
            // 10-15
            itemsTable.Rows.Add("Golden Chestnut", "A Chest of Nuts", "Botanist", 3, "Mature Tree", 15, 80, "83.60042, -28.13994, 266.2188", 1, 0, "");
            itemsTable.Rows.Add("Large Chestnut", "A Chest of Nuts", "Botanist", 3, "Mature Tree", 12, 80, "83.60042, -28.13994, 266.2188", 2, 0, "");
            //West Bank Story Bad Node Positions
            //itemsTable.Rows.Add("West Bank Mistletoe", "West Bank Story", "Botanist", 3, "Mature Tree", 15, 80, "-0.2901298, -7.354698, -33.67671", 7, 0, "");
            //itemsTable.Rows.Add("Ash Sapling", "West Bank Story", "Botanist", 3, "Mature Tree", 12, 80, "-0.2901298, -7.354698, -33.67671", 5, 0, "");
            itemsTable.Rows.Add("Sprouted Roselet Seed", "The Heart of the Hedge", "Botanist", 3, "Mature Tree", 15, 80, "-52.94984, -36.91956, 462.2035", 6, 0, "");
            itemsTable.Rows.Add("Roselet Seed", "The Heart of the Hedge", "Botanist", 3, "Mature Tree", 12, 80, "-52.94984, -36.91956, 462.2035", 7, 0, "");
            itemsTable.Rows.Add("Long Ash Log", "Digging Deeper", "Botanist", 3, "Mature Tree", 15, 80, "-66.22202, -6.033881, -58.82186", 5, 0, "");
            //15-20
            itemsTable.Rows.Add("Clear Maple Sap", "Mapple Stories", "Botanist", 4, "Mature Tree", 17, 80, "64.03939, 5.7116, 381.6705", 3, 1, "39.99684, 5.423866, 379.8489");
            itemsTable.Rows.Add("Quickweed", "The quick and the Dead", "Botanist", 4, "Lush Vegetation Patch", 17, 80, "-281.1849, 11.91321, 367.8475", 5, 0, "");
            itemsTable.Rows.Add("Jessamine", "The quick and the Dead", "Botanist", 4, "Lush Vegetation Patch", 20, 80, "-281.1849, 11.91321, 367.8475", 4, 0, "");
            itemsTable.Rows.Add("Giant Brambleweed Sap", "Briar in the Hole", "Botanist", 4, "Mature Tree", 17, 90, "-238.5367, -0.5605268, 212.0117", 3, 0, "");
            itemsTable.Rows.Add("Dried Mun-Tuy Bean", "Briar in the Hole", "Botanist", 4, "Mature Tree", 20, 90, "-238.5367, -0.5605268, 212.0117", 1, 0, "");
            itemsTable.Rows.Add("Mature Galago Mint", "Briar in the Hole", "Botanist", 4, "Lush Vegetation Patch", 17, 90, "-238.5367, -0.5605268, 212.0117", 2, 0, "");
            itemsTable.Rows.Add("Shroud Iris", "Briar in the Hole", "Botanist", 4, "Lush Vegetation Patch", 20, 90, "-238.5367, -0.5605268, 212.0117", 0, 0, "");
            itemsTable.Rows.Add("Branded Bark", "Never Strickes Twice", "Botanist", 4, "Mature Tree", 17, 90, "37.03965, -3.286162, 217.3675", 1, 1, "");
            //20-25
            itemsTable.Rows.Add("Young Galago Mint", "Shaken, Not Stirred", "Botanist", 5, "Lush Vegetation Patch", 22, 80, "70.22994, 8.849917, 19.15968", 2, 0, "101.4287, 12.13233, -1.987082");
            itemsTable.Rows.Add("Chopped Firewood 2", "Fueling the Flame", "Botanist", 5, "Mature Tree", 22, 80, "-184.9678, 8.28627, -55.22649", 5, 0, "");
            itemsTable.Rows.Add("Exposed Tree Root", "Nowhere to Slide", "Botanist", 5, "Mature Tree", 22, 90, "0.5626199, -1.303236, -53.64244", 7, 0, "");
            itemsTable.Rows.Add("Healthy Tree Root", "Nowhere to Slide", "Botanist", 5, "Mature Tree", 22, 90, "0.5626199, -1.303236, -53.64244", 6, 0, "");
            itemsTable.Rows.Add("Gelmorran Coin", "Just the Artifacts, Madam", "Botanist", 5, "Mature Tree", 22, 90, "306.2564, -0.4895204, -7.307112", 7, 1, "281.6295, 9.880111, -47.81627");
            //25-30
            itemsTable.Rows.Add("Sprite Apple", "Appleanche", "Botanist", 5, "Mature Tree", 27, 80, "208.6061, 28.29374, -158.0087", 1, 0, "");
            itemsTable.Rows.Add("Soldier's Sore Berries", "Moon in Rouge", "Botanist", 5, "Lush Vegetation Patch", 27, 80, "145.1916, 18.0616, -147.65583", 1, 1, "146.1471, 17.98494, -115.0203");
            itemsTable.Rows.Add("Two-yalm Switch", "Over the Underbrush", "Botanist", 5, "Mature Tree", 27, 70, "187.0872, 8.576387, -68.65286", 2, 0, "");
            itemsTable.Rows.Add("Hairy Caterpillar", "Over the Underbrush", "Botanist", 5, "Mature Tree", 30, 70, "187.0872, 8.576387, -68.65286", 0, 0, "");
            itemsTable.Rows.Add("Spotted Mushroom", "Mushroom Goblin", "Botanist", 5, "Mature Tree", 27, 80, "302.5681, -0.5226027, -1.946397", 6, 1, "270.9116, 5.428098, -3.448066");
            // MinerLevQuest
            // 1-5
            //Miners Holiday
            itemsTable.Rows.Add("Low-quality Copper Ore", "Miners Holiday", "Miner", 17, "Mineral Deposit", 2, 80, "260.0294, 51.3704, 53.50365", 1, 0, "");
            //The Primrose Path
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Who Needs the Paperwork
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Rubble Bubble
            itemsTable.Rows.Add("Weather-worn Brick 1", "Rubble Bubble", "Miner", 17, "Mineral Deposit", 2, 80, "372.845, 78.22433, 158.3768", 1, 0, "");
            itemsTable.Rows.Add("Undamaged Brick 1", "Rubble Bubble", "Miner", 17, "Mineral Deposit", 5, 80, "372.845, 78.22433, 158.3768", 4, 0, "");
            //5-10
            //I Dont Zinc its a Coincidence
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Pipikkulis Ship Comes In
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Do they Ore dont They
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Vanishing Point
            itemsTable.Rows.Add("Weather-worn Brick 5", "Vanishing Point", "Miner", 17 , "Mineral Deposit", 2, 80, "62.23439, 51.90614, 236.4663", 1, 0, "");
            itemsTable.Rows.Add("Undamaged Brick 5", "Vanishing Point", "Miner", 17, "Mineral Deposit", 4, 80, "62.23439, 51.90614, 236.4663", 1, 0, "");
            //10-15
            //We do this the hard way
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //It Peiste to Listen
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Thats why they call it fools
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Break It up
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //15-20
            //The Doom That came to
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Eiderdown for Eidolons
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Eartg Spirits are easy
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //A mans gotta dream
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //20-25
            //Rock my wall
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Location, Location, Location
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Elemental Houskeeping
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Look how they Shine for you
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //25-30
            //Baby light my way
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Tag, youre it
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Cant start a fire
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Fool me twice
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //30-35
            //Shell game
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //The midden Fair
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //Thats waht the money is for
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            //I Kidd you not
            //itemsTable.Rows.Add("ItemName", "Information", "ClassName", AetheryteId, "GatherObject", ObjectLevel, 80, "Location", SlotNumber, 0, "");
            // 35-40
            itemsTable.Rows.Add("Highland Limestone", "Eye for an Eye", "Miner", 23, "Mineral Deposit", 37, 80, "443.613, 209.5668, 464.4349", 3, 0, "");
            itemsTable.Rows.Add("Block of Snow", "There Are No Good Answers", "Miner", 23, "Mineral Deposit", 37, 80, "141.7172, 280.5005, 19.43826", 6, 0, "");
            itemsTable.Rows.Add("Superior Repair Stone", "Rocks of Brains", "Miner", 23, "Mineral Deposit", 40, 80, "77.62911, 217.6815, 420.8323", 6, 0, "");
            itemsTable.Rows.Add("Repair Stone", "Rocks of Brains", "Miner", 23, "Mineral Deposit", 37, 80, "77.62911, 217.6815, 420.8323", 3, 0, "");
            itemsTable.Rows.Add("Blue Mythril Ore", "Mythril Madness", "Miner", 23, "Mineral Deposit", 37, 80, "446.4557, 232.4317, 323.9256", 2, 0, "");
            itemsTable.Rows.Add("Rich Blue Mythril Ore", "Mythril Madness", "Miner", 23, "Mineral Deposit", 40, 80, "446.4557, 232.4317, 323.9256", 5, 0, "");
            // 40-45
            itemsTable.Rows.Add("Marcasite", "Brother in Arms", "Miner", 23, "Mineral Deposit", 42, 80, "-723.2169, 226.3917, -6.858791", 5, 0, "");
            itemsTable.Rows.Add("Building Stone", "Breach and Build", "Miner", 23, "Mineral Deposit", 42, 80, "-780.027, 241.8041, -162.4704", 3, 0, "");
            itemsTable.Rows.Add("Tundra", "Not Losing our Heads This Time", "Miner", 23, "Mineral Deposit", 42, 110, "-570.0806, 204.243, -343.9917", 3, 0, "");
            itemsTable.Rows.Add("Permafrost", "Not Losing our Heads This Time", "Miner", 23, "Mineral Deposit", 45, 110, "-570.0806, 204.243, -343.9917", 5, 0, "");
            itemsTable.Rows.Add("Snowcloak Slab", "Nature is a Monster", "Miner", 23, "Mineral Deposit", 42, 80, "-760.9202, 223.4206, 36.56805", 1, 0, "");
            itemsTable.Rows.Add("Clear Snowcloak Slab", "Nature is a Monster", "Miner", 23, "Mineral Deposit", 45, 80, "-760.9202, 223.4206, 36.56805", 3, 0, "");
            //45-50
            itemsTable.Rows.Add("Crystallized Root", "Hybrid Hypotheses", "Miner", 24, "Mineral Deposit", 47, 120, "431.791, -15.65618, -369.2624", 7, 1, "416.1847, -8.609516, -390.3378");
            itemsTable.Rows.Add("Crystallized Trunk", "Hybrid Hypotheses", "Miner", 24, "Mineral Deposit", 50, 120, "431.791, -15.65618, -369.2624", 5, 1, "416.1847, -8.609516, -390.3378");
            itemsTable.Rows.Add("Scratched Allagan Runestone", "Sucker Seer", "Miner", 24, "Rocky Outcrop", 47, 90, "503.299, -5.072927, -411.5198", 5, 1, "504.6592, -3.232328, -467.1335");
            itemsTable.Rows.Add("Overgrown Crystal", "Crystal Mess", "Miner", 24, "Mineral Deposit", 47, 90, "420.7046, -4.675247, -410.5889", 4, 0, "");
            itemsTable.Rows.Add("Dreadnaught Hull", "Metal Has No Master", "Miner", 24, "Mineral Deposit", 47, 100, "139.3676, -3.467925, -551.3579", 2, 0, "");
            itemsTable.Rows.Add("Dreadnaught Heatshield", "Metal Has No Master", "Miner", 24, "Mineral Deposit", 50, 100, "139.3676, -3.467925, -551.3579", 6, 0, "");
            // Field Survey
            itemsTable.Rows.Add("Adamantoise Shell", "", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 3, 0, "");
            itemsTable.Rows.Add("Ala Mhigan Mustard", "", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 2, 0, "");
            itemsTable.Rows.Add("Allagan Snail", "", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 0, 0, "");
            itemsTable.Rows.Add("Alligator Pear", "", "Botanist", 5, "Mature Tree", 30, 80, "224.0834, 17.33236, -122.0438", 1, 0, "");
            itemsTable.Rows.Add("Almonds", "", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 2, 0, "");
            itemsTable.Rows.Add("Aloe", "", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 6, 0, "");
            itemsTable.Rows.Add("Alpine Parsnip", "", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 6, 0, "");
            itemsTable.Rows.Add("Alumen", "", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 1, 0, "");
            itemsTable.Rows.Add("Ash Branch", "", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 2, 0, "");
            itemsTable.Rows.Add("Ash Branch", "", "Botanist", 7, "Mature Tree", 10, 60, "281.881, -22.99627, 139.9542", 2, 0, "");
            itemsTable.Rows.Add("Ash Log", "", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 5, 0, "");
            itemsTable.Rows.Add("Ash Log", "", "Botanist", 7, "Mature Tree", 10, 60, "281.881, -22.99627, 139.9542", 5, 0, "");
            itemsTable.Rows.Add("Basilisk Egg", "", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 5, 0, "");
            itemsTable.Rows.Add("Beehive Chip", "", "Botanist", 7, "Mature Tree", 5, 60, "242.0697, -23.3774, 290.0143", 1, 0, "");
            itemsTable.Rows.Add("Belladonna", "", "Botanist", 4, "Lush Vegetation Patch", 20, 60, "-150.4986, -1.924852, 334.645", 3, 0, "");
            itemsTable.Rows.Add("Black Alumen", "", "Miner", 5, "Mineral Deposit", 40, 80, "364.1767, -4.775018, 69.99052", 1, 0, "");
            itemsTable.Rows.Add("Black Pepper", "", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 2, 0, "");
            itemsTable.Rows.Add("Black Scorpion", "", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 7, 0, "");
            itemsTable.Rows.Add("Blood Currants", "", "Botanist", 6, "Lush Vegetation Patch", 40, 80, "-29.22734, -0.4312079, 364.1402", 1, 0, "");
            itemsTable.Rows.Add("Bloodgrass", "", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 4, 0, "");
            itemsTable.Rows.Add("Blue Pigment", "", "Botanist", 11, "Mature Tree", 30, 80, "313.3577, 34.86708, 612.363", 5, 0, "");
            itemsTable.Rows.Add("Blue Pigment", "", "Miner", 17, "Rocky Outcrop", 30, 80, "88.5679, 20.55661, 100.7672", 5, 0, "");
            itemsTable.Rows.Add("Bomb Ash", "", "Miner", 20, "Rocky Outcrop", 30, 80, "49.74483, 8.958487, 407.0746", 0, 0, "");
            itemsTable.Rows.Add("Bone Chip", "", "Miner", 53, "Mineral Deposit", 5, 80, "113.5488, 1.701878, 281.9428", 3, 0, "");
            itemsTable.Rows.Add("Brimstone", "", "Miner", 15, "Rocky Outcrop", 30, 80, "-450.4195, -5.269686, 253.1701", 7, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Brown Pigment", "", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 6, 0, "");
            itemsTable.Rows.Add("Brown Pigment", "", "Miner", 10, "Rocky Outcrop", 30, 80, "267.9286, 74.66428, -302.3478", 6, 0, "");
            itemsTable.Rows.Add("Buffalo Beans", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "-159.9534, 1.306874, -102.8071", 1, 0, "");
            itemsTable.Rows.Add("Button Mushroom", "", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 6, 0, "");
            itemsTable.Rows.Add("Carnation", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 0, 0, "");
            itemsTable.Rows.Add("Chamomile", "", "Botanist", 15, "Lush Vegetation Patch", 25, 80, "-364.8127, -1.948596, 152.6039", 5, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Chanterelle", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 6, 0, "");
            itemsTable.Rows.Add("Chocobo Feather", "", "Botanist", 5, "Mature Tree", 30, 80, "224.0834, 17.33236, -122.0438", 0, 0, "");
            itemsTable.Rows.Add("Cieldalaes Spinach", "", "Botanist", 10, "Lush Vegetation Patch", 15, 80, "266.3692, 45.04897, 34.22172", 5, 0, "");
            itemsTable.Rows.Add("Cinderfoot Olive", "", "Botanist", 10, "Lush Vegetation Patch", 15, 80, "266.3692, 45.04897, 34.22172", 1, 0, "");
            itemsTable.Rows.Add("Cinnabar", "", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 2, 0, "");
            itemsTable.Rows.Add("Cinnamon", "", "Botanist", 7, "Mature Tree", 5, 80, "242.0697, -23.3774, 290.0143", 2, 0, "");
            itemsTable.Rows.Add("Cloves", "", "Botanist", 53, "Mature Tree", 10, 100, "42.09723, 4.418721, 281.9322", 2, 0, "");
            itemsTable.Rows.Add("Cobalt Ore", "", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 2, 0, "");
            itemsTable.Rows.Add("Cock Feather", "", "Botanist", 53, "Mature Tree", 10, 80, "68.77254, 1.497645, 240.9623", 0, 0, "");
            itemsTable.Rows.Add("Coerthan Carrot", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 6, 0, "");
            itemsTable.Rows.Add("Copper Ore", "", "Miner", 17, "Mineral Deposit", 5, 60, "264.2455, 56.165, 216.7509", 2, 0, "");
            itemsTable.Rows.Add("Copper Ore", "", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 2, 0, "");
            itemsTable.Rows.Add("Copper Sand", "", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 3, 0, "");
            itemsTable.Rows.Add("Cotton Boll", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 3, 0, "");
            itemsTable.Rows.Add("Crow Feather", "", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 0, 0, "");
            itemsTable.Rows.Add("Dart Frog", "", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 6, 0, "");
            itemsTable.Rows.Add("Desert Saffron", "", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 2, 0, "");
            itemsTable.Rows.Add("Desert Seedling", "", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 5, 0, "");
            itemsTable.Rows.Add("Dragon Pepper", "", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 2, 0, "");
            itemsTable.Rows.Add("Earth Crystal", "", "Miner", 10, "Rocky Outcrop", 30, 60, "232.073792, 73.82699, -289.451752", GatherAssist.NOSLOT, 0, ""); // fix object level
            itemsTable.Rows.Add("Earth Rock", "", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 3, 0, "");
            ////itemsTable.Rows.Add("Earth Shard", "", "Botanist", 10, "Lush Vegetation Patch", 15, 60, "266.3692, 45.04897, 34.22172", 4, 0, ""); // buggy and too few nodes, don't use this one
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 10, "Mature Tree", 10, 60, "530.2131, 75.17319, -277.4191", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 10, "Mature Tree", 20, 60, "664.8801, 65.41305, -216.592", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 4, 0, "");
            ////itemsTable.Rows.Add("Earth Shard", "", "Botanist", 15, "Lush Vegetation Patch", 25, 80, "-364.8127, -1.948596, 152.6039", 4, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 7, "Mature Tree", 10, 60, "242.0697, -23.3774, 290.0143", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 7, "Mature Tree", 5, 60, "281.881, -22.99627, 139.9542", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 7, "Mature Tree", 5, 60, "403.8246, -6.349792, 262.0765", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Botanist", 7, "Mature Tree", 5, 60, "52.50433, -12.99726, -14.05974", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 7, "Mineral Deposit", 20, 80, "389.6131, -6.329008, 79.5415", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 10, "Mineral Deposit", 10, 60, "308.8403, 68.79769, -143.7302", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 10, "Rocky Outcrop", 30, 60, "-7.995946, 41.8293, 684.2917", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 10, "Rocky Outcrop", 50, 60, "267.9286, 74.66428, -302.3478", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 15, "Mineral Deposit", 45, 80, "429.3576, -3.311842, 185.0665", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 15, "Rocky Outcrop", 45, 80, "354.7408, -3.4, 31.44002", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 7, "Mineral Deposit", 10, 60, "203.0196, -4.636922, 29.95464", 4, 0, "");
            itemsTable.Rows.Add("Earth Shard", "", "Miner", 7, "Mineral Deposit", 5, 60, "342.2458, -3.775561, 176.0148", 4, 0, "");
            itemsTable.Rows.Add("Effervescent Water", "", "Miner", 5, "Mineral Deposit", 25, 60, "-271.2609, 15.10915, -84.62809", 0, 0, "");
            itemsTable.Rows.Add("Electrum Ore", "", "Miner", 15, "Mineral Deposit", 45, 80, "429.3576, -3.311842, 185.0665", 5, 0, "");
            itemsTable.Rows.Add("Electrum Sand", "", "Miner", 15, "Rocky Outcrop", 45, 80, "354.7408, -3.4, 31.44002", 1, 0, "");
            itemsTable.Rows.Add("Elm Log", "", "Botanist", 3, "Mature Tree", 15, 50, "-43.49828, -6.881468, -74.46594", 5, 0, "");
            itemsTable.Rows.Add("Faerie Apple", "", "Botanist", 4, "Mature Tree", 20, 80, "-325.5423, -0.854171, 275.6144", 1, 0, "");
            itemsTable.Rows.Add("Fire Crystal", "", "Miner", 18, "Rocky Outcrop", 30, 95, "140.7642, 7.528731, -98.47753", GatherAssist.NOSLOT, 0, "");
            itemsTable.Rows.Add("Fine Sand", "", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 2, 0, "");
            itemsTable.Rows.Add("Fire Rock", "", "Miner", 15, "Rocky Outcrop", 25, 80, "-426.8347, -1.837528, 116.2488", 3, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Fire Shard", "", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 5, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Botanist", 52, "Mature Tree", 30, 80, "-230.5813, 14.96386, -368.5225", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Miner", 17, "Mineral Deposit", 5, 80, "264.2455, 56.165, 216.7509", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Miner", 18, "Mineral Deposit", 30, 80, "254.8704, 5.450076, -220.241", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Miner", 18, "Mineral Deposit", 45, 80, "-451.0229, -13.26132, -118.5514", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Miner", 18, "Rocky Outcrop", 30, 80, "138.6984, 7.975479, -92.46308", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Botanist", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 4, 0, "");
            itemsTable.Rows.Add("Fire Shard", "", "Miner", 52, "Rocky Outcrop", 20, 80, "-283.2861, 32.35982, -574.6313", 4, 0, "");
            itemsTable.Rows.Add("Flax", "", "Botanist", 6, "Lush Vegetation Patch", 35, 80, "-248.453, -0.4402871, 350.7661", 3, 0, "");
            itemsTable.Rows.Add("Galago Mint", "", "Botanist", 4, "Lush Vegetation Patch", 20, 60, "-150.4986, -1.924852, 334.645", 5, 0, "");
            itemsTable.Rows.Add("Garlean Garlic", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 2, 0, "");
            itemsTable.Rows.Add("Gil Bun", "", "Botanist", 4, "Lush Vegetation Patch", 20, 80, "-150.4986, -1.924852, 334.645", 6, 0, "");
            itemsTable.Rows.Add("Grade 1 Carbonized Matter", "", "Botanist", 14, "Mature Tree", 20, 80, "269.2184, -14.18528, 131.3953", 0, 0, "");
            itemsTable.Rows.Add("Grade 1 Carbonized Matter", "", "Miner", 52, "Rocky Outcrop", 20, 80, "-283.2861, 32.35982, -574.6313", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Botanist", 11, "Mature Tree", 30, 80, "313.3577, 34.86708, 612.363", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Botanist", 3, "Mature Tree", 30, 80, "158.9255, -24.59291, 471.9808", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Botanist", 5, "Mature Tree", 30, 80, "-209.3807, 8.241471, 14.18696", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Botanist", 52, "Mature Tree", 30, 80, "-230.5813, 14.96386, -368.5225", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Botanist", 53, "Mature Tree", 30, 80, "159.5731, 10.81703, 453.5827", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Miner", 10, "Rocky Outcrop", 30, 80, "267.9286, 74.66428, -302.3478", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Miner", 13, "Rocky Outcrop", 30, 80, "508.7396, 18.32228, 328.447", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Miner", 17, "Rocky Outcrop", 30, 80, "88.5679, 20.55661, 100.7672", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Miner", 18, "Rocky Outcrop", 30, 80, "138.6984, 7.975479, -92.46308", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Miner", 19, "Rocky Outcrop", 30, 80, "-123.4877, 19.20007, -520.1481", 0, 0, "");
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "", "Miner", 4, "Rocky Outcrop", 30, 80, "-62.15393, -10.53283, 288.2905", 0, 0, "");
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "", "Miner", 10, "Rocky Outcrop", 50, 80, "-7.995946, 41.8293, 684.2917", 0, 0, "");
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "", "Miner", 13, "Rocky Outcrop", 50, 80, "711.1254, 28.62663, 409.9852", 0, 0, "");
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "", "Miner", 17, "Rocky Outcrop", 50, 80, "-167.8359, 38.24171, 363.1013", 0, 0, "");
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "", "Miner", 4, "Rocky Outcrop", 50, 80, "-162.7803, -1.348187, 168.7855", 0, 0, "");
            itemsTable.Rows.Add("Granite", "", "Miner", 3, "Mineral Deposit", 35, 80, "-380.6211, 50.77991, 20.49316", 7, 0, "");
            itemsTable.Rows.Add("Grass Viper", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 7, 0, "");
            itemsTable.Rows.Add("Green Pigment", "", "Botanist", 3, "Mature Tree", 30, 80, "158.9255, -24.59291, 471.9808", 5, 0, "");
            itemsTable.Rows.Add("Green Pigment", "", "Miner", 4, "Rocky Outcrop", 30, 60, "-62.15393, -10.53283, 288.2905", 5, 0, "");
            itemsTable.Rows.Add("Grenade Ash", "", "Miner", 21, "Rocky Outcrop", 40, 80, "15.74665, 2.498478, 339.476", 0, 0, "");
            itemsTable.Rows.Add("Grey Pigment", "", "Botanist", 5, "Mature Tree", 30, 60, "-209.3807, 8.241471, 14.18696", 5, 0, "");
            itemsTable.Rows.Add("Grey Pigment", "", "Miner", 13, "Rocky Outcrop", 30, 80, "508.7396, 18.32228, 328.447", 5, 0, "");
            itemsTable.Rows.Add("Gridanian Chestnut", "", "Botanist", 3, "Mature Tree", 15, 80, "-43.49828, -6.881468, -74.46594", 1, 0, "");
            itemsTable.Rows.Add("Gridanian Walnut", "", "Botanist", 5, "Mature Tree", 25, 80, "54.04222, 6.036263, 7.647984", 1, 0, "");
            itemsTable.Rows.Add("Highland Parsley", "", "Botanist", 10, "Lush Vegetation Patch", 15, 80, "266.3692, 45.04897, 34.22172", 6, 0, "");
            itemsTable.Rows.Add("Humus", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "-159.9534, 1.306874, -102.8071", 6, 0, "");
            itemsTable.Rows.Add("Ice Crystal", "", "Miner", 13, "Rocky Outcrop", 50, 80, "711.1254, 28.62663, 409.9852", 5, 0, ""); // is this always here?
            itemsTable.Rows.Add("Ice Rock", "", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 5, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 14, "Mature Tree", 20, 80, "269.2184, -14.18528, 131.3953", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 5, "Mature Tree", 25, 60, "-209.3807, 8.241471, 14.18696", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 5, "Mature Tree", 30, 60, "224.0834, 17.33236, -122.0438", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 5, "Mature Tree", 30, 60, "54.04222, 6.036263, 7.647984", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 6, "Lush Vegetation Patch", 35, 60, "-248.453, -0.4402871, 350.7661", 4, 0, "");
            ////itemsTable.Rows.Add("Ice Shard", "", "Botanist", 6, "Lush Vegetation Patch", 40, 60, "-29.22734, -0.4312079, 364.1402", 4, 0, ""); // not enough nodes, don't use this one
            itemsTable.Rows.Add("Ice Shard", "", "Botanist", 6, "Mature Tree", 35, 60, "-229.608, -0.03202128, 443.5553", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 13, "Rocky Outcrop", 30, 80, "508.7396, 18.32228, 328.447", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 13, "Rocky Outcrop", 50, 80, "711.1254, 28.62663, 409.9852", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 14, "Mineral Deposit", 20, 80, "353.6206, 2.336102, 74.7085", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 14, "Rocky Outcrop", 20, 80, "267.3307, -15.57352, 142.8833", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 23, "Mature Tree", 45, 50, "71.41046, 287.098, -177.7301", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 23, "Mineral Deposit", 40, 50, "127.6247, 286.0522, -71.48206", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 5, "Mineral Deposit", 25, 60, "-271.2609, 15.10915, -84.62809", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 5, "Mineral Deposit", 40, 60, "364.1767, -4.775018, 69.99052", 4, 0, "");
            itemsTable.Rows.Add("Ice Shard", "", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 4, 0, "");
            itemsTable.Rows.Add("Iron Acorn", "", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 1, 0, "");
            itemsTable.Rows.Add("Iron Ore", "", "Miner", 17, "Mineral Deposit", 15, 80, "298.3246, 62.27867, -208.442", 2, 0, "");
            itemsTable.Rows.Add("Iron Sand", "", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 1, 0, "");
            itemsTable.Rows.Add("Island Seedling", "", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 5, 0, "");
            itemsTable.Rows.Add("Jade Peas", "", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 2, 0, "");
            itemsTable.Rows.Add("Jade", "", "Miner", 23, "Mineral Deposit", 40, 50, "127.6247, 286.0522, -71.48206", 6, 0, "");
            itemsTable.Rows.Add("Kukuru Bean", "", "Botanist", 10, "Mature Tree", 10, 60, "530.2131, 75.17319, -277.4191", 1, 0, "");
            itemsTable.Rows.Add("La Noscean Lettuce", "", "Botanist", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 5, 0, "");
            itemsTable.Rows.Add("La Noscean Orange", "", "Botanist", 10, "Mature Tree", 10, 60, "530.2131, 75.17319, -277.4191", 2, 0, "");
            itemsTable.Rows.Add("Lalafellin Lentil", "", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 1, 0, "");
            itemsTable.Rows.Add("Latex", "", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 3, 0, "");
            itemsTable.Rows.Add("Latex", "", "Botanist", 7, "Mature Tree", 5, 80, "403.8246, -6.349792, 262.0765", 3, 0, "");
            itemsTable.Rows.Add("Laurel", "", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 3, 0, "");
            itemsTable.Rows.Add("Lava Toad", "", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 7, 0, "");
            itemsTable.Rows.Add("Lavender", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 5, 0, "");
            itemsTable.Rows.Add("Lightning Crystal", "", "Miner", 19, "Rocky Outcrop", 30, 80, "-122.5412, 21.88736, -489.5768", GatherAssist.NOSLOT, 0, "");
            itemsTable.Rows.Add("Lightning Rock", "", "Miner", 15, "Rocky Outcrop", 25, 80, "-426.8347, -1.837528, 116.2488", 6, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Lightning Shard", "", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 5, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Botanist", 53, "Mature Tree", 10, 60, "68.77254, 1.497645, 240.9623", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Botanist", 53, "Mature Tree", 20, 80, "-33.39082, -8.737234, -74.28648", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Botanist", 53, "Mature Tree", 30, 60, "159.5731, 10.81703, 453.5827", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Miner", 19, "Rocky Outcrop", 30, 80, "-123.4877, 19.20007, -520.1481", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Miner", 20, "Mineral Deposit", 35, 80, "191.0426, 3.207396, 946.3534", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Miner", 20, "Rocky Outcrop", 30, 80, "49.74483, 8.958487, 407.0746", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 4, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 5, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Miner", 53, "Mineral Deposit", 5, 80, "113.5488, 1.701878, 281.9428", 5, 0, "");
            itemsTable.Rows.Add("Lightning Shard", "", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 4, 0, "");
            itemsTable.Rows.Add("Limestone", "", "Miner", 14, "Rocky Outcrop", 20, 80, "267.3307, -15.57352, 142.8833", 3, 0, "");
            itemsTable.Rows.Add("Lowland Grapes", "", "Botanist", 10, "Lush Vegetation Patch", 15, 80, "266.3692, 45.04897, 34.22172", 2, 0, "");
            itemsTable.Rows.Add("Mahogany Log", "", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 5, 0, "");
            itemsTable.Rows.Add("Maiden Artichoke", "", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 0, 0, "");
            itemsTable.Rows.Add("Maiden Grass", "", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 2, 0, "");
            itemsTable.Rows.Add("Mandrake", "", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 5, 0, "");
            itemsTable.Rows.Add("Maple Branch", "", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 2, 0, "");
            itemsTable.Rows.Add("Maple Branch", "", "Botanist", 7, "Mature Tree", 5, 60, "403.8246, -6.349792, 262.0765", 2, 0, "");
            itemsTable.Rows.Add("Maple Log", "", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 6, 0, "");
            itemsTable.Rows.Add("Maple Log", "", "Botanist", 7, "Mature Tree", 5, 60, "403.8246, -6.349792, 262.0765", 5, 0, "");
            itemsTable.Rows.Add("Maple Sap", "", "Botanist", 7, "Mature Tree", 5, 60, "242.0697, -23.3774, 290.0143", 3, 0, "");
            itemsTable.Rows.Add("Marble", "", "Miner", 15, "Rocky Outcrop", 45, 80, "354.7408, -3.4, 31.44002", 6, 0, "");
            itemsTable.Rows.Add("Marjoram", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "-159.9534, 1.306874, -102.8071", 5, 0, "");
            itemsTable.Rows.Add("Matron's Mistletoe", "", "Botanist", 5, "Mature Tree", 25, 80, "54.04222, 6.036263, 7.647984", 7, 0, "");
            itemsTable.Rows.Add("Midland Basil", "", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 3, 0, "");
            itemsTable.Rows.Add("Midland Cabbage", "", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 5, 0, "");
            itemsTable.Rows.Add("Millioncorn", "", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 4, 0, "");
            itemsTable.Rows.Add("Mirror Apple", "", "Botanist", 23, "Mature Tree", 45, 90, "71.41046, 287.098, -177.7301", 1, 0, "");
            itemsTable.Rows.Add("Mistletoe", "", "Botanist", 23, "Mature Tree", 45, 90, "71.41046, 287.098, -177.7301", 7, 0, "");
            itemsTable.Rows.Add("Moko Grass", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 3, 0, "");
            itemsTable.Rows.Add("Moor Leech", "", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 0, 0, "");
            itemsTable.Rows.Add("Muddy Water", "", "Miner", 17, "Mineral Deposit", 5, 60, "264.2455, 56.165, 216.7509", 0, 0, "");
            itemsTable.Rows.Add("Muddy Water", "", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 0, 0, "");
            itemsTable.Rows.Add("Mudstone", "", "Miner", 14, "Rocky Outcrop", 20, 80, "267.3307, -15.57352, 142.8833", 2, 0, "");
            itemsTable.Rows.Add("Mugwort", "", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 2, 0, "");
            itemsTable.Rows.Add("Mythril Ore", "", "Miner", 20, "Mineral Deposit", 35, 80, "191.0426, 3.207396, 946.3534", 6, 0, "");
            itemsTable.Rows.Add("Noble Grapes", "", "Botanist", 15, "Lush Vegetation Patch", 25, 80, "-364.8127, -1.948596, 152.6039", 1, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Nopales", "", "Botanist", 53, "Mature Tree", 20, 80, "-33.39082, -8.737234, -74.28648", 5, 0, "");
            itemsTable.Rows.Add("Nutmeg", "", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 3, 0, "");
            itemsTable.Rows.Add("Oak Branch", "", "Botanist", 6, "Mature Tree", 35, 90, "-229.608, -0.03202128, 443.5553", 2, 0, "");
            itemsTable.Rows.Add("Oak Log", "", "Botanist", 6, "Mature Tree", 35, 90, "-229.608, -0.03202128, 443.5553", 5, 0, "");
            itemsTable.Rows.Add("Obsidian", "", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 7, 0, "");
            itemsTable.Rows.Add("Ogre Horn", "", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 6, 0, "");
            itemsTable.Rows.Add("Ogre Pumpkin", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 1, 0, "");
            itemsTable.Rows.Add("Paprika", "", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 2, 0, "");
            itemsTable.Rows.Add("Pearl Ginger", "", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 3, 0, "");
            itemsTable.Rows.Add("Pixie Plums", "", "Botanist", 15, "Lush Vegetation Patch", 25, 80, "-364.8127, -1.948596, 152.6039", 2, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Popoto", "", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 6, 0, "");
            itemsTable.Rows.Add("Potter's Clay", "", "Miner", 7, "Mineral Deposit", 10, 60, "342.2458, -3.775561, 176.0148", 3, 0, "");
            itemsTable.Rows.Add("Purple Pigment", "", "Botanist", 53, "Mature Tree", 30, 60, "159.5731, 10.81703, 453.5827", 5, 0, "");
            itemsTable.Rows.Add("Purple Pigment", "", "Miner", 19, "Rocky Outcrop", 30, 80, "-123.4877, 19.20007, -520.1481", 5, 0, "");
            itemsTable.Rows.Add("Ragstone", "", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 1, 0, "");
            itemsTable.Rows.Add("Ramhorn Zucchini", "", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 1, 0, "");
            itemsTable.Rows.Add("Raw Amber", "", "Miner", 18, "Mineral Deposit", 45, 80, "-451.0229, -13.26132, -118.5514", 5, 0, "");
            itemsTable.Rows.Add("Raw Amethyst", "", "Miner", 3, "Mineral Deposit", 35, 80, "-380.6211, 50.77991, 20.49316", 6, 0, "");
            itemsTable.Rows.Add("Raw Aquamarine", "", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 6, 0, "");
            itemsTable.Rows.Add("Raw Danburite", "", "Miner", 14, "Mineral Deposit", 20, 80, "353.6206, 2.336102, 74.7085", 7, 0, "");
            itemsTable.Rows.Add("Raw Fluorite", "", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 7, 0, "");
            itemsTable.Rows.Add("Raw Garnet", "", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 5, 0, "");
            itemsTable.Rows.Add("Raw Goshenite", "", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 7, 0, "");
            itemsTable.Rows.Add("Raw Heliodor", "", "Miner", 20, "Mineral Deposit", 35, 80, "191.0426, 3.207396, 946.3534", 5, 0, "");
            itemsTable.Rows.Add("Raw Lapis Lazuli", "", "Miner", 7, "Mineral Deposit", 10, 60, "342.2458, -3.775561, 176.0148", 6, 0, "");
            itemsTable.Rows.Add("Raw Malachite", "", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 5, 0, "");
            itemsTable.Rows.Add("Raw Peridot", "", "Miner", 3, "Mineral Deposit", 35, 80, "-380.6211, 50.77991, 20.49316", 5, 0, "");
            itemsTable.Rows.Add("Raw Rubellite", "", "Miner", 18, "Mineral Deposit", 45, 80, "-451.0229, -13.26132, -118.5514", 6, 0, "");
            itemsTable.Rows.Add("Raw Spinel", "", "Miner", 5, "Mineral Deposit", 40, 80, "364.1767, -4.775018, 69.99052", 7, 0, "");
            itemsTable.Rows.Add("Raw Sphene", "", "Miner", 7, "Mineral Deposit", 20, 80, "389.6131, -6.329008, 79.5415", 5, 0, "");
            itemsTable.Rows.Add("Raw Sunstone", "", "Miner", 10, "Mineral Deposit", 10, 60, "308.8403, 68.79769, -143.7302", 6, 0, "");
            itemsTable.Rows.Add("Raw Tourmaline", "", "Miner", 5, "Mineral Deposit", 40, 80, "364.1767, -4.775018, 69.99052", 5, 0, "");
            itemsTable.Rows.Add("Raw Turquoise", "", "Miner", 15, "Mineral Deposit", 45, 80, "429.3576, -3.311842, 185.0665", 6, 0, "");
            itemsTable.Rows.Add("Raw Zircon", "", "Miner", 23, "Mineral Deposit", 40, 50, "127.6247, 286.0522, -71.48206", 7, 0, "");
            itemsTable.Rows.Add("Red Pigment", "", "Botanist", 52, "Mature Tree", 30, 80, "-230.5813, 14.96386, -368.5225", 5, 0, "");
            itemsTable.Rows.Add("Red Pigment", "", "Miner", 18, "Rocky Outcrop", 30, 80, "138.6984, 7.975479, -92.46308", 5, 0, "");
            itemsTable.Rows.Add("Rock Salt", "", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 0, 0, "");
            itemsTable.Rows.Add("Rolanberry", "", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 1, 0, "");
            itemsTable.Rows.Add("Rosewood Branch", "", "Botanist", 4, "Mature Tree", 50, 80, "-252.335, 6.061327, 85.4445", 2, 0, "");
            itemsTable.Rows.Add("Rosewood Log", "", "Botanist", 4, "Mature Tree", 50, 90, "-252.335, 6.061327, 85.4445", 5, 0, "");
            itemsTable.Rows.Add("Ruby Tomato", "", "Botanist", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 1, 0, "");
            itemsTable.Rows.Add("Rye", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 2, 0, "");
            itemsTable.Rows.Add("Sagolii Sage", "", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 5, 0, "");
            itemsTable.Rows.Add("Salt Leek", "", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 6, 0, "");
            itemsTable.Rows.Add("Shroud Seedling", "", "Botanist", 4, "Lush Vegetation Patch", 20, 80, "-150.4986, -1.924852, 334.645", 7, 0, "");
            itemsTable.Rows.Add("Silex", "", "Miner", 20, "Rocky Outcrop", 30, 80, "49.74483, 8.958487, 407.0746", 1, 0, "");
            itemsTable.Rows.Add("Siltstone", "", "Miner", 15, "Rocky Outcrop", 30, 80, "-450.4195, -5.269686, 253.1701", 2, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Silver Ore", "", "Miner", 5, "Mineral Deposit", 25, 60, "-271.2609, 15.10915, -84.62809", 5, 0, "");
            itemsTable.Rows.Add("Silver Sand", "", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 1, 0, "");
            itemsTable.Rows.Add("Soiled Femur", "", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 3, 0, "");
            itemsTable.Rows.Add("Soiled Femur", "", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 3, 0, "");
            itemsTable.Rows.Add("Sticky Rice", "", "Botanist", 15, "Lush Vegetation Patch", 25, 80, "-364.8127, -1.948596, 152.6039", 3, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Straw", "", "Botanist", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 3, 0, "");
            itemsTable.Rows.Add("Sun Lemon", "", "Botanist", 10, "Mature Tree", 20, 60, "664.8801, 65.41305, -216.592", 1, 0, "");
            itemsTable.Rows.Add("Sunrise Tellin", "", "Miner", 14, "Mineral Deposit", 20, 80, "353.6206, 2.336102, 74.7085", 0, 0, "");
            itemsTable.Rows.Add("Sunset Wheat", "", "Botanist", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 2, 0, "");
            itemsTable.Rows.Add("Tarantula", "", "Botanist", 6, "Mature Tree", 35, 60, "-229.608, -0.03202128, 443.5553", 0, 0, "");
            itemsTable.Rows.Add("Thanalan Tea Leaves", "", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 5, 0, "");
            itemsTable.Rows.Add("Thyme", "", "Botanist", 6, "Lush Vegetation Patch", 40, 60, "-29.22734, -0.4312079, 364.1402", 5, 0, "");
            itemsTable.Rows.Add("Tin Ore", "", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 1, 0, "");
            itemsTable.Rows.Add("Tin Ore", "", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 1, 0, "");
            itemsTable.Rows.Add("Tinolqa Mistletoe", "", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 7, 0, "");
            itemsTable.Rows.Add("Tinolqa Mistletoe", "", "Botanist", 7, "Mature Tree", 10, 60, "281.881, -22.99627, 139.9542", 7, 0, "");
            itemsTable.Rows.Add("Tree Toad", "", "Botanist", 3, "Lush Vegetation Patch", 15, 50, "-159.9534, 1.306874, -102.8071", 7, 0, "");
            itemsTable.Rows.Add("Walnut Log", "", "Botanist", 5, "Mature Tree", 25, 90, "54.04222, 6.036263, 7.647984", 5, 0, "");
            itemsTable.Rows.Add("Water Crystal", "", "Miner", 17, "Rocky Outcrop", 30, 80, "105.9706, 19.30649, 85.6742", GatherAssist.NOSLOT, 0, "");
            itemsTable.Rows.Add("Water Rock", "", "Miner", 15, "Rocky Outcrop", 25, 80, "-426.8347, -1.837528, 116.2488", 5, 0, ""); // no aetheryte
            itemsTable.Rows.Add("Water Shard", "", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Botanist", 11, "Mature Tree", 30, 80, "313.3577, 34.86708, 612.363", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Miner", 17, "Mineral Deposit", 15, 80, "298.3246, 62.27867, -208.442", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Miner", 17, "Mineral Deposit", 5, 60, "264.2455, 56.165, 216.7509", 5, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Miner", 17, "Rocky Outcrop", 30, 80, "88.5679, 20.55661, 100.7672", 4, 0, "");
            itemsTable.Rows.Add("Water Shard", "", "Miner", 17, "Rocky Outcrop", 50, 50, "-167.8359, 38.24171, 363.1013", 4, 0, "");
            itemsTable.Rows.Add("White Scorpion", "", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 7, 0, "");
            itemsTable.Rows.Add("White Truffle", "", "Botanist", 6, "Lush Vegetation Patch", 35, 60, "-248.453, -0.4402871, 350.7661", 6, 0, "");
            itemsTable.Rows.Add("Wild Onion", "", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 7, 0, "");
            itemsTable.Rows.Add("Wildfowl Feather", "", "Botanist", 6, "Lush Vegetation Patch", 35, 60, "-248.453, -0.4402871, 350.7661", 0, 0, "");
            itemsTable.Rows.Add("Wind Crystal", "", "Botanist", 3, "Mature Tree", 30, 80, "158.9255, -24.59291, 471.9808", 6, 0, ""); // rethink crystals, the positions move.
            itemsTable.Rows.Add("Wind Crystal", "", "Miner", 4, "Rocky Outcrop", 50, 80, "-162.7803, -1.348187, 168.7855", 5, 0, ""); // rethink crystals, the positions move.
            itemsTable.Rows.Add("Wind Rock", "", "Miner", 5, "Rocky Outcrop", 25, 90, "55.40574, 5.669168, 12.8003", 6, 0, "");
            ////itemsTable.Rows.Add("Wind Shard", "", "Botanist", 3, "Lush Vegetation Patch", 15, 50, "-159.9534, 1.306874, -102.8071", 4, 0, ""); //nothing in range, don't use this one
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 3, "Mature Tree", 10, 50, "-43.49828, -6.881468, -74.46594", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 3, "Mature Tree", 15, 60, "158.9255, -24.59291, 471.9808", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 3, "Mature Tree", 30, 60, "233.9021, -9.287003, -59.2255", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 5, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 4, "Lush Vegetation Patch", 20, 60, "-150.4986, -1.924852, 334.645", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 4, "Mature Tree", 15, 60, "-325.5423, -0.854171, 275.6144", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Botanist", 4, "Mature Tree", 20, 70, "-252.335, 6.061327, 85.4445", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Miner", 21, "Rocky Outcrop", 40, 80, "15.74665, 2.498478, 339.476", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Miner", 3, "Mineral Deposit", 35, 60, "-380.6211, 50.77991, 20.49316", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Miner", 4, "Rocky Outcrop", 30, 60, "-162.7803, -1.348187, 168.7855", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Miner", 4, "Rocky Outcrop", 50, 60, "-62.15393, -10.53283, 288.2905", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 4, 0, "");
            itemsTable.Rows.Add("Wind Shard", "", "Miner", 53, "Mineral Deposit", 5, 80, "113.5488, 1.701878, 281.9428", 4, 0, "");
            itemsTable.Rows.Add("Wizard Eggplant", "", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 1, 0, "");
            itemsTable.Rows.Add("Wyvern Obsidian", "", "Miner", 18, "Mineral Deposit", 30, 80, "254.8704, 5.450076, -220.241", 7, 0, "");
            itemsTable.Rows.Add("Yellow Ginseng", "", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 5, 0, "");
            itemsTable.Rows.Add("Yellow Pigment", "", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 5, 0, "");
            itemsTable.Rows.Add("Yellow Pigment", "", "Miner", 10, "Rocky Outcrop", 30, 60, "267.9286, 74.66428, -302.3478", 5, 0, "");
            itemsTable.Rows.Add("Yew Branch", "", "Botanist", 4, "Mature Tree", 20, 90, "-325.5423, -0.854171, 275.6144", 2, 0, "");
            itemsTable.Rows.Add("Yew Log", "", "Botanist", 4, "Mature Tree", 20, 90, "-325.5423, -0.854171, 275.6144", 5, 0, "");
            itemsTable.Rows.Add("Zinc Ore", "", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 2, 0, "");
            itemsTable.Rows.Add("Zinc Ore", "", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 2, 0, "");
            
            return itemsTable;
        }

        /// <summary>
        /// Creates and populates the Maps Table.
        /// </summary>
        /// <returns>A newly populated Maps Table.</returns>
        public static DataTable CreateMapsTable()
        {
            DataTable mapsTable = new DataTable();

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

            return mapsTable;
        }
    }
}
