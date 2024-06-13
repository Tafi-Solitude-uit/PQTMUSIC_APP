using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PQTMUSIC_APP
{
    public partial class Form_Artist : Form
    {
        public Form_Artist()
        {
            InitializeComponent();
        }

        public event EventHandler<Tuple<Class_SongFullData, List<Class_SongFullData>>> SongSelected;
        public List<Class_SongFullData> songList { get; private set; }

        private async Task<Class_Artist> GetArtistData(string Alias)
        {
            string url = $"https://apimusic.bug.edu.vn/zing/getArtist?artistId={Alias}";
            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(url);
                JObject jObject = JObject.Parse(json);
                Class_Artist artist = new Class_Artist
                {
                    Name = (string)jObject["data"]["name"],
                    Alias = (string)jObject["data"]["alias"],
                    ImageUrl = (string)jObject["data"]["thumbnail"],
                    Biography = (string)jObject["data"]["biography"],
                    National = (string)jObject["data"]["national"],
                    Birthday = (string)jObject["data"]["birthday"],
                    Followers = (int)jObject["data"]["totalFollow"]
                };
                return artist;
            }
        }

        private async Task<List<Class_SongFullData>> GetArtistSongs(string Alias)
        {
            string url = $"https://apimusic.bug.edu.vn/zing/getArtist?artistId={Alias}";
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    try
                    {
                        var jObject = JObject.Parse(json);

                        if (jObject["data"]?["sections"] is JArray sections)
                        {
                            var songSection = sections.FirstOrDefault(x => x["sectionType"].ToString() == "song");

                            if (songSection?["items"] is JArray songItems)
                            {
                                var songFullData = new List<Class_SongFullData>();
                                foreach (var track in songItems)
                                {
                                    var song = new Class_SongFullData
                                    {
                                        EncodeId = track["encodeId"].ToString(),
                                        Title = track["title"].ToString(),
                                        Artists = track["artists"].Select(a => new Class_Artist
                                        {
                                            ArtistId = a["id"].ToString(),
                                            Name = a["name"].ToString()
                                        }).ToList(),
                                        Duration = TimeSpan.FromSeconds(int.Parse(track["duration"].ToString())).ToString(@"m\:ss"),
                                        Thumbnail = track["thumbnail"].ToString(),
                                        StreamUrls = await GetStreamUrlAsync(track["encodeId"].ToString())
                                    };
                                    songFullData.Add(song);
                                }
                                songList = songFullData;
                                return songList;
                            }
                        }
                    }
                    catch (JsonReaderException ex)
                    {
                        MessageBox.Show("An error occurred while parsing the JSON response: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("An error occurred while making the API request. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return new List<Class_SongFullData>();
            }
        }

        public async Task<string> GetStreamUrlAsync(string songId)
        {
            string url = $"https://apimusic.bug.edu.vn/zing/getSong?songId={songId}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(jsonResponse);

                    if (jsonData != null && jsonData.err == 0)
                    {
                        string streamUrl = jsonData.data["128"];
                        return streamUrl;
                    }
                }
            }

            return null;
        }

        public async void ShowArtistDetails(Class_Artist artist)
        {
            Class_Artist artistData = await GetArtistData(artist.Alias);

            pic_Singer.Image = await LoadImage(artistData.ImageUrl);
            lbl_ArtistName.Text = artistData.Name;
            lbl_totalFollowers.Text = artistData.Followers.ToString();
            txt_Bio.Text = artistData.Biography;
            lbl_National.Text = artistData.National;
            lbl_Birthday.Text = artistData.Birthday;

            songList = await GetArtistSongs(artist.Alias);
            AddDataToDataGridView(songList);
        }

        private async void AddDataToDataGridView(List<Class_SongFullData> songs)
        {
            datagrid_SongOfSinger.Rows.Clear();

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
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Join(", ", song.Artists.Select(a => a.Name)) });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Duration });

                    datagrid_SongOfSinger.Rows.Add(row);
                    datagrid_SongOfSinger.Rows[datagrid_SongOfSinger.RowCount - 1].Tag = song;
                    datagrid_SongOfSinger.Rows[datagrid_SongOfSinger.RowCount - 1].Height = thumbnail.Height;
                }
            }
            datagrid_SongOfSinger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void datagrid_SongOfSinger_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void datagrid_SongOfSinger_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Class_SongFullData song = datagrid_SongOfSinger.Rows[e.RowIndex].Tag as Class_SongFullData;
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
