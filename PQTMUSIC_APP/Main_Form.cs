using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AngleSharp.Io;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Linq;

namespace PQTMUSIC_APP
{
    public partial class Main_Form : Form
    {
        public string currentUser;
        public bool isPlaying;
        public bool isPaused;
        private IWavePlayer WaveOutDevice;
        private WaveStream audioStream;
        public Class_SongFullData songCurrentPlay;
        private List<Class_SongFullData> songList;
        private int currentSongIndex;
        public static int lastSongIndex;
        private bool isShuffle = false;
        private bool isLoop = false;
        private bool isMute = false;

        
        private Frm_Ranking rankingForm;
        private frm_Explore explore=new frm_Explore();
        private SearchResult result = new SearchResult();
        private frm_Fav fave = new frm_Fav();
        private Form_Artist artist = new Form_Artist();
        public Main_Form(string currentUser)
        {
            InitializeComponent();
            explore = new frm_Explore();
            addForm_Child(explore);
            this.currentUser = currentUser;
            Frm_LgSU.client = new FireSharp.FirebaseClient(Frm_LgSU.config);

            explore.SongSelected += HandleSongSelected;
           
            result.SongSelected += HandleSongSelected;
            result.ArtistSelected += HandleArtistSelected;
            result.PlaylistSelected += (sender, playlist) => { ReceivePlaylist(playlist); };

            fave.SongSelected += HandleSongSelected;
            fave.PlaylistSelected += (sender, playlist) => { ReceivePlaylist(playlist); };

            rankingForm = new Frm_Ranking();
            rankingForm.SongSelected += HandleSongSelected;
            rankingForm.PlaylistSelected += (sender, playlist) => { ReceivePlaylist(playlist); };
            trackBar_Volume.Minimum = 0;
            trackBar_Volume.Maximum = 100;
            trackBar_Volume.Value = 50;

            songList = new List<Class_SongFullData>();
            currentSongIndex = -1;
            lastSongIndex= -1;
        }

        private void addForm_Child(Form frm_child)
        {
            frm_child.Dock = DockStyle.Fill;
            frm_child.TopLevel = false;
            panel_Child.Controls.Clear();
            panel_Child.Controls.Add(frm_child);
            frm_child.Show();
        }

        public void ReceivePlaylist(List<Class_SongFullData> playlist)
        {
            songList.Clear();
            songList = playlist;
        }

        public async void HandleSongSelected(object sender, Class_SongFullData e)
        {
            songCurrentPlay = e;
            currentSongIndex = songList.IndexOf(songCurrentPlay);
            PlayNewSong(songCurrentPlay.StreamUrls);
            pic_currently_Playing_MainForm.Image = await LoadImage(songCurrentPlay.Thumbnail);
            lbl_Artist_Playing_MainFrom.Text = songCurrentPlay.Artists[0].Name;
            lb_TittleCurrentSong.Text = songCurrentPlay.Title;
            lb_endTime.Text = songCurrentPlay.Duration;

            // Load the current favorite songs list from Firebase
            FirebaseResponse response = await Frm_LgSU.client.GetAsync("Users/" + currentUserdata.username + "/favSongID");
            List<string> favSongIDs = response.ResultAs<List<string>>() ?? new List<string>();

            // Check if the current song ID is in the favorite list
            bool isSongLiked = favSongIDs.Contains(songCurrentPlay.EncodeId);

            // Update the liked status of the current song and the button image
            songCurrentPlay.IsLiked = isSongLiked;
            btn_AddToFav.Image = isSongLiked ? Properties.Resources.heart_color : Properties.Resources.heart;

            trackBar_Play.Maximum = (int)audioStream.TotalTime.TotalSeconds;
            trackBar_Play.Value = 0;
        }

