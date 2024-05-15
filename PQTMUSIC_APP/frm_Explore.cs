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
        private readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://api.spotify.com/")
        };
        private const string clientId = "65252f95054a4037be2b62a238222bd9";
        private const string clientSecret = "40a851303a474018a57b7f09284e72f8";
        private string accessToken;

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

        private async Task DisplaySongs(List<Song> songs)
        {
            listView1.LargeImageList = new ImageList();

            foreach (var song in songs)
            {
                var image = await DownloadImage(song.ImageUrl);
                if (image != null)
                {
                    listView1.LargeImageList.Images.Add(image);

                    var listViewItem = new ListViewItem(song.Name) { ImageIndex = listView1.LargeImageList.Images.Count - 1 };
                    listViewItem.SubItems.Add(song.Artist);
                    listView1.Items.Add(listViewItem);
                }
                else
                {
                    Console.WriteLine($"No image found for song: {song.Name}");
                }
            }
        }

        private async Task<Image> DownloadImage(string url)
        {
            var response = await client.GetAsync(url);
            if (response.Content.Headers.ContentType.MediaType.StartsWith("image/"))
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    return Image.FromStream(stream);
                }
            }
            else
            {
                Console.WriteLine($"URL does not return an image: {url}");
                return null;
            }
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

            var response = await client.GetAsync("https://api.spotify.com/v1/browse/new-releases");
            Console.WriteLine($"Response status code: {response.StatusCode}");
            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Response content: {responseContent}");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonResponse);
                var songs = jsonObject["albums"]["items"].ToObject<List<Song>>();
                Console.WriteLine($"Retrieved {songs.Count} songs from the API.");

                return songs;
            }
            else
            {
                Console.WriteLine("Error retrieving songs from the API.");
                return new List<Song>();
            }
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string ImageUrl { get; set; }
    }
}
