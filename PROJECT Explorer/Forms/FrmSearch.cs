using HAKROS.Classes;
using HAKROS.Classes.Controls;
using HAKROS.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmSearch : Form
    {

        FrmBackups goFrmBackups = new FrmBackups();
        FrmMarquee goFrmMarquee = new FrmMarquee();
        FrmSafeBoard goFrmSafeBoard = new FrmSafeBoard();

        bool SearchActive = true;

        CancellationTokenSource cts = new CancellationTokenSource();

        List<string> AllowedExtensions = new List<string>();
        List<string> ArrayContentExtensions = new List<string>();

        ParallelOptions parallelOptions = new ParallelOptions();

        string FileContextualMenu = "";

        int ElapsedTimeToCancel = 0;

        bool OpcHideSearchType = false;

        bool IsInit = false;

        private bool LastNetworkStatus = true;
        
        private bool QuerySearchTypeByContent = false;
        private bool QuerySearchTypeByFullPath = false;
        private bool QuerySearchTypeByFileName = false;
        
        //Relation for columns
        const int ColPosFilepath = 0; 
        const int ColPosSolution = 1; 
        const int ColPosProject = 2;  
        const int ColPosFolder = 3;   
        const int ColPosFilename = 4; 
        const int ColPosExtension = 5;
        const int ColPosSize = 6;     
        const int ColPosDate = 7;     

        enum TypeRunAs
        {
            Normal = 0,
            ForceTrue = 1,
            Question = 2
        }

        public FrmSearch()
        {
            InitializeComponent();
            Opacity = 0;
        }

        private void FrmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!ClassGeneral.IsBusy && ClassGeneral.ExitAuthorised)
            {
                SaveRootFolder();
            }
            else
            {
                e.Cancel = true;
                HideApp();
            }
        }

        private void SetHighPriority()
        {
            try
            {
                var pr = Process.GetCurrentProcess();
                if(pr != null)
                {
                    ClassPriorizer.SetNewPriority(pr, ProcessPriorityClass.High, true);
                }
            }
            catch
            {
                //Error !!
            }
        }

        private void FlushMyMemory()
        {
            try
            {
                var pr = Process.GetCurrentProcess();
                if(pr != null)
                {
                    ClassMemory.FlushProcess(pr);
                }
            }
            catch
            {
                //Error !!
            }
        }

        private string GetRootFolder()
        {
            ClassGeneral.RootFolder = ListFolders.Text;
            goFrmBackups.InitWindow();
            return ListFolders.Text;
        }

        private void SaveRootFolder()
        {
            ClassGeneral.SaveRootFolder(GetRootFolder());
        }
        
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            if (!ClassSecurity.InExecution() && ClassSecurity.CheckEula())
            {
                InitApp();
            }
            else
            {
                ClassGeneral.ExitAuthorised = true;
                Application.Exit();
            }
        }

        private void InitApp()
        {

            SetWindowPosition();

            Text = ClassGeneral.GetWindowTitle();
            Icon = ClassGeneral.GetIcon();
            Nicon.Icon = ClassGeneral.GetIcon();

            MTitle.Text = Text;

            ListSolutions.DrawMode = DrawMode.OwnerDrawFixed;
            ListProjects.DrawMode = DrawMode.OwnerDrawFixed;

            LoadCfgStyle();

            LoadCfgNetworkStatus();

            Opacity = 1;

            DoubleBuffered = true;

            SetHighPriority();

            ArrayContentExtensions.Clear();
            ArrayContentExtensions.Add("cs");
            ArrayContentExtensions.Add("xaml");
            ArrayContentExtensions.Add("xaml.cs");
            ArrayContentExtensions.Add("sql");
            ArrayContentExtensions.Add("xsd");
            ArrayContentExtensions.Add("xml");
            ArrayContentExtensions.Add("sln");
            ArrayContentExtensions.Add("resx");
            ArrayContentExtensions.Add("csproj");

            ListFolders.Enabled = false;
            txtInclude.Focus();
            ListFolders.Enabled = true;

            LoadDefaultExtensions();

            LoadToolTips();

            LoadRootFolders();

            DisableTabStop();

            tcontrol.Enabled = true;

            GUIStatus(true);

            EvalGUI();

            Nicon.Text = Text;
            Nicon.Visible = true;

            IsInit = true;
                       
        }

        private void LoadCfgStyle()
        {
            var ok = false;
            try
            {
                var f = ClassGeneral.FileStyle();
                if (File.Exists(f))
                {
                    var style = "";
                    var sr = new StreamReader(f, Encoding.UTF8, true);
                    style = sr.ReadLine();
                    sr.Close();

                    if (style.ToLowerInvariant() == "dark")
                    {
                        SetDark();
                        ok = true;
                    }

                }
            }
            catch
            {
                //Error !!
            }
            if(!ok)
            {
                SetLight();
            }
        }

        private void SaveCfgStyle()
        {
            try
            {
                var f = ClassGeneral.FileStyle();
                var wr = new StreamWriter(f, false, Encoding.UTF8);
                wr.WriteLine((ClassStyle.CurrentStyle == ClassStyle.StyleType.Light) ? "light" : "dark");
                wr.Close();
            }
            catch
            {
                //Error !!
            }
        }

        private void SetWindowPosition()
        {
            //Width = Screen.GetWorkingArea(this).Width - 300;
            Height = Screen.GetWorkingArea(this).Height - 50;
            CenterToScreen();
        }

        private void SelectRootFolder()
        {
            //
            ClassGeneral.IsBusy = true;
            var go = new FrmFolders();
            go.ShowDialog();
            ClassGeneral.IsBusy = false;
            //
            ListFolders.Enabled = false;
            LoadRootFolders();
            ListFolders.Enabled = true;
            //
        }

        private void LoadRootFolders()
        {
            try
            {
                //
                ListFolders.Items.Clear();
                //
                var f1 = ClassGeneral.FileFolders();
                if (File.Exists(f1))
                {
                    var sr = new StreamReader(f1, Encoding.UTF8, true);
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        if(!line.EndsWith("\\"))
                        {
                            line = line + "\\";
                        }
                        if (!ListFolders.Items.Contains(line))
                        {
                            ListFolders.Items.Add(line);
                        }
                    }
                    sr.Close();
                }
                //
                var f2 = ClassGeneral.FileCurrentFolder();
                if (File.Exists(f2))
                {
                    //
                    var sr = new StreamReader(f2, Encoding.UTF8, true);
                    var result = sr.ReadLine();
                    if (!result.EndsWith("\\"))
                    {
                        result = result + "\\";
                    }
                    sr.Close();
                    //
                    var pos = ListFolders.Items.IndexOf(result);
                    //
                    ListFolders.SelectedIndex = pos;
                    //
                }
                //
                if(ListFolders.SelectedIndex == -1 && ListFolders.Items.Count > 0)
                {
                    ListFolders.SelectedIndex = 0;
                }
                //
                GetRootFolder();
                //
                InitFswAutoBackup();
                //
            }
            catch
            {
                //Error !!
            }
        }

        private void SaveCurrentFolder()
        {
            try
            {
                var f = ClassGeneral.FileCurrentFolder();
                var wr = new StreamWriter(f, false, Encoding.UTF8);
                wr.WriteLine(ListFolders.Text);
                wr.Close();
            }
            catch
            {
                //Error !!
            }
        }

        private void GetStructureForCurrentPath(bool reset)
        {
            var go = new FrmGetStructure(reset);
            go.ShowDialog();
        }

        private void ListFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsInit && ListFolders.Enabled)
            {
                var cancel = false;
                if (tbc.TabCount > 0 && ListFolders.Items.Contains(ClassGeneral.RootFolder))
                {
                    if (ClassGeneral.Message("This will close current queries, do you want to continue?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        cancel = true;
                    }
                }
                if (!cancel)
                {
                    ClassGeneral.RootFolder = ListFolders.Text;
                    RemoveAllQueries();
                    SaveCurrentFolder();
                    UpdateTotalBackups();
                    MoveFocusToIncludeFilter();
                    GetStructureForCurrentPath(true);
                }
                else
                {
                    ListFolders.Enabled = false;
                    ListFolders.Text = ClassGeneral.RootFolder;
                    ListFolders.Enabled = true;
                }
            }
        }

        private void UpdateTotalBackups()
        {
            if(IsInit)
            {
                goFrmBackups.UpdateBackupTotal();
            }
        }

        private void ListFolders_Leave(object sender, EventArgs e)
        {
            MoveFocusToIncludeFilter();
        }

        private void ClearFields()
        {
            txtInclude.Text = "";
            txtExclude.Text = "";
            txtFilter.Text = "";
            ListSolutions.Items.Clear();
            ListProjects.Items.Clear();
            txtSelection.Text = "";
            OpcOnFullpath.Checked = true;
            OpcFilterName.Checked = true;
            OpcFilterInclusive.Checked = true;
            LoadDefaultExtensions();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            var dgv = CurrentDGV();
            if (dgv != null && (ListSolutions.Items.Count > 0 || dgv.RowCount > 0))
            {
                ListSolutions.Items.Clear();
                ListProjects.Items.Clear();
                txtSelection.Text = "";
                ClearDGV();
            }
            else
            {
                ClearFields();
                DisposeDGV();
            }
            EvalGUI();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchNow();
        }

        private void chbOnlyFilename_CheckedChanged(object sender, EventArgs e)
        {
            SearchNow();
        }

        private void txtInclude_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchNow();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchNow();
            }
        }

        private string GetFullPath(string f)
        {
            if (!f.Contains(GetRootFolder()))
            {
                f = GetRootFolder() + f;
            }
            return f;
        }
        private string GetRelativePath(string f)
        {
            if (f.Contains(GetRootFolder()))
            {
                f = f.Replace(GetRootFolder(), "");
            }
            return f;
        }

        private void AddNewTabIfNone()
        {
            var dgv = CurrentDGV();
            if(dgv != null && dgv.RowCount == 0)
            {
                //Mantain tab
                UpdateTabNameForCurrentQuery();
                UpdateTabQuery();
            }
            else
            {
                AddNewTab();
            }
        }

        private void UpdateTabQuery()
        {
            var index = tbc.SelectedIndex;
           
            var op1 = OpcSameLine.Checked.ToString();
            var op2 = OpcAllTerms.Checked.ToString();
            var op3 = OpcIndividualTerms.Checked.ToString();
            var op4 = OpcWholeWord.Checked.ToString();
            var op5 = OpcOnContent.Checked.ToString();
            var op6 = OpcOnFullpath.Checked.ToString();
            var op7 = OpcOnFilename.Checked.ToString();
            var op8 = OpcFilterName.Checked.ToString();
            var op9 = OpcFilterPath.Checked.ToString();
            var op10 = OpcFilterInclusive.Checked.ToString();

            var options = op1 + ";" + op2 + ";" + op3 + ";" + op4 + ";" + op5 + ";" + op6 + ";" + op7 + ";" + op8 + ";" + op9 + ";" + op10;

            try
            {
                ArrayDGVFilterOptions.RemoveAt(index);
                ArrayDGVInclude.RemoveAt(index);
                ArrayDGVExclude.RemoveAt(index);
                ArrayDGVExtensions.RemoveAt(index);
                ArrayDGVFilterFilename.RemoveAt(index);

                ArrayDGVFilterOptions.Insert(index, options.ToLowerInvariant());
                ArrayDGVInclude.Insert(index, txtInclude.Text);
                ArrayDGVExclude.Insert(index, txtExclude.Text);
                ArrayDGVExtensions.Insert(index, txtExtensions.Text);
                ArrayDGVFilterFilename.Insert(index, txtFilter.Text);
            }
            catch
            {
                //Error !!
            }

        }
        
        private bool IsFolderDefined()
        {
            var root = GetRootFolder().ToLowerInvariant();
            return Directory.Exists(root);
        }

        private void SearchNow(bool force = false)
        {

            if (IsFolderDefined())
            {
                ClassGeneral.IsBusy = true;
                ClassGeneral.IsSearching = true;

                var ok = true;

                var pth = GetRootFolder();
                var qry = txtInclude.Text.Trim();
                var exc = txtExclude.Text.Trim();

                if(qry != "")
                {

                    if (OpcOnContent.Checked)
                    {
                        if (!force && ClassGeneral.Message("Attention this operation may take a few minutes.\n\nDo you want to continue?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            SearchActive = false;
                            EvalGUI();
                            SearchActive = true;
                            ok = false;
                        }
                    }

                    if (ok)
                    {

                        GetStructureForCurrentPath(false);

                        MessageStatus.Text = "Keep press (Ctrl+Alt+Shift) to cancel search process..";

                        AddNewTabIfNone();

                        GUIStatus(false);

                        ListSolutions.Items.Clear();
                        ListProjects.Items.Clear();

                        ClearDGV();

                        txtSelection.Text = "";

                        SaveHistory();

                        GetAllowedExtenions();

                        Application.DoEvents();

                        while (CurrentDGV().Rows.Count > 0)
                        {
                            Application.DoEvents();
                        }

                        if (Directory.Exists(pth))
                        {

                            var results = new List<string>();

                            ElapsedTimeToCancel = 0;

                            cts = new CancellationTokenSource();
                            parallelOptions.CancellationToken = cts.Token;
                            parallelOptions.MaxDegreeOfParallelism = Environment.ProcessorCount;
                            parallelOptions.MaxDegreeOfParallelism = 1;

                            GetFilesOnFolder(pth, results, qry, exc, OpcOnContent.Checked, OpcOnFilename.Checked, DateTime.Now);

                            cts.Dispose();

                            LoadResults(results);

                        }

                    }

                    if (cts.IsCancellationRequested)
                    {
                        var dgv = CurrentDGV();
                        if (dgv != null && dgv.Rows.Count > 0)
                        {
                            dgv.Sort(dgv.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                            dgv.Rows[0].Selected = true;
                            LoadRow();
                        }
                        ClassGeneral.Message("Process cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    ShowWarningQueryBeforeContinue();
                }

                MessageStatus.Text = "Ready";

                FlushMyMemory();

                Text = ClassGeneral.GetWindowTitle();

                EvalGUI();

                ClassGeneral.IsBusy = false;
                ClassGeneral.IsSearching = false;

                GUIStatus(true);

                TopMost = true;
                TopMost = false;
            }
            else
            {
                WarningRootNotDefined();                
            }

        }

        private void ShowWarningQueryBeforeContinue()
        {
            txtInclude.BackColor = Color.MistyRose;
            ClassGeneral.Message("You must type a query before continue.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInclude.BackColor = Color.Lavender;
        }

        private void LoadResults(List<string> results)
        {
            var dgv = CurrentDGV();
            if (dgv != null)
            {
                try
                {
                    
                    var dt = new DataTable();

                    dt.Columns.Add(new DataColumn("cfilepath", typeof(string)));
                    dt.Columns.Add(new DataColumn("csolution", typeof(string)));
                    dt.Columns.Add(new DataColumn("cproject", typeof(string)));
                    dt.Columns.Add(new DataColumn("cfilefolder", typeof(string)));
                    dt.Columns.Add(new DataColumn("cfilename", typeof(string)));
                    dt.Columns.Add(new DataColumn("cextension", typeof(string)));
                    dt.Columns.Add(new DataColumn("csize", typeof(string)));
                    dt.Columns.Add(new DataColumn("cdate", typeof(string)));

                    foreach (var f in results)
                    {

                        try
                        {
                            if (!string.IsNullOrEmpty(f))
                            {
                                var relativepath = GetRelativePath(f).Replace("src\\", "");
                                var relativedir = Path.GetDirectoryName(relativepath) + "\\";
                                var filename = Path.GetFileName(f);
                                var extension = GetExtension(f).ToUpperInvariant(); // GetMultiExtension(f);

                                var fi = new FileInfo(f);

                                var v0 = f;

                                var v1_solution = "";
                                var v2_project = "";

                                ClassVisualStudio.GetSolutionProjectForFile(f, ref v1_solution, ref v2_project);

                                var v3 = relativedir;
                                var v4 = filename;
                                var v5 = extension;

                                var KB = Math.Round((double)(fi.Length / 1024), 0);
                                if (KB == 0 && fi.Length > 0)
                                {
                                    KB = 1;
                                }
                                var v6 = KB.ToString().PadLeft(5, '0') + " KB";
                                var v7 = fi.LastWriteTime.ToString();

                                if (fi.Length > 0)
                                {
                                    dt.Rows.Add(v0, v1_solution, v2_project, v3, v4, v5, v6, v7);
                                }

                            }
                        }
                        catch
                        {
                            //Error row !
                        }

                    }

                    dgv.Columns.Clear();

                    dgv.DataSource = dt;

                    dgv.Columns[0].HeaderText = "Filepath";
                    dgv.Columns[1].HeaderText = "Solution";
                    dgv.Columns[2].HeaderText = "Project";
                    dgv.Columns[3].HeaderText = "Folder";
                    dgv.Columns[4].HeaderText = "Filename";
                    dgv.Columns[5].HeaderText = "Extension";
                    dgv.Columns[6].HeaderText = "KBytes";
                    dgv.Columns[7].HeaderText = "Date";

                    EvalColumnsVisibility();

                    AddProjectsAndSolutionsFromDGV();

                }
                catch
                {
                    //Error !!
                }

                if (dgv.Rows.Count > 0)
                {
                    dgv.Sort(dgv.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                    dgv.Rows[0].Selected = true;
                    LoadRow();
                }
                else
                {
                    if(!cts.IsCancellationRequested)
                    {
                        ClassGeneral.Message("No results found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void EvalColumnsVisibility()
        {
            var dgv = CurrentDGV();
            if (dgv != null && dgv.ColumnCount > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = WindowState == FormWindowState.Maximized;
                dgv.Columns[2].Visible = WindowState == FormWindowState.Maximized;
                dgv.Columns[3].Visible = true;
                dgv.Columns[4].Visible = true;
                dgv.Columns[5].Visible = true;
                dgv.Columns[6].Visible = true;
                dgv.Columns[7].Visible = true;

                dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private string GetMultiExtension(string f)
        {
            var vs = Path.GetFileName(f).Split('.');
            var multiextension = "";
            var k = 1;
            if (vs.Length > 2)
            {
                while (k < vs.Length)
                {
                    if (multiextension == "")
                    {
                        multiextension = vs[k];
                    }
                    else
                    {
                        multiextension = multiextension + "." + vs[k];
                    }
                    k += 1;
                }
            }
            else if (vs.Length == 2)
            {
                multiextension = vs[1];
            }

            multiextension = multiextension.ToLowerInvariant();

            var total = multiextension.Split('.');

            if (total.Length <= 2)
            {              
                return multiextension;
            }
            else
            {
                return GetExtension(f);
            }
            
        }

        private string GetExtension(string f)
        {
            return Path.GetExtension(f).ToLowerInvariant().Replace(".", "");
        }

        private void SaveHistory()
        {
            var qry = txtInclude.Text.Trim();
            var exc = txtExclude.Text.Trim();
            var fltr = txtFilter.Text.Trim();

            AddToHistory(txtInclude);
            AddToHistory(txtExclude);
            AddToHistory(txtFilter);

        }

        private void AddToHistory(TextBox tbox)
        {
            var val = tbox.Text.Trim();
            if (!tbox.AutoCompleteCustomSource.Contains(val))
            {
                tbox.AutoCompleteCustomSource.Add(val);
            }
        }

        private void GetAllowedExtenions()
        {
            if(txtExtensions.Text == "" || txtExtensions.Text.Contains("*"))
            {
                txtExtensions.Text = "*";
            }
            var exts = txtExtensions.Text.Split(',');
            AllowedExtensions.Clear();
            foreach(var ext in exts)
            {
                var extlwr = ext.ToLowerInvariant().Trim();
                if(extlwr != "")
                {
                    AllowedExtensions.Add(extlwr);
                }
            }
        }

        private void CheckCancelation()
        {
            ElapsedTimeToCancel = (ClassKeyControl.CheckCtrlKey() && ClassKeyControl.CheckAltKey() && ClassKeyControl.CheckShiftKey()) ? ElapsedTimeToCancel + 1 : 0;
            if (ElapsedTimeToCancel > 1 && !cts.IsCancellationRequested)
            {
                cts.Cancel();
            }
        }

        private void GetFilesOnFolder(string pth, List<string> results, string qry, string exc, bool onContent, bool onFilename, DateTime date)
        {

            try
            {

                CheckForIllegalCrossThreadCalls = false;

                var allTerms = OpcAllTerms.Visible && OpcAllTerms.Checked;
                var sameLine = OpcSameLine.Visible && OpcSameLine.Checked;

                Parallel.ForEach(Directory.GetDirectories(pth, "*", SearchOption.TopDirectoryOnly), parallelOptions, d =>
                {
                    Parallel.ForEach(Directory.GetFiles(d, "*.*", SearchOption.TopDirectoryOnly), parallelOptions, f =>
                    {

                        if(d.Length < 248 && f.Length < 248)
                        {
                            CheckForIllegalCrossThreadCalls = false;

                            CheckCancelation();

                            var fext = GetExtension(f);
                            if (AllowedExtensions.Contains("*") || AllowedExtensions.Contains(fext))
                            {

                                var filename = Path.GetFileNameWithoutExtension(f);
                                var filepathlower = f.ToLowerInvariant();
                                var filenamelower = Path.GetFileNameWithoutExtension(filepathlower);
                                var include = qry.ToLowerInvariant();
                                var exclude = exc.ToLowerInvariant();

                                if ((DateTime.Now - date).TotalSeconds > 1)
                                {
                                    Text = "Files found [" + results.Count + "] - Searching (" + filename + ")..";
                                    Application.DoEvents();
                                }

                                if (onContent)
                                {
                                    try
                                    {

                                        if (File.Exists(filepathlower))
                                        {
                                            var ext = GetExtension(filepathlower);

                                            if (ArrayContentExtensions.Contains(ext))
                                            {
                                                var content = GetContentFromFile(filepathlower);
                                                if (content != "")
                                                {
                                                    if (exclude != "")
                                                    {
                                                        if (!ContainsTerms(content, exclude, sameLine, allTerms) && ContainsTerms(content, include, sameLine, allTerms))
                                                        {
                                                            AddToResults(results, f);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (ContainsTerms(content, include, sameLine, allTerms))
                                                        {
                                                            AddToResults(results, f);
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                    catch
                                    {
                                        //Error
                                    }
                                }
                                else
                                {
                                    var filesearch = onFilename ? filenamelower : filepathlower;

                                    if (ContainsTerms(filesearch, include, sameLine, allTerms))
                                    {
                                        if (exclude != "")
                                        {
                                            if (!filesearch.Contains(exclude) && ContainsTerms(filesearch, include, sameLine, allTerms))
                                            {
                                                AddToResults(results, f);
                                            }
                                        }
                                        else
                                        {
                                            if (ContainsTerms(filesearch, include, sameLine, allTerms))
                                            {
                                                AddToResults(results, f);
                                            }
                                        }
                                    }
                                }

                            }

                            parallelOptions.CancellationToken.ThrowIfCancellationRequested();

                        }

                    });

                    //Recursive call
                    GetFilesOnFolder(d, results, qry, exc, onContent, onFilename, DateTime.Now);
                    parallelOptions.CancellationToken.ThrowIfCancellationRequested();

                });

            }
            catch (PathTooLongException)
            {
                //Path too long
            }
            catch (OperationCanceledException)
            {
                //Cancelled
            }
            catch
            {
                //Error !
            }
            
        }

        private static string GetContentFromFile(string path)
        {
            var content = "";
            try
            {
                if (File.Exists(path))
                {
                    var sr = new StreamReader(path, Encoding.UTF8, true);
                    content = sr.ReadToEnd().ToLowerInvariant();
                    sr.Close();
                }
            }
            catch
            {
                //Error !!
            }
            return content;
        }

        private void AddToResults(List<string> results, string filepath)
        {
            var filter = txtFilter.Text.Trim();
            if (filter != "")
            {
                var relativepath = GetRelativePath(filepath);
                var filepathlower = relativepath.ToLowerInvariant();
                var filenamelower = Path.GetFileName(filepathlower);
                var filterlower = filter.ToLowerInvariant();

                var terms = filterlower.Split(' ');

                var arrayTermInclude = new List<string>();
                var arrayTermExclude = new List<string>();

                foreach (var term in terms)
                {
                    var auxterm = term.Trim();
                    if(auxterm != "")
                    {
                        if (auxterm.StartsWith("-"))
                        {
                            auxterm = auxterm.Substring(1);
                            arrayTermExclude.Add(auxterm);
                        }
                        else
                        {
                            if (auxterm.StartsWith("+"))
                            {
                                auxterm = auxterm.Substring(1);
                            }
                            arrayTermInclude.Add(auxterm);
                        }
                    }
                }

                var arrayBoolInclude = new List<bool>();
                var arrayBoolExclude = new List<bool>();

                foreach (var term in arrayTermExclude)
                {
                    var containsTerm = false;
                    if(term.StartsWith("^"))
                    {
                        var newterm = term.Replace("^", "").ToLowerInvariant();
                        var filename = Path.GetFileNameWithoutExtension(filepathlower);
                        containsTerm = filename.StartsWith(newterm);
                    }
                    else
                    {
                        containsTerm = OpcFilterPath.Checked ? filepathlower.Contains(term) : filenamelower.Contains(term);
                    }
                    arrayBoolExclude.Add(containsTerm);
                }

                foreach (var term in arrayTermInclude)
                {
                    var containsTerm = false;
                    if (term.StartsWith("^"))
                    {
                        var newterm = term.Replace("^", "").ToLowerInvariant();
                        var filename = Path.GetFileNameWithoutExtension(filepathlower);
                        containsTerm = filename.StartsWith(newterm);
                    }
                    else
                    {
                        containsTerm = OpcFilterPath.Checked ? filepathlower.Contains(term) : filenamelower.Contains(term);
                    }
                    arrayBoolInclude.Add(containsTerm);
                }

                var AddCondition = false;

                if (OpcFilterInclusive.Checked)
                {
                    AddCondition = !arrayBoolInclude.Contains(false) && !arrayBoolExclude.Contains(true);
                }
                else
                {
                    AddCondition = arrayBoolInclude.Contains(true) && !arrayBoolExclude.Contains(true);
                }

                if (AddCondition)
                {
                    results.Add(filepath);
                }

            }
            else
            {
                results.Add(filepath);
            }
        }

        private string FilterSymbols(string qr)
        {
            //char[] arr = qr.Where(c => (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-')).ToArray();
            //char[] arr = qr.Where(c => (char.IsLetterOrDigit(c))).ToArray();
            //var res = new string(arr);
            //return res;
            return qr;
        }

        private bool ContainsTerms(string input, string qry, bool sameLine, bool allTerms)
        {
            var result = true;

            if (OpcOnContent.Checked)
            {
                var indexes = new List<int>();
                if (OpcIndividualTerms.Checked)
                {
                    var qrs = qry.Split(' ');
                    foreach (var qr in qrs)
                    {
                        if (input.Contains(qr))
                        {
                            var qrnosymbols = FilterSymbols(qr);
                            var auxIndexes = GetIndexesForQuery(input, OpcWholeWord.Checked, qrnosymbols);
                            foreach(var i in auxIndexes)
                            {
                                if(i != -1)
                                {
                                    indexes.Add(i);
                                }
                            }
                        }

                    }
                }
                else
                {
                    if (input.Contains(qry))
                    {
                        indexes = GetIndexesForQuery(input, OpcWholeWord.Checked, qry);
                    }
                }
                result = indexes.Count > 0;

                if (result && allTerms)
                {
                    //Must contains all terms
                    result = ContainsAllTerms(input, qry);
                }

                if (result && sameLine)
                {
                    //Results must be on same line
                    var validlines = new List<int>();
                    try
                    {
                        var rtb = new RichTextBox();
                        rtb.WordWrap = false;
                        rtb.Text = input;

                        //foreach (var index in indexes)
                        //{
                        //    if(index >= 0)
                        //    {
                        //        var lineIndex = rtb.GetLineFromCharIndex(index);
                        //        var lineContentForIndex = rtb.Lines[lineIndex];
                        //        if (ContainsAllTerms(lineContentForIndex, qry))
                        //        {
                        //            validlines.Add(lineIndex);
                        //        }
                        //    }
                        //}
                       
                        int kline = 0;
                        foreach(var line in rtb.Lines)
                        {
                            if (ContainsAllTerms(line, qry))
                            {
                                validlines.Add(kline);
                                break;
                            }
                            kline += 1;
                        }

                    }
                    catch
                    {
                        //Error !!
                    }
                    result = validlines.Count > 0;
                }

            }
            else
            {
                var vs = qry.Split(' ');
                foreach (var v in vs)
                {
                    if (!input.Contains(qry))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private bool ContainsAllTerms(string input, string qry)
        {
            var res = true;
            var qrs = qry.Split(' ');
            var wholeword = OpcWholeWord.Checked;
            foreach (var qr in qrs)
            {
                var qrnosymbols = FilterSymbols(qr);
                var indexes = GetIndexesForQuery(input, wholeword, qrnosymbols);
                if (indexes.Count == 0)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }

        private List<int> GetIndexesForQuery(string input, bool wholeWord, string qry)
        {
            qry = qry.Trim();
            var indexes = new List<int>();
            if (wholeWord)
            {
                indexes = ClassAllIndexes.AllIndexesOfWholeWord(input, qry).ToList();
            }
            else
            {
                indexes = ClassAllIndexes.AllIndexesOf(input, qry).ToList();
            }
            if(indexes.Count == 1 && indexes[0] == -1)
            {
                indexes.Clear();
            }
            return indexes;
        }
        
        private void SelectSolutionForProject()
        {
            var currentprj = ListProjects.Text;
            var k = 0;
            foreach(var prj in ClassVisualStudio.CurrentFilesProject)
            {
                var auxprj = Path.GetFileNameWithoutExtension(prj);
                if(auxprj.ToLowerInvariant() == currentprj.ToLowerInvariant())
                {
                    var solution = ClassVisualStudio.CurrentFilesSolution[k];
                    solution = Path.GetFileNameWithoutExtension(solution);
                    var j = ListSolutions.Items.IndexOf(solution);
                    ListSolutions.SelectedIndex = j;
                    if(ListSolutions.SelectedIndex != -1)
                    {
                        break;
                    }
                }
                k += 1;
            }
        }

        private void listProjects_Click(object sender, EventArgs e)
        {
            if(ListProjects.Text != "")
            {
                SelectSolutionForProject();
            }
        }

        private void LnkAllFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtExtensions.Text = "*";
        }

        private void LnkRestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDefaultExtensions();
        }

        private void LoadDefaultExtensions()
        {
            txtExtensions.Text = "cs,xaml,xml,resx,sln,csproj,sql";
        }

        private void LoadToolTips()
        {

            help.SetToolTip(OpcSameLine, "All terms must be on the same line.");
            help.SetToolTip(OpcAllTerms, "File must include all terms.");
            help.SetToolTip(OpcIndividualTerms, "Each term separated with a blank will be searched separately.");
            help.SetToolTip(OpcWholeWord, "File must include whole words.");
            help.SetToolTip(OpcOnContent, "Search on file content.");
            help.SetToolTip(OpcOnFullpath, "Search on filepath.");
            help.SetToolTip(OpcOnFilename, "Search on filename.");
            help.SetToolTip(OpcFilterPath, "Filter by filepath.");
            help.SetToolTip(OpcFilterName, "Filter by filename.");
            help.SetToolTip(OpcFilterInclusive, "Query must satisfy all filters");

            var nl = Environment.NewLine;
            help.SetToolTip(txtFilter, "+term to include" + nl + "-term to exclude" + nl + "^term to startswith");

        }

        private void EvalGUI()
        {

            tbc.Visible = tbc.TabCount > 0;

            tSolutions.Text = "Solutions (" + ListSolutions.Items.Count + ")";
            tProjects.Text = "Projects (" + ListProjects.Items.Count + ")";
            tQueries.Text = "Queries (" + (ListQueries.SelectedIndex + 1) + "/" + ListQueries.Items.Count + ")";

            var dgv = CurrentDGV();

            if (dgv != null && dgv.RowCount > 0)
            {
                ClassStyle.ApplyStyle(ListQueries);
            }
            else
            {
                ClassStyle.ApplyStyle(ListQueries);
                ListQueries.ForeColor = IsLight() ? Color.Red : Color.Yellow;
            }

            tResults.Text = (dgv != null) ? "Results (" + dgv.Rows.Count + ")" : "Results (0)";
            
            OpcWholeWord.Visible = OpcOnContent.Checked;
            OpcIndividualTerms.Visible = OpcOnContent.Checked;
            OpcAllTerms.Visible = OpcIndividualTerms.Checked;
            OpcSameLine.Visible = OpcAllTerms.Checked;

            if (!OpcWholeWord.Visible)
            {
                OpcWholeWord.Checked = false;
            }
            if (!OpcIndividualTerms.Visible)
            {
                OpcIndividualTerms.Checked = false;
            }
            if (!OpcAllTerms.Visible)
            {
                OpcAllTerms.Checked = false;
            }
            if (!OpcSameLine.Visible)
            {
                OpcSameLine.Checked = false;
            }

            sep1.Visible = OpcOnContent.Checked;

            ClassStyle.ApplyStyleForListbox(ListSolutions);
            ClassStyle.ApplyStyleForListbox(ListProjects);

            ClassStyle.ApplyStyleForSeparator(sep1);
            ClassStyle.ApplyStyleForSeparator(sep5);
            ClassStyle.ApplyStyleForSeparator(sep6);
            ClassStyle.ApplyStyleForSeparator(sep7);
            ClassStyle.ApplyStyleForSeparator(sep8);
            ClassStyle.ApplyStyleForSeparator(sep9);
            ClassStyle.ApplyStyleForSeparator(sep10);

            ClassStyle.ApplyStyleForCheckbox(OpcWholeWord);
            ClassStyle.ApplyStyleForCheckbox(OpcIndividualTerms);
            ClassStyle.ApplyStyleForCheckbox(OpcAllTerms);
            ClassStyle.ApplyStyleForCheckbox(OpcSameLine);
            ClassStyle.ApplyStyleForCheckbox(OpcFilterInclusive);

            ClassStyle.ApplyStyleForRadiobutton(OpcOnContent);
            ClassStyle.ApplyStyleForRadiobutton(OpcOnFullpath);
            ClassStyle.ApplyStyleForRadiobutton(OpcOnFilename);
            ClassStyle.ApplyStyleForRadiobutton(OpcFilterPath);
            ClassStyle.ApplyStyleForRadiobutton(OpcFilterName);
            
            ClassStyle.ApplyStyleForPanelTBC(PanelTBC);

            ClassStyle.ApplyStyle(ListSolutions);
            ClassStyle.ApplyStyle(ListProjects);

            EvalSearchType();

            ClassStyle.ApplyStyleMenuStrip(MainMenu, Color.Gainsboro, Color.Black);

            var dgvVisible = (dgv != null) ? dgv.RowCount > 0 : false;

            LnkRestoreColors.Visible = dgvVisible;
            LnkColorizeRows.Visible = dgvVisible;
            LnkExportToText.Visible = dgvVisible;
            LnkExportToExcel.Visible = dgvVisible;

            sep6.Visible = dgvVisible;
            sep7.Visible = dgvVisible;
            sep8.Visible = dgvVisible;

            ListQueries.Enabled = ListQueries.Items.Count > 0;
            LinkCloseQuery.Visible = ListQueries.Items.Count > 0;
            LnkPrevQuery.Visible = ListQueries.Items.Count > 0;
            LnkNextQuery.Visible = ListQueries.Items.Count > 0;
            sep9.Visible = ListQueries.Items.Count > 0;
            sep10.Visible = ListQueries.Items.Count > 0;

            LnkPrevQuery.Enabled = ListQueries.SelectedIndex > 0;
            LnkNextQuery.Enabled = ListQueries.SelectedIndex < ListQueries.Items.Count - 1;

            EvalCM();

        }

        private void EvalCM()
        {
            if(FileContextualMenu == "")
            {
                GetRowFilepath();
            }

            CMFileName.Text = "";
            CMFileName.Visible = false;
            CMFilenameSeparator.Visible = false;
            OpcViewResults.Enabled = false;
            OpcViewFolder.Enabled = false;
            OpcViewFile.Enabled = false;

            if (File.Exists(FileContextualMenu))
            {
                CMFileName.Text = Path.GetFileName(FileContextualMenu);
                CMFileName.Visible = true;
                CMFilenameSeparator.Visible = true;
                OpcViewResults.Visible = true;
                OpcViewResults.Enabled = true;
                OpcViewFolder.Enabled = true;
                OpcViewFile.Enabled = true;
            }
        }

        private void GUIStatus(bool status)
        {
            MainMenu.Enabled = status;
            PanelMain.Enabled = status;
            Application.DoEvents();
        }

        private void DisableTabStop()
        {
            foreach (Control ctrl in PanelMain.Controls)
            {
                ctrl.TabStop = ctrl is TextBox;
            }
        }
        
        private void ShowDetailsForFile(int r)
        {

            var query = txtInclude.Text;

            var f = GetRowFilepath(r);
            var solution = CurrentDGV().Rows[r].Cells[ColPosSolution].Value.ToString();
            var project = CurrentDGV().Rows[r].Cells[ColPosProject].Value.ToString();

            if (!QuerySearchTypeByContent)
            {
                query = "";
            }

            var DetailsBackColor = Color.Black;
            var DetailsForeColor = Color.White;

            if (QuerySearchTypeByContent)
            {
                DetailsBackColor = IsLight() ? Color.Firebrick : Color.Crimson;
                DetailsForeColor = IsLight() ? Color.White : Color.White;
            }
            else if (QuerySearchTypeByFullPath)
            {
                DetailsBackColor = IsLight() ? Color.Green : Color.SpringGreen;
                DetailsForeColor = IsLight() ? Color.White : Color.Black;
            }
            else if (QuerySearchTypeByFileName)
            {
                DetailsBackColor = IsLight() ? Color.Blue : Color.DodgerBlue;
                DetailsForeColor = IsLight() ? Color.White : Color.White;
            }

            var go = new FrmSearchDetails(f, solution, project, query, OpcWholeWord.Checked, OpcIndividualTerms.Checked, OpcAllTerms.Checked, OpcSameLine.Checked, DetailsBackColor, DetailsForeColor);
            if (go.ShowDialog() == DialogResult.OK)
            {
                if (go.RequestFind != "")
                {

                    if (go.RequestFindType > 0)
                    {

                        AddNewTab();
                        ClearFields();
                        txtInclude.Text = go.RequestFind;
                        if (go.RequestFindType == 1)
                        {
                            OpcOnContent.Checked = true;
                        }
                        else if (go.RequestFindType == 2)
                        {
                            OpcOnFullpath.Checked = true;
                        }
                        else if (go.RequestFindType == 3)
                        {
                            OpcOnFilename.Checked = true;
                        }
                        EvalGUI();
                        SearchNow(true);
                    }
                    else
                    {
                        //only add to textbox
                        txtInclude.Text = go.RequestFind;
                    }

                }
            }

        }

        private void LoadFile()
        {
            var r = GetSelectRowIndex();
            if (r != -1)
            {
                var dgv = CurrentDGV();
                ColorizeRow(dgv, r, Color.LightSalmon);
                ShowDetailsForFile(r);
            }
        }

        private void listSolutions_DoubleClick(object sender, EventArgs e)
        {
            LoadSolutionFolder();
        }

        private void listProjects_DoubleClick(object sender, EventArgs e)
        {
            LoadSolutionFolder();
        }

        private void LoadSolutionFolder()
        {
            if (ListSolutions.SelectedIndex != -1 && ListSolutions.Text != "")
            {

                var fsolution = "";

                foreach (var slnPath in ClassVisualStudio.CurrentFilesSolution)
                {
                    var slnName = Path.GetFileNameWithoutExtension(slnPath);
                    if(slnName.ToLowerInvariant() == ListSolutions.Text.ToLowerInvariant())
                    {
                        fsolution = slnPath;
                        break;
                    }
                }

                if (File.Exists(fsolution))
                {
                    var sol = ListSolutions.Text.Trim();
                    if(sol != "")
                    {
                        var m = "Do you want to load this solution?" + Environment.NewLine + Environment.NewLine + "'" + sol + "'";
                        if (ClassGeneral.Message(m, "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question, true) == DialogResult.Yes)
                        {
                            ClassExecute.ExecutePath(fsolution, "", false);
                        }
                    }
                }
            }
        }

        private void opcSearch0_CheckedChanged(object sender, EventArgs e)
        {
            if (txtInclude.Text != "" && OpcOnContent.Checked && SearchActive)
            {
                EvalGUI();
            }
        }

        private void opcSearch1_CheckedChanged(object sender, EventArgs e)
        {
            if (OpcOnFullpath.Checked && SearchActive)
            {
                EvalGUI();
            }
        }

        private void opcSearch2_CheckedChanged(object sender, EventArgs e)
        {
            if(OpcOnFilename.Checked && SearchActive)
            {
                EvalGUI();
            }
        }

        private void EvalGui_CheckedChanged(object sender, EventArgs e)
        {
            EvalGUI();
        }
        private void OpcAllTerms_CheckedChanged(object sender, EventArgs e)
        {
            EvalGUI();
        }

        private void OpcSameLine_CheckedChanged(object sender, EventArgs e)
        {
            EvalGUI();
        }
        private void OpcFilterInclusive_CheckedChanged(object sender, EventArgs e)
        {
            EvalGUI();
        }

        private int GetSelectRowIndex()
        {
            var dgv = CurrentDGV();
            if(dgv != null)
            {
                var r = 0;
                while (r < dgv.RowCount)
                {
                    if (dgv.Rows[r].Selected)
                    {
                        return r;
                    }
                    r += 1;
                }
            }
            return -1;
        }

        private string GetRowFilepath(int r = -1)
        {
            if (r == -1) r = GetSelectRowIndex();
            if (r != -1)
            {
                return CurrentDGV().Rows[r].Cells[ColPosFilepath].Value.ToString();
            }
            else {
                return "";
            }
        }

        private void LoadRow()
        {
            var filepath = GetRowFilepath();
            if (File.Exists(filepath))
            {
                txtSelection.Text = Path.GetFileName(filepath);
              
                var r = GetSelectRowIndex();

                var solution = CurrentDGV().Rows[r].Cells[ColPosSolution].Value.ToString();
                var project = CurrentDGV().Rows[r].Cells[ColPosProject].Value.ToString();

                ListProjects.Text = project;
                ListSolutions.Text = solution;

                if (project == "")
                {
                    ListProjects.SelectedIndex = -1;
                }

                if (solution == "")
                {
                    ListSolutions.SelectedIndex = -1;
                }

            }
            else
            {
                txtSelection.Text = "";
                ListProjects.SelectedIndex = -1;
                ListSolutions.SelectedIndex = -1;
            }
        }

        private void opcAutoClose_CheckedChanged(object sender, EventArgs e)
        {
            EvalGUI();
        }

        private void opcSearch0_Click(object sender, EventArgs e)
        {
            EvalGUI();
        }

        private void LnkExportToExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToExcel();
        }

        private void LnkExportResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToText();
        }

        private void ExportToExcel()
        {
            try
            {
                var ftemp = Path.GetTempFileName() + ".csv";
                using (var wr = new StreamWriter(ftemp, false, Encoding.UTF8))
                {
                    var r = 0;
                    while (r < CurrentDGV().RowCount)
                    {
                        var path1 = CurrentDGV().Rows[r].Cells[ColPosFolder].Value.ToString();
                        var path2 = CurrentDGV().Rows[r].Cells[ColPosFilename].Value.ToString();
                        wr.WriteLine(path1 + ";" + path2);
                        r += 1;
                    }
                }
                ClassExecute.LoadPath(ftemp);
            }
            catch
            {
                ShowErrorExportResults();
            }
        }

        private void ExportToText()
        {
            try
            {
                var ftemp = Path.GetTempFileName() + ".txt";
                using(var wr = new StreamWriter(ftemp, false, Encoding.UTF8))
                {
                    var r = 0;
                    while (r < CurrentDGV().RowCount)
                    {
                        var filepath = GetRowFilepath(r);
                        wr.WriteLine(filepath);
                        r += 1;
                    }
                }
                ClassExecute.LoadPath(ftemp);
            }
            catch
            {
                ShowErrorExportResults();
            }
        }

        private void ShowErrorExportResults()
        {
            ClassGeneral.Message("An error occurred exporting results.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void LnkClipboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CopyToClipboard();
        }

        private void CopyToClipboard()
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtSelection.Text);
            }
            catch
            {
                //Error !
            }
        }

        private void txtSelection_TextChanged(object sender, EventArgs e)
        {
            LnkClipboard.Visible = txtSelection.Text != "";
        }

        private void OpcViewResults_Click(object sender, EventArgs e)
        {
            var dgv = CurrentDGV();
            if(dgv != null)
            {
                var r = 0;
                while(r < dgv.RowCount)
                {
                    var f = GetRowFilepath(r);
                    if(f.ToLowerInvariant() == FileContextualMenu.ToLowerInvariant())
                    {
                        ShowDetailsForFile(r);
                        break;
                    }
                    r += 1;
                }
            }
        }

        private void OpcViewFolder_Click(object sender, EventArgs e)
        {
            ClassGeneral.LoadFolder(FileContextualMenu);
        }

        private void OpcViewFile_Click(object sender, EventArgs e)
        {
            ClassGeneral.LoadFile(FileContextualMenu);
        }

        private void tbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!ClassGeneral.IsBusy)
            {
                GetQueryDGVOptions();

                ListSolutions.Items.Clear();
                ListProjects.Items.Clear();

                AddProjectsAndSolutionsFromDGV();

                LoadRow();
            }
            EvalGUI();
        }

        private void AddProjectsAndSolutionsFromDGV()
        {
            var dgv = CurrentDGV();
            if (dgv != null)
            {
                var r = 0;
                while (r < dgv.RowCount)
                {
                    var solution = CurrentDGV().Rows[r].Cells[ColPosSolution].Value.ToString();
                    var project = CurrentDGV().Rows[r].Cells[ColPosProject].Value.ToString();
                    if (solution != "" && !ListSolutions.Items.Contains(solution))
                    {
                        ListSolutions.Items.Add(solution);
                    }
                    if (project != "" && !ListProjects.Items.Contains(project))
                    {
                        ListProjects.Items.Add(project);
                    }
                    r += 1;
                }
            }
        }

        private void BtnSelectRoot_Click(object sender, EventArgs e)
        {
            SelectRootFolder();
        }

        private void BtnLoadRoot_Click(object sender, EventArgs e)
        {
            var root = GetRootFolder();
            if(Directory.Exists(root))
            {
                ClassExecute.LoadPath(root);
            }
            else
            {
                WarningRootNotDefined();
            }
        }

        private void listSolutions_MouseClick(object sender, MouseEventArgs e)
        {
            //No unselect project list because load solution no works
        }

        private void WarningRootNotDefined()
        {
            ListFolders.BackColor = IsLight() ? Color.MistyRose : Color.Orange;
            ListFolders.ForeColor = IsLight() ? Color.Black : Color.Black;
            ClassGeneral.Message("Solution folder not found, you must define it before continue.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ClassStyle.ApplyStyle(ListFolders);
        }

        #region TABS

        List<string> ArrayDGVFilterOptions = new List<string>();
        List<string> ArrayDGVInclude = new List<string>();
        List<string> ArrayDGVExclude = new List<string>();
        List<string> ArrayDGVExtensions = new List<string>();
        List<string> ArrayDGVFilterFilename = new List<string>();

        private void ArrayRemoveFromPosition(List<string> array)
        {
            if(tbc.RowCount > 0)
            {
                try
                {
                    var k = tbc.TabCount + 1;
                    while (k < array.Count)
                    {
                        array.RemoveAt(k);
                        k += 1;
                    }
                }
                catch
                {
                    //Error !!
                }
            }
            else
            {
                array.Clear();
            }
        }

        private void UpdateArrays()
        {
            ArrayRemoveFromPosition(ArrayDGVFilterOptions);
            ArrayRemoveFromPosition(ArrayDGVInclude);
            ArrayRemoveFromPosition(ArrayDGVExclude);
            ArrayRemoveFromPosition(ArrayDGVExtensions);
            ArrayRemoveFromPosition(ArrayDGVFilterFilename);
        }

        private void GetQueryDGVOptions()
        {
            try
            {

                //UpdateArrays();

                var index = tbc.SelectedIndex;

                var options = ArrayDGVFilterOptions[index].ToString().Split(';');

                var queryInclude = ArrayDGVInclude[index].ToString();
                var queryExclude = ArrayDGVExclude[index].ToString();
                var queryExtensions = ArrayDGVExtensions[index].ToString();
                var queryFilter = ArrayDGVFilterFilename[index].ToString();

                if(options.Count() == 10)
                {

                    var op1 = options[0].ToString().ToLowerInvariant() == "true";
                    var op2 = options[1].ToString().ToLowerInvariant() == "true";
                    var op3 = options[2].ToString().ToLowerInvariant() == "true";
                    var op4 = options[3].ToString().ToLowerInvariant() == "true";

                    //These fields are dependent one of each other
                    OpcIndividualTerms.Checked = op3;
                    OpcAllTerms.Checked = op2;
                    OpcSameLine.Checked = op1;

                    OpcWholeWord.Checked = op4;

                    OpcOnContent.Checked = options[4].ToString().ToLowerInvariant() == "true";
                    OpcOnFullpath.Checked = options[5].ToString().ToLowerInvariant() == "true";
                    OpcOnFilename.Checked = options[6].ToString().ToLowerInvariant() == "true";
                    OpcFilterPath.Checked = options[7].ToString().ToLowerInvariant() == "true";
                    OpcFilterName.Checked = options[8].ToString().ToLowerInvariant() == "true";

                    OpcFilterInclusive.Checked = options[9].ToString().ToLowerInvariant() == "true";
                    
                }

                QuerySearchTypeByContent = OpcOnContent.Checked;
                QuerySearchTypeByFullPath = OpcOnFullpath.Checked;
                QuerySearchTypeByFileName = OpcOnFilename.Checked;

                txtInclude.Text = queryInclude;
                txtExclude.Text = queryExclude;
                txtExtensions.Text = queryExtensions;
                txtFilter.Text = queryFilter;

                EvalGUI();

            }
            catch
            {
                //Error !!
            }
        }
               
        private string RemoveMultipleBlanks(string str)
        {
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            return str;
        }

        private string GetTabNameForCurrentQuery()
        {
            var qrymessage = "";

            var textTab = "";

            if (txtInclude.Text != "")
            {
                textTab = txtInclude.Text.ToLowerInvariant().Trim();
                textTab = RemoveMultipleBlanks(textTab);
                qrymessage += "+[" + textTab + "] ";
            }
            if (txtExclude.Text != "")
            {
                textTab = txtExclude.Text.ToLowerInvariant().Trim();
                textTab = RemoveMultipleBlanks(textTab);
                qrymessage += "-[" + textTab + "] ";
            }
            if (txtFilter.Text != "")
            {

                var TypeFilter = OpcFilterPath.Checked ? "PATH" : "NAME";
                var IncludeAll = OpcFilterInclusive.Checked ? "**" : "*";

                var words = txtFilter.Text.ToLowerInvariant().Split(' ');
                var finalFilter = "";

                foreach(var w in words)
                {
                    if(w.Trim() != "")
                    {
                        if (!w.StartsWith("+") && !w.StartsWith("-"))
                        {
                            finalFilter = finalFilter + "+" + w + " ";
                        }
                        else
                        {
                            finalFilter = finalFilter + w + " ";
                        }
                    }
                }

                qrymessage += IncludeAll + TypeFilter + "[" + finalFilter.Trim() + "] ";
            }

            var searchMode = "";

            if(OpcOnContent.Checked)
            {
                searchMode = "Content";
            }
            else if(OpcOnFullpath.Checked)
            {
                searchMode = "Filepath";
            }
            else
            {
                searchMode = "Filename";
            }

            var dt = DateTime.Now.ToShortDateString();
            var tm = DateTime.Now.ToLongTimeString();

            return "[" + dt + "] [" + tm + "] " + searchMode + " " + qrymessage;

        }

        private void UpdateTabNameForCurrentQuery()
        {
            var tp = tbc.SelectedTab;
            if(tp != null)
            {
                tp.Text = GetTabNameForCurrentQuery();
                ListQueries.Items.RemoveAt(tbc.SelectedIndex);
                ListQueries.Items.Insert(tbc.SelectedIndex, tp.Text);
                ListQueries.SelectedIndex = tbc.SelectedIndex;
            }
        }

        private void AddNewTab()
        {
            try
            {

                var TabID = (tbc.TabCount+1).ToString();

                var tp = new TabPage();
                tp.Name = "tp" + TabID;
                tp.Text = GetTabNameForCurrentQuery();

                ListQueries.Items.Add(tp.Text);
                ListQueries.SelectedIndex = ListQueries.Items.Count - 1;

                var dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.Name = "dgv" + TabID;
                dgv.ContextMenuStrip = CM;
                
                DGVGridStyle(dgv);
                DGVHeaderStyle(dgv);

                dgv.BackgroundColor = IsLight() ? Color.Beige : ColorTranslator.FromHtml("#222222");

                var bg = IsLight() ? Color.Beige : ColorTranslator.FromHtml("#222222");
                var fc = GetRecommendedInverseColor(bg);
                var selbg = GetSelectionBackcolor(bg);
                var selfc = GetRecommendedInverseColor(selbg);

                dgv.DefaultCellStyle.BackColor = bg;
                dgv.DefaultCellStyle.ForeColor = fc;
                dgv.DefaultCellStyle.SelectionBackColor = selbg;
                dgv.DefaultCellStyle.SelectionForeColor = selfc;

                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.RowHeadersVisible = false;
                dgv.MultiSelect = true;
                dgv.Cursor = Cursors.Hand;
                dgv.ReadOnly = true;

                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.AllowUserToResizeColumns = false;
                dgv.AllowUserToResizeRows = false;

                dgv.SelectionChanged += dgv_SelectionChanged;
                dgv.MouseDoubleClick += dgv_MouseDoubleClick;
                dgv.MouseDown += dgv_MouseDown;
                dgv.Sorted += Dgv_Sorted;

                var ArraySolutions = new List<string>();
                var ArrayProjectsSolutions = new List<string>();

                var op1 = OpcSameLine.Checked.ToString();
                var op2 = OpcAllTerms.Checked.ToString();
                var op3 = OpcIndividualTerms.Checked.ToString();
                var op4 = OpcWholeWord.Checked.ToString();
                var op5 = OpcOnContent.Checked.ToString();
                var op6 = OpcOnFullpath.Checked.ToString();
                var op7 = OpcOnFilename.Checked.ToString();
                var op8 = OpcFilterName.Checked.ToString();
                var op9 = OpcFilterPath.Checked.ToString();
                var op10 = OpcFilterInclusive.Checked.ToString();

                var options = op1 + ";" + op2 + ";" + op3 + ";" + op4 + ";" + op5 + ";" + op6 + ";" + op7 + ";" + op8 + ";" + op9 + ";" + op10;

                ArrayDGVFilterOptions.Add(options.ToLowerInvariant());
                ArrayDGVInclude.Add(txtInclude.Text);
                ArrayDGVExclude.Add(txtExclude.Text);
                ArrayDGVExtensions.Add(txtExtensions.Text);
                ArrayDGVFilterFilename.Add(txtFilter.Text);

                QuerySearchTypeByContent = OpcOnContent.Checked;
                QuerySearchTypeByFullPath = OpcOnFullpath.Checked;
                QuerySearchTypeByFileName = OpcOnFilename.Checked;

                tp.Controls.Add(dgv);
                tbc.TabPages.Add(tp);

                HideTabsHeaders();

                SelectTab(tbc.TabCount - 1);
            }
            catch
            {
                //Error !!
            }
        }

        private void HideTabsHeaders()
        {
            tbc.Appearance = TabAppearance.FlatButtons;
            tbc.ItemSize = new Size(0, 1);
            tbc.SizeMode = TabSizeMode.Fixed;
        }

        private void SelectTab(int index)
        {
            try
            {
                if (index + 1 >= tbc.TabCount)
                {
                    tbc.SelectedIndex = index;
                }
            }
            catch
            {
                //Error !!
            }
        }

        private DataGridView CurrentDGV(int tabIndex = -1)
        {
            if (tbc.TabPages.Count > 0)
            {
                if(tabIndex < 0)
                {
                    tabIndex = tbc.SelectedIndex;
                }
                var tp = tbc.TabPages[tabIndex];
                if(tp.Controls.Count > 0)
                {
                    var dgv = (DataGridView)tp.Controls[0];
                    return dgv;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        private TabPage CurrentTabpage()
        {
            try
            {
                return tbc.TabPages[tbc.SelectedIndex];
            }
            catch
            {
                return null;
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            LoadRow();
            EvalCM();
        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadFile();
        }

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && CurrentDGV().RowCount > 0)
            {
                var hti = CurrentDGV().HitTest(e.X, e.Y);
                if (hti != null && hti.RowIndex != -1)
                {
                    CurrentDGV().ClearSelection();
                    CurrentDGV().Rows[hti.RowIndex].Selected = true;
                    FileContextualMenu = GetRowFilepath(hti.RowIndex);
                    EvalCM();
                }
            }
        }

        private void Dgv_Sorted(object sender, EventArgs e)
        {
            ApplyDataColors();
        }

        private void tbc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    var i = 0;
                    while (i < tbc.TabCount)
                    {
                        if (tbc.GetTabRect(i).Contains(e.Location))
                        {
                            RemoveTab(i);
                            break;
                        }
                        i += 1;
                    }

                    EvalGUI();

                }
            }
            catch
            {
                //Error !!
            }
        }

        private bool RemoveTab(int i)
        {
            var res = false;
            try
            {
                if(tbc.TabCount > 1)
                {
                    //Current tab
                    var isCurrentTab = tbc.SelectedIndex == i;
                    //Remove arrays
                    ArrayDGVFilterOptions.RemoveAt(i);
                    ArrayDGVInclude.RemoveAt(i);
                    ArrayDGVExclude.RemoveAt(i);
                    ArrayDGVExtensions.RemoveAt(i);
                    ArrayDGVFilterFilename.RemoveAt(i);
                    //Clear lists
                    if (isCurrentTab)
                    {
                        ListSolutions.Items.Clear();
                        ListProjects.Items.Clear();
                    }
                    //Remove tab
                    DisposeDGV();
                    tbc.TabPages.Remove(tbc.TabPages[i]);
                    DeleteQuery(i);
                    EvalGUI();
                }
                else
                {
                    RemoveAllQueries();
                }
                res = true;
            }
            catch
            {
                //Error !!
            }
            if (ListQueries.SelectedIndex < ListQueries.Items.Count - 1)
            {
                ListQueries.SelectedIndex = ListQueries.Items.Count - 1;
            }
            return res;
        }

        private void RemoveAllQueries()
        {
            //Remove arrays
            ArrayDGVFilterOptions.Clear();
            ArrayDGVInclude.Clear();
            ArrayDGVExclude.Clear();
            ArrayDGVExtensions.Clear();
            ArrayDGVFilterFilename.Clear();
            //Clear lists
            ListSolutions.Items.Clear();
            ListProjects.Items.Clear();
            //Remove tab
            DisposeDGV();
            tbc.TabPages.Clear();
            ListQueries.Items.Clear();
            //Fields
            ClearFields();
            EvalGUI();
        }

        private void ClearDGV()
        {
            var dgv = CurrentDGV();
            if (dgv != null)
            {
                dgv.DataSource = null;
                RemoveDataColorsForDgvName(dgv.Name);
                dgv.Rows.Clear();
            }
        }

        private void DisposeDGV()
        {
            var dgv = CurrentDGV();
            if (dgv != null)
            {
                dgv.DataSource = null;
                RemoveDataColorsForDgvName(dgv.Name);
                dgv.Rows.Clear();
                dgv.Dispose();
            }
        }

        private void DeleteQuery(int i)
        {
            try
            {
                ListQueries.Items.RemoveAt(i);
                ListQueries.SelectedIndex = tbc.SelectedIndex;
            }
            catch
            {
                //Error !!
            }
        }

        #endregion

        private void FastFilter(string term, bool include)
        {
            var current = include ? "+" + term : "-" + term;
            var reverse = include ? "-" + term : "+" + term;

            var filter = txtFilter.Text.Trim();

            current = current.ToLowerInvariant();
            reverse = reverse.ToLowerInvariant();

            filter = filter.ToLowerInvariant();
            filter = filter.Replace(current, "");
            filter = filter.Replace(reverse, "");

            filter = filter + " " + current;
            filter = filter.Trim();

            while(filter.Contains("  "))
            {
                filter = filter.Replace("  ", " ");
            }

            txtFilter.Text = filter;

        }

        private void backcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter(".xaml.cs", true);
        }

        private void configurationFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter(".config", true);
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("converter", true);
        }
        private void designerCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("designer.cs", true);
        }

        private void dtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("dto", true);
        }

        private void enumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("enums", true);
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("event", true);
        }

        private void helperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("helper", true);
        }

        private void hibernateFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("hbm.xml", true);
        }

        private void interfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("^i", true);
        }

        private void projectFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter(".csproj", true);
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("properties", true);
        }

        private void safetyFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("safety", true);
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("service", true);
        }

        private void utilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("util", true);
        }

        private void validatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("validator", true);
        }

        private void viewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("view", true);
        }

        private void viewmodelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFilter("viewmodel", true);
        }

        //

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FastFilter(".xaml.cs", false);
        }

        private void configurationFilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FastFilter(".config", false);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FastFilter("converter", false);
        }

        private void designerCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FastFilter("designer.cs", false);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FastFilter("dto", false);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FastFilter("enums", false);
        }

        private void eventsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FastFilter("event", false);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FastFilter("helper", false);
        }

        private void hibernateFilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FastFilter("hbm.xml", false);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FastFilter("^i", false);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FastFilter(".csproj", false);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FastFilter("properties", false);
        }

        private void safetyFilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FastFilter("safety", false);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FastFilter("service", false);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FastFilter("util", false);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            FastFilter("validator", false);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            FastFilter("view", false);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FastFilter("viewmodel", false);
        }

        private void MenuClearFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
        }

        private void OpcAutoMinimize_CheckedChanged(object sender, EventArgs e)
        {
            EvalGUI();
        }

        private void ShowSqlExtractor()
        {
            var root = GetRootFolder();
            if (Directory.Exists(root))
            {
                var go = new FrmSqlExtractor(root);
                go.ShowDialog();
            }
            else
            {
                WarningRootNotDefined();
            }
        }

        private void ShowBackupWindow()
        {
            if (IsFolderDefined())
            {
                ClassGeneral.IsBusy = true;
                goFrmBackups.ShowDialog();
                ClassGeneral.IsBusy = false;
            }
            else
            {
                WarningRootNotDefined();
            }
        }

        private void ShowSafeBoard()
        {
            ClassGeneral.IsBusy = true;
            goFrmSafeBoard.ShowDialog();
            ClassGeneral.IsBusy = false;
        }

        private void ShowTests()
        {
            if (!ClassGeneral.LoadTestManager())
            {
                ClassGeneral.Message("PROJECT Test Manager not found at default location.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region BACKUPS

        string[] AutoBackupFilters = new string[] { ".cs", ".xaml", ".xaml.cs", ".xml", ".csproj" };

        private void InitFswAutoBackup()
        {
            try
            {
                var dir = ClassGeneral.RootFolder.ToLowerInvariant();

                var dirSrc = dir + "src\\";

                if (DirectoryExists(dirSrc))
                {
                    dir = dirSrc;
                }

                if (DirectoryExists(dir))
                {
                    FswAutoBackup.EnableRaisingEvents = false;
                    FswAutoBackup.Path = dir;
                    FswAutoBackup.Filter = "*.*";
                    FswAutoBackup.IncludeSubdirectories = true;
                    FswAutoBackup.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    FswAutoBackup.EnableRaisingEvents = true;
                }
                else
                {
                    FswAutoBackup.EnableRaisingEvents = false;
                }
            }
            catch
            {
              //Error
            }
        }

        private void FswAutoBackup_Changed(object sender, FileSystemEventArgs e)
        {
            BackupFile(e.FullPath);
        }

        private void FswAutoBackup_Created(object sender, FileSystemEventArgs e)
        {
            BackupFile(e.FullPath);
        }

        private void FswAutoBackup_Renamed(object sender, RenamedEventArgs e)
        {
            //BackupFile(e.FullPath);
        }

        private bool DirectoryExists(string dir)
        {
            try
            {
                return Directory.Exists(dir) && (dir != "\\");
            }
            catch
            {
                return false;
            }
        }

        private void BackupFile(string fullpath)
        {

            if (goFrmBackups.isActive() && FswAutoBackup.EnableRaisingEvents)
            {
                var now = DateTime.Now;

                var path = fullpath.ToLowerInvariant();

                if (DirectoryExists(path))
                {
                    var di = new DirectoryInfo(path);
                    var fs = di.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                    foreach (var f in fs)
                    {
                        var extension = Path.GetExtension(f.FullName);
                        if (AutoBackupFilters.Contains(extension))
                        {
                            var lastChange = f.LastWriteTime;
                            var diffInSeconds = (now - lastChange).TotalSeconds;
                            if (diffInSeconds <= 5)
                            {
                                InternalBackupFile(f.FullName);
                            }
                        }
                    }
                }
                else if (File.Exists(path))
                {
                    var extension = Path.GetExtension(path);
                    if (AutoBackupFilters.Contains(extension))
                    {
                        InternalBackupFile(path);
                    }
                }
            }
        }

        private void InternalBackupFile(string path)
        {
            if (goFrmBackups.isActive())
            {
                goFrmBackups.BackupFile(path);
            }
        }

        #endregion

        private void tcontrol_Tick(object sender, EventArgs e)
        {
            
            PanelBottom.BackColor = IsLight() ? Color.White : ColorTranslator.FromHtml("#333333");

            if(Directory.Exists(ListFolders.Text))
            {
                if (ClassGeneral.BackupStatus)
                {
                    if (ClassGeneral.BackupTotal > 0)
                    {
                        string totalBackup = (ClassGeneral.BackupVisible + "/" + ClassGeneral.BackupTotal).ToString();
                        LblBackupStatus.Text = "Local backup is enabled [" + totalBackup + "]";
                        LblBackupStatus.LinkColor = IsLight() ? Color.Green : Color.SpringGreen;
                    }
                    else
                    {
                        LblBackupStatus.Text = "Local backup is enabled";
                        LblBackupStatus.LinkColor = IsLight() ? Color.Green : Color.SpringGreen;
                    }
                }
                else
                {
                    LblBackupStatus.Text = "Local backup is disabled";
                    LblBackupStatus.LinkColor = IsLight() ? Color.Red : Color.Orange;
                }

            }
            else
            {
                LblBackupStatus.Text = "Solution folder not found!";
                LblBackupStatus.LinkColor = IsLight() ? Color.Red : Color.Orange;
                
            }

            CheckNetwork();

        }
                
        private void ShowApp()
        {
            ShowInTaskbar = true;
            Visible = true;
            Opacity = 1;
            WindowState = FormWindowState.Normal;
            MenuShow.Visible = false;
            MenuHide.Visible = true;
            TopMost = true;
            TopMost = false;
        }

        private void HideApp()
        {
            Opacity = 0;
            Visible = false;
            ShowInTaskbar = false;
            MenuShow.Visible = true;
            MenuHide.Visible = false;
            Nicon.ShowBalloonTip(2000, Text, "Click on this icon to restore window application", ToolTipIcon.Info);
        }
        
        private void Nicon_MouseClick(object sender, MouseEventArgs e)
        {
            NiconStatus(e);
        }

        private void Nicon_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowApp();
        }

        private void NiconStatus(MouseEventArgs e)
        {
            if (!ClassGeneral.IsBusy && !ClassGeneral.ExitAuthorised)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (WindowState == FormWindowState.Minimized)
                    {
                        WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        if (!Visible)
                        {
                            ShowApp();
                        }
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    var pos = new Point(Cursor.Position.X, Cursor.Position.Y);
                    CMNicon.Show(pos);
                }
            }
        }

        private void QuestionExit()
        {
            if (ClassGeneral.Message("Do you want to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassGeneral.ExitAuthorised = true;
                Nicon.Visible = false;
                Close();
            }
        }

        private void CMNiconMenuExit_Click(object sender, EventArgs e)
        {
            if (!ClassGeneral.IsBusy && !ClassGeneral.ExitAuthorised)
            {
                QuestionExit();
            }
        }

        private void MenuShow_Click(object sender, EventArgs e)
        {
            ShowApp();
        }

        private void MenuHide_Click(object sender, EventArgs e)
        {
            HideApp();
        }

        private void MTitle_Click(object sender, EventArgs e)
        {
            About();
        }

        private void Logo_MouseClick(object sender, MouseEventArgs e)
        {
            About();
        }

        private void About()
        {
            if(!ClassGeneral.IsBusy)
            {
                ClassGeneral.IsBusy = true;
                var go = new FrmAbout();
                go.ShowDialog();
                ClassGeneral.IsBusy = false;
            }
        }

        private void LnkColorizeRows_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dgv = CurrentDGV();
            dgv.SuspendLayout();
            if (dgv != null)
            {
                ClassGeneral.IsBusy = true;
                var cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    var kr = 0;
                    while (kr < dgv.RowCount)
                    {
                        if (dgv.Rows[kr].Selected)
                        {
                            ColorizeRow(dgv, kr, cd.Color);
                        }
                        kr += 1;
                    }
                }
                ClassGeneral.IsBusy = false;
            }
            foreach(DataGridViewRow row in dgv.Rows)
            {
                row.Selected = false;
            }
            dgv.ResumeLayout();
        }

        private void ColorizeRow(DataGridView dgv, int kr, Color backcolor)
        {
            var bg = backcolor;
            var fc = GetRecommendedInverseColor(bg);
            var selbg = GetSelectionBackcolor(bg);
            var selfc = GetRecommendedInverseColor(selbg);
            var kc = 0;
            while (kc < dgv.ColumnCount)
            {
                dgv.Rows[kr].Cells[kc].Style.BackColor = bg;
                dgv.Rows[kr].Cells[kc].Style.ForeColor = fc;
                dgv.Rows[kr].Cells[kc].Style.SelectionBackColor = selbg;
                dgv.Rows[kr].Cells[kc].Style.SelectionForeColor = selfc;
                kc += 1;
            }
            UpdateDataColors(kr, bg, selbg, -1);
        }

        private void RestoreColors()
        {
            var k = 0;
            while(k < tbc.TabCount)
            {
                RestoreColorsForTab(k);
                k += 1;
            }
            Enabled = true;
        }

        private void DGVGridStyle(DataGridView dgv)
        {
            dgv.GridColor = IsLight() ? Color.DimGray : ColorTranslator.FromHtml("#555555");
        }

        private void DGVHeaderStyle(DataGridView dgv)
        {
            if(ClassStyle.CurrentStyle == ClassStyle.StyleType.Light)
            {
                dgv.EnableHeadersVisualStyles = true;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#333333");
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        private void RestoreColorsForTab(int tabIndex)
        {
            var tp = tbc.TabPages[tabIndex];
            var dgv = (tp.Controls.Count > 0) ? (DataGridView)tp.Controls[0] : null;
            if (dgv != null)
            {
                dgv.SuspendLayout();
                dgv.BackgroundColor = IsLight() ? Color.Beige : ColorTranslator.FromHtml("#222222");
                DGVGridStyle(dgv);
                DGVHeaderStyle(dgv);
                var kr = 0;
                while (kr < dgv.RowCount)
                {
                    var bg = IsLight() ? Color.Beige : ColorTranslator.FromHtml("#222222");
                    var fc = GetRecommendedInverseColor(bg);
                    var selbg = GetSelectionBackcolor(bg);
                    var selfc = GetRecommendedInverseColor(selbg);
                    var kc = 0;
                    while (kc < dgv.ColumnCount)
                    {
                        dgv.Rows[kr].Cells[kc].Style.BackColor = bg;
                        dgv.Rows[kr].Cells[kc].Style.ForeColor = fc;
                        dgv.Rows[kr].Cells[kc].Style.SelectionBackColor = selbg;
                        dgv.Rows[kr].Cells[kc].Style.SelectionForeColor = selfc;
                        kc += 1;
                    }
                    UpdateDataColors(kr, bg, selbg, tabIndex);
                    kr += 1;
                }
                dgv.ResumeLayout();
            }
        }
        
        private void LnkRestoreColors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(ClassGeneral.Message("Do you want to restore table colors?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestoreColors();
            }
        }

        private bool IsLight()
        {
            return ClassStyle.CurrentStyle == ClassStyle.StyleType.Light;
        }

        #region DataColors

        List<DataColors> ListDataColors = new List<DataColors>();

        private DataColors DefaultDataColor()
        {
            var dc = new DataColors();
            dc.dgvname = "";
            dc.dgvfilepath = "";
            dc.bgnormal = IsLight() ? Color.Beige : ColorTranslator.FromHtml("#222222");
            dc.bgselected = Color.Black;
            return dc;
        }

        private void RemoveDataColorsForDgvName(string requestname)
        {
            var k = 0;
            while (k < ListDataColors.Count)
            {
                var dc = ListDataColors[k];
                if (dc.dgvname.ToLowerInvariant() == requestname.ToLowerInvariant())
                {
                    ListDataColors.RemoveAt(k);
                    k = 0;
                }
                else
                {
                    k += 1;
                }
            }
        }

        private void ApplyDataColors()
        {
            var dgv = CurrentDGV();
            dgv.SuspendLayout();
            if (dgv != null)
            {
                int kr = 0;
                while (kr < dgv.RowCount)
                {
                    var dcpos = GetDataColorForRow(-1, kr);
                    if (dcpos != -1)
                    {
                        var dc = ListDataColors[dcpos];
                        var kc = 0;
                        while (kc < dgv.ColumnCount)
                        {
                            dgv.Rows[kr].Cells[kc].Style.BackColor = dc.bgnormal;
                            dgv.Rows[kr].Cells[kc].Style.ForeColor = GetRecommendedInverseColor(dc.bgnormal);
                            dgv.Rows[kr].Cells[kc].Style.SelectionBackColor = dc.bgselected;
                            dgv.Rows[kr].Cells[kc].Style.SelectionForeColor = GetRecommendedInverseColor(dc.bgselected);
                            kc += 1;
                        }
                    }
                    kr += 1;
                }
            }
            dgv.ResumeLayout();
        }
        private int GetDataColorForRow(int tabIndex, int kr)
        {
            var dgv = CurrentDGV(tabIndex);
            if (dgv != null)
            {
                int k = 0;
                foreach (var dc in ListDataColors)
                {
                    var filepath = dgv.Rows[kr].Cells[ColPosFilepath].Value.ToString();
                    if (dc.dgvname.ToLowerInvariant() == dgv.Name.ToLowerInvariant() && dc.dgvfilepath.ToLowerInvariant() == filepath.ToLowerInvariant())
                    {
                        return k;
                    }
                    k += 1;
                }
            }
            return -1;
        }

        private void UpdateDataColors(int kr, Color bgnormal, Color bgselected, int tabIndex)
        {
            try
            {
                var dcpos = GetDataColorForRow(tabIndex, kr);
                if (dcpos != -1)
                {
                    var dc = ListDataColors[dcpos];
                    dc.bgnormal = bgnormal;
                    dc.bgselected = bgselected;
                    ListDataColors.RemoveAt(dcpos);
                    ListDataColors.Insert(dcpos, dc);
                }
                else
                {
                    var dgv = CurrentDGV(tabIndex);
                    var dc = DefaultDataColor();
                    dc.dgvname = dgv.Name;
                    dc.dgvfilepath = dgv.Rows[kr].Cells[ColPosFilepath].Value.ToString();
                    dc.bgnormal = bgnormal;
                    dc.bgselected = bgselected;
                    ListDataColors.Add(dc);
                }
            }
            catch
            {
                //Error !!
            }
        }

        public struct DataColors
        {
            public string dgvname;
            public string dgvfilepath;
            public Color bgnormal;
            public Color bgselected;
        }

        private double GetLuminanceFromColor(Color color)
        {
            return (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
        }

        private Color GetRecommendedInverseColor(Color color)
        {
            var d = 0;
            var luminance = GetLuminanceFromColor(color);
            if (luminance > 0.5)
            {
                d = 0; // bright colors - black font
            }
            else
            {
                d = 255; // dark colors - white font
            }
            return Color.FromArgb(d, d, d);
        }

        private Color GetSelectionBackcolor(Color backcolor)
        {
            try
            {
                return (GetLuminanceFromColor(backcolor) > 0.5) ? ColorTranslator.FromHtml("#444444") : ColorTranslator.FromHtml("#CCCCCC");
            }
            catch
            {
                return backcolor;
            }
        }

        #endregion

        private void LogoSymbol_MouseClick(object sender, MouseEventArgs e)
        {
            About();
        }

        private void SetLight()
        {
            ClassStyle.CurrentStyle = ClassStyle.StyleType.Light;
            SaveCfgStyle();
            LoadStyle();
        }

        private void SetDark()
        {
            ClassStyle.CurrentStyle = ClassStyle.StyleType.Dark;
            SaveCfgStyle();
            LoadStyle();
        }

        private void LoadStyle()
        {
            try
            {

                Enabled = false;

                PanelTop.Tag = "nostyle";

                RestoreColors();

                var AllFormControls = ClassStyle.IterateAllChildren(this);

                ClassStyle.ApplyStyle(this as Control);

                foreach (var ctrl in AllFormControls)
                {
                    ClassStyle.ApplyStyle(ctrl as Control);
                }

                MessageStatus.ForeColor = IsLight() ? Color.Black : Color.WhiteSmoke;

                Enabled = true;

            }
            catch
            {
                //Error !!
            }

            EvalGUI();
        }

        private void LinkCloseQuery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var i = ListQueries.SelectedIndex;
            if(i != -1)
            {
                if(ClassGeneral.Message("Do you want to remove current query?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RemoveTab(i);
                }
            }
        }

        private void MoveFocusToIncludeFilter()
        {
            txtInclude.Focus();
        }

        private void MoveFocusToGrid()
        {
            var dgv = CurrentDGV();
            if (dgv != null)
            {
                dgv.Focus();
            }
        }
        
        private void ListQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = ListQueries.SelectedIndex;
            tbc.SelectedIndex = i;
            MoveFocusToGrid();
            EvalColumnsVisibility();
        }

        private void ListQueries_Leave(object sender, EventArgs e)
        {
            MoveFocusToGrid();
        }

        private void listSolutions_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawItemListBox((CustomListBox)sender, e);
        }

        private void listProjects_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawItemListBox((CustomListBox)sender, e);
        }

        private void DrawItemListBox(CustomListBox List, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();

                bool isItemSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                int itemIndex = e.Index;
                if (itemIndex >= 0 && itemIndex < List.Items.Count)
                {
                    Graphics g = e.Graphics;

                    // Background Color
                    SolidBrush backgroundColorBrush = new SolidBrush(isItemSelected ? List.ItemSelectionBackColor : List.ItemBackColor);
                    g.FillRectangle(backgroundColorBrush, e.Bounds);

                    // Set text color
                    string itemText = List.Items[itemIndex].ToString();

                    SolidBrush itemTextColorBrush = isItemSelected ? new SolidBrush(List.ItemSelectionForeColor) : new SolidBrush(List.ItemForeColor);
                    g.DrawString(itemText, e.Font, itemTextColorBrush, List.GetItemRectangle(itemIndex).Location);

                    // Clean up
                    backgroundColorBrush.Dispose();
                    itemTextColorBrush.Dispose();
                }
                else
                {
                    e.DrawFocusRectangle();
                }
                
            }
            catch
            {
                //Error !!
            }
        }

        private void MenuAutobackup_Click(object sender, EventArgs e)
        {
            ShowBackupWindow();
        }

        private void MenuSQLExtractor_Click(object sender, EventArgs e)
        {
            ShowSqlExtractor();
        }

        private void MenuTests_Click(object sender, EventArgs e)
        {
            ShowTests();
        }

        private void MenuSafeBoard_Click(object sender, EventArgs e)
        {
            ShowSafeBoard();
        }

        private void Menu1_Style_Click(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void ChangeStyle()
        {
            if(!ClassGeneral.IsBusy)
            {
                if (IsLight())
                {
                    SetDark();
                }
                else
                {
                    SetLight();
                }
                ClassStyle.RequestUpdateStyle = true;
            }
        }
        private void Menu1_CreateDesktopShortcut_Click(object sender, EventArgs e)
        {
            if(ClassGeneral.CreateDesktopShortcut())
            {
                ClassGeneral.Message("Shortcut created successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClassGeneral.Message("There was an error creating the shortcut.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu1_ExitApp_Click(object sender, EventArgs e)
        {
            QuestionExit();
        }

        private void ExecuteProcess(string pth, string arguments, TypeRunAs type = TypeRunAs.Normal)
        {
            var runas = false;
            if (!ClassSecurity.IsAdministrator())
            {
                if (type == TypeRunAs.ForceTrue)
                {
                    runas = true;
                }
                else if (type == TypeRunAs.Question)
                {
                    if (ClassGeneral.Message("Do you want to execute this action as administrator?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        runas = true;
                    }
                }
            }
            InternalExecuteProcess(pth, arguments, runas);
        }

        private void InternalExecuteProcess(string pth, string arguments, bool runas = false)
        {
            if (pth != "")
            {
                var ex = ClassExecute.ExecuteProcess(pth, arguments, runas);
                if (ex != null)
                {
                    ClassGeneral.Message(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Menu3_Word_Click(object sender, EventArgs e)
        {
            ExecuteProcess("winword", "");
        }

        private void Menu3_Excel_Click(object sender, EventArgs e)
        {
            ExecuteProcess("excel", "");
        }

        private void Menu3_Powerpoint_Click(object sender, EventArgs e)
        {
            ExecuteProcess("powerpnt", "");
        }

        private void Menu3_Outlook_Click(object sender, EventArgs e)
        {
            ExecuteProcess("outlook", "");
        }

        private void Menu3_Jabber_Click(object sender, EventArgs e)
        {
            var pth = @"C:\Program Files (x86)\Cisco Systems\Cisco Jabber\CiscoJabber.exe";
            if (File.Exists(pth))
            {
                ExecuteProcess(pth, "");
            }
            else
            {
                ClassGeneral.Message("Cisco Jabber not found at default location.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Menu2_Explorer_Click(object sender, EventArgs e)
        {
            ExecuteProcess("explorer", "");
        }

        private void Menu2_RegEdit_Click(object sender, EventArgs e)
        {
            ExecuteProcess("regedit", "", TypeRunAs.Question);
        }

        private void Menu2_DiskCleanUp_Click(object sender, EventArgs e)
        {
            ExecuteProcess("cleanmgr", "");
        }

        private void Menu2_Defraggler_Click(object sender, EventArgs e)
        {
            var pth = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32\\dfrgui.exe";
            ExecuteProcess(pth, "", TypeRunAs.ForceTrue);
        }

        private void Menu2_Services_Click(object sender, EventArgs e)
        {
            ExecuteProcess("services.msc", "", TypeRunAs.Question);
        }

        private void Menu2_TaskManager_Click(object sender, EventArgs e)
        {
            ExecuteProcess("taskmgr", "", TypeRunAs.Question);
        }

        private void Menu2_InternetExplorer_Click(object sender, EventArgs e)
        {
            ExecuteProcess("iexplore", "");
        }

        private void Menu2_Calc_Click(object sender, EventArgs e)
        {
            ExecuteProcess("calc", "");
        }

        private void Menu2_Charmap_Click(object sender, EventArgs e)
        {
            ExecuteProcess("charmap", "");
        }

        private void Menu2_Notepad_Click(object sender, EventArgs e)
        {
            ExecuteProcess("notepad", "");
        }

        private void Menu2_Wordpad_Click(object sender, EventArgs e)
        {
            ExecuteProcess("wordpad", "");
        }

        private void Menu2_Paint_Click(object sender, EventArgs e)
        {
            ExecuteProcess("mspaint", "");
        }

        private void Menu2_Snipping_Click(object sender, EventArgs e)
        {
            ExecuteProcess("SnippingTool", "");
        }

        private void Menu2_Magnifier_Click(object sender, EventArgs e)
        {
            ExecuteProcess("magnify", "");
        }

        private void Menu2_ScreenKeyboard_Click(object sender, EventArgs e)
        {
            ExecuteProcess("osk", "");
        }

        private void Menu2_AccessibilityOptions_Click(object sender, EventArgs e)
        {
            ExecuteProcess("utilman", "");
        }

        private void Menu2_VolumeSettings_Click(object sender, EventArgs e)
        {
            ExecuteProcess("sndvol", "");
        }

        private void Menu2_Cmd_Click(object sender, EventArgs e)
        {
            ExecuteProcess("cmd", "", TypeRunAs.Question);
        }

        private void Menu2_ControlPanel_Click(object sender, EventArgs e)
        {
            ExecuteProcess("control", "");
        }

        private void Menu5_SysInfo_Click(object sender, EventArgs e)
        {
            ExecuteProcess("msinfo32", "");
        }

        private void Menu5_CurrentVersion_Click(object sender, EventArgs e)
        {
            ExecuteProcess("winver", "");
        }

        private void Menu5_InternetProperties_Click(object sender, EventArgs e)
        {
            ExecuteProcess("inetcpl.cpl", "");
        }

        private void Menu5_ClearIconCache_Click(object sender, EventArgs e)
        {
            ExecuteProcess("ie4uinit", "-ClearIconCache");
            ExecuteProcess("ie4uinit", "-show");
        }

        private void Menu5_RemoteDesktopServices_Click(object sender, EventArgs e)
        {
            ExecuteProcess("mstsc", "");
        }

        private void Menu5_UserFolder_Click(object sender, EventArgs e)
        {
            var pth = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pth = Path.GetDirectoryName(pth);
            ExecuteProcess(pth, "");
        }

        private void Menu5_WinFolder_Click(object sender, EventArgs e)
        {
            var pth = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            ExecuteProcess(pth, "");
        }

        private void Menu5_AppDataFolder_Click(object sender, EventArgs e)
        {
            var roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var pth = Path.GetDirectoryName(roaming);
            ExecuteProcess(pth, "");
        }

        private void Menu5_WindowsMobilityCenter_Click(object sender, EventArgs e)
        {
            ExecuteProcess("mblctr", "");
        }

        private void Menu5_Fonts_Click(object sender, EventArgs e)
        {
            ExecuteProcess("fonts", "");
        }

        private void Menu5_DPISettings_Click(object sender, EventArgs e)
        {
            ExecuteProcess("dpiscaling", "");
        }

        private void Menu5_DateTime_Click(object sender, EventArgs e)
        {
            ExecuteProcess("timedate.cpl", "");
        }

        private void Menu5_Printers_Click(object sender, EventArgs e)
        {
            ExecuteProcess("printui", "");
        }

        private void Menu5_ColorManagement_Click(object sender, EventArgs e)
        {
            ExecuteProcess("colorcpl", "");
        }

        private void Menu5_MouseProperties_Click(object sender, EventArgs e)
        {
            ExecuteProcess("main.cpl", "");
        }

        private void Menu5_SystemProperties_Click(object sender, EventArgs e)
        {
            ExecuteProcess("systempropertiesadvanced", "");
        }

        private void Menu5_SysCfg_Click(object sender, EventArgs e)
        {
            ExecuteProcess("msconfig", "");
        }

        private void Menu5_SystemPerformanceOptions_Click(object sender, EventArgs e)
        {
            ExecuteProcess("Systempropertiesperformance", "");
        }

        private void Menu5_DiskManagement_Click(object sender, EventArgs e)
        {
            ExecuteProcess("diskmgmt.msc", "", TypeRunAs.ForceTrue);
        }

        private void Menu5_DeviceManagement_Click(object sender, EventArgs e)
        {
            ExecuteProcess("devmgmt.msc", "", TypeRunAs.ForceTrue);
        }

        private void Menu5_PowerOptions_Click(object sender, EventArgs e)
        {
            ExecuteProcess("powercfg.cpl", "");
        }

        private void Menu5_PerformanceMonitor_Click(object sender, EventArgs e)
        {
            ExecuteProcess("perfmon", "", TypeRunAs.ForceTrue);
        }

        private void Menu5_DirectX_Click(object sender, EventArgs e)
        {
            ExecuteProcess("dxdiag", "");
        }

        private void Menu5_RestoreTool_Click(object sender, EventArgs e)
        {
            ExecuteProcess("rstrui", "", TypeRunAs.ForceTrue);
        }

        private void Menu1_About_Click(object sender, EventArgs e)
        {
            About();
        }

        private void EvalSearchType()
        {
            if(OpcHideSearchType)
            {
                Menu1_HideSearchType.Text = "Show search type";
                SearchType.Height = 5;
            }
            else
            {
                Menu1_HideSearchType.Text = "Hide search type";
                SearchType.Height = 25;
            }

            if (OpcOnContent.Checked)
            {
                SearchType.BackColor = IsLight() ? Color.Firebrick : Color.Crimson;
                SearchType.ForeColor = IsLight() ? Color.White : Color.White;
                SearchType.Text = OpcHideSearchType ? "" : "You are searching on file content";
            }
            else if (OpcOnFullpath.Checked)
            {
                SearchType.BackColor = IsLight() ? Color.Green : Color.SpringGreen;
                SearchType.ForeColor = IsLight() ? Color.White : Color.Black;
                SearchType.Text = OpcHideSearchType ? "" : "You are searching on filepath";
            }
            else if (OpcOnFilename.Checked)
            {
                SearchType.BackColor = IsLight() ? Color.Blue : Color.DodgerBlue;
                SearchType.ForeColor = IsLight() ? Color.White : Color.White;
                SearchType.Text = OpcHideSearchType ? "" : "You are searching on filename";
            }

        }

        private void ChangeSearchTypeNoticeStatus()
        {
            OpcHideSearchType = !OpcHideSearchType;
            EvalSearchType();
        }

        private void Menu1_HideSearchType_Click(object sender, EventArgs e)
        {
            ChangeSearchTypeNoticeStatus();
        }

        private void SearchType_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeSearchTypeNoticeStatus();
        }

        private void Menu1_CheckNetwork_Click(object sender, EventArgs e)
        {
            ChangeCfgNetworkStatus();
        }
        
        private void LoadCfgNetworkStatus()
        {
            try
            {
                var f = ClassGeneral.FileCfgNetwork();
                Menu1_CheckNetwork.Checked = !File.Exists(f);
            }
            catch
            {
                //Error !
            }
        }

        private void ChangeCfgNetworkStatus()
        {
            try
            {
                Menu1_CheckNetwork.Checked = !Menu1_CheckNetwork.Checked;
                var f = ClassGeneral.FileCfgNetwork();
                if (Menu1_CheckNetwork.Checked)
                {
                    if (File.Exists(f))
                    {
                        File.Delete(f);
                    }
                }
                else
                {
                    var wr = new StreamWriter(f, false, Encoding.UTF8);
                    wr.WriteLine(DateTime.Now);
                    wr.Close();
                }
            }
            catch
            {
                //Error !
            }
        }

        private void Menu1_WindowState_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
            else
            {
                CenterToScreen();
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Menu1_AutoscaleMode_1_Click(object sender, EventArgs e)
        {
            ClassGeneral.AutoScaleMode = AutoScaleMode.None;
            EvalAutoScaleMode();
        }

        private void Menu1_AutoscaleMode_2_Click(object sender, EventArgs e)
        {
            ClassGeneral.AutoScaleMode = AutoScaleMode.Font;
            EvalAutoScaleMode();
        }

        private void Menu1_AutoscaleMode_3_Click(object sender, EventArgs e)
        {
            ClassGeneral.AutoScaleMode = AutoScaleMode.Dpi;
            EvalAutoScaleMode();
        }

        private void EvalAutoScaleMode()
        {

            Menu1_AutoscaleMode_1.Checked = false;
            Menu1_AutoscaleMode_2.Checked = false;
            Menu1_AutoscaleMode_3.Checked = false;

            if (ClassGeneral.AutoScaleMode == AutoScaleMode.None)
            {
                Menu1_AutoscaleMode_1.Checked = true;
            }
            else if (ClassGeneral.AutoScaleMode == AutoScaleMode.Font)
            {
                Menu1_AutoscaleMode_2.Checked = true;
            }
            else if (ClassGeneral.AutoScaleMode == AutoScaleMode.Dpi)
            {
                Menu1_AutoscaleMode_3.Checked = true;
            }

            AutoScaleMode = ClassGeneral.AutoScaleMode;
            Refresh();
            CenterToScreen();

        }

        private void FrmSearch_Activated(object sender, EventArgs e)
        {
            //Activate
        }

        private void FrmSearch_Deactivate(object sender, EventArgs e)
        {
            //Deactivate
        }

        private void FrmSearch_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                ListFolders.Refresh();
                ListQueries.Refresh();
                EvalColumnsVisibility();
            }
            catch
            {
                //Error !!
            }
        }

        private void subscribeEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inc = txtInclude.Text;
            if (inc != "")
            {
                //
                inc = inc.ToLowerInvariant();
                inc = inc.Replace("getevent", "");
                inc = inc.Replace("publish", "");
                inc = inc.Replace("subscribe", "");
                inc = inc.Replace("unsubscribe", "");
                inc = "getevent " + inc + " subscribe";
                //
                while(inc.Contains("  "))
                {
                    inc = inc.Replace("  ", " ");
                }
                //
                txtInclude.Text = inc;
                txtExclude.Text = "";
                txtExtensions.Text = "cs";
                //
                OpcOnContent.Checked = true;
                OpcWholeWord.Checked = true;
                OpcIndividualTerms.Checked = true;
                OpcAllTerms.Checked = true;
                OpcSameLine.Checked = true;
                //
                EvalGUI();
                SearchNow(false);
                //
            }
            else
            {
                ShowWarningQueryBeforeContinue();
            }
        }

        private void publishEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inc = txtInclude.Text;
            if (inc != "")
            {
                //
                inc = inc.ToLowerInvariant();
                inc = inc.Replace("getevent", "");
                inc = inc.Replace("publish", "");
                inc = inc.Replace("subscribe", "");
                inc = inc.Replace("unsubscribe", "");
                inc = "getevent " + inc + " publish";
                //
                while (inc.Contains("  "))
                {
                    inc = inc.Replace("  ", " ");
                }
                //
                txtInclude.Text = inc;
                txtExclude.Text = "";
                txtExtensions.Text = "cs";
                //
                OpcOnContent.Checked = true;
                OpcWholeWord.Checked = true;
                OpcIndividualTerms.Checked = true;
                OpcAllTerms.Checked = true;
                OpcSameLine.Checked = true;
                //
                EvalGUI();
                SearchNow(false);
                //
            }
            else
            {
                ShowWarningQueryBeforeContinue();
            }
        }

        private void Marquee(string m, Color bg, Color fc, bool animation)
        {
            goFrmMarquee.Close();
            if (goFrmMarquee.IsDisposed)
            {
                goFrmMarquee = new FrmMarquee();
                goFrmMarquee.ShowInTaskbar = false;
            }
            goFrmMarquee.Init(m, bg, fc, animation);
            goFrmMarquee.Show();
        }

        private void Marquee()
        {
            goFrmMarquee.Visible = false;
            goFrmMarquee.ShowInTaskbar = false;
            goFrmMarquee.Close();
            if (!goFrmMarquee.IsDisposed)
            {
                goFrmMarquee.Dispose();
            }
        }

        DateTime LastCheck = DateTime.Now;

        private void CheckNetwork()
        {
            if(Menu1_CheckNetwork.Checked)
            {
                var elapsed = (DateTime.Now - LastCheck).Milliseconds;
                if (elapsed > 300)
                {
                    var isNetworkAvailable = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                    if (isNetworkAvailable && !LastNetworkStatus)
                    {
                        Marquee("Network connection is available", Color.Green, Color.White, true);
                        LastNetworkStatus = true;
                    }
                    else if (!isNetworkAvailable && LastNetworkStatus)
                    {
                        Marquee("Network connection is not available", Color.Firebrick, Color.White, true);
                        LastNetworkStatus = false;
                    }
                    LastCheck = DateTime.Now;
                }
            }
        }
        
        private void LnkPrevQuery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ListQueries.SelectedIndex > 0)
            {
                ListQueries.SelectedIndex -= 1;
            }
        }

        private void LnkNextQuery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ListQueries.SelectedIndex < ListQueries.Items.Count - 1)
            {
                ListQueries.SelectedIndex += 1;
            }
        }

        private void CMenuTestManager_Click(object sender, EventArgs e)
        {
            ShowTests();
        }

        private void CMenuSqlExtractor_Click(object sender, EventArgs e)
        {
            ShowSqlExtractor();
        }

        private void CMenuLocalBackup_Click(object sender, EventArgs e)
        {
            ShowBackupWindow();
        }

        private void CMenuSafeboard_Click(object sender, EventArgs e)
        {
            ShowSafeBoard();
        }

      
    }
}