        public void HandleArtistSelected(object sender, Class_Artist artist)
        {
            Form_Artist artistForm = new Form_Artist();
            addForm_Child(artistForm);
        }


        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            if (WaveOutDevice == null)
            {
                MessageBox.Show("No song is currently loaded.");
                return;
            }

            if (isPlaying)
            {
                if (isPaused)
                {
                    btn_PlayPause.Image = Properties.Resources.pause;
                    WaveOutDevice.Play();
                    isPaused = false;
                }
                else
                {
                    btn_PlayPause.Image = Properties.Resources.play_button_arrowhead__1_;
                    WaveOutDevice.Pause();
                    isPaused = true;
                }
            }
        }

        private void PlayAudio(string audioUrl)
        {
            audioStream?.Dispose();
            audioStream = new MediaFoundationReader(audioUrl);

            WaveOutDevice?.Stop();
            WaveOutDevice?.Dispose();

            WaveOutDevice = new WaveOut();
            WaveOutDevice.PlaybackStopped += OnPlaybackStopped;

            WaveOutDevice.Init(audioStream);
            WaveOutDevice.Play();
            isPlaying = true;
            isPaused = false;

            trackBar_Play.Maximum = (int)audioStream.TotalTime.TotalSeconds;
            trackBar_Play.Value = 0;

            var timer = new Timer { Interval = 1000 };
            timer.Tick += (s, args) =>
            {
                if (audioStream != null && !isPaused)
                {
                    trackBar_Play.Value = (int)audioStream.CurrentTime.TotalSeconds;
                }
            };
            timer.Start();
            timer.Disposed += (s, args) => timer.Stop();
        }

