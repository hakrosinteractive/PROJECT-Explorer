using HAKROS.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmSqlExtractor : Form
    {

        string FolderSuite = "";

        List<string> ListFilesPaths = new List<string>();

        private void FrmSqlExtractor_Load(object sender, EventArgs e)
        {
            Text = ClassGeneral.GetWindowTitle("SQL Extractor");
            Icon = ClassGeneral.GetIcon();
            AutoScaleMode = ClassGeneral.AutoScaleMode;
            CenterToParent();
        }

        public FrmSqlExtractor(string _folderMprsSuite)
        {
            InitializeComponent();
            FolderSuite = _folderMprsSuite;
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            SelectFiles();
        }

        private void SelectFiles()
        {
            var dir = FolderSuite.ToLowerInvariant();
            if (!dir.EndsWith("\\script bbdd\\"))
            {
                dir = dir + "script bbdd\\";
            }
            var ofd = new OpenFileDialog();
            ofd.InitialDirectory = (Directory.Exists(dir)) ? dir : @"C:\";
            ofd.Multiselect = true;
            ofd.Filter = "SQL Files (*.sql)|*.sql";
            ofd.FileName = "";
            if(ofd.ShowDialog() == DialogResult.OK)
            {                
                foreach (var f in ofd.FileNames)
                {
                    var flower = f.ToLowerInvariant();
                    if(!ListFilesPaths.Contains(flower))
                    {
                        ListFilesPaths.Add(flower);
                        ListFilesNames.Items.Add(Path.GetFileName(f));
                    }
                }
            }
        }
        
        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if(ListFilesNames.Items.Count > 0)
            {
                AnalyzeFiles(OpcExtract.Checked);
            }
            else
            {
                ClassGeneral.Message("You must add at least one script before continue.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AnalyzeFiles(bool extract)
        {
            Enabled = false;
            try
            {

                var sbKO = new StringBuilder();
                var sbOk = new StringBuilder();

                foreach (var f in ListFilesPaths)
                {
                    if(File.Exists(f))
                    {
                        var rtb = new RichTextBox();
                        var sr = new StreamReader(f, Encoding.UTF8, true);
                        rtb.Text = sr.ReadToEnd();
                        sr.Close();

                        var content = "";

                        if(extract)
                        {

                            var k = GetUndefDescriptionLine(rtb);

                            if (k != -1)
                            {
                                content = GetContentFromLine(rtb, k);
                            }

                        }
                        else
                        {
                            content = rtb.Text;
                        }

                        if (sbOk.Length == 0)
                        {
                            sbOk.AppendLine("");
                            sbOk.AppendLine("/* *************************** RESULTS *************************** */");
                            sbOk.AppendLine("");
                        }

                        if (content != "")
                        {
                            sbOk.AppendLine("");
                            sbOk.AppendLine("/* --------------------- " + Path.GetFileName(f) + " --------------------- */");
                            sbOk.AppendLine("");
                            sbOk.Append(content);
                        }
                        else
                        {
                            sbOk.AppendLine("");
                            sbOk.AppendLine("/* --------------------- " + Path.GetFileName(f) + " --------------------- */");
                            sbOk.AppendLine("");
                            sbOk.AppendLine("/* No content found for this file" + "*/");

                            if (sbKO.Length == 0)
                            {
                                sbKO.AppendLine("");
                                sbKO.AppendLine("/* *************************** WARNING: No content found for next files *************************** */");
                                sbKO.AppendLine("");
                            }
                            sbKO.AppendLine("/* --------------------- " + Path.GetFileName(f) + " */");

                        }

                    }
                }

                var ftmp = Path.GetTempFileName() + ".sql";

                var wr = new StreamWriter(ftmp, false, Encoding.UTF8);
                wr.Write(sbKO.ToString());
                wr.WriteLine("");
                wr.Write(sbOk.ToString());
                wr.Close();

                ClassExecute.LoadPath(ftmp);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Enabled = true;
        }

        private int GetUndefDescriptionLine(RichTextBox rtb)
        {
            var k = 0;
            while (k < rtb.Lines.Count())
            {
                var line = rtb.Lines[k].ToLowerInvariant();
                if (line == "undef description")
                {
                    return k;
                }
                k += 1;
            }
            return -1;
        }

        private string GetContentFromLine(RichTextBox rtb, int start)
        {
            var res = "";
            var k = start+1;
            var sb = new StringBuilder();
            while (k < rtb.Lines.Count())
            {
                var line = rtb.Lines[k].Trim();
                if (!line.ToUpperInvariant().Contains("SET ECHO ON") && !line.ToUpperInvariant().Contains("SET ECHO OFF"))
                {
                    sb.AppendLine(line);
                }
                else
                {
                    if(line.ToUpperInvariant().Contains("SET ECHO OFF"))
                    {
                        res = sb.ToString();
                        break;
                    }
                }
                k += 1;
            }
            return res;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ListFilesPaths = new List<string>();
            ListFilesNames.Items.Clear();
        }
    }
}
