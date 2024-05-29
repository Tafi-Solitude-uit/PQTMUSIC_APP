using CSCore.Codecs.MP3;
using CSCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CSCore.SoundOut;
using System.IO;
using System.Media;
using NAudio.Wave;


namespace PQTMUSIC_APP
{
    internal class InteractITEM
    {



        public void PlaySong(string url)
        {
            using (var httpClient = new HttpClient())
            {
                byte[] audioData = httpClient.GetByteArrayAsync(url).Result;

                using (var memoryStream = new MemoryStream(audioData))
                {
                    using (var audioFileReader = new AudioFileReader(memoryStream.ToString()))
                    {
                        using (var waveOutDevice = new WaveOutEvent())
                        {
                            waveOutDevice.Init(audioFileReader);
                            waveOutDevice.Play();


                        }
                    }
                }
            }
        }

    }
}
