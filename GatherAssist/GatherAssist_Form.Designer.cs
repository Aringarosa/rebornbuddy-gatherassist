namespace GatherAssist
{
    partial class GatherAssist_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxUpdateInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelRequestOptions = new System.Windows.Forms.Label();
            this.labelRequestList = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(353, 585);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(108, 22);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // textBoxUpdateInterval
            // 
            this.textBoxUpdateInterval.Location = new System.Drawing.Point(146, 50);
            this.textBoxUpdateInterval.Name = "textBoxUpdateInterval";
            this.textBoxUpdateInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateInterval.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Polling Interval (Minutes)";
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.Size = new System.Drawing.Size(252, 399);
            this.dataGridViewRequests.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxUpdateInterval);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(270, 180);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(187, 398);
            this.dataGridViewResults.TabIndex = 7;
            this.dataGridViewResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewResults_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(318, 141);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(271, 144);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Search";
            // 
            // labelRequestOptions
            // 
            this.labelRequestOptions.AutoSize = true;
            this.labelRequestOptions.Location = new System.Drawing.Point(269, 164);
            this.labelRequestOptions.Name = "labelRequestOptions";
            this.labelRequestOptions.Size = new System.Drawing.Size(86, 13);
            this.labelRequestOptions.TabIndex = 10;
            this.labelRequestOptions.Text = "Request Options";
            // 
            // labelRequestList
            // 
            this.labelRequestList.AutoSize = true;
            this.labelRequestList.Location = new System.Drawing.Point(12, 164);
            this.labelRequestList.Name = "labelRequestList";
            this.labelRequestList.Size = new System.Drawing.Size(66, 13);
            this.labelRequestList.TabIndex = 11;
            this.labelRequestList.Text = "Request List";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(274, 9);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(60, 13);
            this.labelInstructions.TabIndex = 12;
            this.labelInstructions.Text = "instructions";
            // 
            // GatherAssist_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 619);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelRequestList);
            this.Controls.Add(this.labelRequestOptions);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewRequests);
            this.Controls.Add(this.buttonOK);
            this.Name = "GatherAssist_Form";
            this.Text = "GatherAssist Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxUpdateInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelRequestOptions;
        private System.Windows.Forms.Label labelRequestList;
        private System.Windows.Forms.Label labelInstructions;
    }
}