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

namespace PQTMUSIC_APP
{
    internal class Service: Class_SongFullData
    {
        public async Task<string> GetURLsToStream(string apiUrl, string songID)
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
                    throw new Exception("Failed to get response from API after 3 attempts");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                JObject songData = JObject.Parse(responseContent);

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
        }


        public async Task<List<Class_SongFullData>> GetSongFromApi(string apiUrl, string typeGet)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    JObject jObject = JObject.Parse(json);
                    JArray jArray = (JArray)jObject["data"]["items"];

                    List<Class_SongFullData> songs = new List<Class_SongFullData>();

                    foreach (var item in jArray)
                    {
                        for (int i = 0; i < item.Count(); i++)
                        {
                            var aa = item[i] as JObject;
                            if (aa != null && aa["selectionType"].ToString() == typeGet)
                            {
                               
                                Class_SongFullData songIn4 = new Class_SongFullData
                                {
                                    EncodeId = item["items"]["all"]["encodeId"].ToString(),
                                    Title = item["items"]["all"]["title"].ToString(),
                                    Artists = item["items"]["all"]["artistsNames"].Select(a => new Class_Artist { Name = a["name"].ToString() }).ToList(),
                                    Duration = ConvertSecondsToMinutes(int.Parse(item["items"]["all"]["duration"].ToString())),
                                    Thumbnail = item["thumbnail"].ToString()
                                };
                                songs.Add(songIn4);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
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

    }
}
