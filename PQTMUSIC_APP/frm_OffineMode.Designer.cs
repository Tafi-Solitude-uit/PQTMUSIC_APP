namespace PQTMUSIC_APP
{
    partial class frm_OffineMode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OffineMode));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.datagrid_Playlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_Playlist = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Play = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Mix = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_mute = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.TrackBar_Volumn = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TrackBar_Play = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btn_Rewind = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Next = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Pause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnReplay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Upload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl_App_Name = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pic_Player = new System.Windows.Forms.PictureBox();
            this.lbl_Song = new System.Windows.Forms.Label();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // datagrid_Playlist
            // 
            this.datagrid_Playlist.AllowDrop = true;
            this.datagrid_Playlist.AllowUserToAddRows = false;
            this.datagrid_Playlist.AllowUserToDeleteRows = false;
            this.datagrid_Playlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Playlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Playlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Playlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Playlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Playlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid_Playlist.ColumnHeadersHeight = 27;
            this.datagrid_Playlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Playlist.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid_Playlist.EnableHeadersVisualStyles = false;
            this.datagrid_Playlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist.Location = new System.Drawing.Point(12, 326);
            this.datagrid_Playlist.Name = "datagrid_Playlist";
            this.datagrid_Playlist.RowHeadersVisible = false;
            this.datagrid_Playlist.RowHeadersWidth = 51;
            this.datagrid_Playlist.RowTemplate.Height = 24;
            this.datagrid_Playlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Playlist.Size = new System.Drawing.Size(1048, 282);
            this.datagrid_Playlist.TabIndex = 160;
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
            this.datagrid_Playlist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Playlist_CellContentDoubleClick);
            this.datagrid_Playlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.datagrid_Playlist_DragDrop);
            this.datagrid_Playlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.datagrid_Playlist_DragEnter);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Song";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Artist";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Duration";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator1.Location = new System.Drawing.Point(12, 310);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(297, 10);
            this.guna2Separator1.TabIndex = 159;
            // 
            // lbl_Playlist
            // 
            this.lbl_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Playlist.AutoSize = true;
            this.lbl_Playlist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Playlist.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Playlist.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Playlist.Location = new System.Drawing.Point(12, 263);
            this.lbl_Playlist.Name = "lbl_Playlist";
            this.lbl_Playlist.Size = new System.Drawing.Size(135, 46);
            this.lbl_Playlist.TabIndex = 158;
            this.lbl_Playlist.Text = "Playlist";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.guna2Panel1.Controls.Add(this.btn_Play);
            this.guna2Panel1.Controls.Add(this.btn_Mix);
            this.guna2Panel1.Controls.Add(this.btn_mute);
            this.guna2Panel1.Controls.Add(this.label38);
            this.guna2Panel1.Controls.Add(this.label37);
            this.guna2Panel1.Controls.Add(this.TrackBar_Volumn);
            this.guna2Panel1.Controls.Add(this.TrackBar_Play);
            this.guna2Panel1.Controls.Add(this.btn_Rewind);
            this.guna2Panel1.Controls.Add(this.btn_Next);
            this.guna2Panel1.Controls.Add(this.btn_Pause);
            this.guna2Panel1.Controls.Add(this.btnReplay);
            this.guna2Panel1.Controls.Add(this.btn_Upload);
            this.guna2Panel1.Controls.Add(this.lbl_App_Name);
            this.guna2Panel1.Controls.Add(this.lbl_Artist);
            this.guna2Panel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel1.Controls.Add(this.lbl_Song);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1092, 260);
            this.guna2Panel1.TabIndex = 173;
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Play.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Play.CheckedState.Parent = this.btn_Play;
            this.btn_Play.HoverState.Image = global::PQTMUSIC_APP.Properties.Resources.pause__1_;
            this.btn_Play.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Play.HoverState.Parent = this.btn_Play;
            this.btn_Play.Image = global::PQTMUSIC_APP.Properties.Resources.play_button_arrowhead__1_;
            this.btn_Play.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Play.Location = new System.Drawing.Point(758, 114);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Play.PressedState.Parent = this.btn_Play;
            this.btn_Play.Size = new System.Drawing.Size(44, 46);
            this.btn_Play.TabIndex = 188;
            // 
            // btn_Mix
            // 
            this.btn_Mix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Mix.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Mix.CheckedState.Parent = this.btn_Mix;
            this.btn_Mix.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Mix.HoverState.Parent = this.btn_Mix;
            this.btn_Mix.Image = global::PQTMUSIC_APP.Properties.Resources.mix__1_;
            this.btn_Mix.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_Mix.Location = new System.Drawing.Point(858, 166);
            this.btn_Mix.Name = "btn_Mix";
            this.btn_Mix.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Mix.PressedState.Parent = this.btn_Mix;
            this.btn_Mix.Size = new System.Drawing.Size(44, 46);
            this.btn_Mix.TabIndex = 187;
            // 
            // btn_mute
            // 
            this.btn_mute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_mute.CheckedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_mute.CheckedState.Parent = this.btn_mute;
            this.btn_mute.HoverState.Image = global::PQTMUSIC_APP.Properties.Resources.volume__1_;
            this.btn_mute.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_mute.HoverState.Parent = this.btn_mute;
            this.btn_mute.Image = global::PQTMUSIC_APP.Properties.Resources.volume;
            this.btn_mute.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_mute.Location = new System.Drawing.Point(913, 167);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.PressedState.Image = global::PQTMUSIC_APP.Properties.Resources.mute__2_;
            this.btn_mute.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_mute.PressedState.Parent = this.btn_mute;
            this.btn_mute.Size = new System.Drawing.Size(44, 46);
            this.btn_mute.TabIndex = 186;
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label38.Location = new System.Drawing.Point(1041, 216);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 20);
            this.label38.TabIndex = 185;
            this.label38.Text = "3:10";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label37.Location = new System.Drawing.Point(480, 216);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 20);
            this.label37.TabIndex = 184;
            this.label37.Text = "1:10";
            // 
            // TrackBar_Volumn
            // 
            this.TrackBar_Volumn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TrackBar_Volumn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.TrackBar_Volumn.HoverState.Parent = this.TrackBar_Volumn;
            this.TrackBar_Volumn.HoverState.ThumbColor = System.Drawing.Color.Green;
            this.TrackBar_Volumn.Location = new System.Drawing.Point(963, 177);
            this.TrackBar_Volumn.Name = "TrackBar_Volumn";
            this.TrackBar_Volumn.Size = new System.Drawing.Size(109, 23);
            this.TrackBar_Volumn.TabIndex = 183;
            this.TrackBar_Volumn.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            // 
            // TrackBar_Play
            // 
            this.TrackBar_Play.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrackBar_Play.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.TrackBar_Play.HoverState.Parent = this.TrackBar_Play;
            this.TrackBar_Play.HoverState.ThumbColor = System.Drawing.Color.Green;
            this.TrackBar_Play.Location = new System.Drawing.Point(526, 212);
            this.TrackBar_Play.Name = "TrackBar_Play";
            this.TrackBar_Play.Size = new System.Drawing.Size(509, 30);
            this.TrackBar_Play.TabIndex = 182;
            this.TrackBar_Play.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            // 
            // btn_Rewind
            // 
            this.btn_Rewind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Rewind.BackColor = System.Drawing.Color.Transparent;
            this.btn_Rewind.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Rewind.CheckedState.Parent = this.btn_Rewind;
            this.btn_Rewind.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Rewind.HoverState.Parent = this.btn_Rewind;
            this.btn_Rewind.Image = global::PQTMUSIC_APP.Properties.Resources.back;
            this.btn_Rewind.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_Rewind.Location = new System.Drawing.Point(708, 166);
            this.btn_Rewind.Name = "btn_Rewind";
            this.btn_Rewind.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Rewind.PressedState.Parent = this.btn_Rewind;
            this.btn_Rewind.Size = new System.Drawing.Size(44, 46);
            this.btn_Rewind.TabIndex = 181;
            this.btn_Rewind.UseTransparentBackground = true;
            this.btn_Rewind.Click += new System.EventHandler(this.btn_Rewind_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Next.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Next.CheckedState.Parent = this.btn_Next;
            this.btn_Next.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Next.HoverState.Parent = this.btn_Next;
            this.btn_Next.Image = global::PQTMUSIC_APP.Properties.Resources.play_and_pause_button__1_;
            this.btn_Next.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_Next.Location = new System.Drawing.Point(808, 166);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Next.PressedState.Parent = this.btn_Next;
            this.btn_Next.Size = new System.Drawing.Size(44, 46);
            this.btn_Next.TabIndex = 180;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Pause.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Pause.CheckedState.Parent = this.btn_Pause;
            this.btn_Pause.HoverState.Image = global::PQTMUSIC_APP.Properties.Resources.pause__1_;
            this.btn_Pause.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Pause.HoverState.Parent = this.btn_Pause;
            this.btn_Pause.Image = global::PQTMUSIC_APP.Properties.Resources.pause;
            this.btn_Pause.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Pause.Location = new System.Drawing.Point(758, 166);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Pause.PressedState.Parent = this.btn_Pause;
            this.btn_Pause.Size = new System.Drawing.Size(44, 46);
            this.btn_Pause.TabIndex = 179;
            // 
            // btnReplay
            // 
            this.btnReplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReplay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnReplay.CheckedState.Parent = this.btnReplay;
            this.btnReplay.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReplay.HoverState.Parent = this.btnReplay;
            this.btnReplay.Image = global::PQTMUSIC_APP.Properties.Resources.rewind;
            this.btnReplay.ImageSize = new System.Drawing.Size(27, 27);
            this.btnReplay.Location = new System.Drawing.Point(658, 166);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnReplay.PressedState.Parent = this.btnReplay;
            this.btnReplay.Size = new System.Drawing.Size(44, 46);
            this.btnReplay.TabIndex = 178;
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
            this.btn_Upload.Location = new System.Drawing.Point(282, 198);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.ShadowDecoration.Parent = this.btn_Upload;
            this.btn_Upload.Size = new System.Drawing.Size(180, 45);
            this.btn_Upload.TabIndex = 177;
            this.btn_Upload.Text = "Upload new song";
            // 
            // lbl_App_Name
            // 
            this.lbl_App_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_App_Name.AutoSize = true;
            this.lbl_App_Name.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_App_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.lbl_App_Name.Location = new System.Drawing.Point(798, 4);
            this.lbl_App_Name.Name = "lbl_App_Name";
            this.lbl_App_Name.Size = new System.Drawing.Size(269, 59);
            this.lbl_App_Name.TabIndex = 176;
            this.lbl_App_Name.Text = "PQTMUSIC";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Artist.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_Artist.Location = new System.Drawing.Point(274, 112);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(110, 46);
            this.lbl_Artist.TabIndex = 175;
            this.lbl_Artist.Text = "Artist";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pic_Player);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(11, 7);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.SlateBlue;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(250, 250);
            this.guna2ShadowPanel1.TabIndex = 174;
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
            // lbl_Song
            // 
            this.lbl_Song.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Song.AutoSize = true;
            this.lbl_Song.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Song.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Song.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_Song.Location = new System.Drawing.Point(267, 23);
            this.lbl_Song.Name = "lbl_Song";
            this.lbl_Song.Size = new System.Drawing.Size(403, 89);
            this.lbl_Song.TabIndex = 173;
            this.lbl_Song.Text = "Name Song";
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(484, 274);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(451, 35);
            this.musicPlayer.TabIndex = 174;
            this.musicPlayer.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frm_OffineMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1092, 620);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.datagrid_Playlist);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lbl_Playlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_OffineMode";
            this.Text = "frm_OffineMode";
            this.Load += new System.EventHandler(this.frm_OffineMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_Playlist;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_Playlist;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Play;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Mix;
        private Guna.UI2.WinForms.Guna2ImageButton btn_mute;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar_Volumn;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar_Play;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Rewind;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Next;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Pause;
        private Guna.UI2.WinForms.Guna2ImageButton btnReplay;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Upload;
        private System.Windows.Forms.Label lbl_App_Name;
        private System.Windows.Forms.Label lbl_Artist;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PictureBox pic_Player;
        private System.Windows.Forms.Label lbl_Song;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}