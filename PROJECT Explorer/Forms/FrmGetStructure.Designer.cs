namespace HAKROS.Forms
{
    partial class FrmGetStructure
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
            this.components = new System.ComponentModel.Container();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.T2 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.Label();
            this.Progressbar = new System.Windows.Forms.ProgressBar();
            this.tcontrol = new System.Windows.Forms.Timer(this.components);
            this.PanelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelTop.Controls.Add(this.label9);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(444, 33);
            this.PanelTop.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Analyzing Solution";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.T2);
            this.panel1.Controls.Add(this.T1);
            this.panel1.Controls.Add(this.Progressbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 79);
            this.panel1.TabIndex = 7;
            // 
            // T2
            // 
            this.T2.AutoSize = true;
            this.T2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2.ForeColor = System.Drawing.Color.Black;
            this.T2.Location = new System.Drawing.Point(13, 28);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(17, 13);
            this.T2.TabIndex = 1;
            this.T2.Text = "--";
            // 
            // T1
            // 
            this.T1.AutoSize = true;
            this.T1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1.ForeColor = System.Drawing.Color.Blue;
            this.T1.Location = new System.Drawing.Point(13, 11);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(17, 13);
            this.T1.TabIndex = 1;
            this.T1.Text = "--";
            // 
            // Progressbar
            // 
            this.Progressbar.Location = new System.Drawing.Point(13, 50);
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(418, 17);
            this.Progressbar.TabIndex = 0;
            // 
            // tcontrol
            // 
            this.tcontrol.Tick += new System.EventHandler(this.tcontrol_Tick);
            // 
            // FrmGetStructure
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 112);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 150);
            this.Name = "FrmGetStructure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "---";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGetStructure_FormClosing);
            this.Load += new System.EventHandler(this.FrmGetStructure_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar Progressbar;
        private System.Windows.Forms.Label T1;
        private System.Windows.Forms.Label T2;
        private System.Windows.Forms.Timer tcontrol;
    }
}