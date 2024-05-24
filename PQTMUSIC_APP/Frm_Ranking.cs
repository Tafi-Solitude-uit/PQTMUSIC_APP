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
using System.Security.Policy;
namespace PQTMUSIC_APP
{
    public partial class Frm_Ranking : Form
    {
        public Frm_Ranking()
        {
            InitializeComponent();
        }
        
        string apiUrl = "https://apimusic.bug.edu.vn/nhaccuatui/getTop100";
        string songDetailsApiUrl = "https://apimusic.bug.edu.vn/nhaccuatui/getSong";
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

        public async Task<List<SongDisplay>> GetSongsFromApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                var json = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(json);
                var jArray = (JArray)jObject["playlist"]["songs"];
                List<SongDisplay> songs = new List<SongDisplay>();
                foreach (var item in jArray)
                {
                    var songDisplay = new SongDisplay
                    {
                        Key = item["key"].ToString(),
                        Title = item["title"].ToString(),
                        Artist = string.Join(", ", item["artists"].Select(a => a["name"].ToString())),
                        Duration = item["duration"].ToString(),
                        Thumbnail = await LoadImage(item["thumbnail"].ToString())
                    };
                    songs.Add(songDisplay);
                }
                return songs;
            }
        }

        private ImageList imageList = new ImageList();
        private ImageList thumbnailList = new ImageList(); // New ImageList for thumbnails
        private async void Frm_Ranking_Load(object sender, EventArgs e)
        {
            List<SongDisplay> songs = await GetSongsFromApi(apiUrl);

            imageList.ImageSize = new Size(50, 50);
            thumbnailList.ImageSize = new Size(30, 30); // Set the size of the thumbnail images

            ListTop100.Columns.Add("", 30, HorizontalAlignment.Left);
            ListTop100.Columns.Add("Title", -2, HorizontalAlignment.Left);
            ListTop100.Columns.Add("Artist", -2, HorizontalAlignment.Left);
            ListTop100.Columns.Add("Duration", 150, HorizontalAlignment.Left);

            ListTop100.SmallImageList = imageList; // Use imageList for the main columns
            ListTop100.LargeImageList = thumbnailList; // Use thumbnailList for the thumbnail column

            foreach (var song in songs)
            {
                imageList.Images.Add(song.Title, song.Thumbnail);
                thumbnailList.Images.Add(song.Thumbnail); // Add the thumbnail to the thumbnailList

                ListViewItem musicListViewItem = new ListViewItem(new string[] { "", song.Title, song.Artist, song.Duration.ToString() }, thumbnailList.Images.Count - 1);
                musicListViewItem.Tag = song;
                ListTop100.Items.Add(musicListViewItem);
            }

            ListTop100.View = View.Details;
            ListTop100.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

    }
}
