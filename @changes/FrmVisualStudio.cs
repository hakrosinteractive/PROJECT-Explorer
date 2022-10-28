using HAKROS.Classes;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmVisualStudio : Form
    {

        public static readonly ArrayList VisualStudioDirs = new ArrayList();
        public static readonly ArrayList VisualStudioPaths = new ArrayList();
        public static readonly ArrayList VisualStudioInfo = new ArrayList();

        public FrmVisualStudio()
        {
            InitializeComponent();
        }

        private void FrmVisualStudio_Load(object sender, EventArgs e)
        {
            base.Text = ClassGeneral.GetWindowTitle("Visual Studio (available versions)");
            Icon = ClassGeneral.GetIcon();
            AutoScaleMode = AutoScaleMode.None;
            EvalButtons();
            LoadVersions(false);
        }

        private void LoadVersions(bool force)
        {
            Enabled = false;
            List.Sorted = true;

            if (force)
            {

                VisualStudioDirs.Clear();
                VisualStudioPaths.Clear();
                VisualStudioInfo.Clear();

                string programFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%") + "\\";
                string programFilesX86 = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%") + "\\";

                if (Directory.Exists(programFiles))
                {
                    var di64 = new DirectoryInfo(programFiles);
                    var vs64 = di64.GetDirectories("*Visual Studio*", SearchOption.TopDirectoryOnly);
                    foreach (var d in vs64)
                    {
                        VisualStudioDirs.Add(d.FullName);
                    }
                }

                if (Directory.Exists(programFilesX86))
                {
                    var di86 = new DirectoryInfo(programFilesX86);
                    var vs86 = di86.GetDirectories("*Visual Studio*", SearchOption.TopDirectoryOnly);
                    foreach (var d in vs86)
                    {
                        VisualStudioDirs.Add(d.FullName);
                    }
                }

                foreach (string vsDir in VisualStudioDirs)
                {
                    string pth = GetDevEnvOnPath(vsDir.ToString());
                    if (File.Exists(pth))
                    {
                        VisualStudioPaths.Add(pth);

                        FileInfo fi = new FileInfo(pth);
                        string description = ClassAdvFileInfo.GetDescription(fi.FullName);
                        VisualStudioInfo.Add(description != "" ? description : Path.GetDirectoryName(fi.FullName));

                    }
                }

            }

            List.Items.Clear();

            foreach (string itm in VisualStudioInfo)
            {
                List.Items.Add(itm);
            }

            Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if(List.SelectedIndex != -1)
            {
                DialogResult = DialogResult.OK; 
            }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            EvalButtons();
        }

        private void EvalButtons()
        {
            BtnAccept.Enabled = List.SelectedIndex != -1;
        }

        private void FrmVisualStudio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Close
        }

        private string GetDevEnvOnPath(string dirPath)
        {
            try
            {
                if (Directory.Exists(dirPath))
                {
                    var di = new DirectoryInfo(dirPath);
                    var fs = di.GetFiles("devenv.exe", SearchOption.AllDirectories);
                    if (fs.Length > 0)
                    {
                        return fs[0].FullName;
                    }
                }
            }
            catch
            {
                //Error !!
            }

            return "";
        }

        public string GetSelectedPath()
        {
            int pos = VisualStudioInfo.IndexOf(List.Text);
            return (pos != -1) ? VisualStudioPaths[pos].ToString() : "";
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if(ClassGeneral.ExistsExternalDLLs())
            {
                LoadVersions(true);
            }
            else
            {
                ClassGeneral.Message("Required files not found:\n\nMicrosoft.WindowsAPICodePack.dll\nMicrosoft.WindowsAPICodePack.Shell.dll", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
