namespace HAKROS.Controls
{
    partial class FrmSearchDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.MSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.MSep1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MSep2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcComments = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LnkExpand = new System.Windows.Forms.LinkLabel();
            this.LnkNotepad = new System.Windows.Forms.LinkLabel();
            this.LnkCollapse = new System.Windows.Forms.LinkLabel();
            this.LnkLoadFolder = new System.Windows.Forms.LinkLabel();
            this.LnkLoadFile = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SPC = new System.Windows.Forms.SplitContainer();
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.CM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MFindSelection0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MFindSelection1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MFindSelection2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MFindSelection3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tp_results = new System.Windows.Forms.TabPage();
            this.TreeResults = new System.Windows.Forms.TreeView();
            this.tp_functions = new System.Windows.Forms.TabPage();
            this.TreeFunctions = new System.Windows.Forms.TreeView();
            this.tp_classes = new System.Windows.Forms.TabPage();
            this.TreeClasses = new System.Windows.Forms.TreeView();
            this.tp_inheritance = new System.Windows.Forms.TabPage();
            this.TreeInheritance = new System.Windows.Forms.TreeView();
            this.tp_namespaces = new System.Windows.Forms.TabPage();
            this.TreeNamespaces = new System.Windows.Forms.TreeView();
            this.tp_usings = new System.Windows.Forms.TabPage();
            this.TreeUsings = new System.Windows.Forms.TreeView();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.MessageCopied = new System.Windows.Forms.ToolStripStatusLabel();
            this.tMessageCopied = new System.Windows.Forms.Timer(this.components);
            this.OpcHighlightAll = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPC)).BeginInit();
            this.SPC.Panel1.SuspendLayout();
            this.SPC.Panel2.SuspendLayout();
            this.SPC.SuspendLayout();
            this.CM.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tp_results.SuspendLayout();
            this.tp_functions.SuspendLayout();
            this.tp_classes.SuspendLayout();
            this.tp_inheritance.SuspendLayout();
            this.tp_namespaces.SuspendLayout();
            this.tp_usings.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TopMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 26);
            this.panel1.TabIndex = 0;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSolution,
            this.MSep1,
            this.MProject,
            this.MSep2,
            this.MFile});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(984, 26);
            this.TopMenu.TabIndex = 26;
            this.TopMenu.Text = "menuStrip1";
            // 
            // MSolution
            // 
            this.MSolution.AutoToolTip = true;
            this.MSolution.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSolution.ForeColor = System.Drawing.Color.White;
            this.MSolution.Name = "MSolution";
            this.MSolution.Size = new System.Drawing.Size(89, 22);
            this.MSolution.Text = "SOLUTION";
            this.MSolution.ToolTipText = "Copy this value to clipboard..";
            this.MSolution.Click += new System.EventHandler(this.MSolution_Click);
            // 
            // MSep1
            // 
            this.MSep1.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSep1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MSep1.Name = "MSep1";
            this.MSep1.Size = new System.Drawing.Size(27, 22);
            this.MSep1.Text = "||";
            // 
            // MProject
            // 
            this.MProject.AutoToolTip = true;
            this.MProject.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProject.ForeColor = System.Drawing.Color.White;
            this.MProject.Name = "MProject";
            this.MProject.Size = new System.Drawing.Size(78, 22);
            this.MProject.Text = "PROJECT";
            this.MProject.ToolTipText = "Copy this value to clipboard..";
            this.MProject.Click += new System.EventHandler(this.MProject_Click);
            // 
            // MSep2
            // 
            this.MSep2.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSep2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MSep2.Name = "MSep2";
            this.MSep2.Size = new System.Drawing.Size(27, 22);
            this.MSep2.Text = "||";
            // 
            // MFile
            // 
            this.MFile.AutoToolTip = true;
            this.MFile.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFile.ForeColor = System.Drawing.Color.White;
            this.MFile.Name = "MFile";
            this.MFile.Size = new System.Drawing.Size(49, 22);
            this.MFile.Text = "FILE";
            this.MFile.ToolTipText = "Copy this value to clipboard..";
            this.MFile.Click += new System.EventHandler(this.MFile_Click);
            // 
            // OpcComments
            // 
            this.OpcComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcComments.AutoSize = true;
            this.OpcComments.Checked = true;
            this.OpcComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpcComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcComments.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcComments.ForeColor = System.Drawing.Color.Blue;
            this.OpcComments.Location = new System.Drawing.Point(507, 7);
            this.OpcComments.Name = "OpcComments";
            this.OpcComments.Size = new System.Drawing.Size(123, 16);
            this.OpcComments.TabIndex = 100000007;
            this.OpcComments.TabStop = false;
            this.OpcComments.Text = "Highlight comments";
            this.OpcComments.UseVisualStyleBackColor = true;
            this.OpcComments.CheckedChanged += new System.EventHandler(this.OpcComments_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "|";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(775, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "|";
            // 
            // LnkExpand
            // 
            this.LnkExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkExpand.AutoSize = true;
            this.LnkExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkExpand.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkExpand.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkExpand.LinkColor = System.Drawing.Color.Green;
            this.LnkExpand.Location = new System.Drawing.Point(650, 9);
            this.LnkExpand.Name = "LnkExpand";
            this.LnkExpand.Size = new System.Drawing.Size(56, 12);
            this.LnkExpand.TabIndex = 25;
            this.LnkExpand.TabStop = true;
            this.LnkExpand.Text = "Expand all";
            this.LnkExpand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkExpand_LinkClicked);
            // 
            // LnkNotepad
            // 
            this.LnkNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkNotepad.AutoSize = true;
            this.LnkNotepad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkNotepad.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkNotepad.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkNotepad.LinkColor = System.Drawing.Color.Green;
            this.LnkNotepad.Location = new System.Drawing.Point(791, 9);
            this.LnkNotepad.Name = "LnkNotepad";
            this.LnkNotepad.Size = new System.Drawing.Size(53, 12);
            this.LnkNotepad.TabIndex = 25;
            this.LnkNotepad.TabStop = true;
            this.LnkNotepad.Text = "Notepad..";
            this.LnkNotepad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkNotepad_LinkClicked);
            // 
            // LnkCollapse
            // 
            this.LnkCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkCollapse.AutoSize = true;
            this.LnkCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkCollapse.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkCollapse.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkCollapse.LinkColor = System.Drawing.Color.Green;
            this.LnkCollapse.Location = new System.Drawing.Point(710, 9);
            this.LnkCollapse.Name = "LnkCollapse";
            this.LnkCollapse.Size = new System.Drawing.Size(61, 12);
            this.LnkCollapse.TabIndex = 24;
            this.LnkCollapse.TabStop = true;
            this.LnkCollapse.Text = "Collapse all";
            this.LnkCollapse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCollapse_LinkClicked);
            // 
            // LnkLoadFolder
            // 
            this.LnkLoadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkLoadFolder.AutoSize = true;
            this.LnkLoadFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkLoadFolder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLoadFolder.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkLoadFolder.LinkColor = System.Drawing.Color.Green;
            this.LnkLoadFolder.Location = new System.Drawing.Point(848, 9);
            this.LnkLoadFolder.Name = "LnkLoadFolder";
            this.LnkLoadFolder.Size = new System.Drawing.Size(68, 12);
            this.LnkLoadFolder.TabIndex = 24;
            this.LnkLoadFolder.TabStop = true;
            this.LnkLoadFolder.Text = "Load folder..";
            this.LnkLoadFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLoadFolder_LinkClicked);
            // 
            // LnkLoadFile
            // 
            this.LnkLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkLoadFile.AutoSize = true;
            this.LnkLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkLoadFile.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLoadFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkLoadFile.LinkColor = System.Drawing.Color.Green;
            this.LnkLoadFile.Location = new System.Drawing.Point(920, 9);
            this.LnkLoadFile.Name = "LnkLoadFile";
            this.LnkLoadFile.Size = new System.Drawing.Size(55, 12);
            this.LnkLoadFile.TabIndex = 24;
            this.LnkLoadFile.TabStop = true;
            this.LnkLoadFile.Text = "Load file..";
            this.LnkLoadFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLoadFile_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SPC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 583);
            this.panel2.TabIndex = 0;
            // 
            // SPC
            // 
            this.SPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPC.Location = new System.Drawing.Point(0, 0);
            this.SPC.Name = "SPC";
            // 
            // SPC.Panel1
            // 
            this.SPC.Panel1.Controls.Add(this.RTB);
            // 
            // SPC.Panel2
            // 
            this.SPC.Panel2.Controls.Add(this.tbc);
            this.SPC.Size = new System.Drawing.Size(984, 583);
            this.SPC.SplitterDistance = 579;
            this.SPC.TabIndex = 5;
            // 
            // RTB
            // 
            this.RTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB.ContextMenuStrip = this.CM;
            this.RTB.DetectUrls = false;
            this.RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB.ForeColor = System.Drawing.Color.Black;
            this.RTB.Location = new System.Drawing.Point(0, 0);
            this.RTB.Name = "RTB";
            this.RTB.ReadOnly = true;
            this.RTB.Size = new System.Drawing.Size(579, 583);
            this.RTB.TabIndex = 0;
            this.RTB.TabStop = false;
            this.RTB.Text = "";
            this.RTB.WordWrap = false;
            this.RTB.SelectionChanged += new System.EventHandler(this.RTB_SelectionChanged);
            this.RTB.TextChanged += new System.EventHandler(this.RTB_TextChanged);
            // 
            // CM
            // 
            this.CM.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MFindSelection0,
            this.toolStripSeparator1,
            this.MFindSelection1,
            this.MFindSelection2,
            this.MFindSelection3});
            this.CM.Name = "CM";
            this.CM.Size = new System.Drawing.Size(220, 98);
            // 
            // MFindSelection0
            // 
            this.MFindSelection0.Name = "MFindSelection0";
            this.MFindSelection0.Size = new System.Drawing.Size(219, 22);
            this.MFindSelection0.Text = "Replace current query..";
            this.MFindSelection0.Click += new System.EventHandler(this.MFindSelection0_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // MFindSelection1
            // 
            this.MFindSelection1.Name = "MFindSelection1";
            this.MFindSelection1.Size = new System.Drawing.Size(219, 22);
            this.MFindSelection1.Text = "Find on content..";
            this.MFindSelection1.Click += new System.EventHandler(this.MFindSelection1_Click);
            // 
            // MFindSelection2
            // 
            this.MFindSelection2.Name = "MFindSelection2";
            this.MFindSelection2.Size = new System.Drawing.Size(219, 22);
            this.MFindSelection2.Text = "Find on filepath..";
            this.MFindSelection2.Click += new System.EventHandler(this.MFindSelection2_Click);
            // 
            // MFindSelection3
            // 
            this.MFindSelection3.Name = "MFindSelection3";
            this.MFindSelection3.Size = new System.Drawing.Size(219, 22);
            this.MFindSelection3.Text = "Find on filename..";
            this.MFindSelection3.Click += new System.EventHandler(this.MFindSelection3_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tp_results);
            this.tbc.Controls.Add(this.tp_functions);
            this.tbc.Controls.Add(this.tp_classes);
            this.tbc.Controls.Add(this.tp_inheritance);
            this.tbc.Controls.Add(this.tp_namespaces);
            this.tbc.Controls.Add(this.tp_usings);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(0, 0);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(401, 583);
            this.tbc.TabIndex = 0;
            this.tbc.SelectedIndexChanged += new System.EventHandler(this.tbc_SelectedIndexChanged);
            // 
            // tp_results
            // 
            this.tp_results.Controls.Add(this.TreeResults);
            this.tp_results.Location = new System.Drawing.Point(4, 22);
            this.tp_results.Name = "tp_results";
            this.tp_results.Padding = new System.Windows.Forms.Padding(3);
            this.tp_results.Size = new System.Drawing.Size(393, 557);
            this.tp_results.TabIndex = 0;
            this.tp_results.Text = "Results";
            this.tp_results.UseVisualStyleBackColor = true;
            // 
            // TreeResults
            // 
            this.TreeResults.BackColor = System.Drawing.Color.White;
            this.TreeResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeResults.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeResults.ForeColor = System.Drawing.Color.Black;
            this.TreeResults.Location = new System.Drawing.Point(3, 3);
            this.TreeResults.Name = "TreeResults";
            this.TreeResults.Size = new System.Drawing.Size(387, 551);
            this.TreeResults.TabIndex = 0;
            this.TreeResults.TabStop = false;
            // 
            // tp_functions
            // 
            this.tp_functions.Controls.Add(this.TreeFunctions);
            this.tp_functions.Location = new System.Drawing.Point(4, 22);
            this.tp_functions.Name = "tp_functions";
            this.tp_functions.Size = new System.Drawing.Size(393, 557);
            this.tp_functions.TabIndex = 3;
            this.tp_functions.Text = "Functions";
            this.tp_functions.UseVisualStyleBackColor = true;
            // 
            // TreeFunctions
            // 
            this.TreeFunctions.BackColor = System.Drawing.Color.White;
            this.TreeFunctions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeFunctions.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeFunctions.ForeColor = System.Drawing.Color.Black;
            this.TreeFunctions.Location = new System.Drawing.Point(0, 0);
            this.TreeFunctions.Name = "TreeFunctions";
            this.TreeFunctions.Size = new System.Drawing.Size(393, 557);
            this.TreeFunctions.TabIndex = 1;
            this.TreeFunctions.TabStop = false;
            // 
            // tp_classes
            // 
            this.tp_classes.Controls.Add(this.TreeClasses);
            this.tp_classes.Location = new System.Drawing.Point(4, 22);
            this.tp_classes.Name = "tp_classes";
            this.tp_classes.Size = new System.Drawing.Size(393, 557);
            this.tp_classes.TabIndex = 5;
            this.tp_classes.Text = "Classes";
            this.tp_classes.UseVisualStyleBackColor = true;
            // 
            // TreeClasses
            // 
            this.TreeClasses.BackColor = System.Drawing.Color.White;
            this.TreeClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeClasses.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeClasses.ForeColor = System.Drawing.Color.Black;
            this.TreeClasses.Location = new System.Drawing.Point(0, 0);
            this.TreeClasses.Name = "TreeClasses";
            this.TreeClasses.Size = new System.Drawing.Size(393, 557);
            this.TreeClasses.TabIndex = 2;
            this.TreeClasses.TabStop = false;
            // 
            // tp_inheritance
            // 
            this.tp_inheritance.Controls.Add(this.TreeInheritance);
            this.tp_inheritance.Location = new System.Drawing.Point(4, 22);
            this.tp_inheritance.Name = "tp_inheritance";
            this.tp_inheritance.Size = new System.Drawing.Size(393, 557);
            this.tp_inheritance.TabIndex = 2;
            this.tp_inheritance.Text = "Inheritance";
            this.tp_inheritance.UseVisualStyleBackColor = true;
            // 
            // TreeInheritance
            // 
            this.TreeInheritance.BackColor = System.Drawing.Color.White;
            this.TreeInheritance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeInheritance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeInheritance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeInheritance.ForeColor = System.Drawing.Color.Black;
            this.TreeInheritance.Location = new System.Drawing.Point(0, 0);
            this.TreeInheritance.Name = "TreeInheritance";
            this.TreeInheritance.Size = new System.Drawing.Size(393, 557);
            this.TreeInheritance.TabIndex = 1;
            this.TreeInheritance.TabStop = false;
            // 
            // tp_namespaces
            // 
            this.tp_namespaces.Controls.Add(this.TreeNamespaces);
            this.tp_namespaces.Location = new System.Drawing.Point(4, 22);
            this.tp_namespaces.Name = "tp_namespaces";
            this.tp_namespaces.Size = new System.Drawing.Size(393, 557);
            this.tp_namespaces.TabIndex = 4;
            this.tp_namespaces.Text = "Namespaces";
            this.tp_namespaces.UseVisualStyleBackColor = true;
            // 
            // TreeNamespaces
            // 
            this.TreeNamespaces.BackColor = System.Drawing.Color.White;
            this.TreeNamespaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeNamespaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeNamespaces.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeNamespaces.ForeColor = System.Drawing.Color.Black;
            this.TreeNamespaces.Location = new System.Drawing.Point(0, 0);
            this.TreeNamespaces.Name = "TreeNamespaces";
            this.TreeNamespaces.Size = new System.Drawing.Size(393, 557);
            this.TreeNamespaces.TabIndex = 1;
            this.TreeNamespaces.TabStop = false;
            // 
            // tp_usings
            // 
            this.tp_usings.Controls.Add(this.TreeUsings);
            this.tp_usings.Location = new System.Drawing.Point(4, 22);
            this.tp_usings.Name = "tp_usings";
            this.tp_usings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_usings.Size = new System.Drawing.Size(393, 557);
            this.tp_usings.TabIndex = 1;
            this.tp_usings.Text = "Usings";
            this.tp_usings.UseVisualStyleBackColor = true;
            // 
            // TreeUsings
            // 
            this.TreeUsings.BackColor = System.Drawing.Color.White;
            this.TreeUsings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeUsings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeUsings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeUsings.ForeColor = System.Drawing.Color.Black;
            this.TreeUsings.Location = new System.Drawing.Point(3, 3);
            this.TreeUsings.Name = "TreeUsings";
            this.TreeUsings.Size = new System.Drawing.Size(387, 551);
            this.TreeUsings.TabIndex = 1;
            this.TreeUsings.TabStop = false;
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalLength,
            this.toolStripStatusLabel2,
            this.MessageCopied});
            this.statusbar.Location = new System.Drawing.Point(0, 640);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(984, 22);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 2;
            // 
            // MessageCopied
            // 
            this.MessageCopied.BackColor = System.Drawing.Color.Transparent;
            this.MessageCopied.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageCopied.ForeColor = System.Drawing.Color.Green;
            this.MessageCopied.Name = "MessageCopied";
            this.MessageCopied.Size = new System.Drawing.Size(143, 17);
            this.MessageCopied.Text = "Copied to clipboard !";
            this.MessageCopied.Visible = false;
            // 
            // tMessageCopied
            // 
            this.tMessageCopied.Interval = 1000;
            this.tMessageCopied.Tick += new System.EventHandler(this.tMessageCopied_Tick);
            // 
            // OpcHighlightAll
            // 
            this.OpcHighlightAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcHighlightAll.AutoSize = true;
            this.OpcHighlightAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcHighlightAll.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcHighlightAll.ForeColor = System.Drawing.Color.Crimson;
            this.OpcHighlightAll.Location = new System.Drawing.Point(417, 7);
            this.OpcHighlightAll.Name = "OpcHighlightAll";
            this.OpcHighlightAll.Size = new System.Drawing.Size(84, 16);
            this.OpcHighlightAll.TabIndex = 100000008;
            this.OpcHighlightAll.TabStop = false;
            this.OpcHighlightAll.Text = "Highlight all";
            this.OpcHighlightAll.UseVisualStyleBackColor = true;
            this.OpcHighlightAll.CheckedChanged += new System.EventHandler(this.OpcHighlightAll_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OpcHighlightAll);
            this.panel3.Controls.Add(this.LnkLoadFile);
            this.panel3.Controls.Add(this.OpcComments);
            this.panel3.Controls.Add(this.LnkLoadFolder);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LnkCollapse);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.LnkNotepad);
            this.panel3.Controls.Add(this.LnkExpand);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 31);
            this.panel3.TabIndex = 3;
            // 
            // TotalLength
            // 
            this.TotalLength.BackColor = System.Drawing.Color.Transparent;
            this.TotalLength.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TotalLength.Name = "TotalLength";
            this.TotalLength.Size = new System.Drawing.Size(72, 17);
            this.TotalLength.Text = "Length: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(723, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // FrmSearchDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.TopMenu;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmSearchDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "--";
            this.Load += new System.EventHandler(this.FrmSearchDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.SPC.Panel1.ResumeLayout(false);
            this.SPC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPC)).EndInit();
            this.SPC.ResumeLayout(false);
            this.CM.ResumeLayout(false);
            this.tbc.ResumeLayout(false);
            this.tp_results.ResumeLayout(false);
            this.tp_functions.ResumeLayout(false);
            this.tp_classes.ResumeLayout(false);
            this.tp_inheritance.ResumeLayout(false);
            this.tp_namespaces.ResumeLayout(false);
            this.tp_usings.ResumeLayout(false);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.LinkLabel LnkLoadFolder;
        internal System.Windows.Forms.LinkLabel LnkLoadFile;
        private System.Windows.Forms.TreeView TreeResults;
        private System.Windows.Forms.SplitContainer SPC;
        internal System.Windows.Forms.LinkLabel LnkNotepad;
        private System.Windows.Forms.RichTextBox RTB;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem MSolution;
        private System.Windows.Forms.ToolStripMenuItem MProject;
        private System.Windows.Forms.ToolStripMenuItem MFile;
        private System.Windows.Forms.ToolStripMenuItem MSep1;
        private System.Windows.Forms.ToolStripMenuItem MSep2;
        private System.Windows.Forms.ContextMenuStrip CM;
        private System.Windows.Forms.ToolStripMenuItem MFindSelection1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tp_results;
        private System.Windows.Forms.TabPage tp_usings;
        private System.Windows.Forms.TabPage tp_inheritance;
        private System.Windows.Forms.TabPage tp_functions;
        private System.Windows.Forms.TabPage tp_namespaces;
        private System.Windows.Forms.TreeView TreeUsings;
        private System.Windows.Forms.TreeView TreeInheritance;
        private System.Windows.Forms.TreeView TreeFunctions;
        private System.Windows.Forms.TreeView TreeNamespaces;
        private System.Windows.Forms.TabPage tp_classes;
        private System.Windows.Forms.TreeView TreeClasses;
        private System.Windows.Forms.CheckBox OpcComments;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.LinkLabel LnkExpand;
        internal System.Windows.Forms.LinkLabel LnkCollapse;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel MessageCopied;
        private System.Windows.Forms.Timer tMessageCopied;
        private System.Windows.Forms.CheckBox OpcHighlightAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem MFindSelection0;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MFindSelection2;
        private System.Windows.Forms.ToolStripMenuItem MFindSelection3;
        private System.Windows.Forms.ToolStripStatusLabel TotalLength;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}