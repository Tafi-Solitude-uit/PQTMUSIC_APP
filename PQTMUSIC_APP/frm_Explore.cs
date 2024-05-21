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
using System.IO;
using System.Net;
using NAudio.Wave;
using SpotifyAPI.Web;


namespace PQTMUSIC_APP
{
    public partial class frm_Explore : Form
    {
        private const string clientId = "65252f95054a4037be2b62a238222bd9";
        private const string clientSecret = "40a851303a474018a57b7f09284e72f8";
        private SpotifyClient spotify;
        private IWavePlayer waveOutDevice;
        private MediaFoundationReader mediaReader;

        public frm_Explore()
        {
            InitializeComponent();
        }

        private async Task GetAccessToken()
        {
            var config = SpotifyClientConfig.CreateDefault();
            var request = new ClientCredentialsRequest(clientId, clientSecret);
            var response = await new OAuthClient(config).RequestToken(request);

            spotify = new SpotifyClient(config.WithToken(response.AccessToken));
        }

        private async void frm_Explore_Load(object sender, EventArgs e)
        {
            await GetAccessToken();
            await DisplayNewReleases();
            listSong.ItemActivate += ListSong_ItemActivate;
        }

        private void ListSong_ItemActivate(object sender, EventArgs e)
        {
            var item = listSong.SelectedItems[0].SubItems[1].Text;
            playTrack(item);
        }

        private void playTrack(string trackUrl)
        {
            waveOutDevice = new WaveOut();
            mediaReader = new MediaFoundationReader(trackUrl);

            waveOutDevice.Init(mediaReader);
            waveOutDevice.Play();
        }

        private async Task DisplayNewReleases()
        {
            var response = await spotify.Browse.GetNewReleases(new NewReleasesRequest());

            listSong.Items.Clear();
            listSong.View = View.Details;
            listSong.Columns.Add("Image", -2, HorizontalAlignment.Left);
            listSong.Columns.Add("Track Name", -2, HorizontalAlignment.Left);
            listSong.Columns.Add("Artist", -2, HorizontalAlignment.Left);

            ImageList imageList = new ImageList();
            int imageIndex = 0;

            foreach (var album in response.Albums.Items)
            {
                var track = album.Name;

                var imageUrl = album.Images.FirstOrDefault()?.Url;

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    using (var webClient = new WebClient())
                    {
                        byte[] imageBytes = await webClient.DownloadDataTaskAsync(imageUrl);

                        using (var ms = new MemoryStream(imageBytes))
                        {
                            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                            imageList.Images.Add(image);
                        }
                    }
                }

                var item = new ListViewItem(new[] { "", track, });
                item.ImageIndex = imageIndex++;
                listSong.Items.Add(item);
            }

            listSong.SmallImageList = imageList;
        }
    }
}
