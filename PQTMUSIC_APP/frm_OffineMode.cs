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
        private List<string> music_Files; // Danh sách đường dẫn đến tệp tin bài hát
        
        private string Current_Song;    
        private bool isPause;
        private bool isChanging_Position;
        
        public frm_OffineMode()
        {
            InitializeComponent();
            music_Files = new List<string>();
            isPause = false;
            isChanging_Position = false;

            datagrid_Playlist.Columns[0].DefaultCellStyle.NullValue = null;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                musicPlayer.Ctlcontrols.play();
                isPause = false;
            }
            else
            {
                int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
                if (selectedIndex >= 0 && selectedIndex < music_Files.Count)
                {
                    Current_Song = music_Files[selectedIndex];
                    musicPlayer.URL = Current_Song;
                    musicPlayer.Ctlcontrols.play();
                }
            }

            timerPlayBack.Enabled = true;
        }

        private void frm_OffineMode_Load(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var item in openFileDialog1.FileNames)
            {
                FileInfo fi = new FileInfo(item);
                TagLib.File f = TagLib.File.Create(fi.FullName);
                var r = datagrid_Playlist.Rows.Add(new object[]
                {
                    null,
                    fi.Name,
                    f.Tag.JoinedGenres,
                    f.Tag.JoinedAlbumArtists,
                    Math.Round(f.Properties.Duration.TotalMinutes, 2) + " Mins"
                });

                datagrid_Playlist.Rows[r].Tag = fi;
            }
        }
        private void datagrid_Playlist_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string item in files)
            {
                FileInfo fi = new FileInfo(item);
                TagLib.File f = TagLib.File.Create(fi.FullName);
                var r = datagrid_Playlist.Rows.Add(new object[]
                {
                    null,
                    fi.Name,
                    f.Tag.JoinedGenres,
                    f.Tag.JoinedAlbumArtists,
                    Math.Round(f.Properties.Duration.TotalMinutes, 2) + " Mins"
                });

                datagrid_Playlist.Rows[r].Tag = fi;
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
            DataGridViewRow selectedRow = datagrid_Playlist.SelectedRows[0]; // Lấy hàng được chọn
            int selectedIndex = selectedRow.Index;
            if (selectedIndex >= 0 && selectedIndex < music_Files.Count)
            {
                Current_Song = music_Files[selectedIndex];
                musicPlayer.URL = Current_Song;
                musicPlayer.Ctlcontrols.play();
                isPause = false;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Rewind_Click(object sender, EventArgs e)
        {
            
        }

        private void timerPlayBack_Tick(object sender, EventArgs e)
        {
            if (!isChanging_Position && musicPlayer != null && musicPlayer.currentMedia != null)
            {
                lbl_timeStart.Text = FormatTime(musicPlayer.Ctlcontrols.currentPosition);
                lbl_timeEnd.Text = FormatTime(musicPlayer.currentMedia.duration);
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if(isPause == false)
            {
                musicPlayer.Ctlcontrols.pause();
                isPause = true;
            }
            else
            {
                musicPlayer.Ctlcontrols.play();
                isPause = false;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
            isPause = false;
            timerPlayBack.Enabled = false;
        }

        private string FormatTime(double second)
        {
            TimeSpan time = TimeSpan.FromSeconds(second);
            return time.ToString(@"mm\:ss");
        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) // MediaEnded
            {
                int nextIndex = datagrid_Playlist.CurrentCell.RowIndex + 1;
                if (nextIndex < music_Files.Count)
                {
                    datagrid_Playlist.ClearSelection();
                    datagrid_Playlist.Rows[nextIndex].Selected = true;
                    datagrid_Playlist.FirstDisplayedScrollingRowIndex = nextIndex;
                    Current_Song = music_Files[nextIndex];
                    musicPlayer.URL = Current_Song;
                    musicPlayer.Ctlcontrols.play();
                    isPause = false;
                }
                else
                {
                    musicPlayer.Ctlcontrols.stop();
                    isPause = false;
                }
            }
        }

        private void TrackBar_Volumn_Scroll(object sender, ScrollEventArgs e)
        {
            musicPlayer.settings.volume = TrackBar_Volumn.Value;
        }
    }
}
