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
namespace GatherAssist
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using Clio.Utilities;
    using Settings;

    /// <summary>
    /// The settings form to this plugin.  Allows the user to adjust plugin settings, as well as create the list of gather requests.
    /// </summary>
    public partial class GatherAssist_Form : Form
    {
        /// <summary>
        /// The plugin settings.
        /// </summary>
        private static GatherAssistSettings settings = GatherAssistSettings.Instance;

        /// <summary>
        /// The search results for possible items to add to the request table.  Shows everything if no search is present.
        /// </summary>
        private DataTable resultsTable;

        /// <summary>
        /// The table containing all items which can be added to the list of gather requests.
        /// </summary>
        private DataTable itemsTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="GatherAssist_Form" /> class.  Loads the provided list of possible gather items into the searchable items table.
        /// </summary>
        /// <param name="inItemsTable">A table of all possible items to be gathered.  Should contain an ItemName field.</param>
        public GatherAssist_Form(DataTable inItemsTable)
        {
            // TODO: validate inItemsTable parameter.
            this.itemsTable = inItemsTable.Copy();
            this.InitializeComponent();
            this.textBoxUpdateInterval.Text = Convert.ToString(settings.UpdateIntervalMinutes);
            this.textBoxAutoSkipInterval.Text = Convert.ToString(settings.AutoSkipInterval);
            this.checkBoxAutoSkip.Checked = settings.AutoSkip;
            this.RequestTable = this.itemsTable.DefaultView.ToTable(false, "ItemName");
            this.RequestTable.Rows.Clear();
            this.RequestTable.Columns[0].ReadOnly = true;
            this.RequestTable.Columns.Add(new DataColumn("Count", typeof(int)) { DefaultValue = 0 }); // requested count, defaults to 0
            this.UpdateSearchBox();
            this.labelInstructions.Text = "Instructions:\nBrowse from the request options, or\nsearch for the item you need.  Clicking\nthe item in the request options list\nwill make it appear in the request list.\nEnter the desired number of each item\nyou are searching for, and click OK to\nstart the bot!";

            DataTable oldTable = this.RequestTable.Copy();
            this.RequestTable = oldTable.Clone();
            this.RequestTable.Columns[0].ReadOnly = true;
            foreach (DataRow curRow in oldTable.Rows)
            {
                if (Convert.ToInt32(curRow["Count"]) != 0)
                {
                    this.RequestTable.Rows.Add(Convert.ToString(curRow["ItemName"]), Convert.ToInt32(curRow["Count"]));
                }
            }

            this.dataGridViewRequests.DataSource = this.RequestTable;
            this.UpdateSearchBox();
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="GatherAssist_Form" /> class from being created.
        /// </summary>
        private GatherAssist_Form()
        {
        }

        /// <summary>
        /// Gets or sets the table containing all gather requests.
        /// </summary>
        public DataTable RequestTable { get; set; }

        /// <summary>
        /// Sorts a DataTable.
        /// </summary>
        /// <param name="inTable">The table to be sorted.</param>
        /// <param name="colName">The column which should be used to sort the table.</param>
        /// <param name="direction">The sort direction.  ASC or DESC.</param>
        /// <returns>The newly sorted table.</returns>
        private static DataTable ReSort(DataTable inTable, string colName, string direction)
        {
            // TODO: validate all parameters.
            inTable.DefaultView.Sort = colName + " " + direction;
            inTable = inTable.DefaultView.ToTable();
            return inTable;
        }

        /// <summary>
        /// Handles the buttonOK.Click event.  Filters the request list to requests with more than a zero count, and closes the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            settings.UpdateIntervalMinutes = System.Convert.ToInt32(this.textBoxUpdateInterval.Text);
            settings.AutoSkip = this.checkBoxAutoSkip.Checked;
            settings.AutoSkipInterval = System.Convert.ToInt32(this.textBoxAutoSkipInterval.Text);
            DataTable oldTable = ((DataTable)this.dataGridViewRequests.DataSource).Copy();
            this.RequestTable = oldTable.Clone();
            this.RequestTable.Columns[0].ReadOnly = true;
            foreach (DataRow curRow in oldTable.Rows)
            {
                if (Convert.ToInt32(curRow["Count"]) != 0)
                {
                    this.RequestTable.Rows.Add(Convert.ToString(curRow["ItemName"]), Convert.ToInt32(curRow["Count"]));
                }
            }

            this.dataGridViewRequests.DataSource = this.RequestTable;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Handles the textBoxSearch.TextChanged event.  Pass-through function calling the UpdateSearchBox function.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.UpdateSearchBox();
        }

        /// <summary>
        /// Updates the search box to reflect the currently entered search criteria.
        /// </summary>
        private void UpdateSearchBox()
        {
            this.resultsTable = this.itemsTable.DefaultView.ToTable(false, "ItemName");

            if (this.textBoxSearch.Text != string.Empty)
            {
                this.resultsTable.Rows.Clear();
                foreach (DataRow resultRow in this.itemsTable.Select(string.Format("ItemName LIKE '%{0}%'", this.textBoxSearch.Text)))
                {
                    this.resultsTable.Rows.Add(resultRow["ItemName"]);
                }
            }

            this.resultsTable.Columns[0].ReadOnly = true;
            this.dataGridViewResults.DataSource = this.resultsTable;
        }

        /// <summary>
        /// Handles the dataGridViewResults.CellClick event.  Pass-through function calling the AddSelectedCell function.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridViewResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AddSelectedCell();
        }        

        /// <summary>
        /// Adds the currently selected cell in the item list to the list of gather requests.  Only adds if the item is not already on the
        ///  gather list (no duplicates).
        /// </summary>
        private void AddSelectedCell()
        {
            if (this.dataGridViewResults.SelectedCells.Count != 1)
            {
                return; // don't bother unless a single cell is selected
            }

            int rowIndex = this.dataGridViewResults.SelectedCells[0].RowIndex;
            int columnIndex = this.dataGridViewResults.SelectedCells[0].ColumnIndex;

            if (rowIndex < 0 || columnIndex < 0)
            {
                return; // do nothing, invalid index
            }

            string itemName = Convert.ToString(this.dataGridViewResults.Rows[rowIndex].Cells[columnIndex].Value);
            if (this.RequestTable.Select(string.Format("ItemName = '{0}'", itemName)).Length == 0)
            {
                this.RequestTable.Rows.Add(itemName, 0);
            }

            this.RequestTable = ReSort(this.RequestTable, "ItemName", "ASC");
            this.RequestTable.Columns[0].ReadOnly = true;
            this.dataGridViewRequests.DataSource = this.RequestTable;
        }
    }
}