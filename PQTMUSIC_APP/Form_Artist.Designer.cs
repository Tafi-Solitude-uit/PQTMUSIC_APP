namespace PQTMUSIC_APP
{
    partial class Form_Artist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_SongOfSinger = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ArtistName = new System.Windows.Forms.Label();
            this.lbl_totalFollowers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_Singer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.txt_Bio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_National = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_SongOfSinger)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Singer)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_SongOfSinger
            // 
            this.datagrid_SongOfSinger.AllowDrop = true;
            this.datagrid_SongOfSinger.AllowUserToAddRows = false;
            this.datagrid_SongOfSinger.AllowUserToDeleteRows = false;
            this.datagrid_SongOfSinger.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.datagrid_SongOfSinger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid_SongOfSinger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_SongOfSinger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_SongOfSinger.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_SongOfSinger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_SongOfSinger.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_SongOfSinger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_SongOfSinger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid_SongOfSinger.ColumnHeadersHeight = 27;
            this.datagrid_SongOfSinger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_SongOfSinger.DefaultCellStyle = dataGridViewCellStyle7;
            this.datagrid_SongOfSinger.EnableHeadersVisualStyles = false;
            this.datagrid_SongOfSinger.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.datagrid_SongOfSinger.Location = new System.Drawing.Point(18, 487);
            this.datagrid_SongOfSinger.Name = "datagrid_SongOfSinger";
            this.datagrid_SongOfSinger.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_SongOfSinger.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagrid_SongOfSinger.RowHeadersVisible = false;
            this.datagrid_SongOfSinger.RowHeadersWidth = 51;
            this.datagrid_SongOfSinger.RowTemplate.Height = 24;
            this.datagrid_SongOfSinger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_SongOfSinger.Size = new System.Drawing.Size(1054, 292);
            this.datagrid_SongOfSinger.TabIndex = 176;
            this.datagrid_SongOfSinger.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagrid_SongOfSinger.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_SongOfSinger.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_SongOfSinger.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_SongOfSinger.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_SongOfSinger.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_SongOfSinger.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_SongOfSinger.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.datagrid_SongOfSinger.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_SongOfSinger.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_SongOfSinger.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_SongOfSinger.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_SongOfSinger.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_SongOfSinger.ThemeStyle.HeaderStyle.Height = 27;
            this.datagrid_SongOfSinger.ThemeStyle.ReadOnly = true;
            this.datagrid_SongOfSinger.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_SongOfSinger.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_SongOfSinger.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_SongOfSinger.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_SongOfSinger.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_SongOfSinger.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_SongOfSinger.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_SongOfSinger.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_SongOfSinger_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Thumbnail";
            this.dataGridViewTextBoxColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.lbl_Birthday);
            this.guna2Panel2.Controls.Add(this.lbl_National);
            this.guna2Panel2.Controls.Add(this.txt_Bio);
            this.guna2Panel2.Controls.Add(this.guna2Separator2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.pic_Singer);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.lbl_totalFollowers);
            this.guna2Panel2.Controls.Add(this.lbl_ArtistName);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1090, 481);
            this.guna2Panel2.TabIndex = 180;
            // 
            // lbl_ArtistName
            // 
            this.lbl_ArtistName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ArtistName.AutoSize = true;
            this.lbl_ArtistName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ArtistName.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArtistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_ArtistName.Location = new System.Drawing.Point(266, 44);
            this.lbl_ArtistName.Name = "lbl_ArtistName";
            this.lbl_ArtistName.Size = new System.Drawing.Size(418, 89);
            this.lbl_ArtistName.TabIndex = 173;
            this.lbl_ArtistName.Text = "Name Artist";
            // 
            // lbl_totalFollowers
            // 
            this.lbl_totalFollowers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_totalFollowers.AutoSize = true;
            this.lbl_totalFollowers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalFollowers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalFollowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_totalFollowers.Location = new System.Drawing.Point(273, 133);
            this.lbl_totalFollowers.Name = "lbl_totalFollowers";
            this.lbl_totalFollowers.Size = new System.Drawing.Size(183, 46);
            this.lbl_totalFollowers.TabIndex = 175;
            this.lbl_totalFollowers.Text = "Followers:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(803, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 59);
            this.label2.TabIndex = 176;
            this.label2.Text = "PQTMUSIC";
            // 
            // pic_Singer
            // 
            this.pic_Singer.Image = global::PQTMUSIC_APP.Properties.Resources.OIP__6_1;
            this.pic_Singer.Location = new System.Drawing.Point(3, 4);
            this.pic_Singer.Name = "pic_Singer";
            this.pic_Singer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_Singer.ShadowDecoration.Parent = this.pic_Singer;
            this.pic_Singer.Size = new System.Drawing.Size(250, 250);
            this.pic_Singer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Singer.TabIndex = 0;
            this.pic_Singer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(10, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 46);
            this.label1.TabIndex = 177;
            this.label1.Text = "Giới Thiệu";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator2.Location = new System.Drawing.Point(10, 304);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(297, 10);
            this.guna2Separator2.TabIndex = 178;
            // 
            // txt_Bio
            // 
            this.txt_Bio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Bio.AutoScroll = true;
            this.txt_Bio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Bio.BorderRadius = 10;
            this.txt_Bio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Bio.DefaultText = "";
            this.txt_Bio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Bio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Bio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Bio.DisabledState.Parent = this.txt_Bio;
            this.txt_Bio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Bio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.txt_Bio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Bio.FocusedState.Parent = this.txt_Bio;
            this.txt_Bio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Bio.HoverState.Parent = this.txt_Bio;
            this.txt_Bio.Location = new System.Drawing.Point(18, 321);
            this.txt_Bio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Bio.Multiline = true;
            this.txt_Bio.Name = "txt_Bio";
            this.txt_Bio.PasswordChar = '\0';
            this.txt_Bio.PlaceholderText = "";
            this.txt_Bio.ReadOnly = true;
            this.txt_Bio.SelectedText = "";
            this.txt_Bio.ShadowDecoration.Parent = this.txt_Bio;
            this.txt_Bio.Size = new System.Drawing.Size(1054, 153);
            this.txt_Bio.TabIndex = 179;
            // 
            // lbl_National
            // 
            this.lbl_National.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_National.AutoSize = true;
            this.lbl_National.BackColor = System.Drawing.Color.Transparent;
            this.lbl_National.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_National.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_National.Location = new System.Drawing.Point(273, 241);
            this.lbl_National.Name = "lbl_National";
            this.lbl_National.Size = new System.Drawing.Size(167, 46);
            this.lbl_National.TabIndex = 180;
            this.lbl_National.Text = "National:";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Birthday.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_Birthday.Location = new System.Drawing.Point(662, 241);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(166, 46);
            this.lbl_Birthday.TabIndex = 181;
            this.lbl_Birthday.Text = "Birthday:";
            // 
            // Form_Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1090, 791);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.datagrid_SongOfSinger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Artist";
            this.Text = "Form_Artist";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_SongOfSinger)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Singer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_SongOfSinger;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_National;
        private Guna.UI2.WinForms.Guna2TextBox txt_Bio;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Singer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_totalFollowers;
        private System.Windows.Forms.Label lbl_ArtistName;
    }
}