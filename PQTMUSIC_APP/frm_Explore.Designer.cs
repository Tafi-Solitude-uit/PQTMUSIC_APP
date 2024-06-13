namespace PQTMUSIC_APP
{
    partial class frm_Explore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_Child = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_App_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_Playlist = new System.Windows.Forms.Label();
            this.datagrid_Playlist_TOPSONG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Thumbnail = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.panel_Child.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist_TOPSONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel_Child
            // 
            this.panel_Child.AutoScroll = true;
            this.panel_Child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.panel_Child.Controls.Add(this.lbl_App_Name);
            this.panel_Child.Controls.Add(this.label1);
            this.panel_Child.Controls.Add(this.guna2Separator1);
            this.panel_Child.Controls.Add(this.lbl_Playlist);
            this.panel_Child.Controls.Add(this.datagrid_Playlist_TOPSONG);
            this.panel_Child.Controls.Add(this.pictureBox1);
            this.panel_Child.Controls.Add(this.lbl_title1);
            this.panel_Child.Controls.Add(this.lbl_Tittle);
            this.panel_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Child.Location = new System.Drawing.Point(0, 0);
            this.panel_Child.Name = "panel_Child";
            this.panel_Child.ShadowDecoration.Parent = this.panel_Child;
            this.panel_Child.Size = new System.Drawing.Size(1090, 740);
            this.panel_Child.TabIndex = 9;
            // 
            // lbl_App_Name
            // 
            this.lbl_App_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_App_Name.AutoSize = true;
            this.lbl_App_Name.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_App_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.lbl_App_Name.Location = new System.Drawing.Point(802, 12);
            this.lbl_App_Name.Name = "lbl_App_Name";
            this.lbl_App_Name.Size = new System.Drawing.Size(269, 59);
            this.lbl_App_Name.TabIndex = 184;
            this.lbl_App_Name.Text = "PQTMUSIC";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(312, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 100);
            this.label1.TabIndex = 181;
            this.label1.Text = "Discover";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator1.Location = new System.Drawing.Point(25, 267);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(297, 10);
            this.guna2Separator1.TabIndex = 180;
            // 
            // lbl_Playlist
            // 
            this.lbl_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Playlist.AutoSize = true;
            this.lbl_Playlist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Playlist.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Playlist.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Playlist.Location = new System.Drawing.Point(19, 229);
            this.lbl_Playlist.Name = "lbl_Playlist";
            this.lbl_Playlist.Size = new System.Drawing.Size(191, 35);
            this.lbl_Playlist.TabIndex = 179;
            this.lbl_Playlist.Text = "Mới Phát Hành";
            // 
            // datagrid_Playlist_TOPSONG
            // 
            this.datagrid_Playlist_TOPSONG.AllowDrop = true;
            this.datagrid_Playlist_TOPSONG.AllowUserToAddRows = false;
            this.datagrid_Playlist_TOPSONG.AllowUserToDeleteRows = false;
            this.datagrid_Playlist_TOPSONG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOPSONG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Playlist_TOPSONG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Playlist_TOPSONG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Playlist_TOPSONG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_Playlist_TOPSONG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Playlist_TOPSONG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Playlist_TOPSONG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Playlist_TOPSONG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Playlist_TOPSONG.ColumnHeadersHeight = 27;
            this.datagrid_Playlist_TOPSONG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thumbnail,
            this.Tittle,
            this.Artist,
            this.Duration});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Playlist_TOPSONG.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_Playlist_TOPSONG.EnableHeadersVisualStyles = false;
            this.datagrid_Playlist_TOPSONG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist_TOPSONG.Location = new System.Drawing.Point(25, 283);
            this.datagrid_Playlist_TOPSONG.Name = "datagrid_Playlist_TOPSONG";
            this.datagrid_Playlist_TOPSONG.ReadOnly = true;
            this.datagrid_Playlist_TOPSONG.RowHeadersVisible = false;
            this.datagrid_Playlist_TOPSONG.RowHeadersWidth = 51;
            this.datagrid_Playlist_TOPSONG.RowTemplate.Height = 24;
            this.datagrid_Playlist_TOPSONG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Playlist_TOPSONG.Size = new System.Drawing.Size(1046, 450);
            this.datagrid_Playlist_TOPSONG.TabIndex = 161;
            this.datagrid_Playlist_TOPSONG.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_Playlist_TOPSONG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist_TOPSONG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist_TOPSONG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Playlist_TOPSONG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.HeaderStyle.Height = 27;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.ReadOnly = true;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Playlist_TOPSONG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Playlist_TOPSONG.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_Playlist_TOPSONG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist_TOPSONG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Playlist_TOPSONG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Playlist_TOPSONG_CellDoubleClick_1);
            // 
            // Thumbnail
            // 
            this.Thumbnail.HeaderText = "Thumbnail";
            this.Thumbnail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Thumbnail.MinimumWidth = 6;
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.ReadOnly = true;
            // 
            // Tittle
            // 
            this.Tittle.HeaderText = "Tittle";
            this.Tittle.MinimumWidth = 6;
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PQTMUSIC_APP.Properties.Resources.ab67616d00001e024b18f196222db6c99f952839;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title1
            // 
            this.lbl_title1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.lbl_title1.Location = new System.Drawing.Point(312, 157);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(731, 92);
            this.lbl_title1.TabIndex = 127;
            this.lbl_title1.Text = "Hottest New Songs!";
            // 
            // lbl_Tittle
            // 
            this.lbl_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tittle.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tittle.ForeColor = System.Drawing.Color.LightSalmon;
            this.lbl_Tittle.Location = new System.Drawing.Point(312, 83);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(715, 88);
            this.lbl_Tittle.TabIndex = 126;
            this.lbl_Tittle.Text = "Vietnamese Music";
            // 
            // frm_Explore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1090, 740);
            this.Controls.Add(this.panel_Child);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Explore";
            this.Text = "frm_Explore";
            this.Load += new System.EventHandler(this.frm_Explore_Load);
            this.panel_Child.ResumeLayout(false);
            this.panel_Child.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist_TOPSONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panel_Child;
        private System.Windows.Forms.Label lbl_title1;
        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_Playlist_TOPSONG;
        private System.Windows.Forms.DataGridViewImageColumn Thumbnail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_Playlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_App_Name;
    }
}