using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PQTMUSIC_APP
{
    public partial class frm_OffineMode : Form
    {
        private List<string> music_Files;
        private List<string> shuffledMusicFiles;

        private string Current_Song;
        private bool isPause;
        private bool isChanging_Position;
        private bool isShuffle;

        private enum RepeatMode { None, One, All }
        private RepeatMode repeatMode = RepeatMode.None;

        public frm_OffineMode()
        {
            InitializeComponent();

            music_Files = new List<string>();

            isPause = false;
            isShuffle = false;
            isChanging_Position = false;

            datagrid_Playlist.Columns[0].DefaultCellStyle.NullValue = null;
        }

        private void ShuffleMusicFiles()
        {
            var rng = new Random();
            shuffledMusicFiles = new List<string>(music_Files);
            int n = shuffledMusicFiles.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = shuffledMusicFiles[k];
                shuffledMusicFiles[k] = shuffledMusicFiles[n];
                shuffledMusicFiles[n] = value;
            }
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            isShuffle = !isShuffle;
            btn_Shuffle.Image = isShuffle ? Properties.Resources.icons8_shuffle_24 : Properties.Resources.mix__1_;

            if (isShuffle)
            {
                ShuffleMusicFiles();
            }
            else
            {
                shuffledMusicFiles = new List<string>(music_Files);
            }
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            switch (repeatMode)
            {
                case RepeatMode.None:
                    repeatMode = RepeatMode.One;
                    btn_repeat.Image = Properties.Resources.repeat_1_;
                    break;
                case RepeatMode.One:
                    repeatMode = RepeatMode.All;
                    btn_repeat.Image = Properties.Resources.icons8_loop_on;
                    break;
                case RepeatMode.All:
                    repeatMode = RepeatMode.None;
                    btn_repeat.Image = Properties.Resources.repeat;
                    break;
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (datagrid_Playlist.RowCount <= 0) return;

            int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
            if (selectedIndex >= 0 && selectedIndex < music_Files.Count)
            {
                string selectedSong = music_Files[selectedIndex];

                if (selectedSong == Current_Song)
                {
                    // If the selected song is currently playing or paused, toggle between play and pause
                    Pause(sender, e);
                    btn_Play.Image = isPause ? Properties.Resources.play_button_arrowhead__1_ : Properties.Resources.pause;
                }
                else
                {
                    // If another song is selected, play it
                    Current_Song = selectedSong;
                    musicPlayer.URL = Current_Song;
                    musicPlayer.Ctlcontrols.play();
                    btn_Play.Image = Properties.Resources.pause;
                    isPause = false;
                }
            }
            timerPlayBack.Start();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fileNames = openFileDialog1.FileNames;
            var rowsToAdd = new List<DataGridViewRow>();

            foreach (var fileName in fileNames)
            {
                FileInfo fi = new FileInfo(fileName);
                TagLib.File f = TagLib.File.Create(fi.FullName);
                var duration = Math.Round(f.Properties.Duration.TotalMinutes, 2) + " Mins";
                var row = new DataGridViewRow();
                row.CreateCells(datagrid_Playlist, null, fi.Name, f.Tag.JoinedGenres, f.Tag.JoinedAlbumArtists, duration);
                row.Tag = fi;
                rowsToAdd.Add(row);
                music_Files.Add(fi.FullName);
            }

            datagrid_Playlist.Rows.AddRange(rowsToAdd.ToArray());
        }

        private void datagrid_Playlist_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string item in files)
            {
                FileInfo fi = new FileInfo(item);
                TagLib.File f = TagLib.File.Create(fi.FullName);
                var duration = Math.Round(f.Properties.Duration.TotalMinutes, 2) + " Mins";
                var row = new object[]
                {
                        null,
                        fi.Name,
                        f.Tag.JoinedGenres,
                        f.Tag.JoinedAlbumArtists,
                        duration
                };

                int rowIndex = datagrid_Playlist.Rows.Add(row);
                datagrid_Playlist.Rows[rowIndex].Tag = fi;
                music_Files.Add(fi.FullName);
            }
        }

        private void datagrid_Playlist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void datagrid_Playlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_Playlist.RowCount <= 0) return;

            int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
            if (selectedIndex >= 0 && selectedIndex < music_Files.Count)
            {
                Current_Song = music_Files[selectedIndex];
                musicPlayer.URL = Current_Song;
                musicPlayer.Ctlcontrols.play();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (datagrid_Playlist.RowCount > 0)
            {
                int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
                int nextIndex = selectedIndex + 1;

                List<string> currentList = isShuffle ? shuffledMusicFiles : music_Files;

                if (nextIndex < currentList.Count)
                {
                    datagrid_Playlist.CurrentCell = datagrid_Playlist.Rows[nextIndex].Cells[0];
                    datagrid_Playlist.ClearSelection();
                    datagrid_Playlist.Rows[nextIndex].Selected = true;
                    datagrid_Playlist.FirstDisplayedScrollingRowIndex = nextIndex;

                    Current_Song = currentList[nextIndex];
                    musicPlayer.URL = Current_Song;
                    musicPlayer.Ctlcontrols.play();
                    isPause = false;
                }
            }
        }

        private void btn_Rewind_Click(object sender, EventArgs e)
        {
            if (datagrid_Playlist.RowCount <= 0) return;

            int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
            int previousIndex = selectedIndex - 1;

            if (previousIndex >= 0)
            {
                datagrid_Playlist.CurrentCell = datagrid_Playlist.Rows[previousIndex].Cells[0];
                datagrid_Playlist.ClearSelection();
                datagrid_Playlist.Rows[previousIndex].Selected = true;
                datagrid_Playlist.FirstDisplayedScrollingRowIndex = previousIndex;

                Current_Song = music_Files[previousIndex];
                musicPlayer.URL = Current_Song;
                musicPlayer.Ctlcontrols.play();
                isPause = false;
            }
        }

        private void timerPlayBack_Tick(object sender, EventArgs e)
        {
            if (isChanging_Position || musicPlayer == null || musicPlayer.currentMedia == null) return;

            var currentPosition = musicPlayer.Ctlcontrols.currentPosition;
            var duration = musicPlayer.currentMedia.duration;

            lbl_timeStart.Text = FormatTime(currentPosition);
            lbl_timeEnd.Text = FormatTime(duration);

            TrackBar_Play.Value = duration == 0 ? 0 : (int)((currentPosition / duration) * 100);
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Pause(object sender, EventArgs e)
        {
            if (isPause)
            {
                musicPlayer.Ctlcontrols.play();
            }
            else
            {
                musicPlayer.Ctlcontrols.pause();
            }
            isPause = !isPause;
        }

        private string FormatTime(double second)
        {
            return TimeSpan.FromSeconds(second).ToString(@"mm\:ss");
        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) // Media ended
            {
                int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
                int nextIndex = selectedIndex + 1;

                switch (repeatMode)
                {
                    case RepeatMode.One:
                        // Replay the current song
                        musicPlayer.URL = Current_Song;
                        musicPlayer.Ctlcontrols.play();
                        break;
                    case RepeatMode.All:
                        // Play the next song, or the first song if the current song is the last one
                        if (nextIndex >= music_Files.Count)
                        {
                            nextIndex = 0; // Loop back to the first song
                        }
                        PlaySongAtIndex(nextIndex);
                        break;
                    case RepeatMode.None:
                        // Stop the playback if there are no more songs to play
                        if (nextIndex < music_Files.Count)
                        {
                            PlaySongAtIndex(nextIndex);
                        }
                        else
                        {
                            musicPlayer.Ctlcontrols.stop();
                            isPause = false;
                        }
                        break;
                }
            }
        }

        private void PlaySongAtIndex(int index)
        {
            datagrid_Playlist.CurrentCell = datagrid_Playlist.Rows[index].Cells[0];
            datagrid_Playlist.ClearSelection();
            datagrid_Playlist.Rows[index].Selected = true;
            datagrid_Playlist.FirstDisplayedScrollingRowIndex = index;

            Current_Song = music_Files[index];
            musicPlayer.URL = Current_Song;
            musicPlayer.Ctlcontrols.play();
            isPause = false;
        }

        private void TrackBar_Volumn_Scroll(object sender, ScrollEventArgs e)
        {
            musicPlayer.settings.volume = TrackBar_Volumn.Value;
        }

        private void TrackBar_Play_Scroll(object sender, ScrollEventArgs e)
        {
            int trackbarValue = TrackBar_Play.Value;

            if (musicPlayer != null && musicPlayer.currentMedia != null)
            {
                double newPosition = (musicPlayer.currentMedia.duration / 100) * trackbarValue;
                musicPlayer.Ctlcontrols.currentPosition = newPosition;
            }
        }
    }
}
