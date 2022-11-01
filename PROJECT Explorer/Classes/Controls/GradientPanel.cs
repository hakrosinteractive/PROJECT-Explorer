//
using System;
using System.Drawing;
using System.Windows.Forms;
//
namespace HAKROS
{
    public partial class GradientPanel : Panel
    {

        //SPECIAL DECLARATIONS
        //***************************************************************************************************************************************************
        /// <summary>
        /// This declaration set double buffered for all controls
        /// </summary>
        protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ExStyle |= 0x02000000; return cp; } }

        //DECLARATIONS
        //***************************************************************************************************************************************************
        private Color _c1 = Color.White;
        private Color _c2 = Color.LightGray;
        private bool RequestUpdate = false;
        private float _angle = 90;

        public Color Color1
        {
            get
            {
                return _c1;
            }
            set
            {
                _c1 = value;
                RequestUpdate = true;
                DrawGradient();
            }
        }

        public Color Color2
        {
            get
            {
                return _c2;
            }
            set
            {
                _c2 = value;
                RequestUpdate = true;
                DrawGradient();
            }
        }

        public float Angle
        {
            get
            {
                return _angle;
            }
            set
            {
                _angle = value;
                RequestUpdate = true;
                DrawGradient();
            }
        }

        //CONSTRUCTOR
        //***************************************************************************************************************************************************	
        public GradientPanel()
        {
            InitializeComponent();
            DoubleBuffered = true;
            RequestUpdate = true;
            DrawGradient();
        }

        //EVENTS
        //***************************************************************************************************************************************************
        private void GradientPanel_SizeChanged(object sender, EventArgs e)
        {
            RequestUpdate = true;
            DrawGradient();
        }

        //METHODS
        //***************************************************************************************************************************************************
        
        /// <summary>
        /// Standard paint event method
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawGradient();
        }

        /// <summary>
        /// Draw gradient effect
        /// </summary>
        private void DrawGradient()
        {
            if(RequestUpdate)
            {
                //
                try
                {
                    //
                    System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
                    //
                    gradBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), Color1, Color2, Angle);
                    //
                    Bitmap bmp = new Bitmap(this.Width, this.Height);
                    //
                    Graphics g = Graphics.FromImage(bmp);
                    //
                    g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
                    //
                    this.BackgroundImage = bmp;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    //
                }
                catch (Exception)
                {
                    //Graphic error !
                }
                //
                RequestUpdate = false;
                //
            }
        }

    }
}
