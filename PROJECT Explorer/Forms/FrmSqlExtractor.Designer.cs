namespace HAKROS.Forms
{
    partial class FrmSqlExtractor
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
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.OpcAll = new System.Windows.Forms.RadioButton();
            this.OpcExtract = new System.Windows.Forms.RadioButton();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.ListFilesNames = new System.Windows.Forms.ListBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnalyze.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalyze.Location = new System.Drawing.Point(216, 12);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(206, 31);
            this.BtnAnalyze.TabIndex = 18;
            this.BtnAnalyze.Text = "Add sql files..";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // OpcAll
            // 
            this.OpcAll.AutoSize = true;
            this.OpcAll.Checked = true;
            this.OpcAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcAll.Location = new System.Drawing.Point(12, 397);
            this.OpcAll.Name = "OpcAll";
            this.OpcAll.Size = new System.Drawing.Size(127, 18);
            this.OpcAll.TabIndex = 19;
            this.OpcAll.TabStop = true;
            this.OpcAll.Text = "Include all script";
            this.OpcAll.UseVisualStyleBackColor = true;
            // 
            // OpcExtract
            // 
            this.OpcExtract.AutoSize = true;
            this.OpcExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcExtract.Location = new System.Drawing.Point(145, 397);
            this.OpcExtract.Name = "OpcExtract";
            this.OpcExtract.Size = new System.Drawing.Size(125, 18);
            this.OpcExtract.TabIndex = 19;
            this.OpcExtract.Text = "Extract sql code";
            this.OpcExtract.UseVisualStyleBackColor = true;
            // 
            // BtnProcess
            // 
            this.BtnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProcess.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcess.Location = new System.Drawing.Point(12, 420);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(410, 31);
            this.BtnProcess.TabIndex = 17;
            this.BtnProcess.Text = "Process files..";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // ListFilesNames
            // 
            this.ListFilesNames.BackColor = System.Drawing.Color.Lavender;
            this.ListFilesNames.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListFilesNames.ForeColor = System.Drawing.Color.Black;
            this.ListFilesNames.FormattingEnabled = true;
            this.ListFilesNames.IntegralHeight = false;
            this.ListFilesNames.Location = new System.Drawing.Point(12, 49);
            this.ListFilesNames.Name = "ListFilesNames";
            this.ListFilesNames.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListFilesNames.Size = new System.Drawing.Size(410, 342);
            this.ListFilesNames.TabIndex = 0;
            this.ListFilesNames.TabStop = false;
            // 
            // BtnClear
            // 
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(12, 12);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(198, 31);
            this.BtnClear.TabIndex = 20;
            this.BtnClear.Text = "Clear list..";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmSqlExtractor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 462);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.ListFilesNames);
            this.Controls.Add(this.OpcExtract);
            this.Controls.Add(this.OpcAll);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.BtnAnalyze);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "FrmSqlExtractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmSqlExtractor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAnalyze;
        private System.Windows.Forms.RadioButton OpcAll;
        private System.Windows.Forms.RadioButton OpcExtract;
        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.ListBox ListFilesNames;
        private System.Windows.Forms.Button BtnClear;
    }
}