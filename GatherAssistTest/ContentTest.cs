//-----------------------------------------------------------------------
// <copyright file="ContentTest.cs" company="Zane McFate">
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
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        /// <summary>
        /// Tests whether the Items Table class names are all known gathering classes.  This prevents obvious typos
        ///  and unsupported classes.
        /// </summary>
        public void CreateItemsTable_InvalidClass()
        {
            DataTable itemsTable = Content.CreateItemsTable();
            DataRow[] offenders = itemsTable.Select("ClassName NOT IN ('Miner', 'Botanist')");
            int offenderCount = offenders.Length;
            Assert.AreEqual(offenderCount, 0, "Unknown Class Name in one or more ItemsTable records.");
        }
    }
}
