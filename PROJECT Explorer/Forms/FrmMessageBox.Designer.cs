namespace HAKROS.Forms
{
    partial class FrmMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBox));
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.iWARNING = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.iQUESTION = new System.Windows.Forms.PictureBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.iINFO = new System.Windows.Forms.PictureBox();
            this.iOk = new System.Windows.Forms.PictureBox();
            this.iKO = new System.Windows.Forms.PictureBox();
            this.WindowIcon = new System.Windows.Forms.PictureBox();
            this.MessageText = new System.Windows.Forms.Label();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iWARNING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQUESTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iINFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelBottom.Controls.Add(this.iWARNING);
            this.PanelBottom.Controls.Add(this.BtnCancel);
            this.PanelBottom.Controls.Add(this.iQUESTION);
            this.PanelBottom.Controls.Add(this.BtnOk);
            this.PanelBottom.Controls.Add(this.iINFO);
            this.PanelBottom.Controls.Add(this.iOk);
            this.PanelBottom.Controls.Add(this.iKO);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 97);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(434, 45);
            this.PanelBottom.TabIndex = 1;
            // 
            // iWARNING
            // 
            this.iWARNING.Image = ((System.Drawing.Image)(resources.GetObject("iWARNING.Image")));
            this.iWARNING.Location = new System.Drawing.Point(201, 13);
            this.iWARNING.Name = "iWARNING";
            this.iWARNING.Size = new System.Drawing.Size(20, 20);
            this.iWARNING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iWARNING.TabIndex = 23;
            this.iWARNING.TabStop = false;
            this.iWARNING.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Location = new System.Drawing.Point(12, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 31);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // iQUESTION
            // 
            this.iQUESTION.Image = ((System.Drawing.Image)(resources.GetObject("iQUESTION.Image")));
            this.iQUESTION.Location = new System.Drawing.Point(181, 13);
            this.iQUESTION.Name = "iQUESTION";
            this.iQUESTION.Size = new System.Drawing.Size(20, 20);
            this.iQUESTION.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iQUESTION.TabIndex = 23;
            this.iQUESTION.TabStop = false;
            this.iQUESTION.Visible = false;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(322, 7);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 31);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "Accept";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // iINFO
            // 
            this.iINFO.Image = ((System.Drawing.Image)(resources.GetObject("iINFO.Image")));
            this.iINFO.Location = new System.Drawing.Point(161, 13);
            this.iINFO.Name = "iINFO";
            this.iINFO.Size = new System.Drawing.Size(20, 20);
            this.iINFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iINFO.TabIndex = 23;
            this.iINFO.TabStop = false;
            this.iINFO.Visible = false;
            // 
            // iOk
            // 
            this.iOk.Image = ((System.Drawing.Image)(resources.GetObject("iOk.Image")));
            this.iOk.Location = new System.Drawing.Point(121, 13);
            this.iOk.Name = "iOk";
            this.iOk.Size = new System.Drawing.Size(20, 20);
            this.iOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iOk.TabIndex = 23;
            this.iOk.TabStop = false;
            this.iOk.Visible = false;
            // 
            // iKO
            // 
            this.iKO.Image = ((System.Drawing.Image)(resources.GetObject("iKO.Image")));
            this.iKO.Location = new System.Drawing.Point(141, 13);
            this.iKO.Name = "iKO";
            this.iKO.Size = new System.Drawing.Size(20, 20);
            this.iKO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iKO.TabIndex = 23;
            this.iKO.TabStop = false;
            this.iKO.Visible = false;
            // 
            // WindowIcon
            // 
            this.WindowIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WindowIcon.Location = new System.Drawing.Point(12, 9);
            this.WindowIcon.Name = "WindowIcon";
            this.WindowIcon.Size = new System.Drawing.Size(88, 79);
            this.WindowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WindowIcon.TabIndex = 23;
            this.WindowIcon.TabStop = false;
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.Location = new System.Drawing.Point(106, 9);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(316, 79);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.";
            this.MessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 142);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.WindowIcon);
            this.Controls.Add(this.PanelBottom);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 180);
            this.Name = "FrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "--";
            this.Load += new System.EventHandler(this.FrmMessageBox_Load);
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iWARNING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQUESTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iINFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.PictureBox WindowIcon;
        private System.Windows.Forms.PictureBox iOk;
        private System.Windows.Forms.PictureBox iKO;
        private System.Windows.Forms.PictureBox iQUESTION;
        private System.Windows.Forms.PictureBox iINFO;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.PictureBox iWARNING;
    }
}