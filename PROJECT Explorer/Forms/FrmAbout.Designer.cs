namespace HAKROS.Forms
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblDeveloper = new System.Windows.Forms.Label();
            this.LnkDeveloper = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblVersion
            // 
            this.LblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVersion.BackColor = System.Drawing.Color.Transparent;
            this.LblVersion.Location = new System.Drawing.Point(311, 9);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(241, 13);
            this.LblVersion.TabIndex = 1;
            this.LblVersion.Text = "ClassGeneral.GetVersion()";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDeveloper
            // 
            this.LblDeveloper.AutoSize = true;
            this.LblDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.LblDeveloper.Location = new System.Drawing.Point(12, 8);
            this.LblDeveloper.Name = "LblDeveloper";
            this.LblDeveloper.Size = new System.Drawing.Size(190, 14);
            this.LblDeveloper.TabIndex = 1;
            this.LblDeveloper.Text = "ClassGeneral.GetDeveloper()";
            // 
            // LnkDeveloper
            // 
            this.LnkDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkDeveloper.AutoSize = true;
            this.LnkDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.LnkDeveloper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkDeveloper.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkDeveloper.LinkColor = System.Drawing.Color.White;
            this.LnkDeveloper.Location = new System.Drawing.Point(438, 239);
            this.LnkDeveloper.Name = "LnkDeveloper";
            this.LnkDeveloper.Size = new System.Drawing.Size(116, 14);
            this.LnkDeveloper.TabIndex = 2;
            this.LnkDeveloper.TabStop = true;
            this.LnkDeveloper.Text = "www.hakros.com";
            this.LnkDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkDeveloper_LinkClicked);
            // 
            // FrmAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 261);
            this.Controls.Add(this.LnkDeveloper);
            this.Controls.Add(this.LblDeveloper);
            this.Controls.Add(this.LblVersion);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 300);
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "--";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblDeveloper;
        private System.Windows.Forms.LinkLabel LnkDeveloper;
    }
}