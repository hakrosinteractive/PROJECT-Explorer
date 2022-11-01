using HAKROS.Classes;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmFolders : Form
    {
        
        public FrmFolders()
        {
            InitializeComponent();
        }

        private void FrmFolders_Load(object sender, EventArgs e)
        {
            base.Text = ClassGeneral.GetWindowTitle("Folders Manager");
            Icon = ClassGeneral.GetIcon();
            AutoScaleMode = AutoScaleMode.None;
            LoadFolders();
        }

        private void LoadFolders()
        {
            try
            {
                //
                List.Sorted = true;
                List.Items.Clear();
                //
                var f = ClassGeneral.FileFolders();
                if (File.Exists(f))
                {
                    var sr = new StreamReader(f, Encoding.UTF8, true);
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        if (!List.Items.Contains(line))
                        {
                            List.Items.Add(line);
                        }
                    }
                    sr.Close();
                }
                //
            }
            catch
            {
                //Error !!
            }
            EvalButtons();
        }

        private void SaveFolders()
        {
            try
            {
                var f = ClassGeneral.FileFolders();
                var wr = new StreamWriter(f, false, Encoding.UTF8);
                foreach(var item in List.Items)
                {
                    wr.WriteLine(item);
                }
                wr.Close();
            }
            catch
            {
                //Error !!
            }
        }

        private void BtnRemoveSelection_Click(object sender, EventArgs e)
        {
            if(List.SelectedIndex != -1)
            {
                if (MessageBox.Show("Do you want to delete selected path?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List.Items.RemoveAt(List.SelectedIndex);
                }
            }
            EvalButtons();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete all paths?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List.Items.Clear();
            }
            EvalButtons();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            EvalButtons();
        }

        private void EvalButtons()
        {
            BtnRemoveSelection.Enabled = (List.SelectedIndex != -1);
            BtnRemoveAll.Enabled = (List.Items.Count > 0);
        }

        private void BtnAddFolder_Click(object sender, EventArgs e)
        {

            if(Directory.Exists(List.Text))
            {
                ClassGeneral.LastSelectedPath = List.Text;
            }

            var fbd = new FolderBrowserDialog();
            fbd.Description = "Select a root folder..";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.SelectedPath = ClassGeneral.LastSelectedPath;
            fbd.ShowNewFolderButton = false;
            if(fbd.ShowDialog() == DialogResult.OK)
            {

                ClassGeneral.LastSelectedPath = fbd.SelectedPath;

                if(!List.Items.Contains(ClassGeneral.LastSelectedPath))
                {
                    List.Items.Add(ClassGeneral.LastSelectedPath);
                }

            }
            EvalButtons();
        }

        private void FrmFolders_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFolders();
        }
    }
}
