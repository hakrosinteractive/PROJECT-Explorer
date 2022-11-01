using HAKROS.Classes;
using System;
using System.Windows.Forms;

namespace AIRBUS.Forms
{
    public partial class FrmLicense : Form
    {
        public FrmLicense()
        {
            InitializeComponent();
        }

        private void FrmLicense_Load(object sender, EventArgs e)
        {
            base.Text = ClassGeneral.GetWindowTitle("Hakros Interactive (EULA)");
            Icon = ClassGeneral.GetIcon();
            AutoScaleMode = AutoScaleMode.None;
            LoadLicense();
        }

        private void LoadLicense()
        {
            string licenseText = License.Text;
            string currentYear = DateTime.Now.Year.ToString();
            wb.DocumentText = licenseText.Replace("$$YEAR", currentYear);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
