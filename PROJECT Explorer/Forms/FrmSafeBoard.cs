using HAKROS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmSafeBoard : Form
    {

        private string InternalPass = "";

        List<PictureBox> ArrayImages = new List<PictureBox>();
        List<string> ArrayValues = new List<string>();
        List<string> ArrayNames = new List<string>();

        public FrmSafeBoard()
        {
            InitializeComponent();
        }

        private void FrmSafePass_Load(object sender, EventArgs e)
        {
            Text = ClassGeneral.GetWindowTitle("Safeboard");
            Icon = ClassGeneral.GetIcon();
            ResetPass();
        }

        private void FrmSafeBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetPass();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPass();
        }

        private void ResetPass()
        {
            InternalPass = "";
            SafePassword.Text = "";
            ArrayNames.Clear();
            if (ArrayImages.Count == 0)
            {
                var go = new FrmAux();
                ArrayImages = go.GetPictureBoxes();
            }
            if (ArrayImages.Count > 0)
            {
                Random rnd = new Random();
                var randomArray = ArrayImages.OrderBy(x => rnd.Next()).ToArray();
                var k = 0;
                while(k < PanelImages.Controls.Count)
                {
                    var pic1 = (PictureBox)PanelImages.Controls[k];
                    var pic2 = randomArray[k];
                    pic1.BackColor = Color.White;
                    pic1.Cursor = Cursors.Hand;
                    pic1.Image = pic2.Image;
                    pic1.Tag = pic2.Tag;
                    k += 1;
                }
            }
        }

        private void PictureBoxClick(object obj)
        {
            try
            {
                var pic = (PictureBox)obj;
                var tag = pic.Tag.ToString();
                if (!ArrayNames.Contains(pic.Name))
                {
                    InternalPass = InternalPass + ";" + tag;
                    ArrayNames.Add(pic.Name);
                    pic.BackColor = Color.Navy;
                }
                else
                {
                    InternalPass = InternalPass.Replace(";" + tag, "");
                    ArrayNames.Remove(pic.Name);
                    pic.BackColor = Color.White;
                }
                GenerateSafePass();
            }
            catch
            {
                //Error !!
            }
        }

        private void GenerateSafePass()
        {
            SafePassword.Text = (InternalPass != "") ? ClassSecurity.GetSafePass(InternalPass) : "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            PictureBoxClick(sender);
        }

        private void LnkClipboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CopyToClipboard();
        }

        private void CopyToClipboard()
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(SafePassword.Text);
            }
            catch
            {
                //Error !!
            }
        }

    }
}
