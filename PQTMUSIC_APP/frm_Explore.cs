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


namespace PQTMUSIC_APP
{
    public partial class frm_Explore : Form
    {
        private readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://api.spotify.com/")
        };
        private const string clientId = "65252f95054a4037be2b62a238222bd9";
        private const string clientSecret = "40a851303a474018a57b7f09284e72f8";
        private string accessToken;
        private string cacheDuration;

        public frm_Explore()
        {
            InitializeComponent();
        }

        private async Task GetAccessToken()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token")
            {
                Headers = { Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"))) },
                Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded")
            };

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Access token retrieved successfully");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonResponse);
                accessToken = jsonObject.Value<string>("access_token");

                var expiresIn = jsonObject.Value<int>("expires_in");
                _ = Task.Delay(TimeSpan.FromSeconds(expiresIn)).ContinueWith(async _ => await GetAccessToken());
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                var errorObject = JObject.Parse(errorResponse);
                var errorMessage = errorObject.Value<string>("error_description");

                Console.WriteLine($"Error getting access token: {errorMessage}");
            }
        }
      

      
        private async void frm_Explore_Load(object sender, EventArgs e)
        {
          await DisplayNewReleases();
        }

        private async Task getTrackDuration(string TrackID) 
        {
            var response = await client.GetAsync("v1/tracks/" + TrackID);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonResponse);
                this.cacheDuration = jsonObject["duration_ms"].ToString();
            }
            else {
                this.cacheDuration = "";
            }  
        }


        private async Task DisplayNewReleases()
        {
            await GetAccessToken();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var response = await client.GetAsync("v1/browse/new-releases");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonResponse);
                var albums = jsonObject["albums"]["items"];

                listSong.Items.Clear();
                listSong.View = View.Details;
                listSong.Columns.Add("Image", -2, HorizontalAlignment.Left);
                listSong.Columns.Add("Track Name", -2, HorizontalAlignment.Left);
                listSong.Columns.Add("Track Duration", -2, HorizontalAlignment.Left);

                foreach (var album in albums)
                {
                    var albumArtist = album["artists"].FirstOrDefault()["name"].ToString();
                    var albumImage = album["images"].ToString();
                    var albumName = album["name"].ToString();
                    var albumId = album["id"].ToString();
                    
                    await getTrackDuration(albumId);
                    
                    var item = new ListViewItem(new[] { albumImage, albumName ,this.cacheDuration });
                    listSong.Items.Add(item);
                    this.cacheDuration = "";
                }
                /*  var track = album["name"].ToString();

                  var duration = album["duration_ms"].ToString();

                  var imageToken = album["images"] != null ? album["images"].FirstOrDefault() : null;

                  var imageUrl = imageToken != null ? (string)imageToken["url"] : null;*/

            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                var errorObject = JObject.Parse(errorResponse);
                var errorMessage = errorObject.Value<string>("error_description");
                Console.WriteLine($"Error getting new releases: {errorMessage}");
            }
        }

        

        private void listSong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listSong.SelectedItems.Count > 0)
            {
                var item = listSong.SelectedItems[0];
                var trackName = item.SubItems[1].Text;
                var trackDuration = item.SubItems[2].Text;
                MessageBox.Show($"Track Name: {trackName}\nTrack Duration: {trackDuration}");
            }
        }
    }
}
