using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Media;
using NAudio.Wave;
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
        public event EventHandler<Class_SongFullData> SongSelected;

        private async void frm_Explore_Load(object sender, EventArgs e)
        {
            List<Class_SongFullData> songs = await GetSongsFromApi(apiUrl);

            foreach (var song in songs)
            {
                var row = new object[]
                {
                        await LoadImage(song.Thumbnail), // Load the image from the URL
                        song.Title,
                        string.Join(", ", song.Artists.Select(a => a.Name)), // Fix the FormatException by selecting the Name property of each artist,
                        song.Duration
                };

                // Add the row to the DataGridView
                int rowIndex = datagrid_Playlist_TOPSONG.Rows.Add(row);
                datagrid_Playlist_TOPSONG.Rows[rowIndex].Tag = song;
            }
        }

        public async Task<List<Class_SongFullData>> GetSongsFromApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    try
                    {
                        var jObject = JObject.Parse(json);

                        // Check if "data" and "items" exist in the JSON object
                        if (jObject["data"]?["items"] is JArray items)
                        {
                            var newReleaseSection = items.FirstOrDefault(x => x["sectionType"].ToString() == "new-release");

                            // Check if "items" and "vPop" exist in the newReleaseSection
                            if (newReleaseSection?["items"]?["vPop"] is JArray vPopItems)
                            {
                                var vpopFullData = new List<Class_SongFullData>();
                                foreach (var track in vPopItems)
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
                                    vpopFullData.Add(song);
                                }

                                return vpopFullData;
                            }
                        }
                    }
                    catch (JsonReaderException ex)
                    {
                        // Or you can show an error message to the user using a MessageBox
                        MessageBox.Show("An error occurred while parsing the JSON response: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    // Show an error message to the user
                    MessageBox.Show("An error occurred while making the API request. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Return an empty list if any of the required properties are missing or an error occurred
                return null;
            }
        }



        private async Task<Image> LoadImage(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    return Image.FromStream(stream);
                }
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

        private void datagrid_Playlist_TOPSONG_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Class_SongFullData song = datagrid_Playlist_TOPSONG.Rows[e.RowIndex].Tag as Class_SongFullData;
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

        private void lbl_App_Name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Tittle_Click(object sender, EventArgs e)
        {

        }
    }
}