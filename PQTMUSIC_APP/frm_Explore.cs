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

        public string apiUrl = "https://apimusic.bug.edu.vn/nhaccuatui/getHome";

        private async void frm_Explore_Load(object sender, EventArgs e)
        {
            List<Class_SongFullData> songs = await GetSongsFromApi(apiUrl);

            foreach (var song in songs)
            {
                var row = new object[]
                {
                        await LoadImage(song.Thumbnail), // Load the image from the URL
                        song.Title,
                        string.Join(", ", song.Artists),
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
                                            ArtistId = int.Parse(a["id"].ToString()),
                                            Name = a["name"].ToString()
                                        }).ToList(),
                                        Duration = track["duration"].ToString(),
                                        Thumbnail = track["thumbnail"].ToString()
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

        

        private void datagrid_Playlist_TOPSONG_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming you have a DataGridView named datagrid_playlist_TOPSONG in your form
            //var selectedSong = (Class_Song)datagrid_playlist_TOPSONG.Rows[e.RowIndex].DataBoundItem;

            // Assuming you have a method named PlaySong to play the song
            //PlaySong(selectedSong);
        }

        private void PlaySong(Class_SongFullData song)
        {
            // Code to play the song goes here
            // Assuming you have a URL for the song
            string songUrl = song.StreamUrls[0].Url;

            // Assuming you have a title for the song
            string songTitle = song.Title;

            // Assuming you have an artist name for the song
            string artistName = song.Artists[0].Name;

            // Assuming you have a method to play the audio
            PlayAudio(songUrl);

            // Assuming you have a method to display the song title and artist name
            DisplaySongInfo(songTitle, artistName);
        }

        private void PlayAudio(string url)
        {
            // Code to play the audio goes here
            using (var waveOut = new WaveOutEvent())
            {
                using (var audioStream = new MediaFoundationReader(url))
                {
                    waveOut.Init(audioStream);
                    waveOut.Play();
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {

                    }
                }
            }
        }

        public void DisplaySongInfo(string title, string artist)
        {
            // Assuming you have a reference to lbl_Music_Playing_MainForm and lbl_Artist_Playing_MainFrom
            //lbl_Music_Playing_MainForm.Text = title;
            //lbl_Artist_Playing_MainFrom.Text = artist;
        }
    }
}