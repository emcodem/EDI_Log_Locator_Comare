﻿namespace EDI_LOC_Validator
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistoryLoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNewEntryCount = new System.Windows.Forms.Label();
            this.buttonBrowseCurrentEdi = new System.Windows.Forms.Button();
            this.textBoxCurrentEdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelOldLogCount = new System.Windows.Forms.Label();
            this.buttonBrowseOldEdi = new System.Windows.Forms.Button();
            this.textBoxOldEdiLogPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEntriesDifferent = new System.Windows.Forms.DataGridView();
            this.buttonUpdateLoc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryLoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntriesDifferent)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 523);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewHistoryLoc);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(536, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 387);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Locator History for Callsign";
            // 
            // dataGridViewHistoryLoc
            // 
            this.dataGridViewHistoryLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoryLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistoryLoc.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewHistoryLoc.Name = "dataGridViewHistoryLoc";
            this.dataGridViewHistoryLoc.RowHeadersWidth = 62;
            this.dataGridViewHistoryLoc.RowTemplate.Height = 15;
            this.dataGridViewHistoryLoc.Size = new System.Drawing.Size(522, 362);
            this.dataGridViewHistoryLoc.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNewEntryCount);
            this.groupBox1.Controls.Add(this.buttonBrowseCurrentEdi);
            this.groupBox1.Controls.Add(this.textBoxCurrentEdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current EDI Log";
            // 
            // labelNewEntryCount
            // 
            this.labelNewEntryCount.AutoSize = true;
            this.labelNewEntryCount.Location = new System.Drawing.Point(66, 79);
            this.labelNewEntryCount.Name = "labelNewEntryCount";
            this.labelNewEntryCount.Size = new System.Drawing.Size(76, 20);
            this.labelNewEntryCount.TabIndex = 3;
            this.labelNewEntryCount.Text = "Entries: 0";
            // 
            // buttonBrowseCurrentEdi
            // 
            this.buttonBrowseCurrentEdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseCurrentEdi.Location = new System.Drawing.Point(444, 35);
            this.buttonBrowseCurrentEdi.Name = "buttonBrowseCurrentEdi";
            this.buttonBrowseCurrentEdi.Size = new System.Drawing.Size(75, 34);
            this.buttonBrowseCurrentEdi.TabIndex = 2;
            this.buttonBrowseCurrentEdi.Text = "Browse";
            this.buttonBrowseCurrentEdi.UseVisualStyleBackColor = true;
            this.buttonBrowseCurrentEdi.Click += new System.EventHandler(this.buttonBrowseCurrentEdi_Click);
            // 
            // textBoxCurrentEdi
            // 
            this.textBoxCurrentEdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentEdi.Location = new System.Drawing.Point(70, 39);
            this.textBoxCurrentEdi.Name = "textBoxCurrentEdi";
            this.textBoxCurrentEdi.Size = new System.Drawing.Size(370, 26);
            this.textBoxCurrentEdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelOldLogCount);
            this.groupBox2.Controls.Add(this.buttonBrowseOldEdi);
            this.groupBox2.Controls.Add(this.textBoxOldEdiLogPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(536, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Old EDI Logs";
            // 
            // labelOldLogCount
            // 
            this.labelOldLogCount.AutoSize = true;
            this.labelOldLogCount.Location = new System.Drawing.Point(63, 79);
            this.labelOldLogCount.Name = "labelOldLogCount";
            this.labelOldLogCount.Size = new System.Drawing.Size(76, 20);
            this.labelOldLogCount.TabIndex = 4;
            this.labelOldLogCount.Text = "Entries: 0";
            // 
            // buttonBrowseOldEdi
            // 
            this.buttonBrowseOldEdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseOldEdi.Location = new System.Drawing.Point(442, 38);
            this.buttonBrowseOldEdi.Name = "buttonBrowseOldEdi";
            this.buttonBrowseOldEdi.Size = new System.Drawing.Size(75, 34);
            this.buttonBrowseOldEdi.TabIndex = 5;
            this.buttonBrowseOldEdi.Text = "Browse";
            this.buttonBrowseOldEdi.UseVisualStyleBackColor = true;
            this.buttonBrowseOldEdi.Click += new System.EventHandler(this.buttonBrowseOldEdi_Click);
            // 
            // textBoxOldEdiLogPath
            // 
            this.textBoxOldEdiLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOldEdiLogPath.Location = new System.Drawing.Point(67, 42);
            this.textBoxOldEdiLogPath.Name = "textBoxOldEdiLogPath";
            this.textBoxOldEdiLogPath.Size = new System.Drawing.Size(370, 26);
            this.textBoxOldEdiLogPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewEntriesDifferent);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 387);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entries with odd Locator";
            // 
            // dataGridViewEntriesDifferent
            // 
            this.dataGridViewEntriesDifferent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntriesDifferent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEntriesDifferent.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewEntriesDifferent.Name = "dataGridViewEntriesDifferent";
            this.dataGridViewEntriesDifferent.RowHeadersWidth = 62;
            this.dataGridViewEntriesDifferent.RowTemplate.Height = 15;
            this.dataGridViewEntriesDifferent.Size = new System.Drawing.Size(521, 362);
            this.dataGridViewEntriesDifferent.TabIndex = 0;
            this.dataGridViewEntriesDifferent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntriesDifferent_CellClick);
            // 
            // buttonUpdateLoc
            // 
            this.buttonUpdateLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateLoc.Location = new System.Drawing.Point(548, 569);
            this.buttonUpdateLoc.Name = "buttonUpdateLoc";
            this.buttonUpdateLoc.Size = new System.Drawing.Size(531, 43);
            this.buttonUpdateLoc.TabIndex = 1;
            this.buttonUpdateLoc.Text = "<< Update With Selected Locator";
            this.buttonUpdateLoc.UseVisualStyleBackColor = true;
            this.buttonUpdateLoc.Click += new System.EventHandler(this.buttonUpdateLoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 633);
            this.Controls.Add(this.buttonUpdateLoc);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryLoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntriesDifferent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCurrentEdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseCurrentEdi;
        private System.Windows.Forms.Button buttonBrowseOldEdi;
        private System.Windows.Forms.TextBox textBoxOldEdiLogPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNewEntryCount;
        private System.Windows.Forms.Label labelOldLogCount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewEntriesDifferent;
        private System.Windows.Forms.DataGridView dataGridViewHistoryLoc;
        private System.Windows.Forms.Button buttonUpdateLoc;
    }
}

