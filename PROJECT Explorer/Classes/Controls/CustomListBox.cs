using System.Drawing;
using System.Windows.Forms;

namespace HAKROS.Classes.Controls
{
    public class CustomListBox : ListBox
    {

        public CustomListBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        Color _itemBackColor = Color.White;
        Color _itemForeColor = Color.Black;
        Color _itemSelectionBackColor = Color.Red;
        Color _itemSelectionForeColor = Color.White;

        public Color ItemBackColor
        {
            get { return _itemBackColor; }
            set { _itemBackColor = value; Invalidate(); }
        }

        public Color ItemForeColor
        {
            get { return _itemForeColor; }
            set { _itemForeColor = value; Invalidate(); }
        }

        public Color ItemSelectionBackColor
        {
            get { return _itemSelectionBackColor; }
            set { _itemSelectionBackColor = value; Invalidate(); }
        }

        public Color ItemSelectionForeColor
        {
            get { return _itemSelectionForeColor; }
            set { _itemSelectionForeColor = value; Invalidate(); }
        }

    }
}
