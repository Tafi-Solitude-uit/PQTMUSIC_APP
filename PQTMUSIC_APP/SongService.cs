using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PQTMUSIC_APP
{
    internal class SongService: Class_SongFullData
    {
        public async Task<string> GetURLsFromApi(string apiUrl, string songID, Class_SongFullData song)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = null;
                for (int i = 0; i < 3; i++) // Try 3 times
                {
                    try
                    {
                        response = await client.GetAsync($"{apiUrl}?songId={songID}");
                        response.EnsureSuccessStatusCode(); // Check if request is successful
                        break; // If no exception is thrown, break the loop
                    }
                    catch (HttpRequestException) when (i < 2) // If it's not the last attempt
                    {
                        await Task.Delay(2000); // Wait for 2 seconds before the next attempt
                    }
                }

                if (response == null || !response.IsSuccessStatusCode)
                {
                    // Handle the case when all attempts fail
                    MessageBox.Show("Failed to get response from API after 3 attempts");
                    return null;
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var songData = JObject.Parse(responseContent);

                JArray streamUrls = (JArray)songData["song"]["streamUrls"];
                if (streamUrls.Count > 0)
                {
                    string linkStream = (string)streamUrls[0]["streamUrl"];
                    MessageBox.Show(linkStream);
                    return linkStream;
                }
                else
                {
                    // Handle the case when streamUrls array is empty
                    MessageBox.Show("No stream URL found");
                    return null;
                }
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
        public async Task<List<Class_SongFullData>> GetSongToDisplayFromApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                var json = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(json);
                var jArray = (JArray)jObject["playlist"]["songs"];
                List<Class_SongFullData> songs = new List<Class_SongFullData>();
                foreach (var item in jArray)
                {
                    var songDisplay = new Class_SongFullData
                    {
                        Key = item["key"].ToString(),
                        Title = item["title"].ToString(),
                        Artists = item["artists"].Select(a => new Class_Artist { Name = a["name"].ToString() }).ToList(),
                        Duration = item["duration"].ToString(),
                        Thumbnail = await LoadImage(item["thumbnail"].ToString())
                    };
                    songs.Add(songDisplay);
                }
                return songs;
            }
        }

    }
}
    

