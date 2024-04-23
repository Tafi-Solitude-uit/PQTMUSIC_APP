namespace PQTMUSIC_APP
{
    partial class frm_Offline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Offline));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_Song = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_tittle = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.iconPause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_img_Play_Pause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_img_Mix = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_img_Rewind = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_img_Next = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_img_Stop = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_img_Replay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel_WaveSong = new Guna.UI2.WinForms.Guna2Panel();
            this.pic_Wv = new System.Windows.Forms.PictureBox();
            this.btn_Upload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl_App_Name = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pic_Player = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_store_Playlist = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Playlist = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.datagrid_Playlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_tittle.SuspendLayout();
            this.panel_WaveSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Wv)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Player)).BeginInit();
            this.pnl_store_Playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_Song
            // 
            this.lbl_Song.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Song.AutoSize = true;
            this.lbl_Song.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Song.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Song.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_Song.Location = new System.Drawing.Point(274, 28);
            this.lbl_Song.Name = "lbl_Song";
            this.lbl_Song.Size = new System.Drawing.Size(403, 89);
            this.lbl_Song.TabIndex = 127;
            this.lbl_Song.Text = "Name Song";
            // 
            // pnl_tittle
            // 
            this.pnl_tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.pnl_tittle.Controls.Add(this.iconPlay);
            this.pnl_tittle.Controls.Add(this.iconPause);
            this.pnl_tittle.Controls.Add(this.btn_img_Play_Pause);
            this.pnl_tittle.Controls.Add(this.btn_img_Mix);
            this.pnl_tittle.Controls.Add(this.btn_img_Rewind);
            this.pnl_tittle.Controls.Add(this.btn_img_Next);
            this.pnl_tittle.Controls.Add(this.btn_img_Stop);
            this.pnl_tittle.Controls.Add(this.btn_img_Replay);
            this.pnl_tittle.Controls.Add(this.panel_WaveSong);
            this.pnl_tittle.Controls.Add(this.btn_Upload);
            this.pnl_tittle.Controls.Add(this.lbl_App_Name);
            this.pnl_tittle.Controls.Add(this.lbl_Artist);
            this.pnl_tittle.Controls.Add(this.guna2ShadowPanel1);
            this.pnl_tittle.Controls.Add(this.lbl_Song);
            this.pnl_tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tittle.Location = new System.Drawing.Point(0, 0);
            this.pnl_tittle.Name = "pnl_tittle";
            this.pnl_tittle.ShadowDecoration.Parent = this.pnl_tittle;
            this.pnl_tittle.Size = new System.Drawing.Size(1100, 281);
            this.pnl_tittle.TabIndex = 128;
            // 
            // iconPlay
            // 
            this.iconPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPlay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.iconPlay.CheckedState.Parent = this.iconPlay;
            this.iconPlay.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("iconPlay.HoverState.Image")));
            this.iconPlay.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.iconPlay.HoverState.Parent = this.iconPlay;
            this.iconPlay.Image = ((System.Drawing.Image)(resources.GetObject("iconPlay.Image")));
            this.iconPlay.ImageSize = new System.Drawing.Size(34, 34);
            this.iconPlay.Location = new System.Drawing.Point(683, 12);
            this.iconPlay.Name = "iconPlay";
            this.iconPlay.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.iconPlay.PressedState.Parent = this.iconPlay;
            this.iconPlay.Size = new System.Drawing.Size(44, 46);
            this.iconPlay.TabIndex = 141;
            // 
            // iconPause
            // 
            this.iconPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPause.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.iconPause.CheckedState.Parent = this.iconPause;
            this.iconPause.HoverState.Image = global::PQTMUSIC_APP.Properties.Resources.pause__1_;
            this.iconPause.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.iconPause.HoverState.Parent = this.iconPause;
            this.iconPause.Image = global::PQTMUSIC_APP.Properties.Resources.pause;
            this.iconPause.ImageSize = new System.Drawing.Size(35, 35);
            this.iconPause.Location = new System.Drawing.Point(740, 12);
            this.iconPause.Name = "iconPause";
            this.iconPause.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.iconPause.PressedState.Parent = this.iconPause;
            this.iconPause.Size = new System.Drawing.Size(44, 46);
            this.iconPause.TabIndex = 140;
            // 
            // btn_img_Play_Pause
            // 
            this.btn_img_Play_Pause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_img_Play_Pause.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Play_Pause.CheckedState.Parent = this.btn_img_Play_Pause;
            this.btn_img_Play_Pause.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_img_Play_Pause.HoverState.Image")));
            this.btn_img_Play_Pause.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btn_img_Play_Pause.HoverState.Parent = this.btn_img_Play_Pause;
            this.btn_img_Play_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_img_Play_Pause.Image")));
            this.btn_img_Play_Pause.ImageSize = new System.Drawing.Size(34, 34);
            this.btn_img_Play_Pause.Location = new System.Drawing.Point(686, 74);
            this.btn_img_Play_Pause.Name = "btn_img_Play_Pause";
            this.btn_img_Play_Pause.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Play_Pause.PressedState.Parent = this.btn_img_Play_Pause;
            this.btn_img_Play_Pause.Size = new System.Drawing.Size(44, 46);
            this.btn_img_Play_Pause.TabIndex = 139;
            this.btn_img_Play_Pause.Click += new System.EventHandler(this.btn_img_Play_Pause_Click);
            // 
            // btn_img_Mix
            // 
            this.btn_img_Mix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_img_Mix.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Mix.CheckedState.Parent = this.btn_img_Mix;
            this.btn_img_Mix.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_img_Mix.HoverState.Parent = this.btn_img_Mix;
            this.btn_img_Mix.Image = global::PQTMUSIC_APP.Properties.Resources.mix__1_;
            this.btn_img_Mix.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_img_Mix.Location = new System.Drawing.Point(940, 74);
            this.btn_img_Mix.Name = "btn_img_Mix";
            this.btn_img_Mix.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Mix.PressedState.Parent = this.btn_img_Mix;
            this.btn_img_Mix.Size = new System.Drawing.Size(44, 46);
            this.btn_img_Mix.TabIndex = 138;
            // 
            // btn_img_Rewind
            // 
            this.btn_img_Rewind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_img_Rewind.BackColor = System.Drawing.Color.Transparent;
            this.btn_img_Rewind.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Rewind.CheckedState.Parent = this.btn_img_Rewind;
            this.btn_img_Rewind.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_img_Rewind.HoverState.Parent = this.btn_img_Rewind;
            this.btn_img_Rewind.Image = global::PQTMUSIC_APP.Properties.Resources.back;
            this.btn_img_Rewind.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_img_Rewind.Location = new System.Drawing.Point(790, 74);
            this.btn_img_Rewind.Name = "btn_img_Rewind";
            this.btn_img_Rewind.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Rewind.PressedState.Parent = this.btn_img_Rewind;
            this.btn_img_Rewind.Size = new System.Drawing.Size(44, 46);
            this.btn_img_Rewind.TabIndex = 137;
            this.btn_img_Rewind.UseTransparentBackground = true;
            // 
            // btn_img_Next
            // 
            this.btn_img_Next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_img_Next.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Next.CheckedState.Parent = this.btn_img_Next;
            this.btn_img_Next.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_img_Next.HoverState.Parent = this.btn_img_Next;
            this.btn_img_Next.Image = global::PQTMUSIC_APP.Properties.Resources.play_and_pause_button__1_;
            this.btn_img_Next.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_img_Next.Location = new System.Drawing.Point(890, 74);
            this.btn_img_Next.Name = "btn_img_Next";
            this.btn_img_Next.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Next.PressedState.Parent = this.btn_img_Next;
            this.btn_img_Next.Size = new System.Drawing.Size(44, 46);
            this.btn_img_Next.TabIndex = 136;
            // 
            // btn_img_Stop
            // 
            this.btn_img_Stop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_img_Stop.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Stop.CheckedState.Parent = this.btn_img_Stop;
            this.btn_img_Stop.HoverState.Image = global::PQTMUSIC_APP.Properties.Resources.pause__1_;
            this.btn_img_Stop.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_img_Stop.HoverState.Parent = this.btn_img_Stop;
            this.btn_img_Stop.Image = global::PQTMUSIC_APP.Properties.Resources.pause;
            this.btn_img_Stop.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_img_Stop.Location = new System.Drawing.Point(840, 74);
            this.btn_img_Stop.Name = "btn_img_Stop";
            this.btn_img_Stop.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Stop.PressedState.Parent = this.btn_img_Stop;
            this.btn_img_Stop.Size = new System.Drawing.Size(44, 46);
            this.btn_img_Stop.TabIndex = 135;
            this.btn_img_Stop.Click += new System.EventHandler(this.btn_img_Play_Click);
            // 
            // btn_img_Replay
            // 
            this.btn_img_Replay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_img_Replay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Replay.CheckedState.Parent = this.btn_img_Replay;
            this.btn_img_Replay.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_img_Replay.HoverState.Parent = this.btn_img_Replay;
            this.btn_img_Replay.Image = global::PQTMUSIC_APP.Properties.Resources.rewind;
            this.btn_img_Replay.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_img_Replay.Location = new System.Drawing.Point(740, 74);
            this.btn_img_Replay.Name = "btn_img_Replay";
            this.btn_img_Replay.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_img_Replay.PressedState.Parent = this.btn_img_Replay;
            this.btn_img_Replay.Size = new System.Drawing.Size(44, 46);
            this.btn_img_Replay.TabIndex = 134;
            // 
            // panel_WaveSong
            // 
            this.panel_WaveSong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_WaveSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_WaveSong.Controls.Add(this.pic_Wv);
            this.panel_WaveSong.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_WaveSong.Location = new System.Drawing.Point(460, 133);
            this.panel_WaveSong.Name = "panel_WaveSong";
            this.panel_WaveSong.ShadowDecoration.Parent = this.panel_WaveSong;
            this.panel_WaveSong.Size = new System.Drawing.Size(614, 134);
            this.panel_WaveSong.TabIndex = 133;
            this.panel_WaveSong.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_WaveSong_MouseUp);
            // 
            // pic_Wv
            // 
            this.pic_Wv.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Wv.Location = new System.Drawing.Point(0, 0);
            this.pic_Wv.Name = "pic_Wv";
            this.pic_Wv.Size = new System.Drawing.Size(19, 134);
            this.pic_Wv.TabIndex = 0;
            this.pic_Wv.TabStop = false;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Upload.BorderRadius = 12;
            this.btn_Upload.CheckedState.Parent = this.btn_Upload;
            this.btn_Upload.CustomImages.Parent = this.btn_Upload;
            this.btn_Upload.FillColor = System.Drawing.Color.Green;
            this.btn_Upload.FillColor2 = System.Drawing.Color.Goldenrod;
            this.btn_Upload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Upload.ForeColor = System.Drawing.Color.Gold;
            this.btn_Upload.HoverState.Parent = this.btn_Upload;
            this.btn_Upload.Location = new System.Drawing.Point(274, 203);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.ShadowDecoration.Parent = this.btn_Upload;
            this.btn_Upload.Size = new System.Drawing.Size(180, 45);
            this.btn_Upload.TabIndex = 131;
            this.btn_Upload.Text = "Upload new song";
            this.btn_Upload.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // lbl_App_Name
            // 
            this.lbl_App_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_App_Name.AutoSize = true;
            this.lbl_App_Name.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_App_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.lbl_App_Name.Location = new System.Drawing.Point(805, 9);
            this.lbl_App_Name.Name = "lbl_App_Name";
            this.lbl_App_Name.Size = new System.Drawing.Size(269, 59);
            this.lbl_App_Name.TabIndex = 130;
            this.lbl_App_Name.Text = "PQTMUSIC";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Artist.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_Artist.Location = new System.Drawing.Point(281, 117);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(110, 46);
            this.lbl_Artist.TabIndex = 129;
            this.lbl_Artist.Text = "Artist";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pic_Player);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(18, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.SlateBlue;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(250, 250);
            this.guna2ShadowPanel1.TabIndex = 128;
            // 
            // pic_Player
            // 
            this.pic_Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.pic_Player.Image = global::PQTMUSIC_APP.Properties.Resources.cd;
            this.pic_Player.Location = new System.Drawing.Point(17, 16);
            this.pic_Player.Name = "pic_Player";
            this.pic_Player.Size = new System.Drawing.Size(220, 220);
            this.pic_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Player.TabIndex = 130;
            this.pic_Player.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_store_Playlist
            // 
            this.pnl_store_Playlist.AllowDrop = true;
            this.pnl_store_Playlist.AutoScroll = true;
            this.pnl_store_Playlist.Controls.Add(this.datagrid_Playlist);
            this.pnl_store_Playlist.Controls.Add(this.guna2Separator1);
            this.pnl_store_Playlist.Controls.Add(this.lbl_Playlist);
            this.pnl_store_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_store_Playlist.Location = new System.Drawing.Point(0, 281);
            this.pnl_store_Playlist.Name = "pnl_store_Playlist";
            this.pnl_store_Playlist.ShadowDecoration.Parent = this.pnl_store_Playlist;
            this.pnl_store_Playlist.Size = new System.Drawing.Size(1100, 454);
            this.pnl_store_Playlist.TabIndex = 129;
            // 
            // lbl_Playlist
            // 
            this.lbl_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Playlist.AutoSize = true;
            this.lbl_Playlist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Playlist.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Playlist.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Playlist.Location = new System.Drawing.Point(14, 3);
            this.lbl_Playlist.Name = "lbl_Playlist";
            this.lbl_Playlist.Size = new System.Drawing.Size(135, 46);
            this.lbl_Playlist.TabIndex = 133;
            this.lbl_Playlist.Text = "Playlist";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator1.Location = new System.Drawing.Point(14, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(297, 10);
            this.guna2Separator1.TabIndex = 134;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Duration";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Artist";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Song";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // datagrid_Playlist
            // 
            this.datagrid_Playlist.AllowDrop = true;
            this.datagrid_Playlist.AllowUserToAddRows = false;
            this.datagrid_Playlist.AllowUserToDeleteRows = false;
            this.datagrid_Playlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Playlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Playlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Playlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Playlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Playlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Playlist.ColumnHeadersHeight = 27;
            this.datagrid_Playlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Playlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_Playlist.EnableHeadersVisualStyles = false;
            this.datagrid_Playlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist.Location = new System.Drawing.Point(14, 66);
            this.datagrid_Playlist.Name = "datagrid_Playlist";
            this.datagrid_Playlist.RowHeadersVisible = false;
            this.datagrid_Playlist.RowHeadersWidth = 51;
            this.datagrid_Playlist.RowTemplate.Height = 24;
            this.datagrid_Playlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Playlist.Size = new System.Drawing.Size(1048, 376);
            this.datagrid_Playlist.TabIndex = 135;
            this.datagrid_Playlist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagrid_Playlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_Playlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_Playlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_Playlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Playlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_Playlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_Playlist.ThemeStyle.HeaderStyle.Height = 27;
            this.datagrid_Playlist.ThemeStyle.ReadOnly = false;
            this.datagrid_Playlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Playlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Playlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Playlist.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_Playlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frm_Offline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1100, 735);
            this.Controls.Add(this.pnl_store_Playlist);
            this.Controls.Add(this.pnl_tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Offline";
            this.Text = "frm_Offline";
            this.pnl_tittle.ResumeLayout(false);
            this.pnl_tittle.PerformLayout();
            this.panel_WaveSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Wv)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Player)).EndInit();
            this.pnl_store_Playlist.ResumeLayout(false);
            this.pnl_store_Playlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbl_Song;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel pnl_tittle;
        private System.Windows.Forms.Label lbl_Artist;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PictureBox pic_Player;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Upload;
        private System.Windows.Forms.Label lbl_App_Name;
        private Guna.UI2.WinForms.Guna2Panel panel_WaveSong;
        private System.Windows.Forms.PictureBox pic_Wv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_img_Mix;
        private Guna.UI2.WinForms.Guna2ImageButton btn_img_Rewind;
        private Guna.UI2.WinForms.Guna2ImageButton btn_img_Next;
        private Guna.UI2.WinForms.Guna2ImageButton btn_img_Stop;
        private Guna.UI2.WinForms.Guna2ImageButton btn_img_Replay;
        private Guna.UI2.WinForms.Guna2ImageButton btn_img_Play_Pause;
        private Guna.UI2.WinForms.Guna2ImageButton iconPlay;
        private Guna.UI2.WinForms.Guna2ImageButton iconPause;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel pnl_store_Playlist;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_Playlist;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_Playlist;
    }
}