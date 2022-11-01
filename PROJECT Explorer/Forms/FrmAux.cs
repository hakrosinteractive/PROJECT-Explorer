using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HAKROS.Forms
{
    public partial class FrmAux : Form
    {

        List<PictureBox> ArrayImages = new List<PictureBox>();

        public FrmAux()
        {
            InitializeComponent();
            Opacity = 0;
        }

        public Icon GetIcon()
        {
            return Icon;
        }

        private void FrmAux_Load(object sender, System.EventArgs e)
        {
            //Nothing
        }

        private void LoadArrayPictureBoxes()
        {
            ArrayImages.Clear();
            foreach (PictureBox pic in PanelImages.Controls)
            {
                ArrayImages.Add(pic);
            }
        }

        public List<PictureBox> GetPictureBoxes()
        {
            if (ArrayImages.Count < 25)
            {
                LoadArrayPictureBoxes();
            }
            return ArrayImages;
        }

    }
}
