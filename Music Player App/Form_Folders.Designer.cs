namespace Music_Player_App
{
    partial class Form_Folders
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
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.iconAddFolder = new FontAwesome.Sharp.IconPictureBox();
            this.iconDeleteFolder = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDeleteFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFolders
            // 
            this.lstFolders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.lstFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFolders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFolders.ForeColor = System.Drawing.Color.White;
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.ItemHeight = 37;
            this.lstFolders.Location = new System.Drawing.Point(5, 71);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(1020, 444);
            this.lstFolders.TabIndex = 0;
            // 
            // iconAddFolder
            // 
            this.iconAddFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.iconAddFolder.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.iconAddFolder.IconColor = System.Drawing.Color.White;
            this.iconAddFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddFolder.IconSize = 55;
            this.iconAddFolder.Location = new System.Drawing.Point(970, 8);
            this.iconAddFolder.Name = "iconAddFolder";
            this.iconAddFolder.Size = new System.Drawing.Size(55, 55);
            this.iconAddFolder.TabIndex = 1;
            this.iconAddFolder.TabStop = false;
            this.iconAddFolder.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.iconAddFolder.MouseEnter += new System.EventHandler(this.iconAddFolder_MouseEnter);
            this.iconAddFolder.MouseLeave += new System.EventHandler(this.iconAddFolder_MouseLeave);
            // 
            // iconDeleteFolder
            // 
            this.iconDeleteFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.iconDeleteFolder.IconChar = FontAwesome.Sharp.IconChar.FolderMinus;
            this.iconDeleteFolder.IconColor = System.Drawing.Color.White;
            this.iconDeleteFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDeleteFolder.IconSize = 55;
            this.iconDeleteFolder.Location = new System.Drawing.Point(906, 8);
            this.iconDeleteFolder.Name = "iconDeleteFolder";
            this.iconDeleteFolder.Size = new System.Drawing.Size(55, 55);
            this.iconDeleteFolder.TabIndex = 2;
            this.iconDeleteFolder.TabStop = false;
            this.iconDeleteFolder.Click += new System.EventHandler(this.iconDeleteFolder_Click);
            this.iconDeleteFolder.MouseEnter += new System.EventHandler(this.iconDeleteFolder_MouseEnter);
            this.iconDeleteFolder.MouseLeave += new System.EventHandler(this.iconDeleteFolder_MouseLeave);
            // 
            // Form_Folders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1030, 520);
            this.Controls.Add(this.iconDeleteFolder);
            this.Controls.Add(this.iconAddFolder);
            this.Controls.Add(this.lstFolders);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Folders";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form_Folders";
            this.Load += new System.EventHandler(this.Form_Folders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconAddFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDeleteFolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstFolders;
        private FontAwesome.Sharp.IconPictureBox iconAddFolder;
        private FontAwesome.Sharp.IconPictureBox iconDeleteFolder;
    }
}