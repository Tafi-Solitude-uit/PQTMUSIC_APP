using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;

namespace PQTMUSIC_APP
{
    public partial class frm_Fav : Form
    {
        public frm_Fav()
        {
            InitializeComponent();
        }

        public event EventHandler<Class_SongFullData> SongSelected;
        public event EventHandler<List<Class_SongFullData>> PlaylistSelected;
        public List<Class_SongFullData> songList { get; private set; }

        public async void frm_Fav_Load(object sender, EventArgs e)
        {
            datagrid_Playlist_fav.Rows.Clear();
            await LoadFavoriteSongs();
                            
        }

        private async Task LoadFavoriteSongs()
        {
            try
            {
                songList = new List<Class_SongFullData>();
                Service songs = new Service();
                List<string> favSongIDs = await GetSongList();

                foreach (string songID in favSongIDs)
                {
                    Class_SongFullData song = await songs.GetFavSong(songID);
                    if (song != null)
                    {
                        songList.Add(song);
                    }
                }

                AddDataToDataGridView(songList);
                PlaylistSelected?.Invoke(this, songList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading favorite songs: " + ex.Message);
            }
        }

        private async Task<List<string>> GetSongList()
        {
            try
            {
                FirebaseResponse response = await Frm_LgSU.client.GetAsync("Users/" + Frm_LgSU.currentUser + "/favSongID");
                List<string> songList = response.ResultAs<List<string>>();
                return songList ?? new List<string>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading favorite songs: " + ex.Message);
                return new List<string>();
            }
        }

        private async void AddDataToDataGridView(List<Class_SongFullData> songs)
        {
            foreach (var song in songs)
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

                    datagrid_Playlist_fav.Rows.Add(row);
                    datagrid_Playlist_fav.Rows[datagrid_Playlist_fav.RowCount - 1].Tag = song;
                    datagrid_Playlist_fav.Rows[datagrid_Playlist_fav.RowCount - 1].Height = thumbnail.Height;
                }
            }
            datagrid_Playlist_fav.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private Image ResizeImage(Image image, Size size)
        {
            return (Image)(new Bitmap(image, size));
        }

        private async Task<Image> LoadImage(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
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

        private void datagrid_Playlist_fav_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Class_SongFullData song = datagrid_Playlist_fav.Rows[e.RowIndex].Tag as Class_SongFullData;
                if (song != null)
                {
                    SongSelected?.Invoke(this, song);
                }
                else
                {
                    MessageBox.Show("No song data available.");
                }
            }
        }
    }
}
