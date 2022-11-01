using HAKROS.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmMarquee : Form
    {

        #region HideAltTab

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x80;
                return cp;
            }
        }

        #endregion

        public FrmMarquee()
        {
            InitializeComponent();
            Message.Text = "Loading..";
        }

        private void FrmMarquee_Load(object sender, EventArgs e)
        {
            Text = ClassGeneral.GetWindowTitle();
            Icon = ClassGeneral.GetIcon();
            SetWindowPosition();
        }

        public void Init(string m, Color bg, Color fc, bool animation)
        {
            THide.Enabled = false;
            BackColor = bg;
            Message.ForeColor = fc;
            Message.Text = m;
        }

        private void FrmMarquee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Opacity != 0)
            {
                e.Cancel = true;
                THide.Interval = 20;
                THide.Enabled = true;
            }
            else
            {
                THide.Enabled = false;
            }
        }

        private void THide_Tick(object sender, EventArgs e)
        {
            TopMost = true;
            if (Opacity == 0)
            {
                Close();
            }
            else
            {
                Opacity -= 0.1;
            }
        }

        private void SetWindowPosition()
        {
            TopMost = true;

            int winW = Screen.GetWorkingArea(this).Width;
            int winH = Screen.GetWorkingArea(this).Height;

            int w = winW;
            int h = 30;

            Size = new Size(w, h);

            MaximumSize = Size;
            MinimumSize = Size;

            int x = 0;
            int y = winH - Height;

            Location = new Point(x, y);

            ShowInTaskbar = false;

        }

        private void Message_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMarquee_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
