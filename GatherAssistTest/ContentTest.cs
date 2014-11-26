namespace GatherAssist
{
    //    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Data;

    /// <summary>
    /// Contains unit tests for the Content class.
    /// </summary>
    [TestClass]
    public class ContentTest
    {
        /// <summary>
        /// Tests whether the Items Table target names are all known objects.  This prevents obvious typos.
        /// </summary>
        [TestMethod]
        public void CreateItemsTable_InvalidGatherObject()
        {
            DataTable itemsTable = Content.CreateItemsTable();
            DataRow[] offenders = itemsTable.Select("GatherObject NOT IN ('Mineral Deposit', 'Rocky Outcrop', 'Lush Vegetation Patch', 'Mature Tree')");
            int offenderCount = offenders.Length;
            Assert.AreEqual(offenderCount, 0, "Unknown Gather Object in one or more ItemsTable records.");
        }

        public void CreateItemsTable_InvalidClass()
        {
            DataTable itemsTable = Content.CreateItemsTable();
            DataRow[] offenders = itemsTable.Select("ClassName NOT IN ('Miner', 'Botanist')");
            int offenderCount = offenders.Length;
            Assert.AreEqual(offenderCount, 0, "Unknown Class Name in one or more ItemsTable records.");
        }
    }
}
