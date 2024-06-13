using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PQTMUSIC_APP
{
    public partial class Frm_Ranking : Form
    {
        public Frm_Ranking()
        {
            InitializeComponent();
        }

        string apiUrl = "https://apimusic.bug.edu.vn/zing/getChartHome";
        public event EventHandler<Tuple<Class_SongFullData, List<Class_SongFullData>>> SongSelected;
        public List<Class_SongFullData> songList { get; private set; }

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

        private async void Frm_Ranking_Load(object sender, EventArgs e)
        {
            Service songs = new Service();
            songList = await songs.GetSongsByURL(apiUrl);
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

                    datagrid_Playlist_TOP100.Rows.Add(row);
                    datagrid_Playlist_TOP100.Rows[datagrid_Playlist_TOP100.RowCount - 1].Tag = song;
                    datagrid_Playlist_TOP100.Rows[datagrid_Playlist_TOP100.RowCount - 1].Height = thumbnail.Height;
                }
            }
            datagrid_Playlist_TOP100.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Datagrid_Playlist_TOP100_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Class_SongFullData song = datagrid_Playlist_TOP100.Rows[e.RowIndex].Tag as Class_SongFullData;
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
