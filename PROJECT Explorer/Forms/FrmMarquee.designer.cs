namespace HAKROS.Forms
{
    partial class FrmMarquee
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
            this.Message = new System.Windows.Forms.Label();
            this.THide = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Message.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(12, 7);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(31, 14);
            this.Message.TabIndex = 0;
            this.Message.Text = "xxx";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Message.Click += new System.EventHandler(this.Message_Click);
            // 
            // THide
            // 
            this.THide.Tick += new System.EventHandler(this.THide_Tick);
            // 
            // FrmMarquee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(953, 28);
            this.Controls.Add(this.Message);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMarquee";
            this.Text = "---";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMarquee_FormClosing);
            this.Load += new System.EventHandler(this.FrmMarquee_Load);
            this.Click += new System.EventHandler(this.FrmMarquee_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Timer THide;
    }
}