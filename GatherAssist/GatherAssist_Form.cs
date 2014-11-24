//-----------------------------------------------------------------------
// <copyright file="GatherAssist_Form.cs" company="Zane McFate">
//      This code file, and this entire plugin, is uncopyrighted.  This means
//       I've put them in the public domain, and released my copyright on all
//       these works.  There is no need to email me for permission -- use my
//       content however you want!  Email it, share it, reprint it with or
//       without credit.  Change it around, break it, and attribute it to me.
//       It's okay.  Attribution is appreciated, but not required.
// </copyright>
// <author>Zane McFate</author>
//-----------------------------------------------------------------------
using Clio.Utilities;
using GatherAssist.Settings;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GatherAssist
{
    /// <summary>
    /// The settings form to this plugin.  Allows the user to adjust plugin settings, as well as create the list of gather requests.
    /// </summary>
    public partial class GatherAssist_Form : Form
    {
        /// <summary>
        /// The plugin settings.
        /// </summary>
        public static GatherAssistSettings settings = GatherAssistSettings.instance;

        /// <summary>
        /// The table for all gather requests.
        /// </summary>
        public DataTable requestTable;

        /// <summary>
        /// The search results for possible items to add to the request table.  Shows everything if no search is present.
        /// </summary>
        private DataTable resultsTable;

        /// <summary>
        /// The table containing all items which can be added to the list of gather requests.
        /// </summary>
        private DataTable itemsTable;

        /// <summary>
        /// Constructor.  Loads the provided list of possible gather items into the searchable items table.
        /// </summary>
        /// <param name="inItemsTable">A table of all possible items to be gathered.  Should contain an ItemName field.</param>
        public GatherAssist_Form(DataTable inItemsTable)
        {
            // TODO: validate inItemsTable parameter.
            this.itemsTable = inItemsTable.Copy();
            InitializeComponent();
            textBoxUpdateInterval.Text = Convert.ToString(settings.UpdateIntervalMinutes);
            //requestTable = itemsTable.DefaultView.ToTable(false, "ItemName");
            //requestTable.Columns.Add(new DataColumn("Count", typeof(int)) { DefaultValue = 0 }); // requested count, defaults to 0
            //dataGridViewRequests.DataSource = requestTable;

            requestTable = itemsTable.DefaultView.ToTable(false, "ItemName");
            requestTable.Rows.Clear();
            requestTable.Columns[0].ReadOnly = true;
            requestTable.Columns.Add(new DataColumn("Count", typeof(int)) { DefaultValue = 0 }); // requested count, defaults to 0
            UpdateSearchBox();
            labelInstructions.Text = "Instructions:\nBrowse from the request options, or\nsearch for the item you need.  Clicking\nthe item in the request options list\nwill make it appear in the request list.\nEnter the desired number of each item\nyou are searching for, and click OK to\nstart the bot!";

            DataTable oldTable = this.requestTable.Copy();
            this.requestTable = oldTable.Clone();
            requestTable.Columns[0].ReadOnly = true;
            foreach (DataRow curRow in oldTable.Rows)
            {
                if (Convert.ToInt32(curRow["Count"]) != 0)
                {
                    this.requestTable.Rows.Add(Convert.ToString(curRow["ItemName"]), Convert.ToInt32(curRow["Count"]));
                }
            }

            dataGridViewRequests.DataSource = requestTable;
            UpdateSearchBox();
        }

        /// <summary>
        /// Prevent default constructor from being called.
        /// </summary>
        private GatherAssist_Form()
        {
        }

        /// <summary>
        /// Handles the buttonOK.Click event.  Filters the request list to requests with more than a zero count, and closes the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            settings.UpdateIntervalMinutes = System.Convert.ToInt32(textBoxUpdateInterval.Text);
            DataTable oldTable = ((DataTable)this.dataGridViewRequests.DataSource).Copy();
            this.requestTable = oldTable.Clone();
            requestTable.Columns[0].ReadOnly = true;
            foreach (DataRow curRow in oldTable.Rows)
            {
                if (Convert.ToInt32(curRow["Count"]) != 0)
                {
                    this.requestTable.Rows.Add(Convert.ToString(curRow["ItemName"]), Convert.ToInt32(curRow["Count"]));
                }
            }

            dataGridViewRequests.DataSource = this.requestTable;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Handles the textBoxSearch.TextChanged event.  Pass-through function calling the UpdateSearchBox function.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchBox();
        }

        /// <summary>
        /// Updates the search box to reflect the currently entered search criteria.
        /// </summary>
        private void UpdateSearchBox()
        {
            resultsTable = itemsTable.DefaultView.ToTable(false, "ItemName");

            if (textBoxSearch.Text != "")
            {
                resultsTable.Rows.Clear();
                foreach (DataRow resultRow in itemsTable.Select(string.Format("ItemName LIKE '%{0}%'", textBoxSearch.Text)))
                {
                    resultsTable.Rows.Add(resultRow["ItemName"]);
                }
            }

            resultsTable.Columns[0].ReadOnly = true;
            dataGridViewResults.DataSource = resultsTable;
        }

        /// <summary>
        /// Handles the dataGridViewResults.CellClick event.  Pass-through function calling the AddSelectedCell function.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void dataGridViewResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSelectedCell();
        }        

        /// <summary>
        /// Adds the currently selected cell in the item list to the list of gather requests.  Only adds if the item is not already on the
        ///  gather list (no duplicates).
        /// </summary>
        private void AddSelectedCell()
        {
            //if (requestTable == null || requestTable.Columns.Count == 0)
            //{
            //    return; // don't run if the request table hasn't been initialized
            //}

            if (dataGridViewResults.SelectedCells.Count != 1)
            {
                return; // don't bother unless a single cell is selected
            }

            int rowIndex = dataGridViewResults.SelectedCells[0].RowIndex;
            int columnIndex = dataGridViewResults.SelectedCells[0].ColumnIndex;

            if (rowIndex < 0 || columnIndex < 0)
            {
                return; // do nothing, invalid index
            }

            string itemName = Convert.ToString(dataGridViewResults.Rows[rowIndex].Cells[columnIndex].Value);
            if (requestTable.Select(string.Format("ItemName = '{0}'", itemName)).Length == 0)
            {
                requestTable.Rows.Add(itemName, 0);
            }

            requestTable = ReSort(requestTable, "ItemName", "ASC");
            requestTable.Columns[0].ReadOnly = true;
            dataGridViewRequests.DataSource = requestTable;
        }

        /// <summary>
        /// Sorts a DataTable.
        /// </summary>
        /// <param name="inTable">The table to be sorted.</param>
        /// <param name="colName">The column which should be used to sort the table.</param>
        /// <param name="direction">The sort direction.  ASC or DESC.</param>
        /// <returns>The newly sorted table.</returns>
        public static DataTable ReSort(DataTable inTable, string colName, string direction)
        {
            // TODO: validate all parameters.
            inTable.DefaultView.Sort = colName + " " + direction;
            inTable = inTable.DefaultView.ToTable();
            return inTable;
        }
    }
}