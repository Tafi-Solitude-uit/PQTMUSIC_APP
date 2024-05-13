using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PQTMUSIC_APP
{
    public partial class testAPI : Form
    {
        private HttpClient client = new HttpClient();

        public testAPI()
        {
            InitializeComponent();
            this.Load += testAPI_Load;
        }

      

        private async Task<List<Song>> GetSongsFromApi()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("your-api-url-here");
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                var songs = JsonConvert.DeserializeObject<List<Song>>(stringResponse);
                return songs;
            }
            else
            {
                // Handle the error
                return new List<Song>();
            }
        }

        private async void testAPI_Load(object sender, EventArgs e)
        {
            var songs = await GetSongsFromApi();
            foreach (var song in songs)
            {
                var listViewItem = new ListViewItem();
                listViewItem.ImageKey = song.ImageUrl; // Assuming the song image URL is stored in the ImageUrl property
                listViewItem.SubItems.Add(song.Name); // Assuming the song name is stored in the Name property
                listViewItem.SubItems.Add(song.Artist); // Assuming the artist name is stored in the Artist property
                listView1.Items.Add(listViewItem); // Assuming listView1 is your ListView
            }
        }
    }
   

    public class Song
    {
        // Define your song properties here
    }
}
