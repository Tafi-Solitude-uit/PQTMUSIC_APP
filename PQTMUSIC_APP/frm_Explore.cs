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





namespace PQTMUSIC_APP
{
    public partial class frm_Explore : Form
    {

        public frm_Explore()
        {
            InitializeComponent();
        }

        //string songId;
        
        private async void frm_Explore_Load(object sender, EventArgs e)
        {
            string apiUrl = "https://apimusic.bug.edu.vn/nhaccuatui/getHome";
            string songDetailsApiUrl = "https://apimusic.bug.edu.vn/nhaccuatui/getSong";
            List<Class_SongFullData> songs = await GetSongsFromApi(apiUrl, songDetailsApiUrl);

            datagrid_Playlist_TOPSONG.DataSource = songs;
        }

        public async Task<Class_Song> GetSongDetailsFromApi(string DetailapiUrl, string songId)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{DetailapiUrl}?songId={songId}");
                var json = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(json);
                var song = jObject["song"].ToObject<Class_Song>();
                return song;
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

        public async Task<List<Class_SongFullData>> GetSongsFromApi(string apiUrl, string songDetailsApiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                var json = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(json);
                var jArray = (JArray)jObject["newRelease"]["song"];
                List<Class_SongFullData> songs = new List<Class_SongFullData>();
                foreach (var item in jArray)
                {
                    var songKey = item["key"].ToString();
                    var songDetails = await GetSongDetailsFromApi(songDetailsApiUrl, songKey);
                    var songDisplay = new Class_SongFullData
                    {
                        Title = songDetails.Title,
                        Artist = string.Join(", ", songDetails.Artists.Select(a => a.Name)),
                        Duration = songDetails.Title,
                        Thumbnail = await LoadImage(songDetails.Thumbnail) // Load the image from the URL
                    };
                    songs.Add(songDisplay);
                }
                return songs;
            }
        }

        private void datagrid_Playlist_TOPSONG_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming you have a DataGridView named datagrid_playlist_TOPSONG in your form
            //var selectedSong = (Class_Song)datagrid_playlist_TOPSONG.Rows[e.RowIndex].DataBoundItem;

            // Assuming you have a method named PlaySong to play the song
            //PlaySong(selectedSong);
        }

        private void PlaySong(Class_Song song)
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