﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PQTMUSIC_APP
{
    public partial class frm_Explore : Form
    {
        public frm_Explore()
        {
            InitializeComponent();
        }

        public string apiUrl = "https://apimusic.bug.edu.vn/zing/getHome";


        public event EventHandler<Tuple<Class_SongFullData, List<Class_SongFullData>>> SongSelected;
        public List<Class_SongFullData> songList { get; private set; }

        private async void frm_Explore_Load(object sender, EventArgs e)
        {
            Service songs = new Service();
            songList = await songs.GetSongsExplore();
            AddDataToDataGridView(songList);
        }
        private async void AddDataToDataGridView(List<Class_SongFullData> songs)
        {
            List<Class_SongFullData> songsCopy = new List<Class_SongFullData>(songs);
            foreach (var song in songsCopy)
            {
                Image thumbnail = await LoadImage(song.Thumbnail);
                if (thumbnail != null)
                {
                    thumbnail = ResizeImage(thumbnail, new Size(70, 70));

                    DataGridViewImageCell imageCell = new DataGridViewImageCell
                    {
                        Value = thumbnail
                    };

                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(imageCell);
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Title });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Artists[0].Name });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Duration.ToString() });

                    datagrid_Playlist_TOPSONG.Rows.Add(row);
                    datagrid_Playlist_TOPSONG.Rows[datagrid_Playlist_TOPSONG.RowCount - 1].Tag = song;
                    datagrid_Playlist_TOPSONG.Rows[datagrid_Playlist_TOPSONG.RowCount - 1].Height = thumbnail.Height;
                }
            }
            datagrid_Playlist_TOPSONG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       

        private async Task<Image> LoadImage(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Throw if not a success code.
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                return null;
            }
        }
        private Image ResizeImage(Image image, Size size)
        {
            return (Image)(new Bitmap(image, size));
        }

        private void datagrid_Playlist_TOPSONG_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Class_SongFullData song = datagrid_Playlist_TOPSONG.Rows[e.RowIndex].Tag as Class_SongFullData;
                if (song != null)
                {
                    SongSelected?.Invoke(this, new Tuple<Class_SongFullData, List<Class_SongFullData>>(song, songList));
                }
                else
                {
                    MessageBox.Show("No song data available.");
                }
            }
        }
    }
}
