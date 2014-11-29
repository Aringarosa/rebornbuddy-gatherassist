//-----------------------------------------------------------------------
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
            itemsTable.Columns.Add("ClassName");
            itemsTable.Columns.Add("AetheryteId");
            itemsTable.Columns.Add("GatherObject");
            itemsTable.Columns.Add("ObjectLevel");
            itemsTable.Columns.Add("HotspotRadius");
            itemsTable.Columns.Add("Location");
            itemsTable.Columns.Add("SlotNumber");

            // Misc
            ////itemsTable.Rows.Add("Earth Cluster", "Miner", 10, "Rocky Outcrop", 60, "30.000,700.000,40.000", GatherAssist.NOSLOT); // fix
            ////itemsTable.Rows.Add("Earth Crystal", "Miner", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Fire Crystal", "Miner", 18, "Rocky Outcrop", 95, "140.7642, 7.528731, -98.47753", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Garlean Garlic", "Botanist", 17, "Lush Vegetation Patch", 80, "89.10497, 20.50989, 99.95108", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Lightning Shard", "Miner", 53, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Ruby Tomato", "Botanist", 52, "Lush Vegetation Patch", 80, "42.27345, 52.46003, -117.3225", GatherAssist.NOSLOT);

            // Field Survey
            itemsTable.Rows.Add("Adamantoise Shell", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 3);
            itemsTable.Rows.Add("Ala Mhigan Mustard", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 2);
            itemsTable.Rows.Add("Allagan Snail", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 0);
            itemsTable.Rows.Add("Alligator Pear", "Botanist", 5, "Mature Tree", 30, 80, "224.0834, 17.33236, -122.0438", 1);
            itemsTable.Rows.Add("Almonds", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 2);
            itemsTable.Rows.Add("Aloe", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 6);
            itemsTable.Rows.Add("Alpine Parsnip", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 6);
            itemsTable.Rows.Add("Alumen", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 1);
            itemsTable.Rows.Add("Ash Branch", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 2);
            itemsTable.Rows.Add("Ash Branch", "Botanist", 7, "Mature Tree", 10, 60, "281.881, -22.99627, 139.9542", 2);
            itemsTable.Rows.Add("Ash Log", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 5);
            itemsTable.Rows.Add("Ash Log", "Botanist", 7, "Mature Tree", 10, 60, "281.881, -22.99627, 139.9542", 5);
            itemsTable.Rows.Add("Basilisk Egg", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 5);
            itemsTable.Rows.Add("Beehive Chip", "Botanist", 7, "Mature Tree", 5, 60, "242.0697, -23.3774, 290.0143", 1);
            itemsTable.Rows.Add("Belladonna", "Botanist", 4, "Lush Vegetation Patch", 20, 60, "-150.4986, -1.924852, 334.645", 3);
            itemsTable.Rows.Add("Black Pepper", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 2);
            itemsTable.Rows.Add("Black Scorpion", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 7);
            itemsTable.Rows.Add("Blood Currants", "Botanist", 6, "Lush Vegetation Patch", 40, 80, "-29.22734, -0.4312079, 364.1402", 1);
            itemsTable.Rows.Add("Bloodgrass", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 4);
            itemsTable.Rows.Add("Blue Pigment", "Botanist", 11, "Mature Tree", 30, 80, "313.3577, 34.86708, 612.363", 5);
            itemsTable.Rows.Add("Blue Pigment", "Miner", 17, "Rocky Outcrop", 30, 80, "88.5679, 20.55661, 100.7672", 5);
            itemsTable.Rows.Add("Bomb Ash", "Miner", 20, "Rocky Outcrop", 30, 80, "49.74483, 8.958487, 407.0746", 0);
            itemsTable.Rows.Add("Bone Chip", "Miner", 53, "Mineral Deposit", 5, 80, "113.5488, 1.701878, 281.9428", 3);
            itemsTable.Rows.Add("Brown Pigment", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 6);
            itemsTable.Rows.Add("Brown Pigment", "Miner", 10, "Rocky Outcrop", 30, 80, "267.9286, 74.66428, -302.3478", 6);
            itemsTable.Rows.Add("Buffalo Beans", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "-159.9534, 1.306874, -102.8071", 1);
            itemsTable.Rows.Add("Button Mushroom", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 6);
            itemsTable.Rows.Add("Carnation", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 0);
            itemsTable.Rows.Add("Chanterelle", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 6);
            itemsTable.Rows.Add("Chocobo Feather", "Botanist", 5, "Mature Tree", 30, 60, "224.0834, 17.33236, -122.0438", 0);
            itemsTable.Rows.Add("Cieldalaes Spinach", "Botanist", 10, "Lush Vegetation Patch", 15, 60, "266.3692, 45.04897, 34.22172", 5);
            itemsTable.Rows.Add("Cinderfoot Olive", "Botanist", 10, "Lush Vegetation Patch", 15, 60, "266.3692, 45.04897, 34.22172", 1);
            itemsTable.Rows.Add("Cinnabar", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 2);
            itemsTable.Rows.Add("Cinnamon", "Botanist", 7, "Mature Tree", 5, 60, "242.0697, -23.3774, 290.0143", 2);
            itemsTable.Rows.Add("Cloves", "Botanist", 53, "Mature Tree", 10, 60, "68.77254, 1.497645, 240.9623", 2);
            itemsTable.Rows.Add("Cobalt Ore", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 2);
            itemsTable.Rows.Add("Cock Feather", "Botanist", 53, "Mature Tree", 10, 60, "68.77254, 1.497645, 240.9623", 0);
            itemsTable.Rows.Add("Coerthan Carrot", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 6);
            itemsTable.Rows.Add("Copper Ore", "Miner", 17, "Mineral Deposit", 5, 60, "264.2455, 56.165, 216.7509", 2);
            itemsTable.Rows.Add("Copper Ore", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 2);
            itemsTable.Rows.Add("Copper Sand", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 3);
            itemsTable.Rows.Add("Cotton Boll", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 3);
            itemsTable.Rows.Add("Crow Feather", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 0);
            itemsTable.Rows.Add("Dart Frog", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 6);
            itemsTable.Rows.Add("Desert Saffron", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 2);
            itemsTable.Rows.Add("Desert Seedling", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 5);
            itemsTable.Rows.Add("Dragon Pepper", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 2);
            itemsTable.Rows.Add("Earth Rock", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 3);
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 10, "Lush Vegetation Patch", 15, 60, "266.3692, 45.04897, 34.22172", 4); // buggy and too few nodes, don't use this one
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 10, "Mature Tree", 10, 60, "530.2131, 75.17319, -277.4191", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 10, "Mature Tree", 20, 60, "664.8801, 65.41305, -216.592", 4); // need to validate
            itemsTable.Rows.Add("Earth Shard", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 4);
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 10, 60, "242.0697, -23.3774, 290.0143", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 5, 60, "281.881, -22.99627, 139.9542", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 5, 60, "403.8246, -6.349792, 262.0765", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 5, 60, "52.50433, -12.99726, -14.05974", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Miner", 10, "Mineral Deposit", 10, 60, "308.8403, 68.79769, -143.7302", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Miner", 10, "Rocky Outcrop", 30, 60, "-7.995946, 41.8293, 684.2917", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Miner", 10, "Rocky Outcrop", 50, 60, "267.9286, 74.66428, -302.3478", 4); // need to validate
            itemsTable.Rows.Add("Earth Shard", "Miner", 15, "Mineral Deposit", 45, 80, "429.3576, -3.311842, 185.0665", 4);
            //itemsTable.Rows.Add("Earth Shard", "Miner", 15, "Rocky Outcrop", 45, 80, "354.7408, -3.4, 31.44002", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Miner", 7, "Mineral Deposit", 10, 60, "203.0196, -4.636922, 29.95464", 4); // need to validate
            //itemsTable.Rows.Add("Earth Shard", "Miner", 7, "Mineral Deposit", 5, 60, "342.2458, -3.775561, 176.0148", 4); // need to validate
            itemsTable.Rows.Add("Effervescent Water", "Miner", 5, "Mineral Deposit", 25, 60, "-271.2609, 15.10915, -84.62809", 0);
            itemsTable.Rows.Add("Electrum Ore", "Miner", 15, "Mineral Deposit", 45, 80, "429.3576, -3.311842, 185.0665", 5);
            itemsTable.Rows.Add("Electrum Sand", "Miner", 15, "Rocky Outcrop", 45, 80, "354.7408, -3.4, 31.44002", 1);
            itemsTable.Rows.Add("Elm Log", "Botanist", 3, "Mature Tree", 15, 50, "-43.49828, -6.881468, -74.46594", 5);
            itemsTable.Rows.Add("Faerie Apple", "Botanist", 4, "Mature Tree", 20, 80, "-325.5423, -0.854171, 275.6144", 1);
            itemsTable.Rows.Add("Fine Sand", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 2);
            itemsTable.Rows.Add("Fire Shard", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 4);
            itemsTable.Rows.Add("Fire Shard", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 5);
            //itemsTable.Rows.Add("Fire Shard", "Botanist", 52, "Mature Tree", 30, 80, "-230.5813, 14.96386, -368.5225", 4); // need to validate
            //itemsTable.Rows.Add("Fire Shard", "Miner", 17, "Mineral Deposit", 5, 60, "264.2455, 56.165, 216.7509", 4); // need to validate
            //itemsTable.Rows.Add("Fire Shard", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 4); // need to validate
            //itemsTable.Rows.Add("Fire Shard", "Miner", 18, "Mineral Deposit", 30, 80, "254.8704, 5.450076, -220.241", 4); // need to validate
            //itemsTable.Rows.Add("Fire Shard", "Miner", 18, "Mineral Deposit", 45, 80, "-451.0229, -13.26132, -118.5514", 4); // need to validate
            //itemsTable.Rows.Add("Fire Shard", "Miner", 18, "Rocky Outcrop", 30, 80, "138.6984, 7.975479, -92.46308", 4); // need to validate
            //itemsTable.Rows.Add("Fire Shard", "Miner", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 4); // need to validate
            //itemsTable.Rows.Add("Fire Shard", "Miner", 52, "Rocky Outcrop", 20, 80, "-283.2861, 32.35982, -574.6313", 4); // need to validate
            itemsTable.Rows.Add("Flax", "Botanist", 6, "Lush Vegetation Patch", 35, 80, "-248.453, -0.4402871, 350.7661", 3);
            itemsTable.Rows.Add("Galago Mint", "Botanist", 4, "Lush Vegetation Patch", 20, 60, "-150.4986, -1.924852, 334.645", 5);
            //itemsTable.Rows.Add("Garlean Garlic", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 2); // flagged
            itemsTable.Rows.Add("Gil Bun", "Botanist", 4, "Lush Vegetation Patch", 20, 80, "-150.4986, -1.924852, 334.645", 6);
            itemsTable.Rows.Add("Grade 1 Carbonized Matter", "Botanist", 14, "Mature Tree", 20, 80, "269.2184, -14.18528, 131.3953", 0);
            itemsTable.Rows.Add("Grade 1 Carbonized Matter", "Miner", 52, "Rocky Outcrop", 20, 80, "-283.2861, 32.35982, -574.6313", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 11, "Mature Tree", 30, 80, "313.3577, 34.86708, 612.363", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 3, "Mature Tree", 30, 60, "158.9255, -24.59291, 471.9808", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 5, "Mature Tree", 30, 60, "-209.3807, 8.241471, 14.18696", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 52, "Mature Tree", 30, 80, "-230.5813, 14.96386, -368.5225", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 53, "Mature Tree", 30, 60, "159.5731, 10.81703, 453.5827", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 0);
            //itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 10, "Rocky Outcrop", 30, 60, "267.9286, 74.66428, -302.3478", 0); // need to validate
            //itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 13, "Rocky Outcrop", 30, 80, "508.7396, 18.32228, 328.447", 0); // need to validate
            //itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 17, "Rocky Outcrop", 30, 80, "88.5679, 20.55661, 100.7672", 0); // need to validate
            //itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 18, "Rocky Outcrop", 30, 80, "138.6984, 7.975479, -92.46308", 0); // need to validate
            //itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 19, "Rocky Outcrop", 30, 80, "-123.4877, 19.20007, -520.1481", 0); // need to validate
            //itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 4, "Rocky Outcrop", 30, 60, "-62.15393, -10.53283, 288.2905", 0); // need to validate
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "Miner", 10, "Rocky Outcrop", 50, 60, "-7.995946, 41.8293, 684.2917", 0);
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "Miner", 13, "Rocky Outcrop", 50, 80, "711.1254, 28.62663, 409.9852", 0);
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "Miner", 17, "Rocky Outcrop", 50, 50, "-167.8359, 38.24171, 363.1013", 0);
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "Miner", 4, "Rocky Outcrop", 50, 60, "-162.7803, -1.348187, 168.7855", 0);
            itemsTable.Rows.Add("Granite", "Miner", 3, "Mineral Deposit", 35, 80, "-380.6211, 50.77991, 20.49316", 7);
            itemsTable.Rows.Add("Grass Viper", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 7);
            itemsTable.Rows.Add("Green Pigment", "Botanist", 3, "Mature Tree", 30, 80, "158.9255, -24.59291, 471.9808", 5);
            itemsTable.Rows.Add("Green Pigment", "Miner", 4, "Rocky Outcrop", 30, 60, "-62.15393, -10.53283, 288.2905", 5);
            itemsTable.Rows.Add("Grenade Ash", "Miner", 21, "Rocky Outcrop", 40, 80, "15.74665, 2.498478, 339.476", 0);
            itemsTable.Rows.Add("Grey Pigment", "Botanist", 5, "Mature Tree", 30, 60, "-209.3807, 8.241471, 14.18696", 5);
            itemsTable.Rows.Add("Grey Pigment", "Miner", 13, "Rocky Outcrop", 30, 80, "508.7396, 18.32228, 328.447", 5);
            itemsTable.Rows.Add("Gridanian Chestnut", "Botanist", 3, "Mature Tree", 15, 80, "-43.49828, -6.881468, -74.46594", 1);
            itemsTable.Rows.Add("Gridanian Walnut", "Botanist", 5, "Mature Tree", 25, 80, "54.04222, 6.036263, 7.647984", 1);
            //itemsTable.Rows.Add("Highland Parsley", "Botanist", 10, "Lush Vegetation Patch", 15, 80, "266.3692, 45.04897, 34.22172", 6); // flagged
            itemsTable.Rows.Add("Humus", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "-159.9534, 1.306874, -102.8071", 6);
            //itemsTable.Rows.Add("Ice Crystal", "Miner", 13, "Rocky Outcrop", 50, 80, "711.1254, 28.62663, 409.9852", 5); // is this always here?
            itemsTable.Rows.Add("Ice Rock", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 5);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 4);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 14, "Mature Tree", 20, 80, "269.2184, -14.18528, 131.3953", 4);
            //itemsTable.Rows.Add("Ice Shard", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Botanist", 5, "Mature Tree", 25, 60, "-209.3807, 8.241471, 14.18696", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Botanist", 5, "Mature Tree", 30, 60, "224.0834, 17.33236, -122.0438", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Botanist", 5, "Mature Tree", 30, 60, "54.04222, 6.036263, 7.647984", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Botanist", 6, "Lush Vegetation Patch", 35, 60, "-248.453, -0.4402871, 350.7661", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Botanist", 6, "Lush Vegetation Patch", 40, 60, "-29.22734, -0.4312079, 364.1402", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Botanist", 6, "Mature Tree", 35, 60, "-229.608, -0.03202128, 443.5553", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 13, "Rocky Outcrop", 30, 80, "508.7396, 18.32228, 328.447", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 13, "Rocky Outcrop", 50, 80, "711.1254, 28.62663, 409.9852", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 14, "Mineral Deposit", 20, 80, "353.6206, 2.336102, 74.7085", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 14, "Rocky Outcrop", 20, 80, "267.3307, -15.57352, 142.8833", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 23, "Mineral Deposit", 40, 50, "127.6247, 286.0522, -71.48206", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Mineral Deposit", 25, 60, "-271.2609, 15.10915, -84.62809", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Mineral Deposit", 40, 60, "364.1767, -4.775018, 69.99052", 4); // need to validate
            //itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 4); // need to validate
            itemsTable.Rows.Add("Iron Acorn", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 1);
            itemsTable.Rows.Add("Iron Ore", "Miner", 17, "Mineral Deposit", 15, 80, "298.3246, 62.27867, -208.442", 2);
            itemsTable.Rows.Add("Iron Sand", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 1);
            itemsTable.Rows.Add("Island Seedling", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 5);
            itemsTable.Rows.Add("Jade Peas", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 2);
            itemsTable.Rows.Add("Jade", "Miner", 23, "Mineral Deposit", 40, 50, "127.6247, 286.0522, -71.48206", 6);
            itemsTable.Rows.Add("Kukuru Bean", "Botanist", 10, "Mature Tree", 10, 60, "530.2131, 75.17319, -277.4191", 1);
            //itemsTable.Rows.Add("La Noscean Lettuce", "Miner", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 5); // flagged
            itemsTable.Rows.Add("La Noscean Orange", "Botanist", 10, "Mature Tree", 10, 60, "530.2131, 75.17319, -277.4191", 2);
            itemsTable.Rows.Add("Lalafellin Lentil", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 1);
            itemsTable.Rows.Add("Latex", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 3);
            itemsTable.Rows.Add("Latex", "Botanist", 7, "Mature Tree", 5, 80, "403.8246, -6.349792, 262.0765", 3);
            itemsTable.Rows.Add("Laurel", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 3);
            itemsTable.Rows.Add("Lava Toad", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 7);
            itemsTable.Rows.Add("Lavender", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 5);
            itemsTable.Rows.Add("Lightning Shard", "Botanist", 19, "Lush Vegetation Patch", 30, 80, "-65.45716, 5.075618, -639.4241", 5);
            itemsTable.Rows.Add("Lightning Shard", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 4);
            itemsTable.Rows.Add("Lightning Shard", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 4);
            //itemsTable.Rows.Add("Lightning Shard", "Botanist", 53, "Mature Tree", 10, 60, "68.77254, 1.497645, 240.9623", 4); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Botanist", 53, "Mature Tree", 20, 80, "-33.39082, -8.737234, -74.28648", 4); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Botanist", 53, "Mature Tree", 30, 60, "159.5731, 10.81703, 453.5827", 4); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Miner", 19, "Rocky Outcrop", 30, 80, "-123.4877, 19.20007, -520.1481", 4); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Miner", 20, "Mineral Deposit", 35, 80, "191.0426, 3.207396, 946.3534", 4); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Miner", 20, "Rocky Outcrop", 30, 80, "49.74483, 8.958487, 407.0746", 4); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 4); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 5); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Miner", 53, "Mineral Deposit", 5, 80, "113.5488, 1.701878, 281.9428", 5); // need to validate
            //itemsTable.Rows.Add("Lightning Shard", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 4); // need to validate
            //itemsTable.Rows.Add("Limestone", "Miner", 14, "Rocky Outcrop", 20, 80, "267.3307, -15.57352, 142.8833", 3); // flagged
            itemsTable.Rows.Add("Lowland Grapes", "Botanist", 10, "Lush Vegetation Patch", 15, 60, "266.3692, 45.04897, 34.22172", 2);
            itemsTable.Rows.Add("Mahogany Log", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 5);
            itemsTable.Rows.Add("Maiden Artichoke", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 0);
            itemsTable.Rows.Add("Maiden Grass", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 2);
            itemsTable.Rows.Add("Mandrake", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 5);
            itemsTable.Rows.Add("Maple Branch", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 2);
            itemsTable.Rows.Add("Maple Branch", "Botanist", 7, "Mature Tree", 5, 60, "403.8246, -6.349792, 262.0765", 2);
            itemsTable.Rows.Add("Maple Log", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 6);
            itemsTable.Rows.Add("Maple Log", "Botanist", 7, "Mature Tree", 5, 60, "403.8246, -6.349792, 262.0765", 5);
            itemsTable.Rows.Add("Maple Sap", "Botanist", 7, "Mature Tree", 5, 60, "242.0697, -23.3774, 290.0143", 3);
            itemsTable.Rows.Add("Marble", "Miner", 15, "Rocky Outcrop", 45, 80, "354.7408, -3.4, 31.44002", 6);
            itemsTable.Rows.Add("Marjoram", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "-159.9534, 1.306874, -102.8071", 5);
            itemsTable.Rows.Add("Matron's Mistletoe", "Botanist", 5, "Mature Tree", 25, 80, "54.04222, 6.036263, 7.647984", 7);
            itemsTable.Rows.Add("Midland Basil", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 3);
            itemsTable.Rows.Add("Midland Cabbage", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 5);
            itemsTable.Rows.Add("Millioncorn", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 4);
            itemsTable.Rows.Add("Moko Grass", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 3);
            itemsTable.Rows.Add("Moor Leech", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 0);
            itemsTable.Rows.Add("Muddy Water", "Miner", 17, "Mineral Deposit", 5, 60, "264.2455, 56.165, 216.7509", 0);
            itemsTable.Rows.Add("Muddy Water", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 0);
            itemsTable.Rows.Add("Mudstone", "Miner", 14, "Rocky Outcrop", 20, 80, "267.3307, -15.57352, 142.8833", 2);
            itemsTable.Rows.Add("Mugwort", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 2);
            itemsTable.Rows.Add("Mythril Ore", "Miner", 20, "Mineral Deposit", 35, 80, "191.0426, 3.207396, 946.3534", 6);
            itemsTable.Rows.Add("Nopales", "Botanist", 53, "Mature Tree", 20, 80, "-33.39082, -8.737234, -74.28648", 5);
            itemsTable.Rows.Add("Nutmeg", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 3);
            itemsTable.Rows.Add("Oak Branch", "Botanist", 6, "Mature Tree", 35, 60, "-229.608, -0.03202128, 443.5553", 2);
            itemsTable.Rows.Add("Oak Log", "Botanist", 6, "Mature Tree", 35, 60, "-229.608, -0.03202128, 443.5553", 5);
            itemsTable.Rows.Add("Obsidian", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 7);
            itemsTable.Rows.Add("Ogre Horn", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 6);
            itemsTable.Rows.Add("Ogre Pumpkin", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 1);
            itemsTable.Rows.Add("Paprika", "Botanist", 13, "Lush Vegetation Patch", 20, 80, "518.6508, 16.50845, 361.1047", 2);
            itemsTable.Rows.Add("Pearl Ginger", "Botanist", 18, "Lush Vegetation Patch", 25, 80, "-342.9444, -26.28499, -33.79862", 3);
            itemsTable.Rows.Add("Popoto", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 6);
            itemsTable.Rows.Add("Potter's Clay", "Miner", 7, "Mineral Deposit", 10, 60, "342.2458, -3.775561, 176.0148", 3);
            itemsTable.Rows.Add("Purple Pigment", "Botanist", 53, "Mature Tree", 30, 60, "159.5731, 10.81703, 453.5827", 5);
            //itemsTable.Rows.Add("Purple Pigment", "Miner", 19, "Rocky Outcrop", 30, 80, "-123.4877, 19.20007, -520.1481", 5); // need to validate
            itemsTable.Rows.Add("Ragstone", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 1);
            itemsTable.Rows.Add("Ramhorn Zucchini", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 1);
            itemsTable.Rows.Add("Raw Amber", "Miner", 18, "Mineral Deposit", 45, 80, "-451.0229, -13.26132, -118.5514", 5);
            itemsTable.Rows.Add("Raw Amethyst", "Miner", 3, "Mineral Deposit", 35, 80, "-380.6211, 50.77991, 20.49316", 6);
            itemsTable.Rows.Add("Raw Aquamarine", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 6);
            itemsTable.Rows.Add("Raw Danburite", "Miner", 14, "Mineral Deposit", 20, 80, "353.6206, 2.336102, 74.7085", 7);
            itemsTable.Rows.Add("Raw Fluorite", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 7);
            itemsTable.Rows.Add("Raw Garnet", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 5);
            itemsTable.Rows.Add("Raw Goshenite", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 7);
            itemsTable.Rows.Add("Raw Heliodor", "Miner", 20, "Mineral Deposit", 35, 80, "191.0426, 3.207396, 946.3534", 5);
            itemsTable.Rows.Add("Raw Lapis Lazuli", "Miner", 7, "Mineral Deposit", 10, 60, "342.2458, -3.775561, 176.0148", 6);
            itemsTable.Rows.Add("Raw Malachite", "Miner", 18, "Mineral Deposit", 20, 80, "-182.4681, -34.45182, -41.76479", 5);
            itemsTable.Rows.Add("Raw Peridot", "Miner", 3, "Mineral Deposit", 35, 80, "-380.6211, 50.77991, 20.49316", 5);
            itemsTable.Rows.Add("Raw Rubellite", "Miner", 18, "Mineral Deposit", 45, 80, "-451.0229, -13.26132, -118.5514", 6);
            itemsTable.Rows.Add("Raw Spinel", "Miner", 5, "Mineral Deposit", 40, 80, "364.1767, -4.775018, 69.99052", 7);
            itemsTable.Rows.Add("Raw Sunstone", "Miner", 10, "Mineral Deposit", 10, 60, "308.8403, 68.79769, -143.7302", 6);
            itemsTable.Rows.Add("Raw Tourmaline", "Miner", 5, "Mineral Deposit", 40, 80, "364.1767, -4.775018, 69.99052", 5);
            itemsTable.Rows.Add("Raw Turquoise", "Miner", 15, "Mineral Deposit", 45, 80, "429.3576, -3.311842, 185.0665", 6);
            itemsTable.Rows.Add("Raw Zircon", "Miner", 23, "Mineral Deposit", 40, 50, "127.6247, 286.0522, -71.48206", 7);
            itemsTable.Rows.Add("Red Pigment", "Botanist", 52, "Mature Tree", 30, 80, "-230.5813, 14.96386, -368.5225", 5);
            itemsTable.Rows.Add("Red Pigment", "Miner", 18, "Rocky Outcrop", 30, 80, "138.6984, 7.975479, -92.46308", 5);
            itemsTable.Rows.Add("Rock Salt", "Miner", 53, "Rocky Outcrop", 15, 80, "-356.4178, 0.6453676, 69.35533", 0);
            itemsTable.Rows.Add("Rolanberry", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 1);
            itemsTable.Rows.Add("Rosewood Branch", "Botanist", 4, "Mature Tree", 50, 80, "-252.335, 6.061327, 85.4445", 2);
            itemsTable.Rows.Add("Rosewood Log", "Botanist", 4, "Mature Tree", 50, 60, "-252.335, 6.061327, 85.4445", 5);
            //itemsTable.Rows.Add("Ruby Tomato", "Miner", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 1); // flagged
            itemsTable.Rows.Add("Rye", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 2);
            itemsTable.Rows.Add("Sagolii Sage", "Botanist", 15, "Lush Vegetation Patch", 45, 80, "638.3107, -3.304667, 153.4811", 5);
            //itemsTable.Rows.Add("Salk Leek", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 6); // flagged
            itemsTable.Rows.Add("Shroud Seedling", "Botanist", 4, "Lush Vegetation Patch", 20, 80, "-150.4986, -1.924852, 334.645", 7);
            itemsTable.Rows.Add("Silex", "Miner", 20, "Rocky Outcrop", 30, 80, "49.74483, 8.958487, 407.0746", 1);
            itemsTable.Rows.Add("Silver Ore", "Miner", 5, "Mineral Deposit", 25, 60, "-271.2609, 15.10915, -84.62809", 5);
            itemsTable.Rows.Add("Silver Sand", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 1);
            //itemsTable.Rows.Add("Soiled Femur", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 3); // flagged
            itemsTable.Rows.Add("Soiled Femur", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 3);
            itemsTable.Rows.Add("Straw", "Botanist", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 3);
            itemsTable.Rows.Add("Sun Lemon", "Botanist", 10, "Mature Tree", 20, 60, "664.8801, 65.41305, -216.592", 1);
            //itemsTable.Rows.Add("Sunrise Tellin", "Miner", 14, "Mineral Deposit", 20, 80, "353.6206, 2.336102, 74.7085", 0); // flagged
            itemsTable.Rows.Add("Sunset Wheat", "Botanist", 52, "Lush Vegetation Patch", 15, 80, "51.5785, 52.90682, -112.3378", 2);
            itemsTable.Rows.Add("Tarantula", "Botanist", 6, "Mature Tree", 35, 60, "-229.608, -0.03202128, 443.5553", 0);
            itemsTable.Rows.Add("Thanalan Tea Leaves", "Botanist", 20, "Lush Vegetation Patch", 50, 80, "-385.8557, 9.669127, 526.6115", 5);
            itemsTable.Rows.Add("Thyme", "Botanist", 6, "Lush Vegetation Patch", 40, 60, "-29.22734, -0.4312079, 364.1402", 5);
            itemsTable.Rows.Add("Tin Ore", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 1);
            //itemsTable.Rows.Add("Tin Ore", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 1); // need to validate
            itemsTable.Rows.Add("Tinolqa Mistletoe", "Botanist", 3, "Mature Tree", 10, 60, "233.9021, -9.287003, -59.2255", 7);
            itemsTable.Rows.Add("Tinolqa Mistletoe", "Botanist", 7, "Mature Tree", 10, 60, "281.881, -22.99627, 139.9542", 7);
            itemsTable.Rows.Add("Tree Toad", "Botanist", 3, "Lush Vegetation Patch", 15, 50, "-159.9534, 1.306874, -102.8071", 7);
            itemsTable.Rows.Add("Walnut Log", "Botanist", 5, "Mature Tree", 25, 60, "54.04222, 6.036263, 7.647984", 5);
            itemsTable.Rows.Add("Water Shard", "Botanist", 11, "Lush Vegetation Patch", 35, 80, "259.4367, 40.34094, 430.9537", 4);
            //itemsTable.Rows.Add("Water Shard", "Botanist", 11, "Mature Tree", 30, 80, "313.3577, 34.86708, 612.363", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Botanist", 12, "Lush Vegetation Patch", 40, 80, "-16.87076, 40.45821, 376.23", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Botanist", 12, "Mature Tree", 40, 80, "-101.0265, 42.08762, 192.7253", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "146.4175, 49.39901, -111.9525", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Miner", 11, "Mineral Deposit", 35, 80, "395.1724, 28.4377, 299.5383", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Miner", 17, "Mineral Deposit", 15, 80, "298.3246, 62.27867, -208.442", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Miner", 17, "Mineral Deposit", 5, 60, "264.2455, 56.165, 216.7509", 5); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Miner", 17, "Rocky Outcrop", 15, 80, "120.6936, 51.13934, -148.9914", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Miner", 17, "Rocky Outcrop", 30, 80, "88.5679, 20.55661, 100.7672", 4); // need to validate
            //itemsTable.Rows.Add("Water Shard", "Miner", 17, "Rocky Outcrop", 50, 50, "-167.8359, 38.24171, 363.1013", 4); // need to validate
            itemsTable.Rows.Add("White Scorpion", "Botanist", 18, "Lush Vegetation Patch", 20, 80, "-283.7762, -33.72977, 278.3234", 7);
            itemsTable.Rows.Add("White Truffle", "Botanist", 6, "Lush Vegetation Patch", 35, 60, "-248.453, -0.4402871, 350.7661", 6);
            itemsTable.Rows.Add("Wild Onion", "Botanist", 17, "Lush Vegetation Patch", 15, 80, "98.04959, 19.84293, 95.2293", 7);
            itemsTable.Rows.Add("Wildfowl Feather", "Botanist", 6, "Lush Vegetation Patch", 35, 60, "-248.453, -0.4402871, 350.7661", 0);
            itemsTable.Rows.Add("Wind Crystal", "Botanist", 3, "Mature Tree", 30, 60, "158.9255, -24.59291, 471.9808", 6);
            //itemsTable.Rows.Add("Wind Crystal", "Miner", 4, "Rocky Outcrop", 50, 60, "-162.7803, -1.348187, 168.7855", 5); // item not present here, not sure what happened
            itemsTable.Rows.Add("Wind Rock", "Miner", 5, "Rocky Outcrop", 25, 60, "55.40574, 5.669168, 12.8003", 6);
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Lush Vegetation Patch", 15, 50, "-159.9534, 1.306874, -102.8071", 4); //nothing in range, don't use this one
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Lush Vegetation Patch", 15, 80, "62.98865, -8.831064, 122.1805", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 10, 50, "-43.49828, -6.881468, -74.46594", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 15, 60, "158.9255, -24.59291, 471.9808", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 30, 60, "233.9021, -9.287003, -59.2255", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 5, 60, "61.01541, 4.252214, -174.6979", 5); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 4, "Lush Vegetation Patch", 20, 60, "-150.4986, -1.924852, 334.645", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 4, "Mature Tree", 15, 60, "-325.5423, -0.854171, 275.6144", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Botanist", 4, "Mature Tree", 20, 60, "-252.335, 6.061327, 85.4445", 4); // need to validate
            itemsTable.Rows.Add("Wind Shard", "Miner", 21, "Mineral Deposit", 50, 80, "92.58333, 22.01458, 151.3047", 4);
            //itemsTable.Rows.Add("Wind Shard", "Miner", 21, "Rocky Outcrop", 40, 80, "15.74665, 2.498478, 339.476", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Miner", 3, "Mineral Deposit", 35, 60, "-380.6211, 50.77991, 20.49316", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Miner", 4, "Rocky Outcrop", 30, 60, "-162.7803, -1.348187, 168.7855", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Miner", 4, "Rocky Outcrop", 50, 60, "-62.15393, -10.53283, 288.2905", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Miner", 53, "Mineral Deposit", 5, 80, "-128.7192, 3.458603, 215.4033", 4); // need to validate
            //itemsTable.Rows.Add("Wind Shard", "Miner", 53, "Mineral Deposit", 5, 80, "113.5488, 1.701878, 281.9428", 4); // need to validate
            itemsTable.Rows.Add("Wizard Eggplant", "Botanist", 7, "Lush Vegetation Patch", 30, 80, "87.2282, -33.21325, 254.1546", 1);
            itemsTable.Rows.Add("Wyvern Obsidian", "Miner", 18, "Mineral Deposit", 30, 80, "254.8704, 5.450076, -220.241", 7);
            //itemsTable.Rows.Add("Yellow Ginseng", "Botanist", 53, "Lush Vegetation Patch", 15, 80, "178.4647, 0.9053299, -56.35048", 5); // flagged
            itemsTable.Rows.Add("Yellow Pigment", "Botanist", 7, "Mature Tree", 30, 80, "252.646, -9.157417, 13.05055", 5);
            itemsTable.Rows.Add("Yellow Pigment", "Miner", 10, "Rocky Outcrop", 30, 60, "267.9286, 74.66428, -302.3478", 5);
            itemsTable.Rows.Add("Yew Branch", "Botanist", 4, "Mature Tree", 20, 60, "-325.5423, -0.854171, 275.6144", 2);
            itemsTable.Rows.Add("Yew Log", "Botanist", 4, "Mature Tree", 20, 60, "-325.5423, -0.854171, 275.6144", 5);
            itemsTable.Rows.Add("Zinc Ore", "Miner", 17, "Mineral Deposit", 10, 70, "42.55082, 57.27194, 353.5192", 2);
            //itemsTable.Rows.Add("Zinc Ore", "Miner", 53, "Mineral Deposit", 10, 60, "-66.32383, -4.023734, 45.27408", 2); // need to validate

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
