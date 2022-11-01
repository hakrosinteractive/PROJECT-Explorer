using HAKROS.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmGetStructure : Form
    {

        int kwait = 0;
        bool reset = false;

        public FrmGetStructure(bool _reset)
        {
            InitializeComponent();
            reset = _reset;
            Opacity = 0;
        }

        private void FrmGetStructure_Load(object sender, EventArgs e)
        {
            Text = ClassGeneral.GetWindowTitle();
            Icon = ClassGeneral.GetIcon();
            tcontrol.Interval = 100;
            tcontrol.Enabled = true;
        }

        private void FrmGetStructure_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcontrol.Enabled = false;
        }

        private void tcontrol_Tick(object sender, EventArgs e)
        {
            if(kwait < 1)
            {
                kwait += 1;
            }
            else
            {
                tcontrol.Enabled = false;
                FindStructure();
                DialogResult = DialogResult.OK;
            }
        }
             
        private bool FindStructure()
        {
            var res = ClassVisualStudio.CheckRootFolder(reset);
            if(!res)
            {
                Opacity = 1;
                T1.Text = "Starting..";
                T2.Text = "";
                Application.DoEvents();
                GetFullStructure();
                res = ClassVisualStudio.CheckRootFolder();
            }
            return res;
        }
        
        private void GetFullStructure()
        {
            try
            {
                T1.Text = "Getting solutions..";
                Application.DoEvents();

                var di = new DirectoryInfo(ClassGeneral.RootFolder);
                var fsExternalSolutions = di.GetFiles("*.sln", SearchOption.TopDirectoryOnly);
                var fsInternalSolutions = di.GetFiles("*.sln", SearchOption.AllDirectories);
                
                ClassVisualStudio.CurrentFilesProject.Clear();
                ClassVisualStudio.CurrentFilesSolution.Clear();

                foreach (var solution in fsExternalSolutions)
                {

                    T1.Text = "SOLUTION: " + Path.GetFileName(solution.FullName);
                    Application.DoEvents();

                    Progressbar.Maximum = fsExternalSolutions.Length;
                    Progressbar.Value += 1;

                    GetProjectsFromSolution(solution.FullName);

                }

                foreach (var solution in fsInternalSolutions)
                {
                    if(!ClassVisualStudio.CurrentFilesSolution.Contains(solution.FullName))
                    {
                        T1.Text = "SOLUTION: " + Path.GetFileName(solution.FullName);
                        Application.DoEvents();

                        Progressbar.Maximum = fsInternalSolutions.Length;
                        Progressbar.Value += 1;

                        GetProjectsFromSolution(solution.FullName);
                    }
                }

                var listProjects = new List<string>();
                var listSolutions = new List<string>();

                foreach (var itm in ClassVisualStudio.CurrentFilesProject)
                {
                    listProjects.Add(itm);
                }

                foreach (var itm in ClassVisualStudio.CurrentFilesSolution)
                {
                    listSolutions.Add(itm);
                }

                if(listProjects.Count > 0 && listSolutions.Count > 0)
                {
                    ClassVisualStudio.TotalRootFolders.Add(ClassGeneral.RootFolder);
                    ClassVisualStudio.TotalFilesProject.Add(listProjects);
                    ClassVisualStudio.TotalFilesSolution.Add(listSolutions);
                }

            }
            catch
            {
                //Error !!
            }

            Progressbar.Value = 0;
            Progressbar.Maximum = 1;
        }

        private void GetProjectsFromSolution(string solution)
        {
            var extension = Path.GetExtension(solution).ToLowerInvariant().Replace(".", "");
            if (extension == "sln")
            {
                try
                {

                    var RTB = new RichTextBox();
                    RTB.WordWrap = false;

                    var sr = new StreamReader(solution, Encoding.UTF8, true);
                    RTB.Text = sr.ReadToEnd();
                    sr.Close();

                    if(RTB.Text.Trim() != "")
                    {

                        var indexes = ClassAllIndexes.AllIndexesOf(RTB.Text, "Project").ToList();

                        var lines = new List<string>();

                        foreach (var index in indexes)
                        {
                            if (index >= 0)
                            {
                                var lineIndex = RTB.GetLineFromCharIndex(index);
                                var line = RTB.Lines[lineIndex].Trim();
                                if (line.Contains("Project(") && !lines.Contains(line))
                                {
                                    lines.Add(line);
                                }
                            }
                        }

                        foreach (var line in lines)
                        {
                            var ln = line.Replace("\"","'").Replace("') = '", "·").Replace("', '", "·");
                            var vs = ln.Split('·');
                            if (vs.Length >= 3)
                            {
                                var prjname = vs[1];
                                var prjrelativepath = vs[2];
                                var project = Path.GetDirectoryName(solution) + "\\" + prjrelativepath;

                                T2.Text = "PROJECT: " + prjname + "..";
                                Application.DoEvents();

                                if (File.Exists(project))
                                {
                                    ClassVisualStudio.CurrentFilesProject.Add(project);
                                    ClassVisualStudio.CurrentFilesSolution.Add(solution);
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
        }

    }
}
