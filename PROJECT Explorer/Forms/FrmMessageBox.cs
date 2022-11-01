using HAKROS.Classes;
using System;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmMessageBox : Form
    {

        public enum WindowType
        {
            OK = 1,
            KO = 2,
            INFO = 3,
            WARNING = 4,
            QUESTION = 5
        }

        string _message;
        string _title;

        WindowType _currentType;


        public FrmMessageBox(string message, string title, WindowType type)
        {
            InitializeComponent();
            Opacity = 0;
            _message = message;
            _title = title;
            _currentType = type;
            Init();
        }

        private void Init()
        {

            MessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MessageText.Text = _message;

            BtnCancel.Visible = false;
            BtnCancel.Text = "Cancel";
            BtnOk.Text = "Accept";

            if (_currentType == WindowType.OK)
            {
                WindowIcon.Image = iOk.Image;
            }
            else if (_currentType == WindowType.KO)
            {
                WindowIcon.Image = iKO.Image;
            }
            else if (_currentType == WindowType.INFO)
            {
                WindowIcon.Image = iINFO.Image;
            }
            else if (_currentType == WindowType.WARNING)
            {
                WindowIcon.Image = iWARNING.Image;
            }
            else if (_currentType == WindowType.QUESTION)
            {
                WindowIcon.Image = iQUESTION.Image;
                BtnCancel.Text = "No";
                BtnOk.Text = "Yes";
                BtnCancel.Visible = true;
            }
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {
            Text = _title;
            Icon = ClassGeneral.GetIcon();
            CenterToParent();
            TopMost = true;
            Opacity = 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(_currentType == WindowType.QUESTION)
            {
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

    }
}
