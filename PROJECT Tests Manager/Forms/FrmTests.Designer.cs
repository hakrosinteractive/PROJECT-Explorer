namespace HAKROS.Forms
{
    partial class FrmTests
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTests));
            this.label7 = new System.Windows.Forms.Label();
            this.ComboTests = new System.Windows.Forms.ComboBox();
            this.TextTest = new System.Windows.Forms.RichTextBox();
            this.ListTest = new System.Windows.Forms.DataGridView();
            this.LnkAdd = new System.Windows.Forms.LinkLabel();
            this.LnkRemove = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tcontrol = new System.Windows.Forms.Timer(this.components);
            this.TBC = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.ListResults = new System.Windows.Forms.DataGridView();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.PanelHelp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LnkExample = new System.Windows.Forms.LinkLabel();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListTest)).BeginInit();
            this.TBC.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListResults)).BeginInit();
            this.tp2.SuspendLayout();
            this.PanelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Available tests";
            // 
            // ComboTests
            // 
            this.ComboTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboTests.BackColor = System.Drawing.Color.White;
            this.ComboTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTests.ForeColor = System.Drawing.Color.Black;
            this.ComboTests.FormattingEnabled = true;
            this.ComboTests.Location = new System.Drawing.Point(15, 26);
            this.ComboTests.Name = "ComboTests";
            this.ComboTests.Size = new System.Drawing.Size(607, 22);
            this.ComboTests.TabIndex = 11;
            this.ComboTests.SelectedIndexChanged += new System.EventHandler(this.ComboTests_SelectedIndexChanged);
            this.ComboTests.Enter += new System.EventHandler(this.ComboTests_Enter);
            // 
            // TextTest
            // 
            this.TextTest.BackColor = System.Drawing.Color.Lavender;
            this.TextTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTest.DetectUrls = false;
            this.TextTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTest.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTest.ForeColor = System.Drawing.Color.Black;
            this.TextTest.Location = new System.Drawing.Point(3, 3);
            this.TextTest.Name = "TextTest";
            this.TextTest.Size = new System.Drawing.Size(593, 533);
            this.TextTest.TabIndex = 12;
            this.TextTest.Text = "";
            this.TextTest.TextChanged += new System.EventHandler(this.TextTest_TextChanged);
            this.TextTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextTest_KeyDown);
            this.TextTest.Leave += new System.EventHandler(this.TextTest_Leave);
            // 
            // ListTest
            // 
            this.ListTest.AllowUserToAddRows = false;
            this.ListTest.AllowUserToDeleteRows = false;
            this.ListTest.AllowUserToResizeColumns = false;
            this.ListTest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ListTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.ctitle,
            this.cstatus});
            this.ListTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListTest.Location = new System.Drawing.Point(3, 3);
            this.ListTest.Name = "ListTest";
            this.ListTest.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ListTest.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ListTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListTest.Size = new System.Drawing.Size(593, 463);
            this.ListTest.TabIndex = 12;
            this.ListTest.TabStop = false;
            this.ListTest.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListTest_CellMouseClick);
            // 
            // LnkAdd
            // 
            this.LnkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkAdd.AutoSize = true;
            this.LnkAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkAdd.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkAdd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkAdd.LinkColor = System.Drawing.Color.Green;
            this.LnkAdd.Location = new System.Drawing.Point(543, 11);
            this.LnkAdd.Name = "LnkAdd";
            this.LnkAdd.Size = new System.Drawing.Size(79, 12);
            this.LnkAdd.TabIndex = 14;
            this.LnkAdd.TabStop = true;
            this.LnkAdd.Text = "Add new test..";
            this.LnkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAdd_LinkClicked);
            // 
            // LnkRemove
            // 
            this.LnkRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkRemove.AutoSize = true;
            this.LnkRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkRemove.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkRemove.LinkColor = System.Drawing.Color.Green;
            this.LnkRemove.Location = new System.Drawing.Point(435, 11);
            this.LnkRemove.Name = "LnkRemove";
            this.LnkRemove.Size = new System.Drawing.Size(99, 12);
            this.LnkRemove.TabIndex = 14;
            this.LnkRemove.TabStop = true;
            this.LnkRemove.Text = "Remove selection..";
            this.LnkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRemove_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "|";
            // 
            // tcontrol
            // 
            this.tcontrol.Tick += new System.EventHandler(this.tcontrol_Tick);
            // 
            // TBC
            // 
            this.TBC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBC.Controls.Add(this.tp1);
            this.TBC.Controls.Add(this.tp2);
            this.TBC.Location = new System.Drawing.Point(15, 54);
            this.TBC.Name = "TBC";
            this.TBC.SelectedIndex = 0;
            this.TBC.Size = new System.Drawing.Size(607, 626);
            this.TBC.TabIndex = 17;
            this.TBC.SelectedIndexChanged += new System.EventHandler(this.TBC_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.ListTest);
            this.tp1.Controls.Add(this.ListResults);
            this.tp1.Location = new System.Drawing.Point(4, 23);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(599, 599);
            this.tp1.TabIndex = 1;
            this.tp1.Text = "Table Format";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // ListResults
            // 
            this.ListResults.AllowUserToAddRows = false;
            this.ListResults.AllowUserToDeleteRows = false;
            this.ListResults.AllowUserToResizeColumns = false;
            this.ListResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ListResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ListResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListResults.Location = new System.Drawing.Point(3, 466);
            this.ListResults.Name = "ListResults";
            this.ListResults.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ListResults.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListResults.Size = new System.Drawing.Size(593, 130);
            this.ListResults.TabIndex = 13;
            this.ListResults.TabStop = false;
            this.ListResults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListResults_CellMouseClick);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.TextTest);
            this.tp2.Controls.Add(this.PanelHelp);
            this.tp2.Location = new System.Drawing.Point(4, 23);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(599, 599);
            this.tp2.TabIndex = 0;
            this.tp2.Text = "Text Format";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // PanelHelp
            // 
            this.PanelHelp.Controls.Add(this.LnkExample);
            this.PanelHelp.Controls.Add(this.label4);
            this.PanelHelp.Controls.Add(this.label2);
            this.PanelHelp.Controls.Add(this.label6);
            this.PanelHelp.Controls.Add(this.label5);
            this.PanelHelp.Controls.Add(this.label1);
            this.PanelHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelHelp.Location = new System.Drawing.Point(3, 536);
            this.PanelHelp.Name = "PanelHelp";
            this.PanelHelp.Size = new System.Drawing.Size(593, 60);
            this.PanelHelp.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type each step in one line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(207, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "H: as prefix to set a header";
            // 
            // LnkExample
            // 
            this.LnkExample.AutoSize = true;
            this.LnkExample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkExample.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkExample.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkExample.LinkColor = System.Drawing.Color.Green;
            this.LnkExample.Location = new System.Drawing.Point(13, 33);
            this.LnkExample.Name = "LnkExample";
            this.LnkExample.Size = new System.Drawing.Size(80, 12);
            this.LnkExample.TabIndex = 15;
            this.LnkExample.TabStop = true;
            this.LnkExample.Text = "Load example..";
            this.LnkExample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkExample_LinkClicked);
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cid.HeaderText = "Step";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Width = 61;
            // 
            // ctitle
            // 
            this.ctitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ctitle.HeaderText = "Title";
            this.ctitle.Name = "ctitle";
            this.ctitle.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cstatus.Width = 73;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Result";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(412, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "R: as prefix to set a result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(189, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "|";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(394, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "|";
            // 
            // FrmTests
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 692);
            this.Controls.Add(this.TBC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LnkRemove);
            this.Controls.Add(this.LnkAdd);
            this.Controls.Add(this.ComboTests);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 730);
            this.Name = "FrmTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Activated += new System.EventHandler(this.FrmTests_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTests_FormClosing);
            this.Load += new System.EventHandler(this.FrmTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListTest)).EndInit();
            this.TBC.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListResults)).EndInit();
            this.tp2.ResumeLayout(false);
            this.PanelHelp.ResumeLayout(false);
            this.PanelHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboTests;
        private System.Windows.Forms.RichTextBox TextTest;
        private System.Windows.Forms.LinkLabel LnkAdd;
        private System.Windows.Forms.LinkLabel LnkRemove;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView ListTest;
        private System.Windows.Forms.Timer tcontrol;
        private System.Windows.Forms.TabControl TBC;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        internal System.Windows.Forms.DataGridView ListResults;
        private System.Windows.Forms.Panel PanelHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LnkExample;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}