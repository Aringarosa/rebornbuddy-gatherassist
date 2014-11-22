using Clio.Utilities;
using GatherAssist.Settings;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GatherAssist
{
    public partial class GatherAssist_Form : Form
    {
        public static Vector3 vendorlocationtemp;
        public static GatherAssistSettings settings = GatherAssistSettings.instance;
        public DataTable requestTable;
        private DataTable resultsTable;
        private DataTable itemsTable;

        public GatherAssist_Form(DataTable inItemsTable)
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchBox();
        }

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

        private void dataGridViewResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSelectedCell();
        }        
        


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
        public static DataTable ReSort(DataTable inTable, string colName, string direction)
        {
            inTable.DefaultView.Sort = colName + " " + direction;
            inTable = inTable.DefaultView.ToTable();
            return inTable;
        }
    }
}