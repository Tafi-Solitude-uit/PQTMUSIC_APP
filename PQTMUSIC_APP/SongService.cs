using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace PQTMUSIC_APP
{
    internal class SongService: Class_Song
    {


        public async Task<string> GetURLsFromApi(string apiUrl, string songID, Class_SongFullData song)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiUrl}?songId={songID}");
                response.EnsureSuccessStatusCode(); // Kiểm tra xem request có thành công không
                var responseContent = await response.Content.ReadAsStringAsync();
                var songData = JObject.Parse(responseContent);
                string linkStream = (string)songData["song"]["streamUrls"][0]["streamUrl"];
                
                return linkStream;

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
