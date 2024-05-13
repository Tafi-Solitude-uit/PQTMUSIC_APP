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


namespace PQTMUSIC_APP
{
    public partial class frm_Explore : Form
    {
        private HttpClient client = new HttpClient();
        private string clientId = "65252f95054a4037be2b62a238222bd9";
        private string clientSecret = "40a851303a474018a57b7f09284e72f8";
        private string accessToken;

        public frm_Explore()
        {
            InitializeComponent();
        }

        private async Task GetAccessToken()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}")));
            request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonResponse);
                accessToken = jsonObject.Value<string>("access_token");

                var expiresIn = jsonObject.Value<int>("expires_in");
                Task.Delay(TimeSpan.FromSeconds(expiresIn)).ContinueWith(async _ => await GetAccessToken());
            }
            else
            {
                // The status code indicates an error
                var errorResponse = await response.Content.ReadAsStringAsync();
                var errorObject = JObject.Parse(errorResponse);
                var errorMessage = errorObject.Value<string>("error_description");

                // Handle the error
                // For example, you can log the error message or show it to the user
                Console.WriteLine($"Error getting access token: {errorMessage}");
            }
        }

        private async Task RefreshAccessToken()
        {
            // The client credentials flow does not support refreshing the access token.
            // You need to request a new access token when the current one expires.
            await GetAccessToken();
        }

        private async Task DisplaySongs(List<Song> songs)
        {
            listView1.Items.Clear();
            listView1.LargeImageList = new ImageList();

            foreach (var song in songs)
            {
                var image = await DownloadImage(song.ImageUrl);
                listView1.LargeImageList.Images.Add(image);

                var listViewItem = new ListViewItem(song.Name);
                listViewItem.SubItems.Add(song.Artist);
                listViewItem.ImageIndex = listView1.LargeImageList.Images.Count - 1;
                listView1.Items.Add(listViewItem);
            }
        }

        private async Task<Image> DownloadImage(string url)
        {
            var response = await client.GetAsync(url);
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                return Image.FromStream(stream);
            }
        }

        private void panel_Child_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void frm_Explore_Load(object sender, EventArgs e)
        {
            await GetAccessToken();
            var songs = await GetSongsFromApi();
            await DisplaySongs(songs);
        }
        private async Task<List<Song>> GetSongsFromApi()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await client.GetAsync("https://api.spotify.com/v1/browse/new-releases"); // Replace with the correct URL
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonResponse);
                var songs = jsonObject["albums"]["items"].ToObject<List<Song>>();
                return songs;
            }
            else
            {
                // Handle the error
                return new List<Song>();
            }
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string ImageUrl { get; set; }
        // Add other properties as needed
    }
}
