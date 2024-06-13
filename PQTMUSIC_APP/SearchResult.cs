using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace PQTMUSIC_APP
{
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        public List<Class_SongFullData> songList { get; private set; }
        public event EventHandler<Tuple<Class_SongFullData, List<Class_SongFullData>>> SongSelected;
      
        public event EventHandler<Class_Artist> ArtistSelected;

        public List<Class_Artist> artistList { get; private set; }

        public string query;

        private async void SearchResult_Load(object sender, EventArgs e)
        {
            query = Main_Form.query;
            Service songs = new Service();
            ArtistService artists = new ArtistService();
            songList = await songs.GetSongBySearch(query);
            artistList = await artists.GetArtistBySearch(query);
            AddDataToDataGridView(songList);
            AddArtistsToPanel(artistList);
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
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Artists?.FirstOrDefault()?.Name ??"unknown artist"});
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Duration.ToString() });

                    datagrid_SearchResult.Rows.Add(row);
                    datagrid_SearchResult.Rows[datagrid_SearchResult.RowCount - 1].Tag = song;
                    datagrid_SearchResult.Rows[datagrid_SearchResult.RowCount - 1].Height = thumbnail.Height;
                }
            }
            datagrid_SearchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private async void AddArtistsToPanel(List<Class_Artist> artists)
        {
            int displayedArtists = 0;
            foreach (var artist in artists)
            {
                if (displayedArtists >= 4) break; // Chỉ hiển thị 4 panel

                Panel artistPanel = new Panel
                {
                    Size = new Size(300, 100), // Panel nằm ngang với kích thước 300x100
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),// Thêm khoảng cách giữa các panel
                    BackColor = Color.White
                };

                PictureBox artistImage = new PictureBox
                {
                    Size = new Size(80, 80),
                    Location = new Point(10, 10), // Cách lề trái và lề trên của panel 10px
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Image image = await LoadImage(artist.ImageUrl);
                if (image != null)
                {
                    artistImage.Image = image;
                }

                Label artistName = new Label
                {
                    Text = artist.Name,
                    Location = new Point(100, 35), // Vị trí bên phải của ảnh
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                artistPanel.Controls.Add(artistImage);
                artistPanel.Controls.Add(artistName);
                artistPanel.Click += (sender, e) => ShowArtistDetails(artist);

                flowLayoutPanel_Artists.Controls.Add(artistPanel);

                displayedArtists++;
            }
        }

        private void ShowArtistDetails(Class_Artist artist)
        {
            ArtistSelected?.Invoke(this, artist);
        }

        private void datagrid_SearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Class_SongFullData song = datagrid_SearchResult.Rows[e.RowIndex].Tag as Class_SongFullData;
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
