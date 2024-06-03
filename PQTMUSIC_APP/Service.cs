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

                    // Filter the items where sectionType matches the given sectionType
                   

                    List<Class_SongFullData> songs = new List<Class_SongFullData>();

                    foreach (var item in itemsArray)
                    {
                        Class_SongFullData songIn4 = new Class_SongFullData
                        {
                            EncodeId = item["encodeId"]?.ToString(),
                            Title = item["title"]?.ToString(),
                            Artists = item["artists"]?.Select(a => new Class_Artist { Name = a["name"]?.ToString() }).ToList(),
                            Duration = ConvertSecondsToMinutes(int.Parse(item["duration"]?.ToString() ?? "0")),
                            Thumbnail = item["thumbnail"]?.ToString()
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
        
    

    }
}
