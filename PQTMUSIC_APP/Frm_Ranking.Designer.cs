﻿namespace PQTMUSIC_APP
{
    partial class Frm_Ranking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_Child = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_App_Name = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_Playlist = new System.Windows.Forms.Label();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid_Playlist_TOP100 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.panel_Child.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist_TOP100)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Child
            // 
            this.panel_Child.AutoScroll = true;
            this.panel_Child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.panel_Child.Controls.Add(this.lbl_App_Name);
            this.panel_Child.Controls.Add(this.guna2Separator1);
            this.panel_Child.Controls.Add(this.lbl_Playlist);
            this.panel_Child.Controls.Add(this.lbl_Tittle);
            this.panel_Child.Controls.Add(this.label2);
            this.panel_Child.Controls.Add(this.datagrid_Playlist_TOP100);
            this.panel_Child.Controls.Add(this.label27);
            this.panel_Child.Controls.Add(this.label1);
            this.panel_Child.Controls.Add(this.label13);
            this.panel_Child.Controls.Add(this.lbl_title1);
            this.panel_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Child.Location = new System.Drawing.Point(0, 0);
            this.panel_Child.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Child.Name = "panel_Child";
            this.panel_Child.ShadowDecoration.Parent = this.panel_Child;
            this.panel_Child.Size = new System.Drawing.Size(1090, 740);
            this.panel_Child.TabIndex = 12;
            // 
            // lbl_App_Name
            // 
            this.lbl_App_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_App_Name.AutoSize = true;
            this.lbl_App_Name.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_App_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.lbl_App_Name.Location = new System.Drawing.Point(809, 214);
            this.lbl_App_Name.Name = "lbl_App_Name";
            this.lbl_App_Name.Size = new System.Drawing.Size(269, 59);
            this.lbl_App_Name.TabIndex = 184;
            this.lbl_App_Name.Text = "PQTMUSIC";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator1.Location = new System.Drawing.Point(11, 263);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(297, 10);
            this.guna2Separator1.TabIndex = 182;
            // 
            // lbl_Playlist
            // 
            this.lbl_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Playlist.AutoSize = true;
            this.lbl_Playlist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Playlist.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Playlist.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Playlist.Location = new System.Drawing.Point(5, 225);
            this.lbl_Playlist.Name = "lbl_Playlist";
            this.lbl_Playlist.Size = new System.Drawing.Size(229, 35);
            this.lbl_Playlist.TabIndex = 181;
            this.lbl_Playlist.Text = "Danh Sách Bài Hát";
            // 
            // lbl_Tittle
            // 
            this.lbl_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tittle.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.lbl_Tittle.Location = new System.Drawing.Point(49, 129);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(894, 104);
            this.lbl_Tittle.TabIndex = 164;
            this.lbl_Tittle.Text = "All Time";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSalmon;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 110);
            this.label2.TabIndex = 163;
            this.label2.Text = "Top Charts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagrid_Playlist_TOP100
            // 
            this.datagrid_Playlist_TOP100.AllowDrop = true;
            this.datagrid_Playlist_TOP100.AllowUserToAddRows = false;
            this.datagrid_Playlist_TOP100.AllowUserToDeleteRows = false;
            this.datagrid_Playlist_TOP100.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOP100.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.datagrid_Playlist_TOP100.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Playlist_TOP100.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Playlist_TOP100.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_Playlist_TOP100.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Playlist_TOP100.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Playlist_TOP100.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Playlist_TOP100.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.datagrid_Playlist_TOP100.ColumnHeadersHeight = 27;
            this.datagrid_Playlist_TOP100.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Playlist_TOP100.DefaultCellStyle = dataGridViewCellStyle11;
            this.datagrid_Playlist_TOP100.EnableHeadersVisualStyles = false;
            this.datagrid_Playlist_TOP100.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.datagrid_Playlist_TOP100.Location = new System.Drawing.Point(11, 279);
            this.datagrid_Playlist_TOP100.Name = "datagrid_Playlist_TOP100";
            this.datagrid_Playlist_TOP100.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Playlist_TOP100.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.datagrid_Playlist_TOP100.RowHeadersVisible = false;
            this.datagrid_Playlist_TOP100.RowHeadersWidth = 51;
            this.datagrid_Playlist_TOP100.RowTemplate.Height = 24;
            this.datagrid_Playlist_TOP100.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Playlist_TOP100.Size = new System.Drawing.Size(1067, 450);
            this.datagrid_Playlist_TOP100.TabIndex = 162;
            this.datagrid_Playlist_TOP100.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagrid_Playlist_TOP100.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOP100.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_Playlist_TOP100.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist_TOP100.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist_TOP100.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_Playlist_TOP100.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.datagrid_Playlist_TOP100.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.datagrid_Playlist_TOP100.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist_TOP100.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_Playlist_TOP100.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Playlist_TOP100.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOP100.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_Playlist_TOP100.ThemeStyle.HeaderStyle.Height = 27;
            this.datagrid_Playlist_TOP100.ThemeStyle.ReadOnly = true;
            this.datagrid_Playlist_TOP100.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Playlist_TOP100.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Playlist_TOP100.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Playlist_TOP100.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Playlist_TOP100.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_Playlist_TOP100.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Playlist_TOP100.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Playlist_TOP100.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_Playlist_TOP100_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Thumbnail";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label27.Location = new System.Drawing.Point(24, 2389);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(205, 25);
            this.label27.TabIndex = 142;
            this.label27.Text = "VIETNAMESE RAPPER";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(27, 2649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 135;
            this.label1.Text = "FOREIGN ARTISTS";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Location = new System.Drawing.Point(27, 2133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 25);
            this.label13.TabIndex = 128;
            this.label13.Text = "VIETNAMESE SINGER";
            // 
            // lbl_title1
            // 
            this.lbl_title1.AutoSize = true;
            this.lbl_title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.lbl_title1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_title1.Location = new System.Drawing.Point(530, 19);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(376, 112);
            this.lbl_title1.TabIndex = 127;
            this.lbl_title1.Text = "TOP 100";
            // 
            // Frm_Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 740);
            this.Controls.Add(this.panel_Child);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ranking";
            this.Text = "Frm_Ranking";
            this.Load += new System.EventHandler(this.Frm_Ranking_Load);
            this.panel_Child.ResumeLayout(false);
            this.panel_Child.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Playlist_TOP100)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panel_Child;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_title1;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_Playlist_TOP100;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Tittle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_Playlist;
        private System.Windows.Forms.Label lbl_App_Name;
    }
}