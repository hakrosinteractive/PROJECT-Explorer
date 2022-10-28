using HAKROS.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmBackups : Form
    {

        const string TagLocked = "LOCKED";
        const string TagUnlocked = "";

        public string RootFolder = "";

        private bool LoadingBranches = false;

        DateTime LastRequest = DateTime.Now;

        public FrmBackups()
        {
            InitializeComponent();
            LoadAutoBackupCfg();
            DeleteEmptyFolders();
            LoadBackups(false);
            UpdateBackupTotal();
        }

        private void FrmBackups_Load(object sender, EventArgs e)
        {
            Text = ClassGeneral.GetWindowTitle("Local Backup");
            Icon = ClassGeneral.GetIcon();
            SetWindowSize();
            LoadBranches(false);
            LoadBackups(false);
            tcontrol.Enabled = true;
        }

        private void SetWindowSize()
        {
            var w = Screen.GetWorkingArea(this).Width - 200;
            var h = Screen.GetWorkingArea(this).Height - 200;
            Size = new Size(w, h);
            AutoScaleMode = ClassGeneral.AutoScaleMode;
            CenterToParent();
        }

        private void ClearTableFiles()
        {
            ListFiles.Rows.Clear();
        }

        private void ClearTableBackups()
        {
            ListBackups.Rows.Clear();
        }

        private void ListFilesClearSelection()
        {
            var r = 0;
            while (r < ListFiles.RowCount)
            {
                ListFiles.Rows[r].Selected = false;
                r += 1;
            }
        }

        private void ListBackupsClearSelection()
        {
            var r = 0;
            while (r < ListBackups.RowCount)
            {
                ListBackups.Rows[r].Selected = false;
                r += 1;
            }
        }

        private int ListFilesSelectedIndex()
        {
            var r = 0;
            while (r < ListFiles.RowCount)
            {
                if (ListFiles.Rows[r].Selected)
                {
                    return r;
                }
                r += 1;
            }
            if(ListFiles.RowCount > 0)
            {
                ListFiles.Rows[0].Selected = true;
                return 0;
            }
            return -1;
        }

        private string GetCurrentBranch()
        {
            if (Directory.Exists(RootFolder))
            {
                string gitHeaderFile = RootFolder + ".git\\HEAD";
                if(File.Exists(gitHeaderFile))
                {
                    try
                    {
                        string content = "";
                        StreamReader sr = new StreamReader(gitHeaderFile, Encoding.UTF8, true);
                        content = sr.ReadLine().Replace("ref: ", "");
                        sr.Close();
                        return Path.GetFileName(content).ToUpperInvariant();
                    }
                    catch
                    {
                        //Error !!
                    }
                }
            }
            return "MASTER";
        }

        private void LoadBranches(bool keepSelection)
        {
            string currentSelection = CbBranches.Text;
            LoadingBranches = true;
            CbBranches.Items.Clear();
            CbBranches.Sorted = true;
            if (Directory.Exists(ClassGeneral.GetDirAutoBackup()))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(ClassGeneral.GetDirAutoBackup());
                    var branches = di.GetDirectories("**", SearchOption.TopDirectoryOnly);
                    foreach(var branch in branches)
                    {
                        string dname = Path.GetFileName(branch.FullName).ToUpperInvariant();
                        CbBranches.Items.Add(dname);
                    }
                }
                catch (Exception)
                {
                    //Error !!
                }
            }

            string currentBranch = GetCurrentBranch();

            if (!CbBranches.Items.Contains("MASTER"))
            {
                CbBranches.Items.Add("MASTER");
            }

            if (!CbBranches.Items.Contains(currentBranch))
            {
                CbBranches.Items.Add(currentBranch);
            }

            CbBranches.Text = (keepSelection) ? currentSelection : currentBranch;

            if (CbBranches.SelectedIndex == -1)
            {
                CbBranches.Text = currentBranch;
            }

            LoadingBranches = false;

        }

        private string GetCurrentBranchDir()
        {
            return ClassGeneral.GetDirAutoBackup() + GetCurrentBranch() + "\\";
        }

        private string GetSelectedBranchDir()
        {
            return ClassGeneral.GetDirAutoBackup() + CbBranches.Text + "\\";
        }

        private void CbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBackups(false, false);
        }

        private void LoadBackups(bool keepSelection, bool reloadBranches = true)
        {

            if (ClassGeneral.IsSearching || CbBranches.SelectedIndex == -1 || LoadingBranches)
            {
                return;
            }

            if(reloadBranches)
            {
                LoadBranches(true);
            }

            try
            {

                var auxhash = "";

                if(keepSelection)
                {
                    auxhash = GetCurrentHash();
                }

                ClearTableFiles();
                ClearTableBackups();

                string branchDir = GetSelectedBranchDir();

                Directory.CreateDirectory(branchDir);

                var di = new DirectoryInfo(branchDir);

                var ds1 = di.GetDirectories("**", SearchOption.TopDirectoryOnly);

                var BackupsToDelete = new List<string>();

                foreach (var d1 in ds1)
                {

                    var DataBackupsOk = new List<string>();

                    var fs1 = d1.GetFiles("*.data", SearchOption.TopDirectoryOnly);
                    if (fs1.Length == 1)
                    {

                        var filepath = "";

                        var ds2 = d1.GetDirectories("**", SearchOption.TopDirectoryOnly);

                        if(ds2.Length > 0)
                        {
                            var sr = new StreamReader(fs1[0].FullName, Encoding.UTF8, true);
                            filepath = sr.ReadLine();
                            sr.Close();
                        }

                        foreach (var d2 in ds2)
                        {

                            if (File.Exists(filepath))
                            {

                                DataBackupsOk.Add(filepath);

                                var fs2 = d2.GetFiles("*.backup", SearchOption.TopDirectoryOnly);
                                if (fs2.Length > 0)
                                {

                                    var dname = Path.GetFileName(d2.FullName);
                                    var root = branchDir;
                                    var hash = Path.GetFileName(Path.GetDirectoryName(d2.FullName));

                                    var dirhash = branchDir + hash + "\\";
                                    var headerfile = dirhash + "header.data";
                                    var originalfilepath = "";
                                    if (File.Exists(headerfile))
                                    {
                                        var sr = new StreamReader(headerfile, Encoding.UTF8, true);
                                        originalfilepath = sr.ReadLine();
                                        sr.Close();
                                    }
                                    var originaldirpath = Path.GetDirectoryName(originalfilepath) + "\\";
                                    var rootlower = ClassGeneral.RootFolder.ToLowerInvariant();

                                    if(originaldirpath.Contains(rootlower))
                                    {

                                        originaldirpath = originaldirpath.ToLowerInvariant().Replace(rootlower, "").Replace("src\\", "");

                                        var folderpath = originaldirpath;
                                        var filename = dname;
                                        var filehash = hash;
                                        var filedate = GetFileDate(originalfilepath);
                                        var status = IsHashLocked(filehash);

                                        var totalBackups = GetTotalBackups(dirhash);

                                        ListFiles.Rows.Add(status, folderpath, filename, filehash, totalBackups, filedate);

                                    }

                                }

                            }

                        }

                    }

                    if(DataBackupsOk.Count == 0)
                    {
                        BackupsToDelete.Add(d1.FullName);
                    }

                }

                foreach(var d in BackupsToDelete)
                {
                    try
                    {
                        Directory.Delete(d, true);
                    }
                    catch
                    {
                        //Error !!
                    }
                }

                EvalListFilesColors();

                ListFiles.Sort(cdate3, System.ComponentModel.ListSortDirection.Descending);

                if (!string.IsNullOrEmpty(auxhash))
                {
                    SelectRowByHash(auxhash);
                }

            }
            catch(Exception ex)
            {
                //Error !!
            }

        }

        private int GetTotalBackups(string path)
        {
            try
            {
                if(Directory.Exists(path))
                {
                    var di = new DirectoryInfo(path);
                    var fs = di.GetFiles("*.backup", SearchOption.AllDirectories);
                    return fs.Length;
                }
            }
            catch (Exception)
            {
            }
            return 0;
        }

        private void SelectRowByHash(string requestHash)
        {
            int r = 0;
            var selectedIndex = ListFilesSelectedIndex();
            var enco = -1;
            if(selectedIndex != -1)
            {
                while (r < ListFiles.RowCount)
                {
                    var auxhash = ListFiles.Rows[r].Cells[chash2.Index].Value.ToString();
                    if (auxhash == requestHash)
                    {
                        enco = r;
                    }
                    r += 1;
                }
                if(enco != -1)
                {
                    ListFiles.Rows[enco].Selected = true;
                    LoadFiles();
                }
            }
        }

        private void LockFile(int r, bool status)
        {
            try
            {
                var dirhash = GetSelectedBranchDir() + GetHashRow(r) + "\\";
                var filelock = dirhash + "lock.lck";
                if(status)
                {
                    var wr = new StreamWriter(filelock, false, Encoding.UTF8);
                    wr.Write(DateTime.Now.ToString());
                    wr.Close();
                }
                else
                {
                    if(File.Exists(filelock))
                    {
                        var fi = new FileInfo(filelock);
                        fi.Attributes = FileAttributes.Normal;
                        fi.Delete();
                    }
                }
            }
            catch
            {
                //Error
            }
        }

        private bool IsRowLocked(int r = -1)
        {
            if (r == -1)
            {
                r = ListFilesSelectedIndex();
            }
            if (r != -1)
            {
                var dirhash = GetSelectedBranchDir() + GetHashRow(r) + "\\";
                var filelock = dirhash + "lock.lck";
                return File.Exists(filelock);
            }
            return false;
        }

        private string IsHashLocked(string hash)
        {
            if(hash != "")
            {
                var dirhash = GetSelectedBranchDir() + hash + "\\";
                var filelock = dirhash + "lock.lck";
                if(File.Exists(filelock))
                {
                    return TagLocked;
                }
            }
            return TagUnlocked;
        }

        private string GetCurrentFileName()
        {
            var selectedIndex = ListFilesSelectedIndex();
            if (selectedIndex != -1)
            {
                return GetFileNameRow(selectedIndex);
            }
            return "";
        }

        private string GetCurrentHash()
        {
            var selectedIndex = ListFilesSelectedIndex();
            if (selectedIndex != -1)
            {
                return GetHashRow(selectedIndex);
            }
            return "";
        }

        private string GetFileNameRow(int r)
        {
            try
            {
                return ListFiles.Rows[r].Cells[cfilename2.Index].Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        private string GetHashRow(int r)
        {
            try
            {
                return ListFiles.Rows[r].Cells[chash2.Index].Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        private void LoadFiles()
        {

            try
            {

                var currentFilename = GetCurrentFileName();

                var dirhash = GetSelectedBranchDir() + GetCurrentHash() + "\\";

                var dir = dirhash + currentFilename + "\\";

                var headerfile = dirhash + "header.data";

                var originalfilepath = "";

                if (File.Exists(headerfile))
                {
                    var sr = new StreamReader(headerfile, Encoding.UTF8, true);
                    originalfilepath = sr.ReadLine();
                    sr.Close();
                }

                if (File.Exists(originalfilepath))
                {

                    var rootlower = ClassGeneral.RootFolder.ToLowerInvariant();

                    var di = new DirectoryInfo(dir);
                    var fs = di.GetFiles("*.backup", SearchOption.AllDirectories);

                    ClearTableBackups();

                    foreach (var f in fs)
                    {

                        var filebackup = f.FullName;

                        var dirname = Path.GetDirectoryName(filebackup);
                        var fileName = Path.GetFileName(dirname);

                        var status = "";

                        var bgColor = new Color();
                        var fgColor = new Color();

                        var modified = FilesAreDiff(filebackup, originalfilepath);

                        status = modified ? "MODIFIED" : "EQUAL";
                        bgColor = modified ? Color.MistyRose : Color.Lavender;
                        fgColor = modified ? Color.Firebrick : Color.Navy;

                        var fname = Path.GetFileName(originalfilepath);
                        var fdate1 = GetFileDate(filebackup);
                        var fdate2 = GetFileDate(originalfilepath);
                        var fsize1 = GetSizeFile(filebackup);
                        var fsize2 = GetSizeFile(originalfilepath);

                        ListBackups.Rows.Add(filebackup, originalfilepath, fname, fdate1, fdate2, fsize1, fsize2, status);

                        ListBackups.Rows[ListBackups.RowCount - 1].DefaultCellStyle.BackColor = bgColor;
                        ListBackups.Rows[ListBackups.RowCount - 1].DefaultCellStyle.ForeColor = fgColor;

                    }

                }

                ListBackups.Sort(cdate1, System.ComponentModel.ListSortDirection.Descending);
                ListBackupsClearSelection();

                //var kr = 1;
                //while(kr < ListBackups.RowCount)
                //{
                //    ListBackups.Rows[kr].Cells[4].Value = "---";
                //    ListBackups.Rows[kr].Cells[6].Value = "---";
                //    kr += 1;
                //}

            }
            catch
            {
                //Error !!
            }

        }

        private bool FilesAreDiff(string f1, string f2)
        {
            try
            {
                var fi1 = new FileInfo(f1);
                var fi2 = new FileInfo(f2);

                if(fi1.Length != fi2.Length)
                {
                    return true;
                }
                else
                {
                    var hash1 = ClassSecurity.GetMD5FromFile(f1);
                    var hash2 = ClassSecurity.GetMD5FromFile(f2);
                    return (hash1 != hash2);
                }

            }
            catch (Exception)
            {
                //Error !!
            }
            return false;
        }

        private DateTime? GetFileDate(string filepath)
        {
            if (File.Exists(filepath))
            {
                try
                {
                    var fi = new FileInfo(filepath);
                    return fi.LastWriteTime;
                }
                catch
                {
                    //Error !!
                }
            }
            return null;
        }

        private string GetFileDateAsString(string filepath)
        {
            if (File.Exists(filepath))
            {
                try
                {
                    var fi = new FileInfo(filepath);
                    return fi.LastWriteTime.ToString("hh:mm:ss - yyyy/MM/dd");
                }
                catch
                {
                    //Error !!
                }
            }
            return "";
        }

        private double GetSizeFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                try
                {
                    var fi = new FileInfo(filepath);
                    return fi.Length;
                }
                catch
                {
                    //Error !!
                }
            }
            return -1;
        }

        private void ListEqual_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Both files are equal.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListDeleted_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Original file not exists.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Listbackups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSelection(e.RowIndex);
        }

        private string GetHeaderFile()
        {
            if (ListFilesSelectedIndex() != -1)
            {
                var dir = GetSelectedBranchDir() + GetCurrentHash() + "\\";
                var headerfile = dir + "header.data";
                if(File.Exists(headerfile))
                {
                    return headerfile;
                }
            }
            return "";
        }

        private string GetOriginalFile(string currentFile)
        {
            var headerfile = GetHeaderFile();
            if (File.Exists(currentFile))
            {
                var sr = new StreamReader(headerfile, Encoding.UTF8, true);
                var originalFile = sr.ReadLine();
                sr.Close();
                return originalFile;
            }

            return "";
        }

        private void RefreshList(bool keepSelection)
        {
            LoadBackups(keepSelection);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList(true);
        }

        private void FrmBackups_Activated(object sender, EventArgs e)
        {
            RefreshList(true);
            tcontrol.Enabled = true;
        }

        private void FrmBackups_Deactivate(object sender, EventArgs e)
        {
            tcontrol.Enabled = false;
        }

        private void FrmBackups_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcontrol.Enabled = false;
            DeleteEmptyFolders();
        }

        private void BtnDeleteSelection_Click(object sender, EventArgs e)
        {
            if(IsRowLocked())
            {
                MessageBox.Show("This backup is locked, and cannot be deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete selected backup?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var dir = GetSelectedBranchDir() + GetCurrentHash() + "\\";
                    if (Directory.Exists(dir))
                    {
                        try
                        {
                            Directory.Delete(dir, true);
                        }
                        catch
                        {
                            //Error !!
                        }
                    }
                    RefreshList(false);
                }
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete all unlocked backups?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                while(ExistRowsNotLocked())
                {
                    DeleteAll();
                    UpdateBackupTotal();
                }
            }
        }

        private void BtnDeleteSingle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete single backups?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteSingle();
                UpdateBackupTotal();
            }
        }

        private bool ExistRowsNotLocked()
        {
            var r = 0;
            while (r < ListFiles.RowCount)
            {
                if (!IsRowLocked(r))
                {
                    return true;
                }
                r += 1;
            }
            return false;
        }

        private void DeleteAll()
        {
            var r = 0;
            while (r < ListFiles.RowCount)
            {
                if (!IsRowLocked(r))
                {
                    var dir = GetSelectedBranchDir() + GetHashRow(r) + "\\";
                    if (Directory.Exists(dir))
                    {
                        try
                        {
                            var di = new DirectoryInfo(dir);
                            var fs = di.GetFiles("*.*", SearchOption.AllDirectories);
                            foreach (var f in fs)
                            {
                                f.Attributes = FileAttributes.Normal;
                                f.Delete();
                            }
                            var dsubs = di.GetDirectories("*.*", SearchOption.AllDirectories);
                            foreach (var dsub in dsubs)
                            {
                                dsub.Attributes = FileAttributes.Normal;
                                dsub.Delete();
                            }
                            di.Attributes = FileAttributes.Normal;
                            di.Delete(true);
                        }
                        catch
                        {
                            //Error !!
                        }
                    }
                }
                r += 1;
            }
            RefreshList(false);
        }

        private void DeleteSingle()
        {
            var r = 0;
            while (r < ListFiles.RowCount)
            {
                if (!IsRowLocked(r))
                {
                    var dir = GetSelectedBranchDir() + GetHashRow(r) + "\\";
                    if (Directory.Exists(dir))
                    {
                        try
                        {
                            var totalbackups = (int)ListFiles.Rows[r].Cells[ctotalbackups.Index].Value;
                            if (totalbackups == 1)
                            {
                                var di = new DirectoryInfo(dir);
                                var fs = di.GetFiles("*.*", SearchOption.AllDirectories);
                                foreach (var f in fs)
                                {
                                    f.Attributes = FileAttributes.Normal;
                                    f.Delete();
                                }
                                var dsubs = di.GetDirectories("*.*", SearchOption.AllDirectories);
                                foreach (var dsub in dsubs)
                                {
                                    dsub.Attributes = FileAttributes.Normal;
                                    dsub.Delete();
                                }
                                di.Attributes = FileAttributes.Normal;
                                di.Delete(true);
                            }
                        }
                        catch
                        {
                            //Error !!
                        }
                    }
                }
                r += 1;
            }
            RefreshList(false);
        }

        private void DeleteEmptyFolders()
        {
            try
            {
                string branchesDir = ClassGeneral.GetDirAutoBackup();
                var dibranches = new DirectoryInfo(branchesDir);
                var branches = dibranches.GetDirectories("**", SearchOption.TopDirectoryOnly);
                foreach (var branch in branches)
                {
                    var di = new DirectoryInfo(branch.FullName);
                    var dbackups = di.GetDirectories("**", SearchOption.TopDirectoryOnly);
                    foreach (var dbackup in dbackups)
                    {
                        var headerfile = dbackup.FullName + "\\header.data";
                        if (!File.Exists(headerfile))
                        {
                            try
                            {
                                var fs = dbackup.GetFiles("*.*", SearchOption.AllDirectories);
                                foreach (var f in fs)
                                {
                                    f.Attributes = FileAttributes.Normal;
                                    f.Delete();
                                }
                                var ds2 = dbackup.GetDirectories("*.*", SearchOption.AllDirectories);
                                foreach (var d2 in ds2)
                                {
                                    d2.Attributes = FileAttributes.Normal;
                                    d2.Delete();
                                }
                                dbackup.Attributes = FileAttributes.Normal;
                                dbackup.Delete();
                            }
                            catch
                            {
                                //Error !!
                            }
                        }
                    }
                }                
            }
            catch
            {
                //Error !!
            }
        }

        private void EvalButtons()
        {
            BtnDeleteAll.Enabled = (ListFiles.RowCount > 0);
            BtnDeleteSingle.Enabled = (ListFiles.RowCount > 0);
            var selectedIndex = ListFilesSelectedIndex();
            BtnDeleteSelection.Enabled = (selectedIndex != -1);
            BtnCompare.Enabled = (selectedIndex != -1);
        }
        private void ChbStatus_CheckedChanged(object sender, EventArgs e)
        {
            //See click event
        }

        private void ChbStatus_Click(object sender, EventArgs e)
        {
            SaveStatus();
        }

        public void LoadAutoBackupCfg()
        {

            try
            {

                var aux = false;

                ClassGeneral.CreateDirs();

                if (File.Exists(ClassGeneral.FileCfgBackup()))
                {
                    try
                    {

                        using (var sr = new StreamReader(ClassGeneral.FileCfgBackup(), Encoding.UTF8, true))
                        {
                            while (!sr.EndOfStream)
                            {
                                var vs = sr.ReadLine().ToUpperInvariant().Split('=');
                                if (vs.Length == 2)
                                {
                                    if (vs[0] == "ENABLED")
                                    {
                                        if (vs[1] == "1")
                                        {
                                            aux = true;
                                        }
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception)
                    {
                        //Error !!
                    }
                }
                else
                {
                    //Default
                    aux = false;
                }

                ChbStatus.Checked = aux;

                UpdateStatus();

            }
            catch
            {
                //Error !
            }

        }

        private void SaveStatus()
        {
            try
            {

                ClassGeneral.CreateDirs();
                using (var wr = new StreamWriter(ClassGeneral.FileCfgBackup(), false, Encoding.UTF8))
                {
                    if (ChbStatus.Checked)
                    {
                        wr.WriteLine("ENABLED=1");
                    }
                    else
                    {
                        wr.WriteLine("ENABLED=0");
                    }
                }

            }
            catch
            {
                //Error !
            }
            UpdateStatus();
        }

        public void UpdateStatus()
        {
            ClassGeneral.BackupStatus = ChbStatus.Checked;
            if (ChbStatus.Checked)
            {
                ChbStatus.ForeColor = Color.Green;
                ChbStatus.Text = "Local backup is enabled";
            }
            else
            {
                ChbStatus.ForeColor = Color.Red;
                ChbStatus.Text = "Local backup is disabled";
            }
        }

        public bool isActive()
        {
            return ChbStatus.Checked;
        }

        public void BackupFile(string currentfile)
        {
            try
            {

                string branchDir = GetCurrentBranchDir();

                Directory.CreateDirectory(branchDir);

                if (File.Exists(currentfile))
                {

                    var originalCaseFile = currentfile;

                    currentfile = currentfile.ToLowerInvariant();

                    if(!currentfile.Contains("\\bin\\") && !currentfile.Contains("\\obj\\"))
                    {
                        var currenthash = ClassSecurity.GetHashNameForString(currentfile);

                        var datestamp = ClassBackup.GetDateStamp(DateTime.Now);
                        var timestamp = ClassBackup.GetTimeStamp(DateTime.Now);
                        var fileName = Path.GetFileName(originalCaseFile);

                        var dhash = branchDir.ToLowerInvariant() + currenthash + "\\";
                        var dbackup = dhash + fileName + "\\";

                        var headerfile = dhash + "header.data";
                        var backupfile = dbackup + datestamp + "_" + timestamp + ".backup";

                        var dir = Path.GetDirectoryName(backupfile) + "\\";

                        Directory.CreateDirectory(dir);

                        if (!File.Exists(headerfile))
                        {
                            var wr = new StreamWriter(headerfile, false, Encoding.UTF8);
                            wr.WriteLine(originalCaseFile);
                            wr.WriteLine(currenthash);
                            wr.Close();
                        }

                        var di = new DirectoryInfo(dir);
                        var fs = di.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                        var orderedFiles = fs.OrderBy(f => f.LastWriteTime).ToList();
                        if (orderedFiles.Count > 0)
                        {
                            var lastbackup = orderedFiles[orderedFiles.Count - 1].FullName;
                            var hash1 = ClassSecurity.GetMD5FromFile(lastbackup);
                            var hash2 = ClassSecurity.GetMD5FromFile(currentfile);
                            if (hash1 != hash2)
                            {
                                if (File.Exists(backupfile))
                                {
                                    var fi = new FileInfo(backupfile);
                                    fi.Attributes = FileAttributes.Normal;
                                }
                                File.Copy(currentfile, backupfile, true);
                                if (Visible)
                                {
                                    RefreshList(true);
                                }
                                LastRequest = DateTime.Now;
                                TRequestUpdateTotal.Enabled = true;
                            }
                        }
                        else
                        {
                            File.Copy(currentfile, backupfile, true);
                            if (Visible)
                            {
                                RefreshList(true);
                            }
                            LastRequest = DateTime.Now;
                            TRequestUpdateTotal.Enabled = true;
                        }
                    }

                }
            }
            catch
            {
                //Error !
            }
        }
        
        private void LoadSelection(int rowindex)
        {
            if (rowindex != -1)
            {
                var f1 = ListBackups.Rows[rowindex].Cells[0].Value.ToString();
                var f2 = GetOriginalFile(f1);
                CompareFiles(f1, f2);
            }
        }

        private void CompareFiles(string f1, string f2)
        {
            try
            {

                string vsPath = ClassGeneral.GetVisualStudioPath();

                if (File.Exists(vsPath) && File.Exists(f1) && File.Exists(f2))
                {
                    var info = new ProcessStartInfo();
                    var filename = GetCurrentFileName();
                    var fi = new FileInfo(f2);

                    var date1 = GetFileDateAsString(f1);
                    var date2 = GetFileDateAsString(f2);

                    var backupWithBackup = (Path.GetDirectoryName(f1) == Path.GetDirectoryName(f2));

                    var f1Mens = "";
                    var f2Mens = "";

                    if(backupWithBackup)
                    {
                        f1Mens = "BACKUP 1";
                        f2Mens = "BACKUP 2";
                    }
                    else
                    {
                        f1Mens = "BACKUP";
                        f2Mens = "SOURCE (CURRENT FILE)";
                    }

                    var backupName = "\"[" + filename + "] [" + date1 + "] " + f1Mens + " \"";
                    var originalName = "\"[" + filename + "] [" + date2 + "] " + f2Mens + " \"";

                    f1 = "\"" + f1 + "\"";
                    f2 = "\"" + f2 + "\"";

                    info.FileName = vsPath;
                    info.Arguments = " /diff " + f1 + " " + f2 + " " + backupName + " " + originalName;

                    var pr = new Process();
                    pr.StartInfo = info;
                    pr.Start();
                }
            }
            catch
            {
                //Error !!
            }
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            var r = 0;
            var sel = new ArrayList();
            while (r < ListBackups.RowCount)
            {
                if(ListBackups.Rows[r].Selected)
                {
                    sel.Add(r);
                }
                r += 1; 
            }
            if(sel.Count > 0 && sel.Count < 3)
            {
                if (sel.Count == 1)
                {
                    var f1 = ListBackups.Rows[(int)sel[0]].Cells[0].Value.ToString();
                    var f2 = GetOriginalFile(f1);
                    CompareFiles(f1, f2);
                }
                else if (sel.Count == 2)
                {
                    var f1 = ListBackups.Rows[(int)sel[0]].Cells[0].Value.ToString();
                    var f2 = ListBackups.Rows[(int)sel[1]].Cells[0].Value.ToString();
                    CompareFiles(f1, f2);
                }
            }
            else
            {
                MessageBox.Show("You must select one or two files to perform the comparation.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void tcontrol_Tick(object sender, EventArgs e)
        {
            EvalButtons();
        }
        
        private void EvalListFilesColors()
        {
            var r = 0;
            while (r < ListFiles.RowCount)
            {

                ListFiles.Rows[r].DefaultCellStyle.BackColor = Color.Beige;
                ListFiles.Rows[r].DefaultCellStyle.SelectionBackColor = Color.PaleGoldenrod;
                ListFiles.Rows[r].DefaultCellStyle.ForeColor = Color.Black;
                ListFiles.Rows[r].DefaultCellStyle.SelectionForeColor = Color.Black;

                if (IsRowLocked(r))
                {
                    ListFiles.Rows[r].Cells[clock3.Index].Style.BackColor = Color.Firebrick;
                    ListFiles.Rows[r].Cells[clock3.Index].Style.SelectionBackColor = Color.Firebrick;
                    ListFiles.Rows[r].Cells[clock3.Index].Style.ForeColor = Color.White;
                    ListFiles.Rows[r].Cells[clock3.Index].Style.SelectionForeColor = Color.White;
                }
                else
                {
                    ListFiles.Rows[r].Cells[clock3.Index].Style.BackColor = Color.Beige;
                    ListFiles.Rows[r].Cells[clock3.Index].Style.SelectionBackColor = Color.PaleGoldenrod;
                    ListFiles.Rows[r].Cells[clock3.Index].Style.ForeColor = Color.Black;
                    ListFiles.Rows[r].Cells[clock3.Index].Style.SelectionForeColor = Color.Black;
                }

                r += 1;
            }
        }

        private void ListFiles_SelectionChanged(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void ListFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == clock3.Index)
            {
                if(IsRowLocked(e.RowIndex))
                {
                    LockFile(e.RowIndex, false);
                    ListFiles.Rows[e.RowIndex].Cells[clock3.Index].Value = TagUnlocked;
                }
                else
                {
                    LockFile(e.RowIndex, true);
                    ListFiles.Rows[e.RowIndex].Cells[clock3.Index].Value = TagLocked;
                }
                EvalListFilesColors();
            }
        }

        public void UpdateBackupTotal()
        {
            try
            {
                LoadBackups(false);
                ClassGeneral.BackupTotal = ListFiles.RowCount;
            }
            catch (Exception)
            {
                ClassGeneral.BackupTotal = 0;
            }
        }

        private void TRequestUpdateTotal_Tick(object sender, EventArgs e)
        {
            var diff = DateTime.Now - LastRequest;
            if(diff.TotalSeconds > 2)
            {
                TRequestUpdateTotal.Enabled = false;
                UpdateBackupTotal();
            }
        }

        private void LnkCurrentBranch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadBranches(false);
            LoadBackups(false);
        }
    }
}