        private void PlayNewSong(string audioUrl)
        {
            if (WaveOutDevice != null)
            {
                WaveOutDevice.Stop();
            }

            PlayAudio(audioUrl);
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show($"Playback Error: {e.Exception.Message}");
            }
            else
            {
                isPlaying = false;
                isPaused = false;
                if (!isPaused)
                {
                    PlayNextSong();
                }
            }
        }

        private void PlayNextSong()
        {
            lastSongIndex = currentSongIndex;
            if (isShuffle)
            {
                Random rnd = new Random();
                currentSongIndex = rnd.Next(songList.Count);
            }
            else
            {
                currentSongIndex++;
                if (currentSongIndex >= songList.Count)
                {
                    currentSongIndex = 0;
                }
            }

            if (songList.Count > 0)
            {
                HandleSongSelected(this, songList[currentSongIndex]);
            }
        }

        private void PlayPreviousSong()
        {
            
            if (currentSongIndex < 0)
            {
                currentSongIndex = songList.Count - 1;
            }

            if (songList.Count > 0)
            {
                HandleSongSelected(this, songList[lastSongIndex]);
            }
        }

        private void btn_PreSong_Click(object sender, EventArgs e)
        {
            PlayPreviousSong();
        }

        private void btn_NextSong_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void btn_playShuffle_Click(object sender, EventArgs e)
        {
            isShuffle = !isShuffle;
            btn_playShuffle.Image = isShuffle ? Properties.Resources.icons8_shuffle_24 : Properties.Resources.mix__1_;
        }

        private void btn_loopCurrentSong_Click(object sender, EventArgs e)
        {
            isLoop = !isLoop;
            if (isLoop)
            {
                btn_loopCurrentSong.Image = Properties.Resources.icons8_loop_on;
                WaveOutDevice.PlaybackStopped -= OnPlaybackStopped;
                WaveOutDevice.PlaybackStopped += (s, args) =>
                {
                    if (!isPaused)
                    {
                        PlayAudio(songCurrentPlay.StreamUrls);
                    }
                };
            }
            else
            {
                btn_loopCurrentSong.Image = Properties.Resources.icons8_repeat_30;
                WaveOutDevice.PlaybackStopped -= OnPlaybackStopped;
            }
        }

        private void pic_User_Click(object sender, EventArgs e)
        {
            ShowIn4 showINFO = new ShowIn4(currentUser);
            showINFO.Show();
        }

        private void btn_Genres_Click(object sender, EventArgs e)
        {
            SearchResult showGenres = new SearchResult();
            addForm_Child(showGenres);
        }

        private void btn_Albums_Click(object sender, EventArgs e)
        {
            frm_Album showAlbum = new frm_Album();
            addForm_Child(showAlbum);
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            addForm_Child(fave);
        }

        private void btn_Offline_Click(object sender, EventArgs e)
        {
            frm_OffineMode Offline = new frm_OffineMode();
            addForm_Child(Offline);
        }

        private void btn_Explore_Click(object sender, EventArgs e)
        {
            addForm_Child(explore);
        }

        private void btn_Ranks_Click(object sender, EventArgs e)
        {
            addForm_Child(rankingForm);
        }

        private void btn_Artists_Click(object sender, EventArgs e)
        {
           addForm_Child(artist);
        }

        private async Task<Image> LoadImage(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Throw if not a success code.
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                return null;
            }
        }

        private void TrackBar_Play_Scroll(object sender, EventArgs e)
        {
            if (audioStream != null)
            {
                audioStream.CurrentTime = TimeSpan.FromSeconds(trackBar_Play.Value);
            }
        }

        private void trackBar_Volume_Scroll(object sender, EventArgs e)
        {
            if (!isMute && WaveOutDevice != null)
            {
                WaveOutDevice.Volume = trackBar_Volume.Value / 100f;
            }
        }



        public static string query; 
        private  void txt_Search_TextChanged(object sender, EventArgs e)
        {
             query = txt_Search.Text;
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                
                addForm_Child(result);
            }
        }
        public static UserData currentUserdata = new UserData { username = Frm_LgSU.currentUser };
            
        private async void btn_AddToFav_Click(object sender, EventArgs e)
        {
            
            // Check if songCurrentPlay is null
            if (songCurrentPlay == null) return;

            // Load the current favorite songs list from Firebase
            FirebaseResponse response = await Frm_LgSU.client.GetAsync("Users/" + currentUserdata.username + "/favSongID");
            List<string> favSongIDs = response.ResultAs<List<string>>() ?? new List<string>();

            // Check if the current song ID is in the favorite list
            bool isSongLiked = favSongIDs.Contains(songCurrentPlay.EncodeId);

            if (isSongLiked)
            {
                // Remove the current song ID from the favorite list
                favSongIDs.Remove(songCurrentPlay.EncodeId);
                btn_AddToFav.Image = Properties.Resources.heart;
                
            }
            else
            {
                // Add the current song ID to the favorite list
                favSongIDs.Add(songCurrentPlay.EncodeId);
                btn_AddToFav.Image = Properties.Resources.heart_color;
                
            }

            // Update the favorite songs list in the user data and save it back to Firebase
            currentUserdata.favSongID = favSongIDs;
            FirebaseResponse updateResponse = await Frm_LgSU.client.SetAsync("Users/" + currentUserdata.username + "/favSongID", favSongIDs);

            // Check the response from Firebase to determine if the update was successful
            if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Optionally reload the favorite songs list in the UI
                fave.frm_Fav_Load(this, EventArgs.Empty);
            }
            else
            {
                // Update failed, you can show an error message or log the error
                MessageBox.Show("Failed to update favorite songs list in Firebase.");
            }
        }



        private void btn_volumn_mute_Click(object sender, EventArgs e)
        {
            isMute = !isMute;
            if (isMute)
            {
                WaveOutDevice.Volume = 0;
                trackBar_Volume.Value = 0;
                btn_volumn_mute.Image = Properties.Resources.mute__1_;
            }
            else
            {
                trackBar_Volume.Value = 50;
                WaveOutDevice.Volume = trackBar_Volume.Value / 100f;
                btn_volumn_mute.Image = Properties.Resources.volume;
            }
        }

        
    }
}
