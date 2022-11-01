using HAKROS.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Classes
{
    static class ClassGeneral
    {

        static public bool ExitAuthorised = false;
        static public bool IsSearching = false;
        static public bool IsBusy = false;

        static readonly public string DirApp = Application.StartupPath + @"\";
        static readonly public string DirCfg = DirApp + @"\data\cfg\";
        static readonly public string DirClipboard = DirApp + @"data\clipboard\";
        static readonly public string DirLocalBackup = DirApp + @"data\autobackup\";

        static public string RootFolder = "";

        static public string LastSelectedPath = "";

        static public bool BackupStatus = false;
        static public bool ClipboardStatus = false;

        static public int BackupTotal = 0;

        static public AutoScaleMode AutoScaleMode = AutoScaleMode.None;

        static public void LoadWebDeveloper()
        {
            Process.Start("https://www.hakros.com/");
        }

        static public string GetDirAutoBackup()
        {
            var machineName = Environment.MachineName.ToUpperInvariant();
            var res = DirLocalBackup + machineName + "\\";
            return res;
        }

        public static void CreateDirs()
        {
            Directory.CreateDirectory(DirCfg);
            Directory.CreateDirectory(DirClipboard);
            Directory.CreateDirectory(DirLocalBackup);
        }

        static public string FileCfg()
        {
            CreateDirs();
            return DirCfg + "explorer.ini";
        }

        static public string FileStyle()
        {
            CreateDirs();
            return DirCfg + "style.ini";
        }

        static public string FileEULA()
        {
            CreateDirs();
            return DirCfg + "eula.ini";
        }

        static public string FileFolders()
        {
            CreateDirs();
            return DirCfg + "folders.ini";
        }

        static public string FileCurrentFolder()
        {
            CreateDirs();
            return DirCfg + "currentfolder.ini";
        }

        static public string FileCfgBackup()
        {
            CreateDirs();
            return DirCfg + "autobackup.ini";
        }

        static public string FileCfgClipboard()
        {
            CreateDirs();
            return DirCfg + "clipboard.ini";
        }

        static public string FileCfgPriority()
        {
            CreateDirs();
            return DirCfg + "priority.ini";
        }

        static public string FileCfgNetwork()
        {
            CreateDirs();
            return DirCfg + "network.ini";
        }

        static public string FileTestManager()
        {
            CreateDirs();
            return DirApp + "PROJECT Tests Manager.exe";
        }

        static public string FileAppControl()
        {
            CreateDirs();
            return DirApp + "PROJECT App Control.exe";
        }

        static public string FileMicrosoftWindowsAPICodePack()
        {
            CreateDirs();
            return DirApp + "Microsoft.WindowsAPICodePack.dll";
        }

        static public string FileMicrosoftWindowsAPICodePackShell()
        {
            CreateDirs();
            return DirApp + "Microsoft.WindowsAPICodePack.Shell.dll";
        }

        static public bool LoadTestManager()
        {
            if(File.Exists(FileTestManager()))
            {
                ClassExecute.ExecuteProcess(FileTestManager(), "", false);
                return true;
            }
            return false;
        }

        static public bool LoadAppControl()
        {
            if(File.Exists(FileAppControl()))
            {
                ClassExecute.ExecuteProcess(FileAppControl(), "", false);
                return true;
            }
            return false;
        }

        static public bool ExistsExternalDLLs()
        {
           return (File.Exists(FileMicrosoftWindowsAPICodePack()) && File.Exists(FileMicrosoftWindowsAPICodePackShell()));
        }

        static public string GetWindowTitle(string ModuleName = "")
        {
            var admin = (ClassSecurity.IsAdministrator()) ? " - (Administrator)" : "";
            if (ModuleName != "")
            {
                return GetAppName() + " " + GetVersion() + admin + " - " + ModuleName;
            }
            else
            {
                return GetAppName() + " " + GetVersion() + admin;
            }
        }

        static public string GetDeveloper()
        {
            return Application.CompanyName;
        }

        static public string GetAppName()
        {
            return Application.ProductName;
        }

        static public string GetVersion()
        {
            var currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
            return currentVersion.Major + "." + currentVersion.Minor + "." + currentVersion.Build;
        }

        static public Icon GetIcon()
        {
            var aux = new FrmAux();
            return aux.GetIcon();
        }
        
        static public bool SaveRootFolder(string root)
        {
            try
            {

                if(Directory.Exists(root))
                {
                    var wr = new StreamWriter(FileCfg(), false, Encoding.UTF8);
                    wr.WriteLine(root);
                    wr.Close();
                }
                
                return true;

            }
            catch (System.Exception)
            {
                return false;
            }
        }

        static public string LoadRootFolder()
        {
            try
            {
                var dirCfg = Application.StartupPath + @"\data\cfg\";
                var fileCfg = dirCfg + "Explorer.ini";
                var res = "";

                if (File.Exists(fileCfg))
                {
                    var sr = new StreamReader(fileCfg, Encoding.UTF8, true);
                    res = sr.ReadLine();
                    sr.Close();
                }

                return res;
            }
            catch (System.Exception)
            {
                return "";
            }
        }

        static public string GetVisualStudioPath()
        {
            string devPath = "";
            FrmVisualStudio go = new FrmVisualStudio();
            if (go.ShowDialog() == DialogResult.OK)
            {
                devPath = go.GetSelectedPath();
            }
            return devPath;
        }

        static public bool LineContainsLetter(string line)
        {
            try
            {
                if (!string.IsNullOrEmpty(line))
                {
                    var containsLetter = false;
                    foreach (var c in line.ToCharArray())
                    {
                        if (char.IsLetter(c))
                        {
                            containsLetter = true;
                            break;
                        }
                    }
                    return containsLetter;
                }
            }
            catch
            {
                //Error !!
            }
            return false;
        }

        static public bool StartWithLetter(string input)
        {
            try
            {
                if (!string.IsNullOrEmpty(input))
                {
                    return char.IsLetter(input[0]);
                }
            }
            catch
            {
                //Error !!
            }
            return false;
        }

        static public void LoadFolder(string f)
        {
            var d = Path.GetDirectoryName(f) + "\\";
            var ex = ClassExecute.LoadFolderAndSelectFile(d, f);
            if (ex != null)
            {
                ClassExecute.ExecutePath(d, "", false);
            }
        }

        static public void LoadFile(string f)
        {
            ClassExecute.LoadPath(f);
        }

        static public DialogResult Message(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool SystemStyle = false)
        {
            if (SystemStyle)
            {
                return MessageBox.Show(text, caption, buttons, icon);
            }
            else
            {
                FrmMessageBox.WindowType winType;
                if (icon == MessageBoxIcon.Information)
                {
                    winType = FrmMessageBox.WindowType.OK;
                }
                else if (icon == MessageBoxIcon.Error)
                {
                    winType = FrmMessageBox.WindowType.KO;
                }
                else if (icon == MessageBoxIcon.Warning)
                {
                    winType = FrmMessageBox.WindowType.WARNING;
                }
                else if (icon == MessageBoxIcon.Question)
                {
                    winType = FrmMessageBox.WindowType.QUESTION;
                }
                else
                {
                    winType = FrmMessageBox.WindowType.OK;
                }
                var go = new FrmMessageBox(text, caption, winType);
                return go.ShowDialog();
            }
        }

    }
}
