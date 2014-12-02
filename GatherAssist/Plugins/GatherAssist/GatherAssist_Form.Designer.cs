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
            this.checkBoxHqOnly = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAutoSkip = new System.Windows.Forms.CheckBox();
            this.textBoxAutoSkipInterval = new System.Windows.Forms.TextBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelRequestOptions = new System.Windows.Forms.Label();
            this.labelRequestList = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.buttonValidationMode = new System.Windows.Forms.Button();
            this.checkBoxSoundWhenFinished = new System.Windows.Forms.CheckBox();
            this.checkBoxLogoutWhenFinished = new System.Windows.Forms.CheckBox();
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
            this.textBoxUpdateInterval.Location = new System.Drawing.Point(146, 94);
            this.textBoxUpdateInterval.Name = "textBoxUpdateInterval";
            this.textBoxUpdateInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateInterval.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Polling Interval (Minutes)";
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(12, 209);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.Size = new System.Drawing.Size(252, 370);
            this.dataGridViewRequests.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLogoutWhenFinished);
            this.groupBox1.Controls.Add(this.buttonValidationMode);
            this.groupBox1.Controls.Add(this.checkBoxSoundWhenFinished);
            this.groupBox1.Controls.Add(this.checkBoxHqOnly);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxAutoSkip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxUpdateInterval);
            this.groupBox1.Controls.Add(this.textBoxAutoSkipInterval);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBoxHqOnly
            // 
            this.checkBoxHqOnly.AutoSize = true;
            this.checkBoxHqOnly.Location = new System.Drawing.Point(95, 19);
            this.checkBoxHqOnly.Name = "checkBoxHqOnly";
            this.checkBoxHqOnly.Size = new System.Drawing.Size(66, 17);
            this.checkBoxHqOnly.TabIndex = 13;
            this.checkBoxHqOnly.Text = "HQ Only";
            this.checkBoxHqOnly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "AutoSkip Interval";
            // 
            // checkBoxAutoSkip
            // 
            this.checkBoxAutoSkip.AutoSize = true;
            this.checkBoxAutoSkip.Location = new System.Drawing.Point(20, 19);
            this.checkBoxAutoSkip.Name = "checkBoxAutoSkip";
            this.checkBoxAutoSkip.Size = new System.Drawing.Size(69, 17);
            this.checkBoxAutoSkip.TabIndex = 14;
            this.checkBoxAutoSkip.Text = "AutoSkip";
            this.checkBoxAutoSkip.UseVisualStyleBackColor = true;
            // 
            // textBoxAutoSkipInterval
            // 
            this.textBoxAutoSkipInterval.Location = new System.Drawing.Point(146, 120);
            this.textBoxAutoSkipInterval.Name = "textBoxAutoSkipInterval";
            this.textBoxAutoSkipInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutoSkipInterval.TabIndex = 13;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(270, 209);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(187, 369);
            this.dataGridViewResults.TabIndex = 7;
            this.dataGridViewResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewResults_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(314, 170);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(267, 173);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Search";
            // 
            // labelRequestOptions
            // 
            this.labelRequestOptions.AutoSize = true;
            this.labelRequestOptions.Location = new System.Drawing.Point(267, 193);
            this.labelRequestOptions.Name = "labelRequestOptions";
            this.labelRequestOptions.Size = new System.Drawing.Size(86, 13);
            this.labelRequestOptions.TabIndex = 10;
            this.labelRequestOptions.Text = "Request Options";
            // 
            // labelRequestList
            // 
            this.labelRequestList.AutoSize = true;
            this.labelRequestList.Location = new System.Drawing.Point(12, 193);
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
            // buttonValidationMode
            // 
            this.buttonValidationMode.Location = new System.Drawing.Point(139, 146);
            this.buttonValidationMode.Name = "buttonValidationMode";
            this.buttonValidationMode.Size = new System.Drawing.Size(107, 23);
            this.buttonValidationMode.TabIndex = 13;
            this.buttonValidationMode.Text = "Validation Mode";
            this.buttonValidationMode.UseVisualStyleBackColor = true;
            this.buttonValidationMode.Click += new System.EventHandler(this.ButtonValidationMode_Click);
            // 
            // checkBoxSoundWhenFinished
            // 
            this.checkBoxSoundWhenFinished.AutoSize = true;
            this.checkBoxSoundWhenFinished.Location = new System.Drawing.Point(20, 41);
            this.checkBoxSoundWhenFinished.Name = "checkBoxSoundWhenFinished";
            this.checkBoxSoundWhenFinished.Size = new System.Drawing.Size(154, 17);
            this.checkBoxSoundWhenFinished.TabIndex = 14;
            this.checkBoxSoundWhenFinished.Text = "Play Sound When Finished";
            this.checkBoxSoundWhenFinished.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogoutWhenFinished
            // 
            this.checkBoxLogoutWhenFinished.AutoSize = true;
            this.checkBoxLogoutWhenFinished.Location = new System.Drawing.Point(20, 64);
            this.checkBoxLogoutWhenFinished.Name = "checkBoxLogoutWhenFinished";
            this.checkBoxLogoutWhenFinished.Size = new System.Drawing.Size(133, 17);
            this.checkBoxLogoutWhenFinished.TabIndex = 13;
            this.checkBoxLogoutWhenFinished.Text = "Logout When Finished";
            this.checkBoxLogoutWhenFinished.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.CheckBox checkBoxAutoSkip;
        private System.Windows.Forms.TextBox textBoxAutoSkipInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxHqOnly;
        private System.Windows.Forms.Button buttonValidationMode;
        private System.Windows.Forms.CheckBox checkBoxSoundWhenFinished;
        private System.Windows.Forms.CheckBox checkBoxLogoutWhenFinished;
    }
}