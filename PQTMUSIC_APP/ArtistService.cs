using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PQTMUSIC_APP
{
    public class ArtistService
    {
        // Danh sách lưu trữ thông tin nghệ sĩ
        private List<Class_Artist> artists = new List<Class_Artist>();

        // Phương thức để thêm nghệ sĩ
       

        // Phương thức để lưu thông tin nghệ sĩ từ JSON
        public async Task<List<Class_Artist>> GetArtistBySearch(string query)
        {

            using (HttpClient client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(query))
                {
                    string apiUrl = "https://apimusic.bug.edu.vn/zing/search";

                    var postData = new
                    {
                        name = query
                    };

                    try
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        StringContent content = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject jObject = JObject.Parse(responseBody);
                        JArray artistsArray = (JArray)jObject["data"]["artists"];
                        List<Class_Artist> artists = new List<Class_Artist>();
                        foreach (var artistItem in artistsArray)
                        {
                            var artist = new Class_Artist
                            {
                                ArtistId = artistItem["id"]?.ToString(),
                                Name = artistItem["name"]?.ToString(),
                                Alias = artistItem["alias"]?.ToString(),
                                ShortLink = artistItem["link"]?.ToString(),
                                ImageUrl = artistItem["thumbnail"]?.ToString()
                            };
                            artists.Add(artist);
                        }
                        return artists;
                        
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
