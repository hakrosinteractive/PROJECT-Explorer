using HAKROS.Classes;
using System;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmAbout : Form
    {

        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            Text = ClassGeneral.GetWindowTitle("About");
            Icon = ClassGeneral.GetIcon();
            LblVersion.Text = ClassGeneral.GetVersion();
            LblDeveloper.Text = ClassGeneral.GetDeveloper();
            AutoScaleMode = ClassGeneral.AutoScaleMode;
            CenterToParent();
        }

        private void LnkDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassGeneral.LoadWebDeveloper();
        }
    }
}
