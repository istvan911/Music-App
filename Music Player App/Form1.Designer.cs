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
            this.components = new System.ComponentModel.Container();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFolders = new FontAwesome.Sharp.IconButton();
            this.btnFavourite = new FontAwesome.Sharp.IconButton();
            this.btnMusics = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMove = new System.Windows.Forms.Panel();
            this.IconClose = new FontAwesome.Sharp.IconPictureBox();
            this.IconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ListNumber = new System.Windows.Forms.NumericUpDown();
            this.IconADDToList = new FontAwesome.Sharp.IconPictureBox();
            this.IconListMinus = new FontAwesome.Sharp.IconPictureBox();
            this.IconFavRemove = new FontAwesome.Sharp.IconPictureBox();
            this.iconFavouriteAdd = new FontAwesome.Sharp.IconPictureBox();
            this.PanelBack = new System.Windows.Forms.Panel();
            this.PanelFor = new System.Windows.Forms.Panel();
            this.lblfull = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.iconPause = new FontAwesome.Sharp.IconPictureBox();
            this.iconPlay = new FontAwesome.Sharp.IconPictureBox();
            this.iconBack = new FontAwesome.Sharp.IconPictureBox();
            this.IconFor = new FontAwesome.Sharp.IconPictureBox();
            this.IconRepeat = new FontAwesome.Sharp.IconPictureBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.lstLists = new System.Windows.Forms.ListBox();
            this.lstMusicList = new System.Windows.Forms.ListBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.PanelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimize)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconADDToList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconListMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconFavRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFavouriteAdd)).BeginInit();
            this.PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRepeat)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.PanelMenu.Controls.Add(this.btnSettings);
            this.PanelMenu.Controls.Add(this.label3);
            this.PanelMenu.Controls.Add(this.btnFolders);
            this.PanelMenu.Controls.Add(this.btnFavourite);
            this.PanelMenu.Controls.Add(this.btnMusics);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(250, 720);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 225);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 50);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "Beállítások";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 48);
            this.label3.TabIndex = 17;
            this.label3.Text = "Istvan\'s Production\r\nCopyrigth © 2022\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFolders
            // 
            this.btnFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFolders.FlatAppearance.BorderSize = 0;
            this.btnFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolders.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFolders.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            this.btnFolders.IconColor = System.Drawing.Color.White;
            this.btnFolders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolders.Location = new System.Drawing.Point(0, 175);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(250, 50);
            this.btnFolders.TabIndex = 15;
            this.btnFolders.Text = "Mappák";
            this.btnFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // btnFavourite
            // 
            this.btnFavourite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavourite.FlatAppearance.BorderSize = 0;
            this.btnFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourite.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFavourite.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnFavourite.IconColor = System.Drawing.Color.White;
            this.btnFavourite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFavourite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavourite.Location = new System.Drawing.Point(0, 125);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.Size = new System.Drawing.Size(250, 50);
            this.btnFavourite.TabIndex = 14;
            this.btnFavourite.Text = "Kedvencek";
            this.btnFavourite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavourite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavourite.UseVisualStyleBackColor = true;
            this.btnFavourite.Click += new System.EventHandler(this.btnFavourite_Click);
            // 
            // btnMusics
            // 
            this.btnMusics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusics.FlatAppearance.BorderSize = 0;
            this.btnMusics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusics.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMusics.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnMusics.IconColor = System.Drawing.Color.White;
            this.btnMusics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMusics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusics.Location = new System.Drawing.Point(0, 75);
            this.btnMusics.Name = "btnMusics";
            this.btnMusics.Size = new System.Drawing.Size(250, 50);
            this.btnMusics.TabIndex = 12;
            this.btnMusics.Text = "Számok";
            this.btnMusics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusics.UseVisualStyleBackColor = true;
            this.btnMusics.Click += new System.EventHandler(this.btnSzamok_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verzió 1.0.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zenelejátszó";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMove
            // 
            this.PanelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.PanelMove.Controls.Add(this.IconClose);
            this.PanelMove.Controls.Add(this.IconMinimize);
            this.PanelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMove.Location = new System.Drawing.Point(250, 0);
            this.PanelMove.Margin = new System.Windows.Forms.Padding(6);
            this.PanelMove.Name = "PanelMove";
            this.PanelMove.Size = new System.Drawing.Size(1030, 50);
            this.PanelMove.TabIndex = 1;
            this.PanelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseDown);
            this.PanelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseMove);
            this.PanelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseUp);
            // 
            // IconClose
            // 
            this.IconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.IconClose.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.IconClose.IconColor = System.Drawing.Color.White;
            this.IconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconClose.IconSize = 40;
            this.IconClose.Location = new System.Drawing.Point(987, 4);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(40, 40);
            this.IconClose.TabIndex = 0;
            this.IconClose.TabStop = false;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            this.IconClose.MouseEnter += new System.EventHandler(this.IconClose_MouseEnter);
            this.IconClose.MouseLeave += new System.EventHandler(this.iconPictureBox1_MouseLeave);
            // 
            // IconMinimize
            // 
            this.IconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.IconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.IconMinimize.IconColor = System.Drawing.Color.White;
            this.IconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMinimize.IconSize = 40;
            this.IconMinimize.Location = new System.Drawing.Point(941, 4);
            this.IconMinimize.Name = "IconMinimize";
            this.IconMinimize.Size = new System.Drawing.Size(40, 40);
            this.IconMinimize.TabIndex = 1;
            this.IconMinimize.TabStop = false;
            this.IconMinimize.Click += new System.EventHandler(this.IconMinimize_Click);
            this.IconMinimize.MouseEnter += new System.EventHandler(this.IconMinimize_MouseEnter);
            this.IconMinimize.MouseLeave += new System.EventHandler(this.IconMinimize_MouseLeave);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.PanelBottom.Controls.Add(this.ListNumber);
            this.PanelBottom.Controls.Add(this.IconADDToList);
            this.PanelBottom.Controls.Add(this.IconListMinus);
            this.PanelBottom.Controls.Add(this.IconFavRemove);
            this.PanelBottom.Controls.Add(this.iconFavouriteAdd);
            this.PanelBottom.Controls.Add(this.PanelBack);
            this.PanelBottom.Controls.Add(this.lblfull);
            this.PanelBottom.Controls.Add(this.lblPos);
            this.PanelBottom.Controls.Add(this.iconPause);
            this.PanelBottom.Controls.Add(this.iconPlay);
            this.PanelBottom.Controls.Add(this.iconBack);
            this.PanelBottom.Controls.Add(this.IconFor);
            this.PanelBottom.Controls.Add(this.IconRepeat);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(250, 583);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1030, 137);
            this.PanelBottom.TabIndex = 3;
            // 
            // ListNumber
            // 
            this.ListNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ListNumber.ForeColor = System.Drawing.Color.White;
            this.ListNumber.Location = new System.Drawing.Point(673, 19);
            this.ListNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ListNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ListNumber.Name = "ListNumber";
            this.ListNumber.ReadOnly = true;
            this.ListNumber.Size = new System.Drawing.Size(56, 43);
            this.ListNumber.TabIndex = 14;
            this.ListNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IconADDToList
            // 
            this.IconADDToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.IconADDToList.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.IconADDToList.IconColor = System.Drawing.Color.White;
            this.IconADDToList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconADDToList.IconSize = 40;
            this.IconADDToList.Location = new System.Drawing.Point(627, 22);
            this.IconADDToList.Name = "IconADDToList";
            this.IconADDToList.Size = new System.Drawing.Size(40, 40);
            this.IconADDToList.TabIndex = 13;
            this.IconADDToList.TabStop = false;
            this.IconADDToList.Click += new System.EventHandler(this.IconListPlus_Click);
            // 
            // IconListMinus
            // 
            this.IconListMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.IconListMinus.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.IconListMinus.IconColor = System.Drawing.Color.White;
            this.IconListMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconListMinus.IconSize = 40;
            this.IconListMinus.Location = new System.Drawing.Point(627, 22);
            this.IconListMinus.Name = "IconListMinus";
            this.IconListMinus.Size = new System.Drawing.Size(40, 40);
            this.IconListMinus.TabIndex = 12;
            this.IconListMinus.TabStop = false;
            this.IconListMinus.Click += new System.EventHandler(this.IconListMinus_Click);
            // 
            // IconFavRemove
            // 
            this.IconFavRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.IconFavRemove.IconChar = FontAwesome.Sharp.IconChar.HeartCircleMinus;
            this.IconFavRemove.IconColor = System.Drawing.Color.White;
            this.IconFavRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconFavRemove.IconSize = 40;
            this.IconFavRemove.Location = new System.Drawing.Point(377, 22);
            this.IconFavRemove.Name = "IconFavRemove";
            this.IconFavRemove.Size = new System.Drawing.Size(40, 40);
            this.IconFavRemove.TabIndex = 11;
            this.IconFavRemove.TabStop = false;
            this.IconFavRemove.Click += new System.EventHandler(this.IconFavRemove_Click);
            // 
            // iconFavouriteAdd
            // 
            this.iconFavouriteAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.iconFavouriteAdd.IconChar = FontAwesome.Sharp.IconChar.HeartCirclePlus;
            this.iconFavouriteAdd.IconColor = System.Drawing.Color.White;
            this.iconFavouriteAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFavouriteAdd.IconSize = 40;
            this.iconFavouriteAdd.Location = new System.Drawing.Point(377, 22);
            this.iconFavouriteAdd.Name = "iconFavouriteAdd";
            this.iconFavouriteAdd.Size = new System.Drawing.Size(40, 40);
            this.iconFavouriteAdd.TabIndex = 10;
            this.iconFavouriteAdd.TabStop = false;
            this.iconFavouriteAdd.Click += new System.EventHandler(this.iconFavourite_Click);
            // 
            // PanelBack
            // 
            this.PanelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.PanelBack.Controls.Add(this.PanelFor);
            this.PanelBack.Location = new System.Drawing.Point(144, 81);
            this.PanelBack.Name = "PanelBack";
            this.PanelBack.Size = new System.Drawing.Size(750, 10);
            this.PanelBack.TabIndex = 9;
            // 
            // PanelFor
            // 
            this.PanelFor.BackColor = System.Drawing.Color.Red;
            this.PanelFor.Location = new System.Drawing.Point(0, 0);
            this.PanelFor.Name = "PanelFor";
            this.PanelFor.Size = new System.Drawing.Size(0, 10);
            this.PanelFor.TabIndex = 10;
            // 
            // lblfull
            // 
            this.lblfull.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfull.Location = new System.Drawing.Point(803, 49);
            this.lblfull.Name = "lblfull";
            this.lblfull.Size = new System.Drawing.Size(90, 23);
            this.lblfull.TabIndex = 8;
            this.lblfull.Text = "0:0:0";
            this.lblfull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPos.Location = new System.Drawing.Point(143, 49);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(45, 23);
            this.lblPos.TabIndex = 7;
            this.lblPos.Text = "0:0:0";
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPause
            // 
            this.iconPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.iconPause.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.iconPause.IconColor = System.Drawing.Color.White;
            this.iconPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPause.IconSize = 60;
            this.iconPause.Location = new System.Drawing.Point(515, 12);
            this.iconPause.Name = "iconPause";
            this.iconPause.Size = new System.Drawing.Size(60, 60);
            this.iconPause.TabIndex = 5;
            this.iconPause.TabStop = false;
            this.iconPause.Click += new System.EventHandler(this.iconPause_Click);
            // 
            // iconPlay
            // 
            this.iconPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.iconPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconPlay.IconColor = System.Drawing.Color.White;
            this.iconPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPlay.IconSize = 60;
            this.iconPlay.Location = new System.Drawing.Point(515, 12);
            this.iconPlay.Name = "iconPlay";
            this.iconPlay.Size = new System.Drawing.Size(60, 60);
            this.iconPlay.TabIndex = 4;
            this.iconPlay.TabStop = false;
            this.iconPlay.Click += new System.EventHandler(this.iconPlay_Click);
            // 
            // iconBack
            // 
            this.iconBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.iconBack.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            this.iconBack.IconColor = System.Drawing.Color.White;
            this.iconBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBack.IconSize = 40;
            this.iconBack.Location = new System.Drawing.Point(469, 22);
            this.iconBack.Name = "iconBack";
            this.iconBack.Size = new System.Drawing.Size(40, 40);
            this.iconBack.TabIndex = 3;
            this.iconBack.TabStop = false;
            this.iconBack.Click += new System.EventHandler(this.iconBack_Click);
            // 
            // IconFor
            // 
            this.IconFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.IconFor.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.IconFor.IconColor = System.Drawing.Color.White;
            this.IconFor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconFor.IconSize = 40;
            this.IconFor.Location = new System.Drawing.Point(581, 22);
            this.IconFor.Name = "IconFor";
            this.IconFor.Size = new System.Drawing.Size(40, 40);
            this.IconFor.TabIndex = 3;
            this.IconFor.TabStop = false;
            this.IconFor.Click += new System.EventHandler(this.IconFor_Click);
            // 
            // IconRepeat
            // 
            this.IconRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.IconRepeat.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.IconRepeat.IconColor = System.Drawing.Color.White;
            this.IconRepeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconRepeat.IconSize = 40;
            this.IconRepeat.Location = new System.Drawing.Point(423, 22);
            this.IconRepeat.Name = "IconRepeat";
            this.IconRepeat.Size = new System.Drawing.Size(40, 40);
            this.IconRepeat.TabIndex = 2;
            this.IconRepeat.TabStop = false;
            this.IconRepeat.Click += new System.EventHandler(this.IconRepeat_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.PanelMain.Controls.Add(this.lstLists);
            this.PanelMain.Controls.Add(this.lstMusicList);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(250, 50);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PanelMain.Size = new System.Drawing.Size(1030, 533);
            this.PanelMain.TabIndex = 4;
            // 
            // lstLists
            // 
            this.lstLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.lstLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLists.ForeColor = System.Drawing.Color.White;
            this.lstLists.FormattingEnabled = true;
            this.lstLists.ItemHeight = 37;
            this.lstLists.Location = new System.Drawing.Point(0, 5);
            this.lstLists.Name = "lstLists";
            this.lstLists.Size = new System.Drawing.Size(1030, 523);
            this.lstLists.TabIndex = 1;
            // 
            // lstMusicList
            // 
            this.lstMusicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.lstMusicList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMusicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMusicList.ForeColor = System.Drawing.Color.White;
            this.lstMusicList.FormattingEnabled = true;
            this.lstMusicList.ItemHeight = 37;
            this.lstMusicList.Location = new System.Drawing.Point(0, 5);
            this.lstMusicList.Name = "lstMusicList";
            this.lstMusicList.Size = new System.Drawing.Size(1030, 523);
            this.lstMusicList.TabIndex = 0;
            this.lstMusicList.SelectedIndexChanged += new System.EventHandler(this.lstMusicList_SelectedIndexChanged);
            // 
            // Timer1
            // 
            this.Timer1.Tag = "1";
            this.Timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelMove);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zenelejátszó 1.0";
            this.Load += new System.EventHandler(this.FormMainWindow_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimize)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconADDToList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconListMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconFavRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFavouriteAdd)).EndInit();
            this.PanelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRepeat)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel PanelBack;
        private Panel PanelFor;
        private FontAwesome.Sharp.IconPictureBox iconFavouriteAdd;
        private FontAwesome.Sharp.IconPictureBox IconFavRemove;
        private ListBox lstLists;
        private FontAwesome.Sharp.IconPictureBox IconListMinus;
        private FontAwesome.Sharp.IconPictureBox IconADDToList;
        private NumericUpDown ListNumber;
        private FontAwesome.Sharp.IconButton btnSettings;
    }
}