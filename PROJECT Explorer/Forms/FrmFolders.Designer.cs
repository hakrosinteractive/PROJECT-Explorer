namespace HAKROS.Forms
{
    partial class FrmFolders
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.BtnRemoveSelection = new System.Windows.Forms.Button();
            this.BtnAddFolder = new System.Windows.Forms.Button();
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
            this.PanelTop.Size = new System.Drawing.Size(684, 33);
            this.PanelTop.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Folders Manager";
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.Lavender;
            this.List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.ForeColor = System.Drawing.Color.Black;
            this.List.FormattingEnabled = true;
            this.List.IntegralHeight = false;
            this.List.ItemHeight = 14;
            this.List.Location = new System.Drawing.Point(0, 33);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(684, 334);
            this.List.Sorted = true;
            this.List.TabIndex = 7;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.BtnRemoveAll);
            this.panel1.Controls.Add(this.BtnRemoveSelection);
            this.panel1.Controls.Add(this.BtnAddFolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 45);
            this.panel1.TabIndex = 8;
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveAll.Location = new System.Drawing.Point(12, 7);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(103, 31);
            this.BtnRemoveAll.TabIndex = 19;
            this.BtnRemoveAll.Text = "Remove all";
            this.BtnRemoveAll.UseVisualStyleBackColor = true;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // BtnRemoveSelection
            // 
            this.BtnRemoveSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveSelection.Location = new System.Drawing.Point(121, 7);
            this.BtnRemoveSelection.Name = "BtnRemoveSelection";
            this.BtnRemoveSelection.Size = new System.Drawing.Size(149, 31);
            this.BtnRemoveSelection.TabIndex = 19;
            this.BtnRemoveSelection.Text = "Remove selection";
            this.BtnRemoveSelection.UseVisualStyleBackColor = true;
            this.BtnRemoveSelection.Click += new System.EventHandler(this.BtnRemoveSelection_Click);
            // 
            // BtnAddFolder
            // 
            this.BtnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddFolder.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFolder.Location = new System.Drawing.Point(560, 7);
            this.BtnAddFolder.Name = "BtnAddFolder";
            this.BtnAddFolder.Size = new System.Drawing.Size(112, 31);
            this.BtnAddFolder.TabIndex = 20;
            this.BtnAddFolder.Text = "Add folder..";
            this.BtnAddFolder.UseVisualStyleBackColor = true;
            this.BtnAddFolder.Click += new System.EventHandler(this.BtnAddFolder_Click);
            // 
            // FrmFolders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.List);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FrmFolders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "---";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFolders_FormClosing);
            this.Load += new System.EventHandler(this.FrmFolders_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRemoveSelection;
        private System.Windows.Forms.Button BtnAddFolder;
        private System.Windows.Forms.Button BtnRemoveAll;
    }
}