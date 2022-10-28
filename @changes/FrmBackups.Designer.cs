namespace HAKROS.Forms
{
    partial class FrmBackups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ListBackups = new System.Windows.Forms.DataGridView();
            this.cfile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfile2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csize1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csize2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ListFiles = new System.Windows.Forms.DataGridView();
            this.clock3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfolder2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfilename2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chash2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctotalbackups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelHeaderFiles = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.BtnDeleteSingle = new System.Windows.Forms.Button();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.ChbStatus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.BtnDeleteSelection = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.tcontrol = new System.Windows.Forms.Timer(this.components);
            this.PanelHeaderBranches = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CbBranches = new System.Windows.Forms.ComboBox();
            this.PanelHeaderBackups = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TRequestUpdateTotal = new System.Windows.Forms.Timer(this.components);
            this.LnkCurrentBranch = new System.Windows.Forms.LinkLabel();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBackups)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFiles)).BeginInit();
            this.PanelHeaderFiles.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelHeaderBranches.SuspendLayout();
            this.PanelHeaderBackups.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.ListFiles);
            this.PanelTop.Controls.Add(this.PanelHeaderBackups);
            this.PanelTop.Controls.Add(this.CbBranches);
            this.PanelTop.Controls.Add(this.PanelHeaderBranches);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1008, 387);
            this.PanelTop.TabIndex = 3;
            // 
            // ListBackups
            // 
            this.ListBackups.AllowUserToAddRows = false;
            this.ListBackups.AllowUserToDeleteRows = false;
            this.ListBackups.AllowUserToResizeColumns = false;
            this.ListBackups.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.ListBackups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ListBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBackups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cfile1,
            this.cfile2,
            this.cfilename,
            this.cdate1,
            this.cdate2,
            this.csize1,
            this.csize2,
            this.cstatus});
            this.ListBackups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBackups.Location = new System.Drawing.Point(0, 30);
            this.ListBackups.Name = "ListBackups";
            this.ListBackups.ReadOnly = true;
            this.ListBackups.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.ListBackups.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ListBackups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListBackups.Size = new System.Drawing.Size(1008, 107);
            this.ListBackups.TabIndex = 11;
            this.ListBackups.TabStop = false;
            this.ListBackups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listbackups_CellDoubleClick);
            // 
            // cfile1
            // 
            this.cfile1.HeaderText = "File1";
            this.cfile1.Name = "cfile1";
            this.cfile1.ReadOnly = true;
            this.cfile1.Visible = false;
            // 
            // cfile2
            // 
            this.cfile2.HeaderText = "File2";
            this.cfile2.Name = "cfile2";
            this.cfile2.ReadOnly = true;
            this.cfile2.Visible = false;
            // 
            // cfilename
            // 
            this.cfilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cfilename.HeaderText = "FileName";
            this.cfilename.Name = "cfilename";
            this.cfilename.ReadOnly = true;
            // 
            // cdate1
            // 
            this.cdate1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdate1.HeaderText = "Date backup";
            this.cdate1.Name = "cdate1";
            this.cdate1.ReadOnly = true;
            // 
            // cdate2
            // 
            this.cdate2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdate2.HeaderText = "Date source";
            this.cdate2.Name = "cdate2";
            this.cdate2.ReadOnly = true;
            // 
            // csize1
            // 
            this.csize1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.csize1.HeaderText = "Backup (By)";
            this.csize1.Name = "csize1";
            this.csize1.ReadOnly = true;
            // 
            // csize2
            // 
            this.csize2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.csize2.HeaderText = "Source (By)";
            this.csize2.Name = "csize2";
            this.csize2.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Width = 73;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.ListBackups);
            this.PanelBottom.Controls.Add(this.PanelHeaderFiles);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBottom.Location = new System.Drawing.Point(0, 387);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1008, 137);
            this.PanelBottom.TabIndex = 14;
            // 
            // ListFiles
            // 
            this.ListFiles.AllowUserToAddRows = false;
            this.ListFiles.AllowUserToDeleteRows = false;
            this.ListFiles.AllowUserToResizeColumns = false;
            this.ListFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ListFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ListFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clock3,
            this.cfolder2,
            this.cfilename2,
            this.chash2,
            this.ctotalbackups,
            this.cdate3});
            this.ListFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListFiles.DefaultCellStyle = dataGridViewCellStyle7;
            this.ListFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListFiles.Location = new System.Drawing.Point(0, 91);
            this.ListFiles.MultiSelect = false;
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.ReadOnly = true;
            this.ListFiles.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.ListFiles.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ListFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListFiles.Size = new System.Drawing.Size(1008, 296);
            this.ListFiles.TabIndex = 15;
            this.ListFiles.TabStop = false;
            this.ListFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListFiles_CellClick);
            this.ListFiles.SelectionChanged += new System.EventHandler(this.ListFiles_SelectionChanged);
            // 
            // clock3
            // 
            this.clock3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clock3.HeaderText = "Lock";
            this.clock3.Name = "clock3";
            this.clock3.ReadOnly = true;
            this.clock3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clock3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clock3.Width = 41;
            // 
            // cfolder2
            // 
            this.cfolder2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cfolder2.HeaderText = "Folder";
            this.cfolder2.Name = "cfolder2";
            this.cfolder2.ReadOnly = true;
            // 
            // cfilename2
            // 
            this.cfilename2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cfilename2.HeaderText = "FileName";
            this.cfilename2.Name = "cfilename2";
            this.cfilename2.ReadOnly = true;
            // 
            // chash2
            // 
            this.chash2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chash2.HeaderText = "Hash";
            this.chash2.Name = "chash2";
            this.chash2.ReadOnly = true;
            this.chash2.Visible = false;
            // 
            // ctotalbackups
            // 
            this.ctotalbackups.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ctotalbackups.HeaderText = "Backups";
            this.ctotalbackups.Name = "ctotalbackups";
            this.ctotalbackups.ReadOnly = true;
            this.ctotalbackups.Width = 84;
            // 
            // cdate3
            // 
            this.cdate3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cdate3.HeaderText = "Date";
            this.cdate3.Name = "cdate3";
            this.cdate3.ReadOnly = true;
            this.cdate3.Width = 62;
            // 
            // PanelHeaderFiles
            // 
            this.PanelHeaderFiles.BackColor = System.Drawing.Color.White;
            this.PanelHeaderFiles.Controls.Add(this.label7);
            this.PanelHeaderFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderFiles.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderFiles.Name = "PanelHeaderFiles";
            this.PanelHeaderFiles.Size = new System.Drawing.Size(1008, 30);
            this.PanelHeaderFiles.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Files";
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.White;
            this.PanelMain.Controls.Add(this.BtnDeleteSingle);
            this.PanelMain.Controls.Add(this.BtnCompare);
            this.PanelMain.Controls.Add(this.ChbStatus);
            this.PanelMain.Controls.Add(this.label3);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.separator);
            this.PanelMain.Controls.Add(this.BtnDeleteAll);
            this.PanelMain.Controls.Add(this.BtnDeleteSelection);
            this.PanelMain.Controls.Add(this.BtnRefresh);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMain.Location = new System.Drawing.Point(0, 524);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1008, 37);
            this.PanelMain.TabIndex = 5;
            // 
            // BtnDeleteSingle
            // 
            this.BtnDeleteSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteSingle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteSingle.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteSingle.Location = new System.Drawing.Point(493, 7);
            this.BtnDeleteSingle.Name = "BtnDeleteSingle";
            this.BtnDeleteSingle.Size = new System.Drawing.Size(148, 22);
            this.BtnDeleteSingle.TabIndex = 27;
            this.BtnDeleteSingle.TabStop = false;
            this.BtnDeleteSingle.Text = "Delete single backups";
            this.BtnDeleteSingle.UseVisualStyleBackColor = true;
            this.BtnDeleteSingle.Click += new System.EventHandler(this.BtnDeleteSingle_Click);
            // 
            // BtnCompare
            // 
            this.BtnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompare.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompare.Location = new System.Drawing.Point(776, 7);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(136, 22);
            this.BtnCompare.TabIndex = 26;
            this.BtnCompare.TabStop = false;
            this.BtnCompare.Text = "Compare selection";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // ChbStatus
            // 
            this.ChbStatus.AutoSize = true;
            this.ChbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbStatus.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbStatus.ForeColor = System.Drawing.Color.Red;
            this.ChbStatus.Location = new System.Drawing.Point(12, 8);
            this.ChbStatus.Name = "ChbStatus";
            this.ChbStatus.Size = new System.Drawing.Size(200, 20);
            this.ChbStatus.TabIndex = 25;
            this.ChbStatus.Text = "Local backup is disabled";
            this.ChbStatus.UseVisualStyleBackColor = true;
            this.ChbStatus.CheckedChanged += new System.EventHandler(this.ChbStatus_CheckedChanged);
            this.ChbStatus.Click += new System.EventHandler(this.ChbStatus_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "|";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "|";
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.AutoSize = true;
            this.separator.Location = new System.Drawing.Point(914, 11);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(12, 14);
            this.separator.TabIndex = 24;
            this.separator.Text = "|";
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteAll.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAll.Location = new System.Drawing.Point(306, 7);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(171, 22);
            this.BtnDeleteAll.TabIndex = 23;
            this.BtnDeleteAll.TabStop = false;
            this.BtnDeleteAll.Text = "Delete all unlocked backups";
            this.BtnDeleteAll.UseVisualStyleBackColor = true;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // BtnDeleteSelection
            // 
            this.BtnDeleteSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteSelection.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteSelection.Location = new System.Drawing.Point(657, 7);
            this.BtnDeleteSelection.Name = "BtnDeleteSelection";
            this.BtnDeleteSelection.Size = new System.Drawing.Size(103, 22);
            this.BtnDeleteSelection.TabIndex = 0;
            this.BtnDeleteSelection.TabStop = false;
            this.BtnDeleteSelection.Text = "Delete selection";
            this.BtnDeleteSelection.UseVisualStyleBackColor = true;
            this.BtnDeleteSelection.Click += new System.EventHandler(this.BtnDeleteSelection_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(928, 7);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(73, 22);
            this.BtnRefresh.TabIndex = 21;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // tcontrol
            // 
            this.tcontrol.Tick += new System.EventHandler(this.tcontrol_Tick);
            // 
            // PanelHeaderBranches
            // 
            this.PanelHeaderBranches.BackColor = System.Drawing.Color.White;
            this.PanelHeaderBranches.Controls.Add(this.LnkCurrentBranch);
            this.PanelHeaderBranches.Controls.Add(this.label4);
            this.PanelHeaderBranches.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderBranches.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderBranches.Name = "PanelHeaderBranches";
            this.PanelHeaderBranches.Size = new System.Drawing.Size(1008, 30);
            this.PanelHeaderBranches.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branches";
            // 
            // CbBranches
            // 
            this.CbBranches.BackColor = System.Drawing.Color.White;
            this.CbBranches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbBranches.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBranches.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBranches.ForeColor = System.Drawing.Color.Black;
            this.CbBranches.FormattingEnabled = true;
            this.CbBranches.Location = new System.Drawing.Point(0, 30);
            this.CbBranches.Name = "CbBranches";
            this.CbBranches.Size = new System.Drawing.Size(1008, 31);
            this.CbBranches.TabIndex = 17;
            this.CbBranches.SelectedIndexChanged += new System.EventHandler(this.CbBranches_SelectedIndexChanged);
            // 
            // PanelHeaderBackups
            // 
            this.PanelHeaderBackups.BackColor = System.Drawing.Color.White;
            this.PanelHeaderBackups.Controls.Add(this.label5);
            this.PanelHeaderBackups.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderBackups.Location = new System.Drawing.Point(0, 61);
            this.PanelHeaderBackups.Name = "PanelHeaderBackups";
            this.PanelHeaderBackups.Size = new System.Drawing.Size(1008, 30);
            this.PanelHeaderBackups.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Available backups";
            // 
            // TRequestUpdateTotal
            // 
            this.TRequestUpdateTotal.Tick += new System.EventHandler(this.TRequestUpdateTotal_Tick);
            // 
            // LnkCurrentBranch
            // 
            this.LnkCurrentBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkCurrentBranch.AutoSize = true;
            this.LnkCurrentBranch.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkCurrentBranch.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkCurrentBranch.LinkColor = System.Drawing.Color.Green;
            this.LnkCurrentBranch.Location = new System.Drawing.Point(856, 9);
            this.LnkCurrentBranch.Name = "LnkCurrentBranch";
            this.LnkCurrentBranch.Size = new System.Drawing.Size(145, 13);
            this.LnkCurrentBranch.TabIndex = 0;
            this.LnkCurrentBranch.TabStop = true;
            this.LnkCurrentBranch.Text = "Select current branch";
            this.LnkCurrentBranch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCurrentBranch_LinkClicked);
            // 
            // FrmBackups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelMain);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "FrmBackups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "--";
            this.Activated += new System.EventHandler(this.FrmBackups_Activated);
            this.Deactivate += new System.EventHandler(this.FrmBackups_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBackups_FormClosing);
            this.Load += new System.EventHandler(this.FrmBackups_Load);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListBackups)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListFiles)).EndInit();
            this.PanelHeaderFiles.ResumeLayout(false);
            this.PanelHeaderFiles.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelHeaderBranches.ResumeLayout(false);
            this.PanelHeaderBranches.PerformLayout();
            this.PanelHeaderBackups.ResumeLayout(false);
            this.PanelHeaderBackups.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel PanelTop;
        internal System.Windows.Forms.Panel PanelMain;
        internal System.Windows.Forms.DataGridView ListBackups;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnDeleteSelection;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Button BtnDeleteAll;
        private System.Windows.Forms.CheckBox ChbStatus;
        private System.Windows.Forms.Panel PanelBottom;
        internal System.Windows.Forms.Panel PanelHeaderFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView ListFiles;
        private System.Windows.Forms.Timer tcontrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfile2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn csize1;
        private System.Windows.Forms.DataGridViewTextBoxColumn csize2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.Button BtnDeleteSingle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clock3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfolder2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfilename2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chash2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctotalbackups;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate3;
        internal System.Windows.Forms.Panel PanelHeaderBackups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbBranches;
        internal System.Windows.Forms.Panel PanelHeaderBranches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer TRequestUpdateTotal;
        private System.Windows.Forms.LinkLabel LnkCurrentBranch;
    }
}
