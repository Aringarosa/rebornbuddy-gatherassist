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
            itemsTable.Columns.Add("HotspotRadius");
            itemsTable.Columns.Add("Location");
            itemsTable.Columns.Add("SlotNumber");

            itemsTable.Rows.Add("Alumen", "Miner", 18, "Mineral Deposit", 95, "-183.1978, -34.69329, -37.8227", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Black Alumen", "Miner", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Bomb Ash", "Miner", 20, "Rocky Outcrop", 95, "26.02704, 8.851164, 399.923", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Brown Pigment", "Miner", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Button Mushroom", "Botanist", 18, "Lush Vegetation Patch", 80, "-344.0994, -28.06476, -41.86419", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Copper Ore", "Miner", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Desert Saffron", "Botanist", 19, "Lush Vegetation Patch", 80, "-41.3371, 2.250951, -645.2979", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Earth Cluster", "Miner", 10, "Rocky Outcrop", 60, "30.000,700.000,40.000", GatherAssist.NOSLOT); // fix
            itemsTable.Rows.Add("Earth Crystal", "Miner", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Earth Shard", "Miner", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Electrum Ore", "Miner", 15, "Mineral Deposit", 95, "425.5676, -2.748671, 180.2855", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Electrum Sand", "Miner", 15, "Rocky Outcrop", 60, "333.2277, -3.4, 45.06057", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Fire Crystal", "Miner", 18, "Rocky Outcrop", 95, "140.7642, 7.528731, -98.47753", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Fire Shard", "Miner", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Flax", "Botanist", 6, "Lush Vegetation Patch", 80, "-258.2026, -0.427259, 368.3641", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Garlean Garlic", "Botanist", 17, "Lush Vegetation Patch", 80, "89.10497, 20.50989, 99.95108", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "Miner", 10, "Rocky Outcrop", 60, "21.32569, 43.12733, 717.137", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Iron Ore", "Miner", 17, "Mineral Deposit", 95, "288.9167, 62.34205, -218.6282", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Lightning Shard", "Miner", 53, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Marble", "Miner", 15, "Rocky Outcrop", 60, "350.000,-3.000,40.000", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Midland Cabbage", "Botanist", 7, "Lush Vegetation Patch", 80, "87.74422, -35.93571, 237.9439", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Muddy Water", "Miner", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Mythril Ore", "Miner", 20, "Mineral Deposit", 95, "181.7675, 3.287047, 962.0443", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Obsidian", "Miner", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Raw Fluorite", "Miner", 18, "Mineral Deposit", 95, "-183.1978, -34.69329, -37.8227", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Raw Heliodor", "Miner", 20, "Mineral Deposit", 95, "181.7675, 3.287047, 962.0443", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Raw Malachite", "Miner", 18, "Mineral Deposit", 95, "-183.1978, -34.69329, -37.8227", GatherAssist.NOSLOT); // flagged, investigate
            itemsTable.Rows.Add("Raw Spinel", "Miner", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Raw Tourmaline", "Miner", 5, "Mineral Deposit", 60, "353.7134, -3.617686, 58.73518", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Rosewood Log", "Botanist", 4, "Mature Tree", 95, "-244.6034, 5.874526, 83.33171", 5);
            itemsTable.Rows.Add("Ruby Tomato", "Botanist", 52, "Lush Vegetation Patch", 80, "42.27345, 52.46003, -117.3225", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Silex", "Miner", 20, "Rocky Outcrop", 95, "26.02704, 8.851164, 399.923", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Soiled Femur", "Miner", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Tin Ore", "Miner", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Water Shard", "Miner", 17, "Mineral Deposit", 95, "264.0081,56.19608,206.0519", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Wild Onion", "Botanist", 17, "Lush Vegetation Patch", 80, "89.10497, 20.50989, 99.95108", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Wind Rock", "Miner", 5, "Rocky Outcrop", 95, "45.63465, 6.407045, 8.635086", GatherAssist.NOSLOT); // fix
            itemsTable.Rows.Add("Wind Shard", "Miner", 53, "Mineral Deposit", 95, "-123.6678, 3.532623, 221.7551", GatherAssist.NOSLOT);
            ////itemsTable.Rows.Add("Wyvern Obsidian", "Miner", 18, "Mineral Deposit", 60, "250.000,5.000,230.000", GatherAssist.NOSLOT); // runs into a cliff and runs endlessly, investigate
            itemsTable.Rows.Add("Yellow Pigment", "Miner", 10, "Rocky Outcrop", 60, "232.073792, 73.82699, -289.451752", GatherAssist.NOSLOT);
            itemsTable.Rows.Add("Zinc Ore", "Miner", 17, "Mineral Deposit", 95, "42.69921,56.98661,349.928", GatherAssist.NOSLOT);
            //// TODO: add items table syntax validation; this can be tested before compile, create a test project.

            // Field Survey: AIDs 1-10
            itemsTable.Rows.Add("Allagan Snail", "Botanist", 3, "Mature Tree", 60, "61.01541, 4.252214, -174.6979", 0);
            itemsTable.Rows.Add("Alligator Pear", "Botanist", 5, "Mature Tree", 80, "224.0834, 17.33236, -122.0438", 1); // flagged
            itemsTable.Rows.Add("Ash Branch", "Botanist", 3, "Mature Tree", 60, "233.9021, -9.287003, -59.2255", 2);
            itemsTable.Rows.Add("Ash Branch", "Botanist", 7, "Mature Tree", 60, "281.881, -22.99627, 139.9542", 2);
            itemsTable.Rows.Add("Ash Log", "Botanist", 3, "Mature Tree", 60, "233.9021, -9.287003, -59.2255", 5);
            itemsTable.Rows.Add("Ash Log", "Botanist", 7, "Mature Tree", 60, "281.881, -22.99627, 139.9542", 5);
            itemsTable.Rows.Add("Beehive Chip", "Botanist", 7, "Mature Tree", 60, "242.0697, -23.3774, 290.0143", 1);
            itemsTable.Rows.Add("Belladonna", "Botanist", 4, "Lush Vegetation Patch", 60, "-150.4986, -1.924852, 334.645", 3);
            itemsTable.Rows.Add("Black Alumen", "Miner", 5, "Mineral Deposit", 60, "364.1767, -4.775018, 69.99052", 1);
            itemsTable.Rows.Add("Blood Currants", "Botanist", 6, "Lush Vegetation Patch", 80, "-29.22734, -0.4312079, 364.1402", 1); // flagged
            itemsTable.Rows.Add("Brown Pigment", "Botanist", 7, "Mature Tree", 80, "252.646, -9.157417, 13.05055", 6); // flagged
            itemsTable.Rows.Add("Brown Pigment", "Miner", 10, "Rocky Outcrop", 80, "267.9286, 74.66428, -302.3478", 6); // flagged
            itemsTable.Rows.Add("Buffalo Beans", "Botanist", 3, "Lush Vegetation Patch", 80, "-159.9534, 1.306874, -102.8071", 1); // flagged
            itemsTable.Rows.Add("Carnation", "Botanist", 3, "Lush Vegetation Patch", 80, "62.98865, -8.831064, 122.1805", 0);
            itemsTable.Rows.Add("Chanterelle", "Botanist", 3, "Lush Vegetation Patch", 80, "62.98865, -8.831064, 122.1805", 6);
            itemsTable.Rows.Add("Chocobo Feather", "Botanist", 5, "Mature Tree", 60, "224.0834, 17.33236, -122.0438", 0);
            itemsTable.Rows.Add("Cieldalaes Spinach", "Botanist", 10, "Lush Vegetation Patch", 60, "266.3692, 45.04897, 34.22172", 5); // fixed, retry
            itemsTable.Rows.Add("Cinderfoot Olive", "Botanist", 10, "Lush Vegetation Patch", 60, "266.3692, 45.04897, 34.22172", 1); // fixed, retry
            itemsTable.Rows.Add("Cinnamon", "Botanist", 7, "Mature Tree", 60, "242.0697, -23.3774, 290.0143", 2);
            itemsTable.Rows.Add("Cotton Boll", "Botanist", 3, "Lush Vegetation Patch", 80, "62.98865, -8.831064, 122.1805", 3);
            itemsTable.Rows.Add("Crow Feather", "Botanist", 3, "Mature Tree", 60, "233.9021, -9.287003, -59.2255", 0);
            itemsTable.Rows.Add("Earth Rock", "Miner", 5, "Rocky Outcrop", 60, "55.40574, 5.669168, 12.8003", 3);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 10, "Lush Vegetation Patch", 60, "266.3692, 45.04897, 34.22172", 4); // fixed, retry
            itemsTable.Rows.Add("Earth Shard", "Botanist", 10, "Mature Tree", 60, "530.2131, 75.17319, -277.4191", 4);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 10, "Mature Tree", 60, "664.8801, 65.41305, -216.592", 4);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Lush Vegetation Patch", 60, "87.2282, -33.21325, 254.1546", 4);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 60, "242.0697, -23.3774, 290.0143", 4);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 60, "252.646, -9.157417, 13.05055", 4);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 60, "281.881, -22.99627, 139.9542", 4);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 60, "403.8246, -6.349792, 262.0765", 4);
            itemsTable.Rows.Add("Earth Shard", "Botanist", 7, "Mature Tree", 60, "52.50433, -12.99726, -14.05974", 4);
            itemsTable.Rows.Add("Earth Shard", "Miner", 10, "Mineral Deposit", 60, "308.8403, 68.79769, -143.7302", 4);
            itemsTable.Rows.Add("Earth Shard", "Miner", 10, "Rocky Outcrop", 60, "-7.995946, 41.8293, 684.2917", 4);
            itemsTable.Rows.Add("Earth Shard", "Miner", 10, "Rocky Outcrop", 60, "267.9286, 74.66428, -302.3478", 4);
            itemsTable.Rows.Add("Earth Shard", "Miner", 7, "Mineral Deposit", 60, "203.0196, -4.636922, 29.95464", 4);
            itemsTable.Rows.Add("Earth Shard", "Miner", 7, "Mineral Deposit", 60, "342.2458, -3.775561, 176.0148", 4);
            itemsTable.Rows.Add("Effervescent Water", "Miner", 5, "Mineral Deposit", 60, "-271.2609, 15.10915, -84.62809", 0);
            itemsTable.Rows.Add("Elm Log", "Botanist", 3, "Mature Tree", 50, "-43.49828, -6.881468, -74.46594", 5);
            itemsTable.Rows.Add("Faerie Apple", "Botanist", 4, "Mature Tree", 80, "-325.5423, -0.854171, 275.6144", 1); // flagged
            itemsTable.Rows.Add("Flax", "Botanist", 6, "Lush Vegetation Patch", 80, "-248.453, -0.4402871, 350.7661", 3); // flagged
            itemsTable.Rows.Add("Galago Mint", "Botanist", 4, "Lush Vegetation Patch", 60, "-150.4986, -1.924852, 334.645", 5);
            itemsTable.Rows.Add("Gil Bun", "Botanist", 4, "Lush Vegetation Patch", 80, "-150.4986, -1.924852, 334.645", 6); // flagged
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 3, "Mature Tree", 60, "158.9255, -24.59291, 471.9808", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 5, "Mature Tree", 60, "-209.3807, 8.241471, 14.18696", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Botanist", 7, "Mature Tree", 60, "252.646, -9.157417, 13.05055", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 10, "Rocky Outcrop", 60, "267.9286, 74.66428, -302.3478", 0);
            itemsTable.Rows.Add("Grade 2 Carbonized Matter", "Miner", 4, "Rocky Outcrop", 60, "-62.15393, -10.53283, 288.2905", 0);
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "Miner", 10, "Rocky Outcrop", 60, "-7.995946, 41.8293, 684.2917", 0);
            itemsTable.Rows.Add("Grade 3 Carbonized Matter", "Miner", 4, "Rocky Outcrop", 60, "-162.7803, -1.348187, 168.7855", 0);
            itemsTable.Rows.Add("Granite", "Miner", 3, "Mineral Deposit", 60, "-380.6211, 50.77991, 20.49316", 7);
            itemsTable.Rows.Add("Green Pigment", "Botanist", 3, "Mature Tree", 60, "158.9255, -24.59291, 471.9808", 6);
            itemsTable.Rows.Add("Green Pigment", "Miner", 4, "Rocky Outcrop", 60, "-62.15393, -10.53283, 288.2905", 5);
            itemsTable.Rows.Add("Grey Pigment", "Botanist", 5, "Mature Tree", 60, "-209.3807, 8.241471, 14.18696", 5);
            itemsTable.Rows.Add("Gridanian Chestnut", "Botanist", 3, "Mature Tree", 80, "-43.49828, -6.881468, -74.46594", 1); // flagged
            itemsTable.Rows.Add("Gridanian Walnut", "Botanist", 5, "Mature Tree", 80, "54.04222, 6.036263, 7.647984", 1); // flagged
            itemsTable.Rows.Add("Highland Parsley", "Botanist", 10, "Lush Vegetation Patch", 60, "266.3692, 45.04897, 34.22172", 6); // fixed, retry
            itemsTable.Rows.Add("Humus", "Botanist", 3, "Lush Vegetation Patch", 80, "-159.9534, 1.306874, -102.8071", 6);
            itemsTable.Rows.Add("Ice Rock", "Miner", 5, "Rocky Outcrop", 60, "55.40574, 5.669168, 12.8003", 5);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 3, "Mature Tree", 60, "61.01541, 4.252214, -174.6979", 4);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 5, "Mature Tree", 60, "-209.3807, 8.241471, 14.18696", 4);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 5, "Mature Tree", 60, "224.0834, 17.33236, -122.0438", 4);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 5, "Mature Tree", 60, "54.04222, 6.036263, 7.647984", 4);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 6, "Lush Vegetation Patch", 60, "-248.453, -0.4402871, 350.7661", 4);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 6, "Lush Vegetation Patch", 60, "-29.22734, -0.4312079, 364.1402", 4);
            itemsTable.Rows.Add("Ice Shard", "Botanist", 6, "Mature Tree", 60, "-229.608, -0.03202128, 443.5553", 4);
            itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Mineral Deposit", 60, "-271.2609, 15.10915, -84.62809", 4);
            itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Mineral Deposit", 60, "364.1767, -4.775018, 69.99052", 4);
            itemsTable.Rows.Add("Ice Shard", "Miner", 5, "Rocky Outcrop", 60, "55.40574, 5.669168, 12.8003", 4);
            itemsTable.Rows.Add("Jade Peas", "Botanist", 7, "Lush Vegetation Patch", 60, "87.2282, -33.21325, 254.1546", 2);
            itemsTable.Rows.Add("Kukuru Bean", "Botanist", 10, "Mature Tree", 60, "530.2131, 75.17319, -277.4191", 1);
            itemsTable.Rows.Add("La Noscean Orange", "Botanist", 10, "Mature Tree", 60, "530.2131, 75.17319, -277.4191", 2);
            itemsTable.Rows.Add("Latex", "Botanist", 3, "Mature Tree", 60, "61.01541, 4.252214, -174.6979", 3);
            itemsTable.Rows.Add("Latex", "Botanist", 7, "Mature Tree", 60, "403.8246, -6.349792, 262.0765", 3);
            itemsTable.Rows.Add("Lavender", "Botanist", 3, "Lush Vegetation Patch", 80, "62.98865, -8.831064, 122.1805", 5);
            itemsTable.Rows.Add("Lowland Grapes", "Botanist", 10, "Lush Vegetation Patch", 60, "266.3692, 45.04897, 34.22172", 2); // fixed, retry
            itemsTable.Rows.Add("Maple Branch", "Botanist", 3, "Mature Tree", 60, "61.01541, 4.252214, -174.6979", 2);
            itemsTable.Rows.Add("Maple Branch", "Botanist", 7, "Mature Tree", 60, "403.8246, -6.349792, 262.0765", 2);
            itemsTable.Rows.Add("Maple Log", "Botanist", 3, "Mature Tree", 60, "61.01541, 4.252214, -174.6979", 6);
            itemsTable.Rows.Add("Maple Log", "Botanist", 7, "Mature Tree", 60, "403.8246, -6.349792, 262.0765", 5);
            itemsTable.Rows.Add("Maple Sap", "Botanist", 7, "Mature Tree", 60, "242.0697, -23.3774, 290.0143", 3);
            itemsTable.Rows.Add("Marjoram", "Botanist", 3, "Lush Vegetation Patch", 50, "-159.9534, 1.306874, -102.8071", 5);
            itemsTable.Rows.Add("Matron's Mistletoe", "Botanist", 5, "Mature Tree", 60, "54.04222, 6.036263, 7.647984", 7);
            itemsTable.Rows.Add("Midland Cabbage", "Botanist", 7, "Lush Vegetation Patch", 60, "87.2282, -33.21325, 254.1546", 5);
            itemsTable.Rows.Add("Moor Leech", "Botanist", 7, "Lush Vegetation Patch", 60, "87.2282, -33.21325, 254.1546", 0);
            itemsTable.Rows.Add("Oak Branch", "Botanist", 6, "Mature Tree", 60, "-229.608, -0.03202128, 443.5553", 2);
            itemsTable.Rows.Add("Oak Log", "Botanist", 6, "Mature Tree", 60, "-229.608, -0.03202128, 443.5553", 5);
            itemsTable.Rows.Add("Potter's Clay", "Miner", 7, "Mineral Deposit", 60, "342.2458, -3.775561, 176.0148", 3);
            itemsTable.Rows.Add("Raw Amethyst", "Miner", 3, "Mineral Deposit", 60, "-380.6211, 50.77991, 20.49316", 6);
            itemsTable.Rows.Add("Raw Lapis Lazuli", "Miner", 7, "Mineral Deposit", 60, "342.2458, -3.775561, 176.0148", 6);
            itemsTable.Rows.Add("Raw Peridot", "Miner", 3, "Mineral Deposit", 60, "-380.6211, 50.77991, 20.49316", 5);
            itemsTable.Rows.Add("Raw Spinel", "Miner", 5, "Mineral Deposit", 60, "364.1767, -4.775018, 69.99052", 7);
            itemsTable.Rows.Add("Raw Sunstone", "Miner", 10, "Mineral Deposit", 60, "308.8403, 68.79769, -143.7302", 6);
            itemsTable.Rows.Add("Raw Tourmaline", "Miner", 5, "Mineral Deposit", 60, "364.1767, -4.775018, 69.99052", 5);
            itemsTable.Rows.Add("Rosewood Branch", "Botanist", 4, "Mature Tree", 60, "-252.335, 6.061327, 85.4445", 2);
            itemsTable.Rows.Add("Rosewood Log", "Botanist", 4, "Mature Tree", 60, "-252.335, 6.061327, 85.4445", 5);
            itemsTable.Rows.Add("Shroud Seedling", "Botanist", 4, "Lush Vegetation Patch", 60, "-150.4986, -1.924852, 334.645", 7);
            itemsTable.Rows.Add("Silver Ore", "Miner", 5, "Mineral Deposit", 60, "-271.2609, 15.10915, -84.62809", 5);
            itemsTable.Rows.Add("Silver Sand", "Miner", 5, "Rocky Outcrop", 60, "55.40574, 5.669168, 12.8003", 1);
            itemsTable.Rows.Add("Sun Lemon", "Botanist", 10, "Mature Tree", 60, "664.8801, 65.41305, -216.592", 1);
            itemsTable.Rows.Add("Tatantula", "Botanist", 6, "Mature Tree", 60, "-229.608, -0.03202128, 443.5553", 0);
            itemsTable.Rows.Add("Thyme", "Botanist", 6, "Lush Vegetation Patch", 60, "-29.22734, -0.4312079, 364.1402", 5);
            itemsTable.Rows.Add("Tinolqa Mistletoe", "Botanist", 3, "Mature Tree", 60, "233.9021, -9.287003, -59.2255", 7);
            itemsTable.Rows.Add("Tinolqa Mistletoe", "Botanist", 7, "Mature Tree", 60, "281.881, -22.99627, 139.9542", 7);
            itemsTable.Rows.Add("Tree Toad", "Botanist", 3, "Lush Vegetation Patch", 50, "-159.9534, 1.306874, -102.8071", 7);
            itemsTable.Rows.Add("Walnut Log", "Botanist", 5, "Mature Tree", 60, "54.04222, 6.036263, 7.647984", 5);
            itemsTable.Rows.Add("White Truffle", "Botanist", 6, "Lush Vegetation Patch", 60, "-248.453, -0.4402871, 350.7661", 6);
            itemsTable.Rows.Add("Wildfowl Feather", "Botanist", 6, "Lush Vegetation Patch", 60, "-248.453, -0.4402871, 350.7661", 0);
            itemsTable.Rows.Add("Wind Crystal", "Botanist", 3, "Mature Tree", 60, "158.9255, -24.59291, 471.9808", 5);
            itemsTable.Rows.Add("Wind Crystal", "Miner", 4, "Rocky Outcrop", 60, "-162.7803, -1.348187, 168.7855", 5);
            itemsTable.Rows.Add("Wind Rock", "Miner", 5, "Rocky Outcrop", 60, "55.40574, 5.669168, 12.8003", 6);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Lush Vegetation Patch", 50, "-159.9534, 1.306874, -102.8071", 4);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Lush Vegetation Patch", 80, "62.98865, -8.831064, 122.1805", 4);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 50, "-43.49828, -6.881468, -74.46594", 4);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 60, "158.9255, -24.59291, 471.9808", 4);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 60, "233.9021, -9.287003, -59.2255", 4);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 3, "Mature Tree", 60, "61.01541, 4.252214, -174.6979", 5);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 4, "Lush Vegetation Patch", 60, "-150.4986, -1.924852, 334.645", 4);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 4, "Mature Tree", 60, "-252.335, 6.061327, 85.4445", 4);
            itemsTable.Rows.Add("Wind Shard", "Botanist", 4, "Mature Tree", 60, "-325.5423, -0.854171, 275.6144", 4);
            itemsTable.Rows.Add("Wind Shard", "Miner", 3, "Mineral Deposit", 60, "-380.6211, 50.77991, 20.49316", 4);
            itemsTable.Rows.Add("Wind Shard", "Miner", 4, "Rocky Outcrop", 60, "-162.7803, -1.348187, 168.7855", 4);
            itemsTable.Rows.Add("Wind Shard", "Miner", 4, "Rocky Outcrop", 60, "-62.15393, -10.53283, 288.2905", 4);
            itemsTable.Rows.Add("Wizard Eggplant", "Botanist", 7, "Lush Vegetation Patch", 60, "87.2282, -33.21325, 254.1546", 1);
            itemsTable.Rows.Add("Yellow Pigment", "Botanist", 7, "Mature Tree", 60, "252.646, -9.157417, 13.05055", 5);
            itemsTable.Rows.Add("Yellow Pigment", "Miner", 10, "Rocky Outcrop", 60, "267.9286, 74.66428, -302.3478", 5);
            itemsTable.Rows.Add("Yew Branch", "Botanist", 4, "Mature Tree", 60, "-325.5423, -0.854171, 275.6144", 2);
            itemsTable.Rows.Add("Yew Log", "Botanist", 4, "Mature Tree", 60, "-325.5423, -0.854171, 275.6144", 5);

            return itemsTable;
        }
    }
}
