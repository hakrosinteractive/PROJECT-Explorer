using HAKROS.Classes;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmTests : Form
    {

        const string StatusOK = "PASSED";
        const string StatusKO = "NOT PASSED";

        const string ExtTest = ".test";
        const string ExtResult = ".result";

        public FrmTests()
        {
            InitializeComponent();
        }

        private void FrmTests_Load(object sender, EventArgs e)
        {
            if (!ClassSecurity.InExecution())
            {
                InitApp();
            }
            else
            {
                Application.Exit();
            }
        }

        private void InitApp()
        {
            Text = ClassGeneral.GetWindowTitle("Test Manager");
            TextTest.Font = new Font("Verdana", 9, FontStyle.Regular);
            AutoScaleMode = ClassGeneral.AutoScaleMode;
            CenterToParent();
            tcontrol.Enabled = true;
            LoadTests(false);
        }

        private void FrmTests_Activated(object sender, EventArgs e)
        {
            //LoadTests(true);
        }

        private void FrmTests_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveResults();
            tcontrol.Enabled = false;
        }
        
        private void LoadTests(bool keepselection)
        {
            Directory.CreateDirectory(ClassGeneral.DirTests);
            try
            {
                var di = new DirectoryInfo(ClassGeneral.DirTests);
                var fs = di.GetFiles("*" + ExtTest, SearchOption.TopDirectoryOnly);
                var current = "";
                if(keepselection) current = ComboTests.Text;
                ComboTests.Items.Clear();
                ComboTests.Sorted = true;
                TextTest.Text = "";
                ListTest.Rows.Clear();
                foreach (var f in fs)
                {
                    var testname = Path.GetFileNameWithoutExtension(f.FullName).ToLowerInvariant();
                    ComboTests.Items.Add(testname);
                }
                if(current != "")
                {
                    ComboTests.Text = current;
                }
                else
                {
                    ComboTests.SelectedIndex = (ComboTests.Items.Count > 0) ? 0 : -1;
                }
            }
            catch
            {
                //Error !!
            }
        }

        private void ComboTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedTest();
        }

        private void LoadSelectedTest()
        {
            TextTest.Text = "";
            ListTest.Rows.Clear();
            if (ComboTests.SelectedIndex != -1)
            {

                TextTest.BackColor = Color.Lavender;
                TextTest.ReadOnly = false;

                var filepath = ClassGeneral.DirTests + ComboTests.Text + ExtTest;
                if (File.Exists(filepath))
                {
                    try
                    {
                        var sr = new StreamReader(filepath, Encoding.UTF8, true);
                        TextTest.Text = sr.ReadToEnd();
                        sr.Close();

                        if (TextTest.Text != "")
                        {
                            GenerateTest();
                            TBC.SelectedIndex = 0;
                        }
                        else
                        {
                            TBC.SelectedIndex = 1;
                        }

                    }
                    catch
                    {
                        //Error !!
                    }
                }

            }
        }
        private void TBC_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateTest();
        }

        private void Generate()
        {
            var filepath1 = ClassGeneral.DirTests + ComboTests.Text + ExtTest;
            var filepath2 = ClassGeneral.DirTests + ComboTests.Text + ExtResult + "1";
            var filepath3 = ClassGeneral.DirTests + ComboTests.Text + ExtResult + "2";
            DeleteFile(filepath1);
            DeleteFile(filepath2);
            DeleteFile(filepath3);
            GenerateTest();
        }

        private void GenerateTest()
        {
            ListTest.Rows.Clear();
            ListResults.Rows.Clear();
            if (TextTest.Text != "")
            {
                var id1 = 1;
                var id2 = 1;
                foreach (var line in TextTest.Lines)
                {
                    try
                    {
                        var trimline = line.Trim();
                        if (trimline != "")
                        {
                            if(ClassGeneral.LineContainsLetter(trimline))
                            {
                                while (trimline != "" && !ClassGeneral.StartWithLetter(trimline))
                                {
                                    if (trimline.Length > 0)
                                    {
                                        trimline = trimline.Substring(1);
                                    }
                                }
                                if (trimline != "")
                                {
                                    if(trimline.ToUpperInvariant().StartsWith("R:"))
                                    {
                                        ListResults.Rows.Add(id2, trimline.Substring(2), StatusKO);
                                        id2 += 1;
                                    }
                                    else if(trimline.ToUpperInvariant().StartsWith("H:"))
                                    {
                                        ListTest.Rows.Add("", trimline.Substring(2), "");
                                        id1 = 1;
                                    }
                                    else
                                    {
                                        ListTest.Rows.Add(id1, trimline, StatusKO);
                                        id1 += 1;
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

                LoadResultsForDgv(ListTest, 1);
                LoadResultsForDgv(ListResults, 2);

                EvalTest();
            }
            SaveTest();
        }

        private void LoadResultsForDgv(DataGridView dgv, int idFile)
        {
            var fileresults = ClassGeneral.DirTests + ComboTests.Text + ExtResult + idFile;
            if (File.Exists(fileresults))
            {
                try
                {
                    var results = new ArrayList();
                    var sr = new StreamReader(fileresults, Encoding.UTF8, true);
                    while (!sr.EndOfStream)
                    {
                        var val = sr.ReadLine().Trim();
                        results.Add(val);
                    }
                    sr.Close();

                    var r = 0;
                    while (r < results.Count)
                    {
                        if (r <= dgv.RowCount)
                        {
                            dgv.Rows[r].Cells[cstatus.Index].Value = results[r];
                        }
                        r += 1;
                    }

                }
                catch
                {
                    //Error !!
                }
            }
        }

        private void SaveTest()
        {
            try
            {
                if(TextTest.Text != "")
                {
                    var filepath = ClassGeneral.DirTests + ComboTests.Text + ExtTest;
                    var wr = new StreamWriter(filepath, false, Encoding.UTF8);
                    wr.Write(TextTest.Text);
                    wr.Close();
                }
            }
            catch
            {
                //Error !!
            }
        }

        private void DeleteFile(string filepath)
        {
            try
            {
                if(File.Exists(filepath))
                {
                    var fi = new FileInfo(filepath);
                    fi.Attributes = FileAttributes.Normal;
                    fi.Delete();
                }
            }
            catch
            {
                //Error !!
            }
        }

        private void SaveResults()
        {
            SaveResult(ListTest, 1);
            SaveResult(ListResults, 2);
        }

        private void SaveResult(DataGridView dgv, int idFile)
        {
            try
            {
                var r = 0;
                var fileResults = ClassGeneral.DirTests + ComboTests.Text + ExtResult + idFile;
                var wr = new StreamWriter(fileResults, false, Encoding.UTF8);
                while (r < dgv.RowCount)
                {
                    wr.WriteLine(dgv.Rows[r].Cells[cstatus.Index].Value.ToString().ToUpperInvariant());
                    r += 1;
                }
                wr.Close();
            }
            catch
            {
                //Error !!
            }
        }

        private void LnkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTest(false);
        }

        private void AddTest(bool exampleTest)
        {
            try
            {

                Directory.CreateDirectory(ClassGeneral.DirTests);

                if (exampleTest)
                {

                    var filename = "00000";
                    var filepath = ClassGeneral.DirTests + filename + ExtTest;
                    var filepathres = ClassGeneral.DirTests + filename + ExtResult;

                    var wr = new StreamWriter(filepath, false, Encoding.UTF8);
                    wr.Close();

                    if(File.Exists(filepathres))
                    {
                        File.Delete(filepathres);
                    }

                    LoadTests(false);

                    ComboTests.Text = filename;

                    TextTest.Text = "H:Header 1\nStep\nStep\nStep\nH:Header 2\nStep\nStep\nStep\nStep\nStep\nR:Result\nR:Result";

                    GenerateTest();

                }
                else
                {

                    var SFD = new SaveFileDialog();

                    SFD.FileName = "";
                    SFD.Title = "Save new test file..";
                    SFD.InitialDirectory = ClassGeneral.DirTests;
                    SFD.Filter = "Test Files (*" + ExtTest + ")|*" + ExtTest;

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        var filename = Path.GetFileNameWithoutExtension(SFD.FileName).ToLowerInvariant();
                        var filepath = ClassGeneral.DirTests + filename + ExtTest;

                        var wr = new StreamWriter(filepath, false, Encoding.UTF8);
                        wr.Close();

                        LoadTests(false);
                        ComboTests.Text = filename;
                    }
                    else
                    {
                        LoadTests(true);
                    }

                }

            }
            catch
            {
                //Error !!
            }
        }

        private void LnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ComboTests.SelectedIndex != -1)
            {

                var filepath1 = ClassGeneral.DirTests + ComboTests.Text + ExtTest;
                var filepath2 = ClassGeneral.DirTests + ComboTests.Text + ExtResult + "1";
                var filepath3 = ClassGeneral.DirTests + ComboTests.Text + ExtResult + "2";

                if (File.Exists(filepath1) || File.Exists(filepath2) || File.Exists(filepath3))
                {
                    if (MessageBox.Show("Do you want to delete current test?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            File.Delete(filepath1);
                        }
                        catch
                        {
                            //Error !!
                        }
                        try
                        {
                            File.Delete(filepath2);
                        }
                        catch
                        {
                            //Error !!
                        }
                        try
                        {
                            File.Delete(filepath3);
                        }
                        catch
                        {
                            //Error !!
                        }
                    }
                    LoadTests(false);
                }
            }
            else
            {
                MessageBox.Show("You must select a test before continue.", "Notice", MessageBoxButtons.OK);
            }
        }

        private void tcontrol_Tick(object sender, EventArgs e)
        {

            if(ComboTests.SelectedIndex == -1 && !TextTest.ReadOnly)
            {
                TextTest.Text = "";
                TextTest.BackColor = Color.Silver;
                TextTest.ReadOnly = true;
            }
            else if(ComboTests.SelectedIndex != -1 && TextTest.ReadOnly)
            {
                TextTest.BackColor = Color.Lavender;
                TextTest.ReadOnly = false;
            }

            LnkRemove.Enabled = ComboTests.SelectedIndex != -1;

        }

        private void ChangeStatus(DataGridView dgv, int start, int final, string status)
        {
            var r = start;
            while (r < final)
            {
                if(!IsRowHeader(dgv,r))
                {
                    dgv.Rows[r].Cells[cstatus.Index].Value = status;
                }
                else
                {
                    dgv.Rows[r].Cells[cstatus.Index].Value = "";
                }
                r += 1;
            }
        }

        private void EvalTest()
        {
            var r = 0;
            while (r < ListTest.RowCount)
            {
                ColorizeRow(ListTest, r);
                r += 1;
            }
            r = 0;
            while (r < ListResults.RowCount)
            {
                ColorizeRow(ListResults, r);
                r += 1;
            }
        }

        private void ColorizeRow(DataGridView dgv, int r)
        {
            try
            {
                var row = dgv.Rows[r];
                var colStatus = row.Cells[cstatus.Index];
                var status = colStatus.Value.ToString().ToUpperInvariant();

                Color bg = Color.White;
                Color fc = Color.Black;

                if(IsRowHeader(dgv, r))
                {
                    bg = Color.Lavender;
                    fc = Color.Navy;
                    colStatus.Value = "";
                }
                else
                {
                    if (status == StatusOK)
                    {
                        bg = Color.Honeydew;
                        fc = Color.Green;
                    }
                    else
                    {
                        bg = Color.MistyRose;
                        fc = Color.Firebrick;
                    }
                }

                dgv.Rows[r].DefaultCellStyle.BackColor = bg;
                dgv.Rows[r].DefaultCellStyle.SelectionBackColor = bg;
                dgv.Rows[r].DefaultCellStyle.ForeColor = fc;
                dgv.Rows[r].DefaultCellStyle.SelectionForeColor = fc;

            }
            catch
            {
                //Error !!
            }

        }

        private bool IsRowHeader(DataGridView dgv, int r)
        {
            var row = dgv.Rows[r];
            var colId = row.Cells[cid.Index];
            var strId = colId.Value.ToString().Trim().ToUpperInvariant();
            return (strId == "");
        }
        
        private void TextTest_TextChanged(object sender, EventArgs e)
        {
            var aux = TextTest.Text.Trim();
            if (string.IsNullOrEmpty(aux))
            {
                GenerateTest();
            }
        }

        private void TextTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {

                if (TextTest.SelectedText.Trim() == TextTest.Text.Trim())
                {
                    TextTest.Text = "";
                }

                // suspend layout to avoid blinking
                TextTest.SuspendLayout();

                // get insertion point
                int insPt = TextTest.SelectionStart;

                // preserve text from after insertion pont to end of RTF content
                string postRTFContent = TextTest.Text.Substring(insPt);

                // remove the content after the insertion point
                TextTest.Text = TextTest.Text.Substring(0, insPt);

                // add the clipboard content and then the preserved postRTF content
                TextTest.Text += (string)Clipboard.GetData("Text") + postRTFContent;

                // adjust the insertion point to just after the inserted text
                TextTest.SelectionStart = TextTest.TextLength - postRTFContent.Length;

                // restore layout
                TextTest.ResumeLayout();

                // cancel the paste
                e.Handled = true;
            }

        }

        private void ComboTests_Enter(object sender, EventArgs e)
        {
            GenerateTest();
        }

        private void TextTest_Leave(object sender, EventArgs e)
        {
            GenerateTest();
        }

        private void ListTest_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeRowStatus(ListTest, e.RowIndex);
        }

        private void ListResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeRowStatus(ListResults, e.RowIndex);
        }

        private bool CheckCtrlKey()
        {
            return ((ModifierKeys & Keys.Control) == Keys.Control);
        }

        private bool CheckShiftKey()
        {
            return ((ModifierKeys & Keys.Shift) == Keys.Shift);
        }

        private void ChangeRowStatus(DataGridView dgv, int rowIndex)
        {
            if (rowIndex != -1 && !IsRowHeader(dgv, rowIndex))
            {
                var status = dgv.Rows[rowIndex].Cells[cstatus.Index].Value.ToString().ToUpperInvariant();
                status = (status == StatusKO) ? StatusOK : StatusKO;
                dgv.Rows[rowIndex].Cells[cstatus.Index].Value = status;

                if(CheckCtrlKey() || CheckShiftKey())
                {
                    if (status == StatusKO)
                    {
                        ChangeStatus(dgv, rowIndex, dgv.RowCount, StatusKO);
                    }
                    else
                    {
                        ChangeStatus(dgv, 0, rowIndex, StatusOK);
                    }
                }
                else
                {
                    if (status == StatusKO)
                    {
                        ChangeStatus(dgv, rowIndex, rowIndex, StatusKO);
                    }
                    else
                    {
                        ChangeStatus(dgv, rowIndex, rowIndex, StatusOK);
                    }
                }
                EvalTest();
                SaveResults();
            }
        }

        private void LnkExample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTest(true);
        }
    }
}
