using HAKROS.Classes.Controls;

namespace HAKROS.Forms
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.help = new System.Windows.Forms.ToolTip(this.components);
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnLoadRoot = new System.Windows.Forms.Button();
            this.BtnSelectRoot = new System.Windows.Forms.Button();
            this.LnkNextQuery = new System.Windows.Forms.LinkLabel();
            this.LnkPrevQuery = new System.Windows.Forms.LinkLabel();
            this.CM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMFileName = new System.Windows.Forms.ToolStripMenuItem();
            this.CMFilenameSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.OpcViewResults = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcViewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcViewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchType = new System.Windows.Forms.Label();
            this.FswAutoBackup = new System.IO.FileSystemWatcher();
            this.tcontrol = new System.Windows.Forms.Timer(this.components);
            this.Nicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMNicon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CMenuAppControl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.CMenuTestManager = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenuSqlExtractor = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenuLocalBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenuSafeboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CMNiconMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.OpcFilterPath = new System.Windows.Forms.RadioButton();
            this.OpcFilterName = new System.Windows.Forms.RadioButton();
            this.OpcFilterInclusive = new System.Windows.Forms.CheckBox();
            this.FastMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFastInclude = new System.Windows.Forms.ToolStripMenuItem();
            this.backcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safetyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewmodelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFastExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.designerCodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.safetyFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClearFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.spc1 = new System.Windows.Forms.SplitContainer();
            this.txtExclude = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LnkRestore = new System.Windows.Forms.LinkLabel();
            this.LnkAllFiles = new System.Windows.Forms.LinkLabel();
            this.sep5 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OpcOnFullpath = new System.Windows.Forms.RadioButton();
            this.OpcOnFilename = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.OpcOnContent = new System.Windows.Forms.RadioButton();
            this.OpcWholeWord = new System.Windows.Forms.CheckBox();
            this.OpcIndividualTerms = new System.Windows.Forms.CheckBox();
            this.sep1 = new System.Windows.Forms.Label();
            this.txtInclude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OpcAllTerms = new System.Windows.Forms.CheckBox();
            this.OpcSameLine = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.spc3 = new System.Windows.Forms.SplitContainer();
            this.spc2 = new System.Windows.Forms.SplitContainer();
            this.ListSolutions = new HAKROS.Classes.Controls.CustomListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tSolutions = new System.Windows.Forms.Label();
            this.ListProjects = new HAKROS.Classes.Controls.CustomListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tProjects = new System.Windows.Forms.Label();
            this.PanelTBC = new System.Windows.Forms.Panel();
            this.tbc = new HAKROS.Classes.Controls.TabControlWithoutHeader();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tResults = new System.Windows.Forms.Label();
            this.LnkExportToText = new System.Windows.Forms.LinkLabel();
            this.sep8 = new System.Windows.Forms.Label();
            this.sep7 = new System.Windows.Forms.Label();
            this.LnkRestoreColors = new System.Windows.Forms.LinkLabel();
            this.LnkExportToExcel = new System.Windows.Forms.LinkLabel();
            this.sep6 = new System.Windows.Forms.Label();
            this.LnkColorizeRows = new System.Windows.Forms.LinkLabel();
            this.ListQueries = new HAKROS.Classes.Controls.FlatComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sep10 = new System.Windows.Forms.Label();
            this.sep9 = new System.Windows.Forms.Label();
            this.tQueries = new System.Windows.Forms.Label();
            this.LinkCloseQuery = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.LnkClipboard = new System.Windows.Forms.LinkLabel();
            this.LblBackupStatus = new System.Windows.Forms.LinkLabel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ListFolders = new HAKROS.Classes.Controls.FlatComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subscribeEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.MessageStatus = new System.Windows.Forms.Label();
            this.PanelTop = new HAKROS.GradientPanel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_HideSearchType = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_WindowState = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_Style = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu1_CheckNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu1_AutoscaleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_AutoscaleMode_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_AutoscaleMode_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_AutoscaleMode_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu1_ExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu3_Word = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu3_Excel = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu3_Powerpoint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu3_Outlook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu3_Jabber = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Explorer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_RegEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_TaskManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_InternetExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_Wordpad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_Notepad = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Calc = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Charmap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_Paint = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Snipping = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Magnifier = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_ScreenKeyboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_AccessibilityOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_VolumeSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2_Cmd = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_ControlPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_SysInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_CurrentVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu5_InternetProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu5_ClearIconCache = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu5_UserFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_WinFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_AppDataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu5_WindowsMobilityCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu5_Fonts = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_DPISettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_ColorManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_DateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5_Printers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu5_MouseProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu5_SystemProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.sPECIALTOOLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuTests = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSQLExtractor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAutobackup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSafeBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoText = new System.Windows.Forms.PictureBox();
            this.LogoSymbol = new System.Windows.Forms.PictureBox();
            this.CM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FswAutoBackup)).BeginInit();
            this.CMNicon.SuspendLayout();
            this.panel5.SuspendLayout();
            this.FastMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc1)).BeginInit();
            this.spc1.Panel1.SuspendLayout();
            this.spc1.Panel2.SuspendLayout();
            this.spc1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc3)).BeginInit();
            this.spc3.Panel1.SuspendLayout();
            this.spc3.Panel2.SuspendLayout();
            this.spc3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc2)).BeginInit();
            this.spc2.Panel1.SuspendLayout();
            this.spc2.Panel2.SuspendLayout();
            this.spc2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelTBC.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.White;
            this.help.ForeColor = System.Drawing.Color.Black;
            this.help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.help.ToolTipTitle = "Information";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(1085, 72);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(34, 34);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.TabStop = false;
            this.help.SetToolTip(this.BtnClear, "Clear query");
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(1049, 72);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(34, 34);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.TabStop = false;
            this.help.SetToolTip(this.BtnSearch, "Search");
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnLoadRoot
            // 
            this.BtnLoadRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadRoot.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoadRoot.Image")));
            this.BtnLoadRoot.Location = new System.Drawing.Point(1085, 18);
            this.BtnLoadRoot.Name = "BtnLoadRoot";
            this.BtnLoadRoot.Size = new System.Drawing.Size(34, 34);
            this.BtnLoadRoot.TabIndex = 0;
            this.BtnLoadRoot.TabStop = false;
            this.help.SetToolTip(this.BtnLoadRoot, "Explore folder..");
            this.BtnLoadRoot.UseVisualStyleBackColor = true;
            this.BtnLoadRoot.Click += new System.EventHandler(this.BtnLoadRoot_Click);
            // 
            // BtnSelectRoot
            // 
            this.BtnSelectRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectRoot.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelectRoot.Image")));
            this.BtnSelectRoot.Location = new System.Drawing.Point(1049, 18);
            this.BtnSelectRoot.Name = "BtnSelectRoot";
            this.BtnSelectRoot.Size = new System.Drawing.Size(34, 34);
            this.BtnSelectRoot.TabIndex = 0;
            this.BtnSelectRoot.TabStop = false;
            this.help.SetToolTip(this.BtnSelectRoot, "Folders Manager..");
            this.BtnSelectRoot.UseVisualStyleBackColor = true;
            this.BtnSelectRoot.Click += new System.EventHandler(this.BtnSelectRoot_Click);
            // 
            // LnkNextQuery
            // 
            this.LnkNextQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkNextQuery.AutoSize = true;
            this.LnkNextQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkNextQuery.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkNextQuery.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkNextQuery.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkNextQuery.Location = new System.Drawing.Point(941, 6);
            this.LnkNextQuery.Name = "LnkNextQuery";
            this.LnkNextQuery.Size = new System.Drawing.Size(64, 12);
            this.LnkNextQuery.TabIndex = 100000011;
            this.LnkNextQuery.TabStop = true;
            this.LnkNextQuery.Text = "Next query";
            this.LnkNextQuery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkNextQuery_LinkClicked);
            // 
            // LnkPrevQuery
            // 
            this.LnkPrevQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkPrevQuery.AutoSize = true;
            this.LnkPrevQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkPrevQuery.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkPrevQuery.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkPrevQuery.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkPrevQuery.Location = new System.Drawing.Point(840, 6);
            this.LnkPrevQuery.Name = "LnkPrevQuery";
            this.LnkPrevQuery.Size = new System.Drawing.Size(89, 12);
            this.LnkPrevQuery.TabIndex = 100000011;
            this.LnkPrevQuery.TabStop = true;
            this.LnkPrevQuery.Text = "Previous query";
            this.LnkPrevQuery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkPrevQuery_LinkClicked);
            // 
            // CM
            // 
            this.CM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMFileName,
            this.CMFilenameSeparator,
            this.OpcViewResults,
            this.OpcViewFolder,
            this.OpcViewFile});
            this.CM.Name = "CM";
            this.CM.Size = new System.Drawing.Size(143, 98);
            // 
            // CMFileName
            // 
            this.CMFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMFileName.Name = "CMFileName";
            this.CMFileName.Size = new System.Drawing.Size(142, 22);
            this.CMFileName.Text = "<filename>";
            // 
            // CMFilenameSeparator
            // 
            this.CMFilenameSeparator.Name = "CMFilenameSeparator";
            this.CMFilenameSeparator.Size = new System.Drawing.Size(139, 6);
            // 
            // OpcViewResults
            // 
            this.OpcViewResults.Name = "OpcViewResults";
            this.OpcViewResults.Size = new System.Drawing.Size(142, 22);
            this.OpcViewResults.Text = "View results..";
            this.OpcViewResults.Click += new System.EventHandler(this.OpcViewResults_Click);
            // 
            // OpcViewFolder
            // 
            this.OpcViewFolder.Name = "OpcViewFolder";
            this.OpcViewFolder.Size = new System.Drawing.Size(142, 22);
            this.OpcViewFolder.Text = "Load folder..";
            this.OpcViewFolder.Click += new System.EventHandler(this.OpcViewFolder_Click);
            // 
            // OpcViewFile
            // 
            this.OpcViewFile.Name = "OpcViewFile";
            this.OpcViewFile.Size = new System.Drawing.Size(142, 22);
            this.OpcViewFile.Text = "Load file..";
            this.OpcViewFile.Click += new System.EventHandler(this.OpcViewFile_Click);
            // 
            // SearchType
            // 
            this.SearchType.BackColor = System.Drawing.Color.SpringGreen;
            this.SearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchType.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchType.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchType.ForeColor = System.Drawing.Color.Black;
            this.SearchType.Location = new System.Drawing.Point(0, 44);
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(1134, 25);
            this.SearchType.TabIndex = 100000008;
            this.SearchType.Text = "xxxxxxxx";
            this.SearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchType_MouseClick);
            // 
            // FswAutoBackup
            // 
            this.FswAutoBackup.EnableRaisingEvents = true;
            this.FswAutoBackup.SynchronizingObject = this;
            this.FswAutoBackup.Changed += new System.IO.FileSystemEventHandler(this.FswAutoBackup_Changed);
            this.FswAutoBackup.Created += new System.IO.FileSystemEventHandler(this.FswAutoBackup_Created);
            this.FswAutoBackup.Renamed += new System.IO.RenamedEventHandler(this.FswAutoBackup_Renamed);
            // 
            // tcontrol
            // 
            this.tcontrol.Tick += new System.EventHandler(this.tcontrol_Tick);
            // 
            // Nicon
            // 
            this.Nicon.BalloonTipClicked += new System.EventHandler(this.Nicon_BalloonTipClicked);
            this.Nicon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Nicon_MouseClick);
            // 
            // CMNicon
            // 
            this.CMNicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MTitle,
            this.toolStripSeparator1,
            this.CMenuAppControl,
            this.toolStripSeparator27,
            this.CMenuTestManager,
            this.CMenuSqlExtractor,
            this.CMenuLocalBackup,
            this.CMenuSafeboard,
            this.toolStripSeparator25,
            this.MenuShow,
            this.MenuHide,
            this.toolStripSeparator2,
            this.CMNiconMenuExit});
            this.CMNicon.Name = "CMNicon";
            this.CMNicon.Size = new System.Drawing.Size(180, 226);
            // 
            // MTitle
            // 
            this.MTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MTitle.ForeColor = System.Drawing.Color.Black;
            this.MTitle.Name = "MTitle";
            this.MTitle.Size = new System.Drawing.Size(179, 22);
            this.MTitle.Text = "<title>";
            this.MTitle.Click += new System.EventHandler(this.MTitle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // CMenuAppControl
            // 
            this.CMenuAppControl.Image = ((System.Drawing.Image)(resources.GetObject("CMenuAppControl.Image")));
            this.CMenuAppControl.Name = "CMenuAppControl";
            this.CMenuAppControl.Size = new System.Drawing.Size(179, 22);
            this.CMenuAppControl.Text = "MPRS App Control..";
            this.CMenuAppControl.Click += new System.EventHandler(this.CMenuAppControl_Click);
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            this.toolStripSeparator27.Size = new System.Drawing.Size(176, 6);
            // 
            // CMenuTestManager
            // 
            this.CMenuTestManager.Image = ((System.Drawing.Image)(resources.GetObject("CMenuTestManager.Image")));
            this.CMenuTestManager.Name = "CMenuTestManager";
            this.CMenuTestManager.Size = new System.Drawing.Size(179, 22);
            this.CMenuTestManager.Text = "Test Manager..";
            this.CMenuTestManager.Click += new System.EventHandler(this.CMenuTestManager_Click);
            // 
            // CMenuSqlExtractor
            // 
            this.CMenuSqlExtractor.Image = ((System.Drawing.Image)(resources.GetObject("CMenuSqlExtractor.Image")));
            this.CMenuSqlExtractor.Name = "CMenuSqlExtractor";
            this.CMenuSqlExtractor.Size = new System.Drawing.Size(179, 22);
            this.CMenuSqlExtractor.Text = "SQL Extractor..";
            this.CMenuSqlExtractor.Click += new System.EventHandler(this.CMenuSqlExtractor_Click);
            // 
            // CMenuLocalBackup
            // 
            this.CMenuLocalBackup.Image = ((System.Drawing.Image)(resources.GetObject("CMenuLocalBackup.Image")));
            this.CMenuLocalBackup.Name = "CMenuLocalBackup";
            this.CMenuLocalBackup.Size = new System.Drawing.Size(179, 22);
            this.CMenuLocalBackup.Text = "Local Backup..";
            this.CMenuLocalBackup.Click += new System.EventHandler(this.CMenuLocalBackup_Click);
            // 
            // CMenuSafeboard
            // 
            this.CMenuSafeboard.Image = ((System.Drawing.Image)(resources.GetObject("CMenuSafeboard.Image")));
            this.CMenuSafeboard.Name = "CMenuSafeboard";
            this.CMenuSafeboard.Size = new System.Drawing.Size(179, 22);
            this.CMenuSafeboard.Text = "Safeboard..";
            this.CMenuSafeboard.Click += new System.EventHandler(this.CMenuSafeboard_Click);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(176, 6);
            // 
            // MenuShow
            // 
            this.MenuShow.Name = "MenuShow";
            this.MenuShow.Size = new System.Drawing.Size(179, 22);
            this.MenuShow.Text = "Show Window";
            this.MenuShow.Visible = false;
            this.MenuShow.Click += new System.EventHandler(this.MenuShow_Click);
            // 
            // MenuHide
            // 
            this.MenuHide.Name = "MenuHide";
            this.MenuHide.Size = new System.Drawing.Size(179, 22);
            this.MenuHide.Text = "Hide Window";
            this.MenuHide.Click += new System.EventHandler(this.MenuHide_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // CMNiconMenuExit
            // 
            this.CMNiconMenuExit.Name = "CMNiconMenuExit";
            this.CMNiconMenuExit.Size = new System.Drawing.Size(179, 22);
            this.CMNiconMenuExit.Text = "Exit application..";
            this.CMNiconMenuExit.Click += new System.EventHandler(this.CMNiconMenuExit_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.OpcFilterPath);
            this.panel5.Controls.Add(this.OpcFilterName);
            this.panel5.Location = new System.Drawing.Point(53, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 18);
            this.panel5.TabIndex = 100000005;
            // 
            // OpcFilterPath
            // 
            this.OpcFilterPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcFilterPath.AutoSize = true;
            this.OpcFilterPath.Checked = true;
            this.OpcFilterPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcFilterPath.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcFilterPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcFilterPath.Location = new System.Drawing.Point(8, 1);
            this.OpcFilterPath.Name = "OpcFilterPath";
            this.OpcFilterPath.Size = new System.Drawing.Size(89, 16);
            this.OpcFilterPath.TabIndex = 1;
            this.OpcFilterPath.TabStop = true;
            this.OpcFilterPath.Text = "Filter filepath";
            this.OpcFilterPath.UseVisualStyleBackColor = true;
            // 
            // OpcFilterName
            // 
            this.OpcFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcFilterName.AutoSize = true;
            this.OpcFilterName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcFilterName.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcFilterName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcFilterName.Location = new System.Drawing.Point(102, 1);
            this.OpcFilterName.Name = "OpcFilterName";
            this.OpcFilterName.Size = new System.Drawing.Size(94, 16);
            this.OpcFilterName.TabIndex = 1;
            this.OpcFilterName.Text = "Filter filename";
            this.OpcFilterName.UseVisualStyleBackColor = true;
            // 
            // OpcFilterInclusive
            // 
            this.OpcFilterInclusive.AutoSize = true;
            this.OpcFilterInclusive.Checked = true;
            this.OpcFilterInclusive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpcFilterInclusive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcFilterInclusive.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcFilterInclusive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcFilterInclusive.Location = new System.Drawing.Point(253, 159);
            this.OpcFilterInclusive.Name = "OpcFilterInclusive";
            this.OpcFilterInclusive.Size = new System.Drawing.Size(109, 16);
            this.OpcFilterInclusive.TabIndex = 100000006;
            this.OpcFilterInclusive.TabStop = false;
            this.OpcFilterInclusive.Text = "Include all filters";
            this.OpcFilterInclusive.UseVisualStyleBackColor = true;
            this.OpcFilterInclusive.CheckedChanged += new System.EventHandler(this.OpcFilterInclusive_CheckedChanged);
            // 
            // FastMenu
            // 
            this.FastMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FastMenu.BackColor = System.Drawing.Color.Transparent;
            this.FastMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.FastMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFastInclude,
            this.MenuFastExclude,
            this.MenuClearFilter});
            this.FastMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.FastMenu.Location = new System.Drawing.Point(868, 154);
            this.FastMenu.Name = "FastMenu";
            this.FastMenu.Size = new System.Drawing.Size(254, 24);
            this.FastMenu.TabIndex = 100000001;
            this.FastMenu.Text = "menuStrip1";
            // 
            // MenuFastInclude
            // 
            this.MenuFastInclude.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backcodeToolStripMenuItem,
            this.configurationFilesToolStripMenuItem,
            this.converterToolStripMenuItem,
            this.designerCodeToolStripMenuItem,
            this.dtoToolStripMenuItem,
            this.enumsToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.helperToolStripMenuItem,
            this.hibernateFilesToolStripMenuItem,
            this.interfacesToolStripMenuItem,
            this.projectFilesToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.safetyFilesToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.utilsToolStripMenuItem,
            this.validatorToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.viewmodelsToolStripMenuItem});
            this.MenuFastInclude.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MenuFastInclude.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuFastInclude.Name = "MenuFastInclude";
            this.MenuFastInclude.Size = new System.Drawing.Size(85, 20);
            this.MenuFastInclude.Text = "Fast Include";
            // 
            // backcodeToolStripMenuItem
            // 
            this.backcodeToolStripMenuItem.Name = "backcodeToolStripMenuItem";
            this.backcodeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.backcodeToolStripMenuItem.Text = "Backend code";
            this.backcodeToolStripMenuItem.Click += new System.EventHandler(this.backcodeToolStripMenuItem_Click);
            // 
            // configurationFilesToolStripMenuItem
            // 
            this.configurationFilesToolStripMenuItem.Name = "configurationFilesToolStripMenuItem";
            this.configurationFilesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.configurationFilesToolStripMenuItem.Text = "Configuration files";
            this.configurationFilesToolStripMenuItem.Click += new System.EventHandler(this.configurationFilesToolStripMenuItem_Click);
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.converterToolStripMenuItem.Text = "Converters";
            this.converterToolStripMenuItem.Click += new System.EventHandler(this.converterToolStripMenuItem_Click);
            // 
            // designerCodeToolStripMenuItem
            // 
            this.designerCodeToolStripMenuItem.Name = "designerCodeToolStripMenuItem";
            this.designerCodeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.designerCodeToolStripMenuItem.Text = "Designer code";
            this.designerCodeToolStripMenuItem.Click += new System.EventHandler(this.designerCodeToolStripMenuItem_Click);
            // 
            // dtoToolStripMenuItem
            // 
            this.dtoToolStripMenuItem.Name = "dtoToolStripMenuItem";
            this.dtoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dtoToolStripMenuItem.Text = "DTOs";
            this.dtoToolStripMenuItem.Click += new System.EventHandler(this.dtoToolStripMenuItem_Click);
            // 
            // enumsToolStripMenuItem
            // 
            this.enumsToolStripMenuItem.Name = "enumsToolStripMenuItem";
            this.enumsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.enumsToolStripMenuItem.Text = "Enumerables";
            this.enumsToolStripMenuItem.Click += new System.EventHandler(this.enumsToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // helperToolStripMenuItem
            // 
            this.helperToolStripMenuItem.Name = "helperToolStripMenuItem";
            this.helperToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.helperToolStripMenuItem.Text = "Helpers";
            this.helperToolStripMenuItem.Click += new System.EventHandler(this.helperToolStripMenuItem_Click);
            // 
            // hibernateFilesToolStripMenuItem
            // 
            this.hibernateFilesToolStripMenuItem.Name = "hibernateFilesToolStripMenuItem";
            this.hibernateFilesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hibernateFilesToolStripMenuItem.Text = "Hibernate files";
            this.hibernateFilesToolStripMenuItem.Click += new System.EventHandler(this.hibernateFilesToolStripMenuItem_Click);
            // 
            // interfacesToolStripMenuItem
            // 
            this.interfacesToolStripMenuItem.Name = "interfacesToolStripMenuItem";
            this.interfacesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.interfacesToolStripMenuItem.Text = "Interfaces";
            this.interfacesToolStripMenuItem.Click += new System.EventHandler(this.interfacesToolStripMenuItem_Click);
            // 
            // projectFilesToolStripMenuItem
            // 
            this.projectFilesToolStripMenuItem.Name = "projectFilesToolStripMenuItem";
            this.projectFilesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.projectFilesToolStripMenuItem.Text = "Project files";
            this.projectFilesToolStripMenuItem.Click += new System.EventHandler(this.projectFilesToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // safetyFilesToolStripMenuItem
            // 
            this.safetyFilesToolStripMenuItem.Name = "safetyFilesToolStripMenuItem";
            this.safetyFilesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.safetyFilesToolStripMenuItem.Text = "Safety files";
            this.safetyFilesToolStripMenuItem.Click += new System.EventHandler(this.safetyFilesToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.utilsToolStripMenuItem.Text = "Utils";
            this.utilsToolStripMenuItem.Click += new System.EventHandler(this.utilsToolStripMenuItem_Click);
            // 
            // validatorToolStripMenuItem
            // 
            this.validatorToolStripMenuItem.Name = "validatorToolStripMenuItem";
            this.validatorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.validatorToolStripMenuItem.Text = "Validators";
            this.validatorToolStripMenuItem.Click += new System.EventHandler(this.validatorToolStripMenuItem_Click);
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewsToolStripMenuItem.Text = "Views";
            this.viewsToolStripMenuItem.Click += new System.EventHandler(this.viewsToolStripMenuItem_Click);
            // 
            // viewmodelsToolStripMenuItem
            // 
            this.viewmodelsToolStripMenuItem.Name = "viewmodelsToolStripMenuItem";
            this.viewmodelsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewmodelsToolStripMenuItem.Text = "Viewmodels";
            this.viewmodelsToolStripMenuItem.Click += new System.EventHandler(this.viewmodelsToolStripMenuItem_Click);
            // 
            // MenuFastExclude
            // 
            this.MenuFastExclude.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.configurationFilesToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.designerCodeToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.eventsToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.hibernateFilesToolStripMenuItem1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.safetyFilesToolStripMenuItem1,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.MenuFastExclude.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MenuFastExclude.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuFastExclude.Name = "MenuFastExclude";
            this.MenuFastExclude.Size = new System.Drawing.Size(84, 20);
            this.MenuFastExclude.Text = "Fast Exclude";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem2.Text = "Backend code";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // configurationFilesToolStripMenuItem1
            // 
            this.configurationFilesToolStripMenuItem1.Name = "configurationFilesToolStripMenuItem1";
            this.configurationFilesToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.configurationFilesToolStripMenuItem1.Text = "Configuration files";
            this.configurationFilesToolStripMenuItem1.Click += new System.EventHandler(this.configurationFilesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem3.Text = "Converters";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // designerCodeToolStripMenuItem1
            // 
            this.designerCodeToolStripMenuItem1.Name = "designerCodeToolStripMenuItem1";
            this.designerCodeToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.designerCodeToolStripMenuItem1.Text = "Designer code";
            this.designerCodeToolStripMenuItem1.Click += new System.EventHandler(this.designerCodeToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem4.Text = "DTOs";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem5.Text = "Enumerables";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // eventsToolStripMenuItem1
            // 
            this.eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            this.eventsToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.eventsToolStripMenuItem1.Text = "Events";
            this.eventsToolStripMenuItem1.Click += new System.EventHandler(this.eventsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem6.Text = "Helpers";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // hibernateFilesToolStripMenuItem1
            // 
            this.hibernateFilesToolStripMenuItem1.Name = "hibernateFilesToolStripMenuItem1";
            this.hibernateFilesToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.hibernateFilesToolStripMenuItem1.Text = "Hibernate files";
            this.hibernateFilesToolStripMenuItem1.Click += new System.EventHandler(this.hibernateFilesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem7.Text = "Interfaces";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem8.Text = "Project files";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem9.Text = "Properties";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // safetyFilesToolStripMenuItem1
            // 
            this.safetyFilesToolStripMenuItem1.Name = "safetyFilesToolStripMenuItem1";
            this.safetyFilesToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.safetyFilesToolStripMenuItem1.Text = "Safety files";
            this.safetyFilesToolStripMenuItem1.Click += new System.EventHandler(this.safetyFilesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem10.Text = "Services";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem11.Text = "Utils";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem12.Text = "Validators";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem13.Text = "Views";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem14.Text = "Viewmodels";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // MenuClearFilter
            // 
            this.MenuClearFilter.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MenuClearFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuClearFilter.Name = "MenuClearFilter";
            this.MenuClearFilter.Size = new System.Drawing.Size(77, 20);
            this.MenuClearFilter.Text = "Clear filter";
            this.MenuClearFilter.Click += new System.EventHandler(this.MenuClearFilter_Click);
            // 
            // spc1
            // 
            this.spc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc1.IsSplitterFixed = true;
            this.spc1.Location = new System.Drawing.Point(14, 102);
            this.spc1.Name = "spc1";
            // 
            // spc1.Panel1
            // 
            this.spc1.Panel1.Controls.Add(this.txtExclude);
            this.spc1.Panel1.Controls.Add(this.panel3);
            // 
            // spc1.Panel2
            // 
            this.spc1.Panel2.Controls.Add(this.txtExtensions);
            this.spc1.Panel2.Controls.Add(this.panel4);
            this.spc1.Size = new System.Drawing.Size(1101, 56);
            this.spc1.SplitterDistance = 551;
            this.spc1.TabIndex = 100000003;
            // 
            // txtExclude
            // 
            this.txtExclude.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtExclude.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtExclude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtExclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExclude.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExclude.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExclude.ForeColor = System.Drawing.Color.Black;
            this.txtExclude.Location = new System.Drawing.Point(0, 24);
            this.txtExclude.Name = "txtExclude";
            this.txtExclude.Size = new System.Drawing.Size(551, 31);
            this.txtExclude.TabIndex = 1;
            this.txtExclude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInclude_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 24);
            this.panel3.TabIndex = 100000003;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(-3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exclude";
            // 
            // txtExtensions
            // 
            this.txtExtensions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtExtensions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtExtensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtExtensions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtensions.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExtensions.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtensions.ForeColor = System.Drawing.Color.Black;
            this.txtExtensions.Location = new System.Drawing.Point(0, 24);
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(546, 31);
            this.txtExtensions.TabIndex = 2;
            this.txtExtensions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExtensions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInclude_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LnkRestore);
            this.panel4.Controls.Add(this.LnkAllFiles);
            this.panel4.Controls.Add(this.sep5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 24);
            this.panel4.TabIndex = 100000003;
            // 
            // LnkRestore
            // 
            this.LnkRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkRestore.AutoSize = true;
            this.LnkRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkRestore.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkRestore.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkRestore.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkRestore.Location = new System.Drawing.Point(438, 8);
            this.LnkRestore.Name = "LnkRestore";
            this.LnkRestore.Size = new System.Drawing.Size(107, 12);
            this.LnkRestore.TabIndex = 23;
            this.LnkRestore.TabStop = true;
            this.LnkRestore.Text = "Default extensions";
            this.LnkRestore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRestore_LinkClicked);
            // 
            // LnkAllFiles
            // 
            this.LnkAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkAllFiles.AutoSize = true;
            this.LnkAllFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkAllFiles.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkAllFiles.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkAllFiles.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkAllFiles.Location = new System.Drawing.Point(333, 8);
            this.LnkAllFiles.Name = "LnkAllFiles";
            this.LnkAllFiles.Size = new System.Drawing.Size(93, 12);
            this.LnkAllFiles.TabIndex = 23;
            this.LnkAllFiles.TabStop = true;
            this.LnkAllFiles.Text = "Include all files";
            this.LnkAllFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAllFiles_LinkClicked);
            // 
            // sep5
            // 
            this.sep5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sep5.AutoSize = true;
            this.sep5.ForeColor = System.Drawing.Color.White;
            this.sep5.Location = new System.Drawing.Point(426, 8);
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(12, 13);
            this.sep5.TabIndex = 32;
            this.sep5.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(-3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Extensions";
            // 
            // OpcOnFullpath
            // 
            this.OpcOnFullpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcOnFullpath.AutoSize = true;
            this.OpcOnFullpath.Checked = true;
            this.OpcOnFullpath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcOnFullpath.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcOnFullpath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcOnFullpath.Location = new System.Drawing.Point(809, 5);
            this.OpcOnFullpath.Name = "OpcOnFullpath";
            this.OpcOnFullpath.Size = new System.Drawing.Size(113, 16);
            this.OpcOnFullpath.TabIndex = 0;
            this.OpcOnFullpath.TabStop = true;
            this.OpcOnFullpath.Text = "Search on filepath";
            this.OpcOnFullpath.UseVisualStyleBackColor = true;
            this.OpcOnFullpath.CheckedChanged += new System.EventHandler(this.opcSearch1_CheckedChanged);
            // 
            // OpcOnFilename
            // 
            this.OpcOnFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcOnFilename.AutoSize = true;
            this.OpcOnFilename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcOnFilename.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcOnFilename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcOnFilename.Location = new System.Drawing.Point(926, 5);
            this.OpcOnFilename.Name = "OpcOnFilename";
            this.OpcOnFilename.Size = new System.Drawing.Size(118, 16);
            this.OpcOnFilename.TabIndex = 0;
            this.OpcOnFilename.Text = "Search on filename";
            this.OpcOnFilename.UseVisualStyleBackColor = true;
            this.OpcOnFilename.CheckedChanged += new System.EventHandler(this.opcSearch2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filter";
            // 
            // OpcOnContent
            // 
            this.OpcOnContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcOnContent.AutoSize = true;
            this.OpcOnContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcOnContent.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcOnContent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcOnContent.Location = new System.Drawing.Point(691, 5);
            this.OpcOnContent.Name = "OpcOnContent";
            this.OpcOnContent.Size = new System.Drawing.Size(114, 16);
            this.OpcOnContent.TabIndex = 0;
            this.OpcOnContent.Text = "Search on content";
            this.OpcOnContent.UseVisualStyleBackColor = true;
            this.OpcOnContent.CheckedChanged += new System.EventHandler(this.opcSearch0_CheckedChanged);
            this.OpcOnContent.Click += new System.EventHandler(this.opcSearch0_Click);
            // 
            // OpcWholeWord
            // 
            this.OpcWholeWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcWholeWord.AutoSize = true;
            this.OpcWholeWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcWholeWord.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcWholeWord.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcWholeWord.Location = new System.Drawing.Point(561, 6);
            this.OpcWholeWord.Name = "OpcWholeWord";
            this.OpcWholeWord.Size = new System.Drawing.Size(112, 16);
            this.OpcWholeWord.TabIndex = 0;
            this.OpcWholeWord.TabStop = false;
            this.OpcWholeWord.Text = "Match whole word";
            this.OpcWholeWord.UseVisualStyleBackColor = true;
            this.OpcWholeWord.CheckedChanged += new System.EventHandler(this.EvalGui_CheckedChanged);
            // 
            // OpcIndividualTerms
            // 
            this.OpcIndividualTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcIndividualTerms.AutoSize = true;
            this.OpcIndividualTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcIndividualTerms.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcIndividualTerms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcIndividualTerms.Location = new System.Drawing.Point(408, 6);
            this.OpcIndividualTerms.Name = "OpcIndividualTerms";
            this.OpcIndividualTerms.Size = new System.Drawing.Size(147, 16);
            this.OpcIndividualTerms.TabIndex = 0;
            this.OpcIndividualTerms.TabStop = false;
            this.OpcIndividualTerms.Text = "Search terms separately";
            this.OpcIndividualTerms.UseVisualStyleBackColor = true;
            this.OpcIndividualTerms.CheckedChanged += new System.EventHandler(this.EvalGui_CheckedChanged);
            // 
            // sep1
            // 
            this.sep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sep1.AutoSize = true;
            this.sep1.ForeColor = System.Drawing.Color.White;
            this.sep1.Location = new System.Drawing.Point(675, 7);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(12, 13);
            this.sep1.TabIndex = 33;
            this.sep1.Text = "|";
            // 
            // txtInclude
            // 
            this.txtInclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInclude.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtInclude.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInclude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtInclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInclude.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclude.ForeColor = System.Drawing.Color.Black;
            this.txtInclude.Location = new System.Drawing.Point(14, 74);
            this.txtInclude.Name = "txtInclude";
            this.txtInclude.Size = new System.Drawing.Size(1027, 31);
            this.txtInclude.TabIndex = 0;
            this.txtInclude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInclude_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Include";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(11, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Solution folder";
            // 
            // OpcAllTerms
            // 
            this.OpcAllTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcAllTerms.AutoSize = true;
            this.OpcAllTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcAllTerms.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcAllTerms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcAllTerms.Location = new System.Drawing.Point(298, 6);
            this.OpcAllTerms.Name = "OpcAllTerms";
            this.OpcAllTerms.Size = new System.Drawing.Size(109, 16);
            this.OpcAllTerms.TabIndex = 38;
            this.OpcAllTerms.TabStop = false;
            this.OpcAllTerms.Text = "Include all terms";
            this.OpcAllTerms.UseVisualStyleBackColor = true;
            this.OpcAllTerms.Visible = false;
            this.OpcAllTerms.CheckedChanged += new System.EventHandler(this.OpcAllTerms_CheckedChanged);
            // 
            // OpcSameLine
            // 
            this.OpcSameLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcSameLine.AutoSize = true;
            this.OpcSameLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcSameLine.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcSameLine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcSameLine.Location = new System.Drawing.Point(171, 6);
            this.OpcSameLine.Name = "OpcSameLine";
            this.OpcSameLine.Size = new System.Drawing.Size(125, 16);
            this.OpcSameLine.TabIndex = 39;
            this.OpcSameLine.TabStop = false;
            this.OpcSameLine.Text = "Search on same line";
            this.OpcSameLine.UseVisualStyleBackColor = true;
            this.OpcSameLine.Visible = false;
            this.OpcSameLine.CheckedChanged += new System.EventHandler(this.OpcSameLine_CheckedChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtFilter.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.Location = new System.Drawing.Point(14, 175);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(1101, 31);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // spc3
            // 
            this.spc3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc3.Location = new System.Drawing.Point(14, 212);
            this.spc3.Name = "spc3";
            this.spc3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc3.Panel1
            // 
            this.spc3.Panel1.Controls.Add(this.spc2);
            this.spc3.Panel1MinSize = 150;
            // 
            // spc3.Panel2
            // 
            this.spc3.Panel2.Controls.Add(this.PanelTBC);
            this.spc3.Panel2MinSize = 200;
            this.spc3.Size = new System.Drawing.Size(1101, 362);
            this.spc3.SplitterDistance = 150;
            this.spc3.TabIndex = 100000013;
            // 
            // spc2
            // 
            this.spc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc2.IsSplitterFixed = true;
            this.spc2.Location = new System.Drawing.Point(0, 0);
            this.spc2.Name = "spc2";
            // 
            // spc2.Panel1
            // 
            this.spc2.Panel1.Controls.Add(this.ListSolutions);
            this.spc2.Panel1.Controls.Add(this.panel1);
            // 
            // spc2.Panel2
            // 
            this.spc2.Panel2.Controls.Add(this.ListProjects);
            this.spc2.Panel2.Controls.Add(this.panel2);
            this.spc2.Size = new System.Drawing.Size(1101, 150);
            this.spc2.SplitterDistance = 551;
            this.spc2.TabIndex = 100000002;
            // 
            // ListSolutions
            // 
            this.ListSolutions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ListSolutions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListSolutions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSolutions.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSolutions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListSolutions.FormattingEnabled = true;
            this.ListSolutions.IntegralHeight = false;
            this.ListSolutions.ItemBackColor = System.Drawing.Color.White;
            this.ListSolutions.ItemForeColor = System.Drawing.Color.Black;
            this.ListSolutions.ItemHeight = 16;
            this.ListSolutions.ItemSelectionBackColor = System.Drawing.Color.Red;
            this.ListSolutions.ItemSelectionForeColor = System.Drawing.Color.White;
            this.ListSolutions.Location = new System.Drawing.Point(0, 24);
            this.ListSolutions.Name = "ListSolutions";
            this.ListSolutions.Size = new System.Drawing.Size(551, 126);
            this.ListSolutions.Sorted = true;
            this.ListSolutions.TabIndex = 4;
            this.ListSolutions.TabStop = false;
            this.ListSolutions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listSolutions_MouseClick);
            this.ListSolutions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listSolutions_DrawItem);
            this.ListSolutions.DoubleClick += new System.EventHandler(this.listSolutions_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.tSolutions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 24);
            this.panel1.TabIndex = 100000003;
            // 
            // tSolutions
            // 
            this.tSolutions.AutoSize = true;
            this.tSolutions.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSolutions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tSolutions.Location = new System.Drawing.Point(-3, 5);
            this.tSolutions.Name = "tSolutions";
            this.tSolutions.Size = new System.Drawing.Size(69, 14);
            this.tSolutions.TabIndex = 3;
            this.tSolutions.Text = "Solutions";
            // 
            // ListProjects
            // 
            this.ListProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ListProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListProjects.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProjects.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListProjects.FormattingEnabled = true;
            this.ListProjects.IntegralHeight = false;
            this.ListProjects.ItemBackColor = System.Drawing.Color.White;
            this.ListProjects.ItemForeColor = System.Drawing.Color.Black;
            this.ListProjects.ItemHeight = 16;
            this.ListProjects.ItemSelectionBackColor = System.Drawing.Color.Red;
            this.ListProjects.ItemSelectionForeColor = System.Drawing.Color.White;
            this.ListProjects.Location = new System.Drawing.Point(0, 24);
            this.ListProjects.Name = "ListProjects";
            this.ListProjects.Size = new System.Drawing.Size(546, 126);
            this.ListProjects.Sorted = true;
            this.ListProjects.TabIndex = 5;
            this.ListProjects.TabStop = false;
            this.ListProjects.Click += new System.EventHandler(this.listProjects_Click);
            this.ListProjects.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listProjects_DrawItem);
            this.ListProjects.DoubleClick += new System.EventHandler(this.listProjects_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tProjects);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 24);
            this.panel2.TabIndex = 100000003;
            // 
            // tProjects
            // 
            this.tProjects.AutoSize = true;
            this.tProjects.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProjects.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tProjects.Location = new System.Drawing.Point(-2, 4);
            this.tProjects.Name = "tProjects";
            this.tProjects.Size = new System.Drawing.Size(62, 14);
            this.tProjects.TabIndex = 3;
            this.tProjects.Text = "Projects";
            // 
            // PanelTBC
            // 
            this.PanelTBC.Controls.Add(this.tbc);
            this.PanelTBC.Controls.Add(this.panel8);
            this.PanelTBC.Controls.Add(this.ListQueries);
            this.PanelTBC.Controls.Add(this.panel6);
            this.PanelTBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTBC.Location = new System.Drawing.Point(0, 0);
            this.PanelTBC.Name = "PanelTBC";
            this.PanelTBC.Size = new System.Drawing.Size(1101, 208);
            this.PanelTBC.TabIndex = 100000011;
            // 
            // tbc
            // 
            this.tbc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(0, 70);
            this.tbc.Multiline = true;
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(1101, 138);
            this.tbc.TabIndex = 40;
            this.tbc.SelectedIndexChanged += new System.EventHandler(this.tbc_SelectedIndexChanged);
            this.tbc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbc_MouseClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tResults);
            this.panel8.Controls.Add(this.LnkExportToText);
            this.panel8.Controls.Add(this.sep8);
            this.panel8.Controls.Add(this.sep7);
            this.panel8.Controls.Add(this.LnkRestoreColors);
            this.panel8.Controls.Add(this.LnkExportToExcel);
            this.panel8.Controls.Add(this.sep6);
            this.panel8.Controls.Add(this.LnkColorizeRows);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1101, 24);
            this.panel8.TabIndex = 100000016;
            // 
            // tResults
            // 
            this.tResults.AutoSize = true;
            this.tResults.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tResults.Location = new System.Drawing.Point(-3, 5);
            this.tResults.Name = "tResults";
            this.tResults.Size = new System.Drawing.Size(56, 14);
            this.tResults.TabIndex = 3;
            this.tResults.Text = "Results";
            // 
            // LnkExportToText
            // 
            this.LnkExportToText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkExportToText.AutoSize = true;
            this.LnkExportToText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkExportToText.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkExportToText.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkExportToText.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkExportToText.Location = new System.Drawing.Point(1020, 7);
            this.LnkExportToText.Name = "LnkExportToText";
            this.LnkExportToText.Size = new System.Drawing.Size(81, 12);
            this.LnkExportToText.TabIndex = 23;
            this.LnkExportToText.TabStop = true;
            this.LnkExportToText.Text = "Export to text..";
            this.LnkExportToText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkExportResults_LinkClicked);
            // 
            // sep8
            // 
            this.sep8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sep8.AutoSize = true;
            this.sep8.ForeColor = System.Drawing.Color.White;
            this.sep8.Location = new System.Drawing.Point(1007, 7);
            this.sep8.Name = "sep8";
            this.sep8.Size = new System.Drawing.Size(12, 13);
            this.sep8.TabIndex = 32;
            this.sep8.Text = "|";
            // 
            // sep7
            // 
            this.sep7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sep7.AutoSize = true;
            this.sep7.ForeColor = System.Drawing.Color.White;
            this.sep7.Location = new System.Drawing.Point(905, 7);
            this.sep7.Name = "sep7";
            this.sep7.Size = new System.Drawing.Size(12, 13);
            this.sep7.TabIndex = 32;
            this.sep7.Text = "|";
            // 
            // LnkRestoreColors
            // 
            this.LnkRestoreColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkRestoreColors.AutoSize = true;
            this.LnkRestoreColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkRestoreColors.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkRestoreColors.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkRestoreColors.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkRestoreColors.Location = new System.Drawing.Point(725, 7);
            this.LnkRestoreColors.Name = "LnkRestoreColors";
            this.LnkRestoreColors.Size = new System.Drawing.Size(87, 12);
            this.LnkRestoreColors.TabIndex = 100000010;
            this.LnkRestoreColors.TabStop = true;
            this.LnkRestoreColors.Text = "Restore colors..";
            this.LnkRestoreColors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRestoreColors_LinkClicked);
            // 
            // LnkExportToExcel
            // 
            this.LnkExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkExportToExcel.AutoSize = true;
            this.LnkExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkExportToExcel.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkExportToExcel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkExportToExcel.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkExportToExcel.Location = new System.Drawing.Point(918, 7);
            this.LnkExportToExcel.Name = "LnkExportToExcel";
            this.LnkExportToExcel.Size = new System.Drawing.Size(88, 12);
            this.LnkExportToExcel.TabIndex = 35;
            this.LnkExportToExcel.TabStop = true;
            this.LnkExportToExcel.Text = "Export to excel..";
            this.LnkExportToExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkExportToExcel_LinkClicked);
            // 
            // sep6
            // 
            this.sep6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sep6.AutoSize = true;
            this.sep6.ForeColor = System.Drawing.Color.White;
            this.sep6.Location = new System.Drawing.Point(813, 7);
            this.sep6.Name = "sep6";
            this.sep6.Size = new System.Drawing.Size(12, 13);
            this.sep6.TabIndex = 100000009;
            this.sep6.Text = "|";
            // 
            // LnkColorizeRows
            // 
            this.LnkColorizeRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkColorizeRows.AutoSize = true;
            this.LnkColorizeRows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkColorizeRows.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkColorizeRows.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkColorizeRows.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkColorizeRows.Location = new System.Drawing.Point(826, 7);
            this.LnkColorizeRows.Name = "LnkColorizeRows";
            this.LnkColorizeRows.Size = new System.Drawing.Size(78, 12);
            this.LnkColorizeRows.TabIndex = 100000008;
            this.LnkColorizeRows.TabStop = true;
            this.LnkColorizeRows.Text = "Colorize row..";
            this.LnkColorizeRows.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkColorizeRows_LinkClicked);
            // 
            // ListQueries
            // 
            this.ListQueries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ListQueries.BorderColor = System.Drawing.Color.Black;
            this.ListQueries.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListQueries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListQueries.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListQueries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListQueries.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListQueries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListQueries.FormattingEnabled = true;
            this.ListQueries.Location = new System.Drawing.Point(0, 24);
            this.ListQueries.Name = "ListQueries";
            this.ListQueries.Size = new System.Drawing.Size(1101, 22);
            this.ListQueries.TabIndex = 100000019;
            this.ListQueries.SelectedIndexChanged += new System.EventHandler(this.ListQueries_SelectedIndexChanged);
            this.ListQueries.Leave += new System.EventHandler(this.ListQueries_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.sep10);
            this.panel6.Controls.Add(this.sep9);
            this.panel6.Controls.Add(this.LnkNextQuery);
            this.panel6.Controls.Add(this.LnkPrevQuery);
            this.panel6.Controls.Add(this.tQueries);
            this.panel6.Controls.Add(this.LinkCloseQuery);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1101, 24);
            this.panel6.TabIndex = 100000015;
            // 
            // sep10
            // 
            this.sep10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sep10.AutoSize = true;
            this.sep10.ForeColor = System.Drawing.Color.White;
            this.sep10.Location = new System.Drawing.Point(929, 6);
            this.sep10.Name = "sep10";
            this.sep10.Size = new System.Drawing.Size(12, 13);
            this.sep10.TabIndex = 100000012;
            this.sep10.Text = "|";
            // 
            // sep9
            // 
            this.sep9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sep9.AutoSize = true;
            this.sep9.ForeColor = System.Drawing.Color.White;
            this.sep9.Location = new System.Drawing.Point(1005, 6);
            this.sep9.Name = "sep9";
            this.sep9.Size = new System.Drawing.Size(12, 13);
            this.sep9.TabIndex = 100000012;
            this.sep9.Text = "|";
            // 
            // tQueries
            // 
            this.tQueries.AutoSize = true;
            this.tQueries.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tQueries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tQueries.Location = new System.Drawing.Point(-3, 5);
            this.tQueries.Name = "tQueries";
            this.tQueries.Size = new System.Drawing.Size(59, 14);
            this.tQueries.TabIndex = 3;
            this.tQueries.Text = "Queries";
            // 
            // LinkCloseQuery
            // 
            this.LinkCloseQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkCloseQuery.AutoSize = true;
            this.LinkCloseQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkCloseQuery.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkCloseQuery.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkCloseQuery.LinkColor = System.Drawing.Color.Gainsboro;
            this.LinkCloseQuery.Location = new System.Drawing.Point(1017, 6);
            this.LinkCloseQuery.Name = "LinkCloseQuery";
            this.LinkCloseQuery.Size = new System.Drawing.Size(83, 12);
            this.LinkCloseQuery.TabIndex = 37;
            this.LinkCloseQuery.TabStop = true;
            this.LinkCloseQuery.Text = "Remove query";
            this.LinkCloseQuery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCloseQuery_LinkClicked);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(12, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Current selection";
            // 
            // txtSelection
            // 
            this.txtSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelection.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelection.ForeColor = System.Drawing.Color.Black;
            this.txtSelection.Location = new System.Drawing.Point(15, 594);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.ReadOnly = true;
            this.txtSelection.Size = new System.Drawing.Size(1099, 31);
            this.txtSelection.TabIndex = 7;
            this.txtSelection.TabStop = false;
            this.txtSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSelection.TextChanged += new System.EventHandler(this.txtSelection_TextChanged);
            // 
            // LnkClipboard
            // 
            this.LnkClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkClipboard.AutoSize = true;
            this.LnkClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkClipboard.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkClipboard.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkClipboard.LinkColor = System.Drawing.Color.Gainsboro;
            this.LnkClipboard.Location = new System.Drawing.Point(1014, 579);
            this.LnkClipboard.Name = "LnkClipboard";
            this.LnkClipboard.Size = new System.Drawing.Size(100, 12);
            this.LnkClipboard.TabIndex = 37;
            this.LnkClipboard.TabStop = true;
            this.LnkClipboard.Text = "Copy to clipboard";
            this.LnkClipboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClipboard_LinkClicked);
            // 
            // LblBackupStatus
            // 
            this.LblBackupStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBackupStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBackupStatus.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblBackupStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LblBackupStatus.LinkColor = System.Drawing.Color.White;
            this.LblBackupStatus.Location = new System.Drawing.Point(842, 9);
            this.LblBackupStatus.Name = "LblBackupStatus";
            this.LblBackupStatus.Size = new System.Drawing.Size(273, 14);
            this.LblBackupStatus.TabIndex = 37;
            this.LblBackupStatus.TabStop = true;
            this.LblBackupStatus.Text = "Local backup is disabled";
            this.LblBackupStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblBackupStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MenuAutobackup_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelMain.Controls.Add(this.ListFolders);
            this.PanelMain.Controls.Add(this.LnkClipboard);
            this.PanelMain.Controls.Add(this.txtSelection);
            this.PanelMain.Controls.Add(this.label10);
            this.PanelMain.Controls.Add(this.spc3);
            this.PanelMain.Controls.Add(this.txtFilter);
            this.PanelMain.Controls.Add(this.BtnSelectRoot);
            this.PanelMain.Controls.Add(this.BtnLoadRoot);
            this.PanelMain.Controls.Add(this.OpcSameLine);
            this.PanelMain.Controls.Add(this.OpcAllTerms);
            this.PanelMain.Controls.Add(this.label9);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.txtInclude);
            this.PanelMain.Controls.Add(this.sep1);
            this.PanelMain.Controls.Add(this.OpcIndividualTerms);
            this.PanelMain.Controls.Add(this.OpcWholeWord);
            this.PanelMain.Controls.Add(this.OpcOnContent);
            this.PanelMain.Controls.Add(this.label4);
            this.PanelMain.Controls.Add(this.OpcOnFilename);
            this.PanelMain.Controls.Add(this.OpcOnFullpath);
            this.PanelMain.Controls.Add(this.BtnSearch);
            this.PanelMain.Controls.Add(this.BtnClear);
            this.PanelMain.Controls.Add(this.spc1);
            this.PanelMain.Controls.Add(this.FastMenu);
            this.PanelMain.Controls.Add(this.OpcFilterInclusive);
            this.PanelMain.Controls.Add(this.panel5);
            this.PanelMain.Controls.Add(this.menuStrip1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 69);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1134, 641);
            this.PanelMain.TabIndex = 36;
            // 
            // ListFolders
            // 
            this.ListFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListFolders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ListFolders.BorderColor = System.Drawing.Color.Black;
            this.ListFolders.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListFolders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListFolders.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListFolders.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListFolders.FormattingEnabled = true;
            this.ListFolders.Location = new System.Drawing.Point(14, 26);
            this.ListFolders.Name = "ListFolders";
            this.ListFolders.Size = new System.Drawing.Size(1027, 22);
            this.ListFolders.TabIndex = 100000020;
            this.ListFolders.SelectedIndexChanged += new System.EventHandler(this.ListFolders_SelectedIndexChanged);
            this.ListFolders.Leave += new System.EventHandler(this.ListFolders_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(952, 51);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(92, 24);
            this.menuStrip1.TabIndex = 100000021;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subscribeEventsToolStripMenuItem,
            this.publishEventsToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem1.Text = "Fast queries";
            // 
            // subscribeEventsToolStripMenuItem
            // 
            this.subscribeEventsToolStripMenuItem.Name = "subscribeEventsToolStripMenuItem";
            this.subscribeEventsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.subscribeEventsToolStripMenuItem.Text = "Subscribe events..";
            this.subscribeEventsToolStripMenuItem.Click += new System.EventHandler(this.subscribeEventsToolStripMenuItem_Click);
            // 
            // publishEventsToolStripMenuItem
            // 
            this.publishEventsToolStripMenuItem.Name = "publishEventsToolStripMenuItem";
            this.publishEventsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.publishEventsToolStripMenuItem.Text = "Publish events..";
            this.publishEventsToolStripMenuItem.Click += new System.EventHandler(this.publishEventsToolStripMenuItem_Click);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelBottom.Controls.Add(this.MessageStatus);
            this.PanelBottom.Controls.Add(this.LblBackupStatus);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 710);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1134, 32);
            this.PanelBottom.TabIndex = 100000016;
            // 
            // MessageStatus
            // 
            this.MessageStatus.AutoSize = true;
            this.MessageStatus.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MessageStatus.Location = new System.Drawing.Point(11, 9);
            this.MessageStatus.Name = "MessageStatus";
            this.MessageStatus.Size = new System.Drawing.Size(49, 14);
            this.MessageStatus.TabIndex = 3;
            this.MessageStatus.Text = "Ready";
            // 
            // PanelTop
            // 
            this.PanelTop.Angle = 90F;
            this.PanelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTop.BackgroundImage")));
            this.PanelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTop.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PanelTop.Color2 = System.Drawing.Color.Black;
            this.PanelTop.Controls.Add(this.MainMenu);
            this.PanelTop.Controls.Add(this.LogoText);
            this.PanelTop.Controls.Add(this.LogoSymbol);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1134, 44);
            this.PanelTop.TabIndex = 100000012;
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuOffice,
            this.MenuTools,
            this.MenuSystem,
            this.sPECIALTOOLSToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(668, 9);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(456, 24);
            this.MainMenu.TabIndex = 100000017;
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1_About,
            this.Menu1_HideSearchType,
            this.Menu1_WindowState,
            this.Menu1_Style,
            this.toolStripSeparator18,
            this.Menu1_CheckNetwork,
            this.toolStripSeparator23,
            this.Menu1_AutoscaleMode,
            this.toolStripSeparator20,
            this.Menu1_ExitApp});
            this.MenuFile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(88, 20);
            this.MenuFile.Text = "OPTIONS";
            // 
            // Menu1_About
            // 
            this.Menu1_About.ForeColor = System.Drawing.Color.Black;
            this.Menu1_About.Image = ((System.Drawing.Image)(resources.GetObject("Menu1_About.Image")));
            this.Menu1_About.Name = "Menu1_About";
            this.Menu1_About.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.Menu1_About.Size = new System.Drawing.Size(225, 22);
            this.Menu1_About.Text = "About..";
            this.Menu1_About.Click += new System.EventHandler(this.Menu1_About_Click);
            // 
            // Menu1_HideSearchType
            // 
            this.Menu1_HideSearchType.ForeColor = System.Drawing.Color.Black;
            this.Menu1_HideSearchType.Image = ((System.Drawing.Image)(resources.GetObject("Menu1_HideSearchType.Image")));
            this.Menu1_HideSearchType.Name = "Menu1_HideSearchType";
            this.Menu1_HideSearchType.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.Menu1_HideSearchType.Size = new System.Drawing.Size(225, 22);
            this.Menu1_HideSearchType.Text = "Hide search type";
            this.Menu1_HideSearchType.Click += new System.EventHandler(this.Menu1_HideSearchType_Click);
            // 
            // Menu1_WindowState
            // 
            this.Menu1_WindowState.ForeColor = System.Drawing.Color.Black;
            this.Menu1_WindowState.Image = ((System.Drawing.Image)(resources.GetObject("Menu1_WindowState.Image")));
            this.Menu1_WindowState.Name = "Menu1_WindowState";
            this.Menu1_WindowState.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.Menu1_WindowState.Size = new System.Drawing.Size(225, 22);
            this.Menu1_WindowState.Text = "Change window state";
            this.Menu1_WindowState.Click += new System.EventHandler(this.Menu1_WindowState_Click);
            // 
            // Menu1_Style
            // 
            this.Menu1_Style.Image = ((System.Drawing.Image)(resources.GetObject("Menu1_Style.Image")));
            this.Menu1_Style.Name = "Menu1_Style";
            this.Menu1_Style.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.Menu1_Style.Size = new System.Drawing.Size(225, 22);
            this.Menu1_Style.Text = "Change style..";
            this.Menu1_Style.Click += new System.EventHandler(this.Menu1_Style_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(222, 6);
            // 
            // Menu1_CheckNetwork
            // 
            this.Menu1_CheckNetwork.Checked = true;
            this.Menu1_CheckNetwork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu1_CheckNetwork.Name = "Menu1_CheckNetwork";
            this.Menu1_CheckNetwork.Size = new System.Drawing.Size(225, 22);
            this.Menu1_CheckNetwork.Text = "Check network connection";
            this.Menu1_CheckNetwork.Click += new System.EventHandler(this.Menu1_CheckNetwork_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(222, 6);
            // 
            // Menu1_AutoscaleMode
            // 
            this.Menu1_AutoscaleMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1_AutoscaleMode_1,
            this.Menu1_AutoscaleMode_2,
            this.Menu1_AutoscaleMode_3});
            this.Menu1_AutoscaleMode.Image = ((System.Drawing.Image)(resources.GetObject("Menu1_AutoscaleMode.Image")));
            this.Menu1_AutoscaleMode.Name = "Menu1_AutoscaleMode";
            this.Menu1_AutoscaleMode.Size = new System.Drawing.Size(225, 22);
            this.Menu1_AutoscaleMode.Text = "Autoscale mode";
            // 
            // Menu1_AutoscaleMode_1
            // 
            this.Menu1_AutoscaleMode_1.Checked = true;
            this.Menu1_AutoscaleMode_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu1_AutoscaleMode_1.Name = "Menu1_AutoscaleMode_1";
            this.Menu1_AutoscaleMode_1.Size = new System.Drawing.Size(115, 22);
            this.Menu1_AutoscaleMode_1.Text = "Normal";
            this.Menu1_AutoscaleMode_1.Click += new System.EventHandler(this.Menu1_AutoscaleMode_1_Click);
            // 
            // Menu1_AutoscaleMode_2
            // 
            this.Menu1_AutoscaleMode_2.Name = "Menu1_AutoscaleMode_2";
            this.Menu1_AutoscaleMode_2.Size = new System.Drawing.Size(115, 22);
            this.Menu1_AutoscaleMode_2.Text = "Font";
            this.Menu1_AutoscaleMode_2.Click += new System.EventHandler(this.Menu1_AutoscaleMode_2_Click);
            // 
            // Menu1_AutoscaleMode_3
            // 
            this.Menu1_AutoscaleMode_3.Name = "Menu1_AutoscaleMode_3";
            this.Menu1_AutoscaleMode_3.Size = new System.Drawing.Size(115, 22);
            this.Menu1_AutoscaleMode_3.Text = "DPI";
            this.Menu1_AutoscaleMode_3.Click += new System.EventHandler(this.Menu1_AutoscaleMode_3_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(222, 6);
            // 
            // Menu1_ExitApp
            // 
            this.Menu1_ExitApp.Image = ((System.Drawing.Image)(resources.GetObject("Menu1_ExitApp.Image")));
            this.Menu1_ExitApp.Name = "Menu1_ExitApp";
            this.Menu1_ExitApp.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.Menu1_ExitApp.Size = new System.Drawing.Size(225, 22);
            this.Menu1_ExitApp.Text = "Exit application..";
            this.Menu1_ExitApp.Click += new System.EventHandler(this.Menu1_ExitApp_Click);
            // 
            // MenuOffice
            // 
            this.MenuOffice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu3_Word,
            this.Menu3_Excel,
            this.Menu3_Powerpoint,
            this.toolStripSeparator7,
            this.Menu3_Outlook,
            this.toolStripSeparator8,
            this.Menu3_Jabber});
            this.MenuOffice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOffice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuOffice.Image = ((System.Drawing.Image)(resources.GetObject("MenuOffice.Image")));
            this.MenuOffice.Name = "MenuOffice";
            this.MenuOffice.Size = new System.Drawing.Size(77, 20);
            this.MenuOffice.Text = "OFFICE";
            // 
            // Menu3_Word
            // 
            this.Menu3_Word.Image = ((System.Drawing.Image)(resources.GetObject("Menu3_Word.Image")));
            this.Menu3_Word.Name = "Menu3_Word";
            this.Menu3_Word.Size = new System.Drawing.Size(153, 22);
            this.Menu3_Word.Text = "Word..";
            this.Menu3_Word.Click += new System.EventHandler(this.Menu3_Word_Click);
            // 
            // Menu3_Excel
            // 
            this.Menu3_Excel.Image = ((System.Drawing.Image)(resources.GetObject("Menu3_Excel.Image")));
            this.Menu3_Excel.Name = "Menu3_Excel";
            this.Menu3_Excel.Size = new System.Drawing.Size(153, 22);
            this.Menu3_Excel.Text = "Excel..";
            this.Menu3_Excel.Click += new System.EventHandler(this.Menu3_Excel_Click);
            // 
            // Menu3_Powerpoint
            // 
            this.Menu3_Powerpoint.Image = ((System.Drawing.Image)(resources.GetObject("Menu3_Powerpoint.Image")));
            this.Menu3_Powerpoint.Name = "Menu3_Powerpoint";
            this.Menu3_Powerpoint.Size = new System.Drawing.Size(153, 22);
            this.Menu3_Powerpoint.Text = "Powerpoint..";
            this.Menu3_Powerpoint.Click += new System.EventHandler(this.Menu3_Powerpoint_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(150, 6);
            // 
            // Menu3_Outlook
            // 
            this.Menu3_Outlook.Image = ((System.Drawing.Image)(resources.GetObject("Menu3_Outlook.Image")));
            this.Menu3_Outlook.Name = "Menu3_Outlook";
            this.Menu3_Outlook.Size = new System.Drawing.Size(153, 22);
            this.Menu3_Outlook.Text = "Outlook..";
            this.Menu3_Outlook.Click += new System.EventHandler(this.Menu3_Outlook_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(150, 6);
            // 
            // Menu3_Jabber
            // 
            this.Menu3_Jabber.Image = ((System.Drawing.Image)(resources.GetObject("Menu3_Jabber.Image")));
            this.Menu3_Jabber.Name = "Menu3_Jabber";
            this.Menu3_Jabber.Size = new System.Drawing.Size(153, 22);
            this.Menu3_Jabber.Text = "Cisco Jabber..";
            this.Menu3_Jabber.Click += new System.EventHandler(this.Menu3_Jabber_Click);
            // 
            // MenuTools
            // 
            this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu2_Explorer,
            this.toolStripSeparator16,
            this.Menu2_RegEdit,
            this.toolStripSeparator17,
            this.Menu2_Services,
            this.toolStripSeparator5,
            this.Menu2_TaskManager,
            this.toolStripSeparator3,
            this.Menu2_InternetExplorer,
            this.toolStripSeparator4,
            this.Menu2_Wordpad,
            this.toolStripSeparator6,
            this.Menu2_Notepad,
            this.Menu2_Calc,
            this.Menu2_Charmap,
            this.toolStripSeparator9,
            this.Menu2_Paint,
            this.Menu2_Snipping,
            this.Menu2_Magnifier,
            this.Menu2_ScreenKeyboard,
            this.toolStripSeparator19,
            this.Menu2_AccessibilityOptions,
            this.toolStripSeparator24,
            this.Menu2_VolumeSettings,
            this.toolStripSeparator10,
            this.Menu2_Cmd,
            this.Menu2_ControlPanel});
            this.MenuTools.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTools.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuTools.Image = ((System.Drawing.Image)(resources.GetObject("MenuTools.Image")));
            this.MenuTools.Name = "MenuTools";
            this.MenuTools.Size = new System.Drawing.Size(74, 20);
            this.MenuTools.Text = "TOOLS";
            // 
            // Menu2_Explorer
            // 
            this.Menu2_Explorer.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Explorer.Image")));
            this.Menu2_Explorer.Name = "Menu2_Explorer";
            this.Menu2_Explorer.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Explorer.Text = "Windows Explorer..";
            this.Menu2_Explorer.Click += new System.EventHandler(this.Menu2_Explorer_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_RegEdit
            // 
            this.Menu2_RegEdit.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_RegEdit.Image")));
            this.Menu2_RegEdit.Name = "Menu2_RegEdit";
            this.Menu2_RegEdit.Size = new System.Drawing.Size(196, 22);
            this.Menu2_RegEdit.Text = "RegEdit..";
            this.Menu2_RegEdit.Click += new System.EventHandler(this.Menu2_RegEdit_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_Services
            // 
            this.Menu2_Services.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Services.Image")));
            this.Menu2_Services.Name = "Menu2_Services";
            this.Menu2_Services.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Services.Text = "Services..";
            this.Menu2_Services.Click += new System.EventHandler(this.Menu2_Services_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_TaskManager
            // 
            this.Menu2_TaskManager.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_TaskManager.Image")));
            this.Menu2_TaskManager.Name = "Menu2_TaskManager";
            this.Menu2_TaskManager.Size = new System.Drawing.Size(196, 22);
            this.Menu2_TaskManager.Text = "Task Manager..";
            this.Menu2_TaskManager.Click += new System.EventHandler(this.Menu2_TaskManager_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_InternetExplorer
            // 
            this.Menu2_InternetExplorer.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_InternetExplorer.Image")));
            this.Menu2_InternetExplorer.Name = "Menu2_InternetExplorer";
            this.Menu2_InternetExplorer.Size = new System.Drawing.Size(196, 22);
            this.Menu2_InternetExplorer.Text = "Internet Explorer..";
            this.Menu2_InternetExplorer.Click += new System.EventHandler(this.Menu2_InternetExplorer_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_Wordpad
            // 
            this.Menu2_Wordpad.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Wordpad.Image")));
            this.Menu2_Wordpad.Name = "Menu2_Wordpad";
            this.Menu2_Wordpad.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Wordpad.Text = "Wordpad..";
            this.Menu2_Wordpad.Click += new System.EventHandler(this.Menu2_Wordpad_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_Notepad
            // 
            this.Menu2_Notepad.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Notepad.Image")));
            this.Menu2_Notepad.Name = "Menu2_Notepad";
            this.Menu2_Notepad.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Notepad.Text = "Notepad..";
            this.Menu2_Notepad.Click += new System.EventHandler(this.Menu2_Notepad_Click);
            // 
            // Menu2_Calc
            // 
            this.Menu2_Calc.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Calc.Image")));
            this.Menu2_Calc.Name = "Menu2_Calc";
            this.Menu2_Calc.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Calc.Text = "Calculator..";
            this.Menu2_Calc.Click += new System.EventHandler(this.Menu2_Calc_Click);
            // 
            // Menu2_Charmap
            // 
            this.Menu2_Charmap.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Charmap.Image")));
            this.Menu2_Charmap.Name = "Menu2_Charmap";
            this.Menu2_Charmap.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Charmap.Text = "Charmap..";
            this.Menu2_Charmap.Click += new System.EventHandler(this.Menu2_Charmap_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_Paint
            // 
            this.Menu2_Paint.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Paint.Image")));
            this.Menu2_Paint.Name = "Menu2_Paint";
            this.Menu2_Paint.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Paint.Text = "Paint..";
            this.Menu2_Paint.Click += new System.EventHandler(this.Menu2_Paint_Click);
            // 
            // Menu2_Snipping
            // 
            this.Menu2_Snipping.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Snipping.Image")));
            this.Menu2_Snipping.Name = "Menu2_Snipping";
            this.Menu2_Snipping.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Snipping.Text = "Snipping Tool..";
            this.Menu2_Snipping.Click += new System.EventHandler(this.Menu2_Snipping_Click);
            // 
            // Menu2_Magnifier
            // 
            this.Menu2_Magnifier.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Magnifier.Image")));
            this.Menu2_Magnifier.Name = "Menu2_Magnifier";
            this.Menu2_Magnifier.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Magnifier.Text = "Magnifier..";
            this.Menu2_Magnifier.Click += new System.EventHandler(this.Menu2_Magnifier_Click);
            // 
            // Menu2_ScreenKeyboard
            // 
            this.Menu2_ScreenKeyboard.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_ScreenKeyboard.Image")));
            this.Menu2_ScreenKeyboard.Name = "Menu2_ScreenKeyboard";
            this.Menu2_ScreenKeyboard.Size = new System.Drawing.Size(196, 22);
            this.Menu2_ScreenKeyboard.Text = "Screen Keyboard..";
            this.Menu2_ScreenKeyboard.Click += new System.EventHandler(this.Menu2_ScreenKeyboard_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_AccessibilityOptions
            // 
            this.Menu2_AccessibilityOptions.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_AccessibilityOptions.Image")));
            this.Menu2_AccessibilityOptions.Name = "Menu2_AccessibilityOptions";
            this.Menu2_AccessibilityOptions.Size = new System.Drawing.Size(196, 22);
            this.Menu2_AccessibilityOptions.Text = "Accessibility options..";
            this.Menu2_AccessibilityOptions.Click += new System.EventHandler(this.Menu2_AccessibilityOptions_Click);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_VolumeSettings
            // 
            this.Menu2_VolumeSettings.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_VolumeSettings.Image")));
            this.Menu2_VolumeSettings.Name = "Menu2_VolumeSettings";
            this.Menu2_VolumeSettings.Size = new System.Drawing.Size(196, 22);
            this.Menu2_VolumeSettings.Text = "Volume Settings..";
            this.Menu2_VolumeSettings.Click += new System.EventHandler(this.Menu2_VolumeSettings_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(193, 6);
            // 
            // Menu2_Cmd
            // 
            this.Menu2_Cmd.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_Cmd.Image")));
            this.Menu2_Cmd.Name = "Menu2_Cmd";
            this.Menu2_Cmd.Size = new System.Drawing.Size(196, 22);
            this.Menu2_Cmd.Text = "Console (CMD)..";
            this.Menu2_Cmd.Click += new System.EventHandler(this.Menu2_Cmd_Click);
            // 
            // Menu2_ControlPanel
            // 
            this.Menu2_ControlPanel.Image = ((System.Drawing.Image)(resources.GetObject("Menu2_ControlPanel.Image")));
            this.Menu2_ControlPanel.Name = "Menu2_ControlPanel";
            this.Menu2_ControlPanel.Size = new System.Drawing.Size(196, 22);
            this.Menu2_ControlPanel.Text = "Control Panel..";
            this.Menu2_ControlPanel.Click += new System.EventHandler(this.Menu2_ControlPanel_Click);
            // 
            // MenuSystem
            // 
            this.MenuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu5_SysInfo,
            this.Menu5_CurrentVersion,
            this.toolStripSeparator11,
            this.Menu5_InternetProperties,
            this.toolStripSeparator13,
            this.Menu5_ClearIconCache,
            this.toolStripSeparator21,
            this.Menu5_UserFolder,
            this.Menu5_WinFolder,
            this.Menu5_AppDataFolder,
            this.toolStripSeparator12,
            this.Menu5_WindowsMobilityCenter,
            this.toolStripSeparator22,
            this.Menu5_Fonts,
            this.Menu5_DPISettings,
            this.Menu5_ColorManagement,
            this.Menu5_DateTime,
            this.Menu5_Printers,
            this.toolStripSeparator14,
            this.Menu5_MouseProperties,
            this.toolStripSeparator15,
            this.Menu5_SystemProperties});
            this.MenuSystem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSystem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuSystem.Image = ((System.Drawing.Image)(resources.GetObject("MenuSystem.Image")));
            this.MenuSystem.Name = "MenuSystem";
            this.MenuSystem.Size = new System.Drawing.Size(81, 20);
            this.MenuSystem.Text = "SYSTEM";
            // 
            // Menu5_SysInfo
            // 
            this.Menu5_SysInfo.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_SysInfo.Image")));
            this.Menu5_SysInfo.Name = "Menu5_SysInfo";
            this.Menu5_SysInfo.Size = new System.Drawing.Size(245, 22);
            this.Menu5_SysInfo.Text = "System information..";
            this.Menu5_SysInfo.Click += new System.EventHandler(this.Menu5_SysInfo_Click);
            // 
            // Menu5_CurrentVersion
            // 
            this.Menu5_CurrentVersion.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_CurrentVersion.Image")));
            this.Menu5_CurrentVersion.Name = "Menu5_CurrentVersion";
            this.Menu5_CurrentVersion.Size = new System.Drawing.Size(245, 22);
            this.Menu5_CurrentVersion.Text = "Current Windows version..";
            this.Menu5_CurrentVersion.Click += new System.EventHandler(this.Menu5_CurrentVersion_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(242, 6);
            // 
            // Menu5_InternetProperties
            // 
            this.Menu5_InternetProperties.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_InternetProperties.Image")));
            this.Menu5_InternetProperties.Name = "Menu5_InternetProperties";
            this.Menu5_InternetProperties.Size = new System.Drawing.Size(245, 22);
            this.Menu5_InternetProperties.Text = "Internet properties..";
            this.Menu5_InternetProperties.Click += new System.EventHandler(this.Menu5_InternetProperties_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(242, 6);
            // 
            // Menu5_ClearIconCache
            // 
            this.Menu5_ClearIconCache.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_ClearIconCache.Image")));
            this.Menu5_ClearIconCache.Name = "Menu5_ClearIconCache";
            this.Menu5_ClearIconCache.Size = new System.Drawing.Size(245, 22);
            this.Menu5_ClearIconCache.Text = "Clear Icon Cache..";
            this.Menu5_ClearIconCache.Click += new System.EventHandler(this.Menu5_ClearIconCache_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(242, 6);
            // 
            // Menu5_UserFolder
            // 
            this.Menu5_UserFolder.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_UserFolder.Image")));
            this.Menu5_UserFolder.Name = "Menu5_UserFolder";
            this.Menu5_UserFolder.Size = new System.Drawing.Size(245, 22);
            this.Menu5_UserFolder.Text = "User folder..";
            this.Menu5_UserFolder.Click += new System.EventHandler(this.Menu5_UserFolder_Click);
            // 
            // Menu5_WinFolder
            // 
            this.Menu5_WinFolder.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_WinFolder.Image")));
            this.Menu5_WinFolder.Name = "Menu5_WinFolder";
            this.Menu5_WinFolder.Size = new System.Drawing.Size(245, 22);
            this.Menu5_WinFolder.Text = "Windows folder..";
            this.Menu5_WinFolder.Click += new System.EventHandler(this.Menu5_WinFolder_Click);
            // 
            // Menu5_AppDataFolder
            // 
            this.Menu5_AppDataFolder.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_AppDataFolder.Image")));
            this.Menu5_AppDataFolder.Name = "Menu5_AppDataFolder";
            this.Menu5_AppDataFolder.Size = new System.Drawing.Size(245, 22);
            this.Menu5_AppDataFolder.Text = "Application data folder..";
            this.Menu5_AppDataFolder.Click += new System.EventHandler(this.Menu5_AppDataFolder_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(242, 6);
            // 
            // Menu5_WindowsMobilityCenter
            // 
            this.Menu5_WindowsMobilityCenter.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_WindowsMobilityCenter.Image")));
            this.Menu5_WindowsMobilityCenter.Name = "Menu5_WindowsMobilityCenter";
            this.Menu5_WindowsMobilityCenter.Size = new System.Drawing.Size(245, 22);
            this.Menu5_WindowsMobilityCenter.Text = "Windows Mobility Center..";
            this.Menu5_WindowsMobilityCenter.Click += new System.EventHandler(this.Menu5_WindowsMobilityCenter_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(242, 6);
            // 
            // Menu5_Fonts
            // 
            this.Menu5_Fonts.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_Fonts.Image")));
            this.Menu5_Fonts.Name = "Menu5_Fonts";
            this.Menu5_Fonts.Size = new System.Drawing.Size(245, 22);
            this.Menu5_Fonts.Text = "Fonts..";
            this.Menu5_Fonts.Click += new System.EventHandler(this.Menu5_Fonts_Click);
            // 
            // Menu5_DPISettings
            // 
            this.Menu5_DPISettings.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_DPISettings.Image")));
            this.Menu5_DPISettings.Name = "Menu5_DPISettings";
            this.Menu5_DPISettings.Size = new System.Drawing.Size(245, 22);
            this.Menu5_DPISettings.Text = "DPI settings..";
            this.Menu5_DPISettings.Click += new System.EventHandler(this.Menu5_DPISettings_Click);
            // 
            // Menu5_ColorManagement
            // 
            this.Menu5_ColorManagement.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_ColorManagement.Image")));
            this.Menu5_ColorManagement.Name = "Menu5_ColorManagement";
            this.Menu5_ColorManagement.Size = new System.Drawing.Size(245, 22);
            this.Menu5_ColorManagement.Text = "Color Management..";
            this.Menu5_ColorManagement.Click += new System.EventHandler(this.Menu5_ColorManagement_Click);
            // 
            // Menu5_DateTime
            // 
            this.Menu5_DateTime.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_DateTime.Image")));
            this.Menu5_DateTime.Name = "Menu5_DateTime";
            this.Menu5_DateTime.Size = new System.Drawing.Size(245, 22);
            this.Menu5_DateTime.Text = "Date and time..";
            this.Menu5_DateTime.Click += new System.EventHandler(this.Menu5_DateTime_Click);
            // 
            // Menu5_Printers
            // 
            this.Menu5_Printers.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_Printers.Image")));
            this.Menu5_Printers.Name = "Menu5_Printers";
            this.Menu5_Printers.Size = new System.Drawing.Size(245, 22);
            this.Menu5_Printers.Text = "Printers, scanners and faxes..";
            this.Menu5_Printers.Click += new System.EventHandler(this.Menu5_Printers_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(242, 6);
            // 
            // Menu5_MouseProperties
            // 
            this.Menu5_MouseProperties.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_MouseProperties.Image")));
            this.Menu5_MouseProperties.Name = "Menu5_MouseProperties";
            this.Menu5_MouseProperties.Size = new System.Drawing.Size(245, 22);
            this.Menu5_MouseProperties.Text = "Mouse properties..";
            this.Menu5_MouseProperties.Click += new System.EventHandler(this.Menu5_MouseProperties_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(242, 6);
            // 
            // Menu5_SystemProperties
            // 
            this.Menu5_SystemProperties.Image = ((System.Drawing.Image)(resources.GetObject("Menu5_SystemProperties.Image")));
            this.Menu5_SystemProperties.Name = "Menu5_SystemProperties";
            this.Menu5_SystemProperties.Size = new System.Drawing.Size(245, 22);
            this.Menu5_SystemProperties.Text = "System properties..";
            this.Menu5_SystemProperties.Click += new System.EventHandler(this.Menu5_SystemProperties_Click);
            // 
            // sPECIALTOOLSToolStripMenuItem
            // 
            this.sPECIALTOOLSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appControlToolStripMenuItem,
            this.toolStripSeparator26,
            this.MenuTests,
            this.MenuSQLExtractor,
            this.MenuAutobackup,
            this.MenuSafeBoard});
            this.sPECIALTOOLSToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPECIALTOOLSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sPECIALTOOLSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sPECIALTOOLSToolStripMenuItem.Image")));
            this.sPECIALTOOLSToolStripMenuItem.Name = "sPECIALTOOLSToolStripMenuItem";
            this.sPECIALTOOLSToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.sPECIALTOOLSToolStripMenuItem.Text = "SPECIAL TOOLS";
            // 
            // appControlToolStripMenuItem
            // 
            this.appControlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("appControlToolStripMenuItem.Image")));
            this.appControlToolStripMenuItem.Name = "appControlToolStripMenuItem";
            this.appControlToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.appControlToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.appControlToolStripMenuItem.Text = "MPRS App Control..";
            this.appControlToolStripMenuItem.Click += new System.EventHandler(this.MenuAppControl_Click);
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(203, 6);
            // 
            // MenuTests
            // 
            this.MenuTests.Image = ((System.Drawing.Image)(resources.GetObject("MenuTests.Image")));
            this.MenuTests.Name = "MenuTests";
            this.MenuTests.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.MenuTests.Size = new System.Drawing.Size(206, 22);
            this.MenuTests.Text = "Test Manager..";
            this.MenuTests.Click += new System.EventHandler(this.MenuTests_Click);
            // 
            // MenuSQLExtractor
            // 
            this.MenuSQLExtractor.Image = ((System.Drawing.Image)(resources.GetObject("MenuSQLExtractor.Image")));
            this.MenuSQLExtractor.Name = "MenuSQLExtractor";
            this.MenuSQLExtractor.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.MenuSQLExtractor.Size = new System.Drawing.Size(206, 22);
            this.MenuSQLExtractor.Text = "SQL Extractor..";
            this.MenuSQLExtractor.Click += new System.EventHandler(this.MenuSQLExtractor_Click);
            // 
            // MenuAutobackup
            // 
            this.MenuAutobackup.Image = ((System.Drawing.Image)(resources.GetObject("MenuAutobackup.Image")));
            this.MenuAutobackup.Name = "MenuAutobackup";
            this.MenuAutobackup.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuAutobackup.Size = new System.Drawing.Size(206, 22);
            this.MenuAutobackup.Text = "Local Backup..";
            this.MenuAutobackup.Click += new System.EventHandler(this.MenuAutobackup_Click);
            // 
            // MenuSafeBoard
            // 
            this.MenuSafeBoard.Image = ((System.Drawing.Image)(resources.GetObject("MenuSafeBoard.Image")));
            this.MenuSafeBoard.Name = "MenuSafeBoard";
            this.MenuSafeBoard.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.MenuSafeBoard.Size = new System.Drawing.Size(206, 22);
            this.MenuSafeBoard.Text = "Safeboard..";
            this.MenuSafeBoard.Click += new System.EventHandler(this.MenuSafeBoard_Click);
            // 
            // LogoText
            // 
            this.LogoText.BackColor = System.Drawing.Color.Transparent;
            this.LogoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoText.Image = ((System.Drawing.Image)(resources.GetObject("LogoText.Image")));
            this.LogoText.Location = new System.Drawing.Point(48, 2);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(218, 39);
            this.LogoText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoText.TabIndex = 0;
            this.LogoText.TabStop = false;
            this.LogoText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoSymbol_MouseClick);
            // 
            // LogoSymbol
            // 
            this.LogoSymbol.BackColor = System.Drawing.Color.Transparent;
            this.LogoSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoSymbol.Image = ((System.Drawing.Image)(resources.GetObject("LogoSymbol.Image")));
            this.LogoSymbol.Location = new System.Drawing.Point(0, 1);
            this.LogoSymbol.Name = "LogoSymbol";
            this.LogoSymbol.Size = new System.Drawing.Size(51, 41);
            this.LogoSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoSymbol.TabIndex = 0;
            this.LogoSymbol.TabStop = false;
            this.LogoSymbol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoSymbol_MouseClick);
            // 
            // FrmSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 742);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.SearchType);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.FastMenu;
            this.MinimumSize = new System.Drawing.Size(1150, 780);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Activated += new System.EventHandler(this.FrmSearch_Activated);
            this.Deactivate += new System.EventHandler(this.FrmSearch_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSearch_FormClosing);
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.SizeChanged += new System.EventHandler(this.FrmSearch_SizeChanged);
            this.CM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FswAutoBackup)).EndInit();
            this.CMNicon.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.FastMenu.ResumeLayout(false);
            this.FastMenu.PerformLayout();
            this.spc1.Panel1.ResumeLayout(false);
            this.spc1.Panel1.PerformLayout();
            this.spc1.Panel2.ResumeLayout(false);
            this.spc1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc1)).EndInit();
            this.spc1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.spc3.Panel1.ResumeLayout(false);
            this.spc3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc3)).EndInit();
            this.spc3.ResumeLayout(false);
            this.spc2.Panel1.ResumeLayout(false);
            this.spc2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc2)).EndInit();
            this.spc2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelTBC.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSymbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip help;
        private System.Windows.Forms.ContextMenuStrip CM;
        private System.Windows.Forms.ToolStripMenuItem OpcViewFile;
        private System.Windows.Forms.ToolStripMenuItem OpcViewFolder;
        private System.Windows.Forms.ToolStripMenuItem OpcViewResults;
        private System.Windows.Forms.ToolStripMenuItem CMFileName;
        private System.Windows.Forms.ToolStripSeparator CMFilenameSeparator;
        internal System.Windows.Forms.Label SearchType;
        private System.IO.FileSystemWatcher FswAutoBackup;
        private System.Windows.Forms.Timer tcontrol;
        private System.Windows.Forms.NotifyIcon Nicon;
        private System.Windows.Forms.ContextMenuStrip CMNicon;
        private System.Windows.Forms.ToolStripMenuItem CMNiconMenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuShow;
        private System.Windows.Forms.ToolStripMenuItem MenuHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private GradientPanel PanelTop;
        private System.Windows.Forms.PictureBox LogoSymbol;
        private System.Windows.Forms.PictureBox LogoText;
        private System.Windows.Forms.Panel PanelMain;
        internal System.Windows.Forms.LinkLabel LblBackupStatus;
        internal System.Windows.Forms.LinkLabel LnkClipboard;
        internal System.Windows.Forms.TextBox txtSelection;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer spc3;
        private System.Windows.Forms.SplitContainer spc2;
        private CustomListBox ListSolutions;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label tSolutions;
        private CustomListBox ListProjects;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label tProjects;
        private System.Windows.Forms.Panel PanelTBC;
        private TabControlWithoutHeader tbc;
        private System.Windows.Forms.Panel panel8;
        internal System.Windows.Forms.Label tResults;
        internal System.Windows.Forms.LinkLabel LnkExportToText;
        private System.Windows.Forms.Label sep8;
        private System.Windows.Forms.Label sep7;
        internal System.Windows.Forms.LinkLabel LnkRestoreColors;
        internal System.Windows.Forms.LinkLabel LnkExportToExcel;
        private System.Windows.Forms.Label sep6;
        internal System.Windows.Forms.LinkLabel LnkColorizeRows;
        private FlatComboBox ListQueries;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Label tQueries;
        internal System.Windows.Forms.LinkLabel LinkCloseQuery;
        internal System.Windows.Forms.TextBox txtFilter;
        internal System.Windows.Forms.Button BtnSelectRoot;
        internal System.Windows.Forms.Button BtnLoadRoot;
        private System.Windows.Forms.CheckBox OpcSameLine;
        private System.Windows.Forms.CheckBox OpcAllTerms;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtInclude;
        private System.Windows.Forms.Label sep1;
        private System.Windows.Forms.CheckBox OpcIndividualTerms;
        private System.Windows.Forms.CheckBox OpcWholeWord;
        private System.Windows.Forms.RadioButton OpcOnContent;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton OpcOnFilename;
        private System.Windows.Forms.RadioButton OpcOnFullpath;
        internal System.Windows.Forms.Button BtnSearch;
        internal System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.SplitContainer spc1;
        internal System.Windows.Forms.TextBox txtExclude;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtExtensions;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.LinkLabel LnkRestore;
        internal System.Windows.Forms.LinkLabel LnkAllFiles;
        private System.Windows.Forms.Label sep5;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip FastMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFastInclude;
        private System.Windows.Forms.ToolStripMenuItem backcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewmodelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFastExclude;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem designerCodeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem MenuClearFilter;
        private System.Windows.Forms.CheckBox OpcFilterInclusive;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton OpcFilterPath;
        private System.Windows.Forms.RadioButton OpcFilterName;
        private System.Windows.Forms.Panel PanelBottom;
        internal System.Windows.Forms.Label MessageStatus;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem Menu1_ExitApp;
        private System.Windows.Forms.ToolStripMenuItem MenuOffice;
        private System.Windows.Forms.ToolStripMenuItem Menu3_Word;
        private System.Windows.Forms.ToolStripMenuItem Menu3_Excel;
        private System.Windows.Forms.ToolStripMenuItem Menu3_Powerpoint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem Menu3_Outlook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem Menu3_Jabber;
        private System.Windows.Forms.ToolStripMenuItem MenuTools;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Explorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem Menu2_RegEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Services;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Menu2_TaskManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Menu2_InternetExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Wordpad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Notepad;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Calc;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Charmap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Paint;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Snipping;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Magnifier;
        private System.Windows.Forms.ToolStripMenuItem Menu2_ScreenKeyboard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem Menu2_AccessibilityOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripMenuItem Menu2_VolumeSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem Menu2_Cmd;
        private System.Windows.Forms.ToolStripMenuItem Menu2_ControlPanel;
        private System.Windows.Forms.ToolStripMenuItem MenuSystem;
        private System.Windows.Forms.ToolStripMenuItem Menu5_SysInfo;
        private System.Windows.Forms.ToolStripMenuItem Menu5_CurrentVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem Menu5_InternetProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem Menu5_UserFolder;
        private System.Windows.Forms.ToolStripMenuItem Menu5_WinFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem Menu5_WindowsMobilityCenter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem Menu5_Fonts;
        private System.Windows.Forms.ToolStripMenuItem Menu5_DPISettings;
        private System.Windows.Forms.ToolStripMenuItem Menu5_ColorManagement;
        private System.Windows.Forms.ToolStripMenuItem Menu5_DateTime;
        private System.Windows.Forms.ToolStripMenuItem Menu5_Printers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem Menu5_MouseProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem Menu5_SystemProperties;
        private System.Windows.Forms.ToolStripMenuItem sPECIALTOOLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAutobackup;
        private System.Windows.Forms.ToolStripMenuItem MenuSQLExtractor;
        private System.Windows.Forms.ToolStripMenuItem MenuTests;
        private System.Windows.Forms.ToolStripMenuItem Menu1_Style;
        private System.Windows.Forms.ToolStripMenuItem Menu5_AppDataFolder;
        private System.Windows.Forms.ToolStripMenuItem Menu1_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem Menu1_HideSearchType;
        private System.Windows.Forms.ToolStripMenuItem Menu1_WindowState;
        private System.Windows.Forms.ToolStripMenuItem Menu1_AutoscaleMode;
        private System.Windows.Forms.ToolStripMenuItem Menu1_AutoscaleMode_1;
        private System.Windows.Forms.ToolStripMenuItem Menu1_AutoscaleMode_2;
        private System.Windows.Forms.ToolStripMenuItem Menu1_AutoscaleMode_3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private FlatComboBox ListFolders;
        private System.Windows.Forms.ToolStripMenuItem hibernateFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibernateFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configurationFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem safetyFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safetyFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menu5_ClearIconCache;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subscribeEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu1_CheckNetwork;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        internal System.Windows.Forms.LinkLabel LnkNextQuery;
        internal System.Windows.Forms.LinkLabel LnkPrevQuery;
        private System.Windows.Forms.Label sep10;
        private System.Windows.Forms.Label sep9;
        private System.Windows.Forms.ToolStripMenuItem MTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripMenuItem CMenuTestManager;
        private System.Windows.Forms.ToolStripMenuItem CMenuSqlExtractor;
        private System.Windows.Forms.ToolStripMenuItem CMenuLocalBackup;
        private System.Windows.Forms.ToolStripMenuItem MenuSafeBoard;
        private System.Windows.Forms.ToolStripMenuItem appControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMenuAppControl;
        private System.Windows.Forms.ToolStripMenuItem CMenuSafeboard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator26;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator27;
    }
}
