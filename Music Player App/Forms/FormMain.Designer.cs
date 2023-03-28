namespace Music_Player_App
{
    partial class FormMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PanelMenu = new Panel();
            btnSettings = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            btnFolders = new FontAwesome.Sharp.IconButton();
            btnFavourite = new FontAwesome.Sharp.IconButton();
            btnMusics = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            PanelMove = new Panel();
            IconClose = new FontAwesome.Sharp.IconPictureBox();
            IconMinimize = new FontAwesome.Sharp.IconPictureBox();
            PanelBottom = new Panel();
            progressBar1 = new ProgressBar();
            ListNumber = new NumericUpDown();
            IconADDToList = new FontAwesome.Sharp.IconPictureBox();
            IconListMinus = new FontAwesome.Sharp.IconPictureBox();
            IconFavRemove = new FontAwesome.Sharp.IconPictureBox();
            iconFavouriteAdd = new FontAwesome.Sharp.IconPictureBox();
            lblfull = new Label();
            lblPos = new Label();
            iconPause = new FontAwesome.Sharp.IconPictureBox();
            iconPlay = new FontAwesome.Sharp.IconPictureBox();
            iconBack = new FontAwesome.Sharp.IconPictureBox();
            IconFor = new FontAwesome.Sharp.IconPictureBox();
            IconRepeat = new FontAwesome.Sharp.IconPictureBox();
            PanelMain = new Panel();
            lstMusicList = new ListBox();
            Timer1 = new System.Windows.Forms.Timer(components);
            PanelMenu.SuspendLayout();
            PanelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconMinimize).BeginInit();
            PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconADDToList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconListMinus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconFavRemove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconFavouriteAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconFor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconRepeat).BeginInit();
            PanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(30, 30, 80);
            PanelMenu.Controls.Add(btnSettings);
            PanelMenu.Controls.Add(label3);
            PanelMenu.Controls.Add(btnFolders);
            PanelMenu.Controls.Add(btnFavourite);
            PanelMenu.Controls.Add(btnMusics);
            PanelMenu.Controls.Add(label2);
            PanelMenu.Controls.Add(label1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Margin = new Padding(6);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(250, 720);
            PanelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            btnSettings.IconColor = Color.White;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 225);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(250, 50);
            btnSettings.TabIndex = 18;
            btnSettings.Text = "Beállítások";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 672);
            label3.Name = "label3";
            label3.Size = new Size(250, 48);
            label3.TabIndex = 17;
            label3.Text = "Istvan's Production\r\nCopyrigth © 2022\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFolders
            // 
            btnFolders.Dock = DockStyle.Top;
            btnFolders.FlatAppearance.BorderSize = 0;
            btnFolders.FlatStyle = FlatStyle.Flat;
            btnFolders.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFolders.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            btnFolders.IconColor = Color.White;
            btnFolders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFolders.ImageAlign = ContentAlignment.MiddleLeft;
            btnFolders.Location = new Point(0, 175);
            btnFolders.Name = "btnFolders";
            btnFolders.Size = new Size(250, 50);
            btnFolders.TabIndex = 15;
            btnFolders.Text = "Mappák";
            btnFolders.TextAlign = ContentAlignment.MiddleLeft;
            btnFolders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFolders.UseVisualStyleBackColor = true;
            btnFolders.Click += btnFolders_Click;
            // 
            // btnFavourite
            // 
            btnFavourite.Dock = DockStyle.Top;
            btnFavourite.FlatAppearance.BorderSize = 0;
            btnFavourite.FlatStyle = FlatStyle.Flat;
            btnFavourite.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFavourite.IconChar = FontAwesome.Sharp.IconChar.Heart;
            btnFavourite.IconColor = Color.White;
            btnFavourite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFavourite.ImageAlign = ContentAlignment.MiddleLeft;
            btnFavourite.Location = new Point(0, 125);
            btnFavourite.Name = "btnFavourite";
            btnFavourite.Size = new Size(250, 50);
            btnFavourite.TabIndex = 14;
            btnFavourite.Text = "Kedvencek";
            btnFavourite.TextAlign = ContentAlignment.MiddleLeft;
            btnFavourite.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFavourite.UseVisualStyleBackColor = true;
            btnFavourite.Click += btnFavourite_Click;
            // 
            // btnMusics
            // 
            btnMusics.Dock = DockStyle.Top;
            btnMusics.FlatAppearance.BorderSize = 0;
            btnMusics.FlatStyle = FlatStyle.Flat;
            btnMusics.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusics.IconChar = FontAwesome.Sharp.IconChar.Music;
            btnMusics.IconColor = Color.White;
            btnMusics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMusics.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusics.Location = new Point(0, 75);
            btnMusics.Name = "btnMusics";
            btnMusics.Size = new Size(250, 50);
            btnMusics.TabIndex = 12;
            btnMusics.Text = "Számok";
            btnMusics.TextAlign = ContentAlignment.MiddleLeft;
            btnMusics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMusics.UseVisualStyleBackColor = true;
            btnMusics.Click += btnSzamok_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 50);
            label2.Name = "label2";
            label2.Size = new Size(250, 25);
            label2.TabIndex = 2;
            label2.Text = "Verzió 1.0.0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 50);
            label1.TabIndex = 1;
            label1.Text = "Zenelejátszó";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelMove
            // 
            PanelMove.BackColor = Color.FromArgb(30, 30, 80);
            PanelMove.Controls.Add(IconClose);
            PanelMove.Controls.Add(IconMinimize);
            PanelMove.Dock = DockStyle.Top;
            PanelMove.Location = new Point(250, 0);
            PanelMove.Margin = new Padding(6);
            PanelMove.Name = "PanelMove";
            PanelMove.Size = new Size(1030, 50);
            PanelMove.TabIndex = 1;
            PanelMove.Paint += PanelMove_Paint;
            PanelMove.MouseDown += PanelMove_MouseDown;
            PanelMove.MouseMove += PanelMove_MouseMove;
            PanelMove.MouseUp += PanelMove_MouseUp;
            // 
            // IconClose
            // 
            IconClose.BackColor = Color.FromArgb(30, 30, 90);
            IconClose.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            IconClose.IconColor = Color.White;
            IconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconClose.IconSize = 40;
            IconClose.Location = new Point(987, 4);
            IconClose.Name = "IconClose";
            IconClose.Size = new Size(40, 40);
            IconClose.TabIndex = 0;
            IconClose.TabStop = false;
            IconClose.Click += IconClose_Click;
            IconClose.MouseEnter += IconClose_MouseEnter;
            IconClose.MouseLeave += iconPictureBox1_MouseLeave;
            // 
            // IconMinimize
            // 
            IconMinimize.BackColor = Color.FromArgb(30, 30, 90);
            IconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            IconMinimize.IconColor = Color.White;
            IconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMinimize.IconSize = 40;
            IconMinimize.Location = new Point(941, 4);
            IconMinimize.Name = "IconMinimize";
            IconMinimize.Size = new Size(40, 40);
            IconMinimize.TabIndex = 1;
            IconMinimize.TabStop = false;
            IconMinimize.Click += IconMinimize_Click;
            IconMinimize.MouseEnter += IconMinimize_MouseEnter;
            IconMinimize.MouseLeave += IconMinimize_MouseLeave;
            // 
            // PanelBottom
            // 
            PanelBottom.BackColor = Color.FromArgb(30, 30, 60);
            PanelBottom.Controls.Add(progressBar1);
            PanelBottom.Controls.Add(ListNumber);
            PanelBottom.Controls.Add(IconADDToList);
            PanelBottom.Controls.Add(IconListMinus);
            PanelBottom.Controls.Add(IconFavRemove);
            PanelBottom.Controls.Add(iconFavouriteAdd);
            PanelBottom.Controls.Add(lblfull);
            PanelBottom.Controls.Add(lblPos);
            PanelBottom.Controls.Add(iconPause);
            PanelBottom.Controls.Add(iconPlay);
            PanelBottom.Controls.Add(iconBack);
            PanelBottom.Controls.Add(IconFor);
            PanelBottom.Controls.Add(IconRepeat);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(250, 583);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(1030, 137);
            PanelBottom.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(143, 89);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(750, 15);
            progressBar1.TabIndex = 15;
            // 
            // ListNumber
            // 
            ListNumber.BackColor = Color.FromArgb(30, 30, 60);
            ListNumber.ForeColor = Color.White;
            ListNumber.Location = new Point(673, 19);
            ListNumber.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ListNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ListNumber.Name = "ListNumber";
            ListNumber.ReadOnly = true;
            ListNumber.Size = new Size(56, 43);
            ListNumber.TabIndex = 14;
            ListNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // IconADDToList
            // 
            IconADDToList.BackColor = Color.FromArgb(30, 30, 60);
            IconADDToList.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IconADDToList.IconColor = Color.White;
            IconADDToList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconADDToList.IconSize = 40;
            IconADDToList.Location = new Point(627, 22);
            IconADDToList.Name = "IconADDToList";
            IconADDToList.Size = new Size(40, 40);
            IconADDToList.TabIndex = 13;
            IconADDToList.TabStop = false;
            IconADDToList.Click += IconListPlus_Click;
            // 
            // IconListMinus
            // 
            IconListMinus.BackColor = Color.FromArgb(30, 30, 60);
            IconListMinus.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IconListMinus.IconColor = Color.White;
            IconListMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconListMinus.IconSize = 40;
            IconListMinus.Location = new Point(627, 22);
            IconListMinus.Name = "IconListMinus";
            IconListMinus.Size = new Size(40, 40);
            IconListMinus.TabIndex = 12;
            IconListMinus.TabStop = false;
            IconListMinus.Click += IconListMinus_Click;
            // 
            // IconFavRemove
            // 
            IconFavRemove.BackColor = Color.FromArgb(30, 30, 60);
            IconFavRemove.IconChar = FontAwesome.Sharp.IconChar.HeartCircleMinus;
            IconFavRemove.IconColor = Color.White;
            IconFavRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconFavRemove.IconSize = 40;
            IconFavRemove.Location = new Point(377, 22);
            IconFavRemove.Name = "IconFavRemove";
            IconFavRemove.Size = new Size(40, 40);
            IconFavRemove.TabIndex = 11;
            IconFavRemove.TabStop = false;
            IconFavRemove.Click += IconFavRemove_Click;
            // 
            // iconFavouriteAdd
            // 
            iconFavouriteAdd.BackColor = Color.FromArgb(30, 30, 60);
            iconFavouriteAdd.IconChar = FontAwesome.Sharp.IconChar.HeartCirclePlus;
            iconFavouriteAdd.IconColor = Color.White;
            iconFavouriteAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconFavouriteAdd.IconSize = 40;
            iconFavouriteAdd.Location = new Point(377, 22);
            iconFavouriteAdd.Name = "iconFavouriteAdd";
            iconFavouriteAdd.Size = new Size(40, 40);
            iconFavouriteAdd.TabIndex = 10;
            iconFavouriteAdd.TabStop = false;
            iconFavouriteAdd.Click += iconFavourite_Click;
            // 
            // lblfull
            // 
            lblfull.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblfull.Location = new Point(803, 49);
            lblfull.Name = "lblfull";
            lblfull.Size = new Size(90, 23);
            lblfull.TabIndex = 8;
            lblfull.Text = "0:0:0";
            lblfull.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPos
            // 
            lblPos.AutoSize = true;
            lblPos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPos.Location = new Point(143, 49);
            lblPos.Name = "lblPos";
            lblPos.Size = new Size(45, 23);
            lblPos.TabIndex = 7;
            lblPos.Text = "0:0:0";
            lblPos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPause
            // 
            iconPause.BackColor = Color.FromArgb(30, 30, 60);
            iconPause.IconChar = FontAwesome.Sharp.IconChar.Pause;
            iconPause.IconColor = Color.White;
            iconPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPause.IconSize = 60;
            iconPause.Location = new Point(515, 12);
            iconPause.Name = "iconPause";
            iconPause.Size = new Size(60, 60);
            iconPause.TabIndex = 5;
            iconPause.TabStop = false;
            iconPause.Click += iconPause_Click;
            // 
            // iconPlay
            // 
            iconPlay.BackColor = Color.FromArgb(30, 30, 60);
            iconPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            iconPlay.IconColor = Color.White;
            iconPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPlay.IconSize = 60;
            iconPlay.Location = new Point(515, 12);
            iconPlay.Name = "iconPlay";
            iconPlay.Size = new Size(60, 60);
            iconPlay.TabIndex = 4;
            iconPlay.TabStop = false;
            iconPlay.Click += iconPlay_Click;
            // 
            // iconBack
            // 
            iconBack.BackColor = Color.FromArgb(30, 30, 60);
            iconBack.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            iconBack.IconColor = Color.White;
            iconBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBack.IconSize = 40;
            iconBack.Location = new Point(469, 22);
            iconBack.Name = "iconBack";
            iconBack.Size = new Size(40, 40);
            iconBack.TabIndex = 3;
            iconBack.TabStop = false;
            iconBack.Click += iconBack_Click;
            // 
            // IconFor
            // 
            IconFor.BackColor = Color.FromArgb(30, 30, 60);
            IconFor.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            IconFor.IconColor = Color.White;
            IconFor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconFor.IconSize = 40;
            IconFor.Location = new Point(581, 22);
            IconFor.Name = "IconFor";
            IconFor.Size = new Size(40, 40);
            IconFor.TabIndex = 3;
            IconFor.TabStop = false;
            IconFor.Click += IconFor_Click;
            // 
            // IconRepeat
            // 
            IconRepeat.BackColor = Color.FromArgb(30, 30, 60);
            IconRepeat.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            IconRepeat.IconColor = Color.White;
            IconRepeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconRepeat.IconSize = 40;
            IconRepeat.Location = new Point(423, 22);
            IconRepeat.Name = "IconRepeat";
            IconRepeat.Size = new Size(40, 40);
            IconRepeat.TabIndex = 2;
            IconRepeat.TabStop = false;
            IconRepeat.Click += IconRepeat_Click;
            // 
            // PanelMain
            // 
            PanelMain.BackColor = Color.FromArgb(30, 30, 70);
            PanelMain.Controls.Add(lstMusicList);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(250, 50);
            PanelMain.Name = "PanelMain";
            PanelMain.Padding = new Padding(0, 5, 0, 5);
            PanelMain.Size = new Size(1030, 533);
            PanelMain.TabIndex = 4;
            // 
            // lstMusicList
            // 
            lstMusicList.BackColor = Color.FromArgb(30, 30, 70);
            lstMusicList.BorderStyle = BorderStyle.None;
            lstMusicList.Dock = DockStyle.Fill;
            lstMusicList.ForeColor = Color.White;
            lstMusicList.FormattingEnabled = true;
            lstMusicList.ItemHeight = 37;
            lstMusicList.Location = new Point(0, 5);
            lstMusicList.Name = "lstMusicList";
            lstMusicList.Size = new Size(1030, 523);
            lstMusicList.TabIndex = 0;
            lstMusicList.SelectedIndexChanged += lstMusicList_SelectedIndexChanged;
            // 
            // Timer1
            // 
            Timer1.Interval = 50;
            Timer1.Tag = "1";
            Timer1.Tick += Timer_Tick;
            // 
            // FormMainWindow
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 70);
            ClientSize = new Size(1280, 720);
            Controls.Add(PanelMain);
            Controls.Add(PanelBottom);
            Controls.Add(PanelMove);
            Controls.Add(PanelMenu);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zenelejátszó 1.0";
            Load += FormMainWindow_Load;
            PanelMenu.ResumeLayout(false);
            PanelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconMinimize).EndInit();
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconADDToList).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconListMinus).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconFavRemove).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconFavouriteAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconFor).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconRepeat).EndInit();
            PanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelMove;
        private FontAwesome.Sharp.IconPictureBox IconMinimize;
        private FontAwesome.Sharp.IconPictureBox IconClose;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnFolders;
        private FontAwesome.Sharp.IconButton btnFavourite;
        private FontAwesome.Sharp.IconButton btnMusics;
        private Panel PanelBottom;
        private Panel PanelMain;
        private Label label3;
        private ListBox lstMusicList;
        private FontAwesome.Sharp.IconPictureBox IconRepeat;
        private System.Windows.Forms.Timer Timer1;
        private FontAwesome.Sharp.IconPictureBox iconPause;
        private FontAwesome.Sharp.IconPictureBox iconPlay;
        private FontAwesome.Sharp.IconPictureBox iconBack;
        private FontAwesome.Sharp.IconPictureBox IconFor;
        private Label lblPos;
        private Label lblfull;
        private FontAwesome.Sharp.IconPictureBox iconFavouriteAdd;
        private FontAwesome.Sharp.IconPictureBox IconFavRemove;
        private FontAwesome.Sharp.IconPictureBox IconListMinus;
        private FontAwesome.Sharp.IconPictureBox IconADDToList;
        private NumericUpDown ListNumber;
        private FontAwesome.Sharp.IconButton btnSettings;
        private ProgressBar progressBar1;
    }
}