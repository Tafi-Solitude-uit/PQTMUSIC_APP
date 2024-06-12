using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AngleSharp.Text;
using NAudio.Wave;
using AngleSharp.Io;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Swan.Formatters;

namespace PQTMUSIC_APP
{
    public class Service : Class_SongFullData
    {
        public string detailAPI = "https://apimusic.bug.edu.vn/zing/getSong";
        public async Task<string> GetURLsToStream(string songID)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = null;
                for (int i = 0; i < 3; i++) // Try 3 times
                {
                    try
                    {
                        response = await client.GetAsync($"{detailAPI}?songId={songID}");
                        response.EnsureSuccessStatusCode();
                        break;
                    }
                    catch (HttpRequestException) when (i < 2) // If it's not the last attempt
                    {
                        await Task.Delay(2000); // Wait for 2 seconds before the next attempt
                    }
                }

                if (response == null || !response.IsSuccessStatusCode)
                {

                    throw new Exception("Failed to get response from API after 3 attempts");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                JObject songData = JObject.Parse(responseContent);

                if (songData["msg"].ToString() == "Success")
                {
                    if (songData["data"]["128"] is JToken streamUrlToken)
                    {
                        string linkStream = (string)streamUrlToken;
                        return linkStream;
                    }
                    else
                    {
                        // Handle the case when "128" key is not found
                        throw new Exception("No stream URL found");
                    }
                }
                else
                {
                    MessageBox.Show(songData["msg"].ToString());
                    return null;
                }
            }
        }
        public async Task<List<Class_SongFullData>> GetSongBySearch(string query)
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

                        // Kiểm tra lỗi và thông báo
                        int errorCode = jObject["err"]?.Value<int>() ?? -1;
                        if (errorCode != 0)
                        {
                            // Có lỗi xảy ra
                            MessageBox.Show("Error occurred while searching for songs.");
                            return null;
                        }

                        JArray itemsArray = (JArray)jObject["data"]["songs"];

                        List<Class_SongFullData> songs = new List<Class_SongFullData>();

                        foreach (var item in itemsArray)
                        {
                            string encodeId = item["encodeId"]?.ToString();

                            Class_SongFullData songIn4 = new Class_SongFullData
                            {
                                EncodeId = encodeId,
                                Title = item["title"]?.ToString(),
                                Artists = item["artists"]?.Select(a => new Class_Artist { Name = a["name"]?.ToString() }).ToList(),
                                Duration = ConvertSecondsToMinutes(int.Parse(item["duration"]?.ToString() ?? "0")),
                                Thumbnail = item["thumbnail"]?.ToString(),
                                StreamUrls = await GetURLsToStream(encodeId)
                            };

                            songs.Add(songIn4);
                        }

                        return songs;
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a search query");
                    return null;
                }
            }
        }
        public async Task<List<Class_SongFullData>> GetSongsByURL(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    JObject jObject = JObject.Parse(json);
                    JArray itemsArray = (JArray)jObject["data"]["RTChart"]["items"];

                    List<Class_SongFullData> songs = new List<Class_SongFullData>();

                    foreach (var item in  itemsArray)
                    {
                        
                        string encodeId = item["encodeId"]?.ToString();                    

                        Class_SongFullData songIn4 = new Class_SongFullData
                        {
                            EncodeId = encodeId,
                            Title = item["title"]?.ToString(),
                            Artists = item["artists"]?.Select(a => new Class_Artist { Name = a["name"]?.ToString() }).ToList(),
                            Duration = ConvertSecondsToMinutes(int.Parse(item["duration"]?.ToString() ?? "0")),
                            Thumbnail = item["thumbnail"]?.ToString(),
                            StreamUrls = await GetURLsToStream(encodeId)
                        };

                        songs.Add(songIn4);
                    }

                    return songs;
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Failed to get response from API");
                    return null;
                }
            }
        }
        public string ConvertSecondsToMinutes(int totalSeconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            return time.ToString(@"m\:ss");
        }
        public async Task<Class_SongFullData> GetFavSong(string songID)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"https://apimusic.bug.edu.vn/zing/getInfoSong?songId={songID}");
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    JObject jObject = JObject.Parse(json);
                    JObject dataObject = (JObject)jObject["data"];
                    
                    Class_SongFullData songIn4 = new Class_SongFullData
                    {
                        EncodeId = dataObject["encodeId"]?.ToString(),
                        Title = dataObject["title"]?.ToString(),
                        Artists = dataObject["artists"]?.Select(a => new Class_Artist { Name = a["name"]?.ToString(), ArtistId = a["id"]?.ToString() }).ToList(),
                        Duration = ConvertSecondsToMinutes(int.Parse(dataObject["duration"]?.ToString() ?? "0")),
                        Thumbnail = dataObject["thumbnail"]?.ToString(),
                        StreamUrls = await GetURLsToStream(songID)
                    };
                    
                    return songIn4;
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Failed to get response from API");
                    return null;
                }
            }
        }
    }
}
