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
            tlp1 = new TableLayoutPanel();
            lstFolders = new ListBox();
            P1 = new Panel();
            iconDeleteFolder = new FontAwesome.Sharp.IconPictureBox();
            iconAddFolder = new FontAwesome.Sharp.IconPictureBox();
            tlp1.SuspendLayout();
            P1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDeleteFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconAddFolder).BeginInit();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.Controls.Add(lstFolders, 0, 1);
            tlp1.Controls.Add(P1, 0, 0);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(5, 5);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp1.Size = new Size(1020, 510);
            tlp1.TabIndex = 0;
            // 
            // lstFolders
            // 
            lstFolders.BackColor = Color.FromArgb(30, 30, 70);
            lstFolders.BorderStyle = BorderStyle.None;
            lstFolders.Dock = DockStyle.Fill;
            lstFolders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstFolders.ForeColor = Color.White;
            lstFolders.FormattingEnabled = true;
            lstFolders.ItemHeight = 28;
            lstFolders.Location = new Point(3, 63);
            lstFolders.Name = "lstFolders";
            lstFolders.Size = new Size(1014, 444);
            lstFolders.TabIndex = 2;
            // 
            // P1
            // 
            P1.Controls.Add(iconDeleteFolder);
            P1.Controls.Add(iconAddFolder);
            P1.Dock = DockStyle.Fill;
            P1.Location = new Point(3, 3);
            P1.Name = "P1";
            P1.Size = new Size(1014, 54);
            P1.TabIndex = 0;
            // 
            // iconDeleteFolder
            // 
            iconDeleteFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconDeleteFolder.BackColor = Color.FromArgb(30, 30, 50);
            iconDeleteFolder.IconChar = FontAwesome.Sharp.IconChar.FolderMinus;
            iconDeleteFolder.IconColor = Color.White;
            iconDeleteFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDeleteFolder.IconSize = 45;
            iconDeleteFolder.Location = new Point(966, 3);
            iconDeleteFolder.Name = "iconDeleteFolder";
            iconDeleteFolder.Size = new Size(45, 45);
            iconDeleteFolder.TabIndex = 8;
            iconDeleteFolder.TabStop = false;
            iconDeleteFolder.Click += iconDeleteFolder_Click;
            iconDeleteFolder.MouseEnter += iconDeleteFolder_MouseEnter;
            iconDeleteFolder.MouseLeave += iconDeleteFolder_MouseLeave;
            // 
            // iconAddFolder
            // 
            iconAddFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconAddFolder.BackColor = Color.FromArgb(30, 30, 50);
            iconAddFolder.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            iconAddFolder.IconColor = Color.White;
            iconAddFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAddFolder.IconSize = 45;
            iconAddFolder.Location = new Point(915, 3);
            iconAddFolder.Name = "iconAddFolder";
            iconAddFolder.Size = new Size(45, 45);
            iconAddFolder.TabIndex = 7;
            iconAddFolder.TabStop = false;
            iconAddFolder.Click += iconPictureBox1_Click;
            iconAddFolder.MouseEnter += iconAddFolder_MouseEnter;
            iconAddFolder.MouseLeave += iconAddFolder_MouseLeave;
            // 
            // Form_Folders
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 70);
            ClientSize = new Size(1030, 520);
            Controls.Add(tlp1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Form_Folders";
            Padding = new Padding(5);
            Text = "Form_Folders";
            Load += Form_Folders_Load;
            tlp1.ResumeLayout(false);
            P1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconDeleteFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconAddFolder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private Panel P1;
        private FontAwesome.Sharp.IconPictureBox iconDeleteFolder;
        private FontAwesome.Sharp.IconPictureBox iconAddFolder;
        private ListBox lstFolders;
    }
}