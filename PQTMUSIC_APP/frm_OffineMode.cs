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
        private bool isChanging_Position; //Kiểm tra xem có đang thay đổi vị trí phát nhạc không
        private bool isplaying; //Kiểm tra xem có đang phát nhạc không  

        public frm_OffineMode()
        {
            InitializeComponent();

            music_Files = new List<string>();
            isPause = false;
            isplaying = false;  
            isChanging_Position = false;

            datagrid_Playlist.Columns[0].DefaultCellStyle.NullValue = null; // Đặt hình ảnh mặc định cho cột hình ảnh
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            //sự kiện khi click vào nút phát
            if (datagrid_Playlist.RowCount > 0)
            {
                if (isPause) // Nếu đang dừng thì phát
                {
                    musicPlayer.Ctlcontrols.play();
                    isPause = false;
                }
                int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
                if (selectedIndex >= 0 && selectedIndex < music_Files.Count)
                {
                    // If a song is playing, pause it
                    if (isplaying)
                    {
                        musicPlayer.Ctlcontrols.pause();
                        isplaying = false;
                    }
                    // If no song is playing, play the selected song
                    else
                    {
                        Current_Song = music_Files[selectedIndex];
                        musicPlayer.URL = Current_Song;
                        musicPlayer.Ctlcontrols.play();
                        isplaying = true;
                    }
                }
                // Start the playback timer
                timerPlayBack.Start();
            }
        }
        private void frm_OffineMode_Load(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Khi chọn file xong
            var fileNames = openFileDialog1.FileNames;
            var rowsToAdd = new List<DataGridViewRow>(); // Danh sách các dòng để thêm vào datagrid

            foreach (var fileName in fileNames)
            {
                // Lấy thông tin file
                FileInfo fi = new FileInfo(fileName);
                TagLib.File f = TagLib.File.Create(fi.FullName);
                var duration = Math.Round(f.Properties.Duration.TotalMinutes, 2) + " Mins";
                var row = new DataGridViewRow();
                row.CreateCells(datagrid_Playlist, null, fi.Name, f.Tag.JoinedGenres, f.Tag.JoinedAlbumArtists, duration); // Tạo dòng mới
                row.Tag = fi;
                rowsToAdd.Add(row); // Thêm vào danh sách dòng
                music_Files.Add(fi.FullName); // Thêm vào danh sách bài hát
            }

            datagrid_Playlist.Rows.AddRange(rowsToAdd.ToArray()); // Thêm các dòng vào datagrid
        }
        private void datagrid_Playlist_DragDrop(object sender, DragEventArgs e)
        {
            // Khi kéo thả file vào datagrid
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string item in files)
            {
                // Lấy thông tin file
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

                // Thêm vào datagrid
                int rowIndex = datagrid_Playlist.Rows.Add(row);
                datagrid_Playlist.Rows[rowIndex].Tag = fi;
                music_Files.Add(fi.FullName);
            }
        }

        private void datagrid_Playlist_DragEnter(object sender, DragEventArgs e)
        {
            // Khi kéo thả file vào datagrid
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void datagrid_Playlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //sự kiện khi click vào 1 bài hát trong playlist
            if (datagrid_Playlist.RowCount > 0)
            {
                // Nếu đang phát thì dừng
                int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
                if (selectedIndex >= 0 && selectedIndex < music_Files.Count)
                {
                    // Chuyển đến bài hát được chọn
                    Current_Song = music_Files[selectedIndex];
                    musicPlayer.URL = Current_Song;
                    musicPlayer.Ctlcontrols.play();
                }
            }
        }

            private void btn_Next_Click(object sender, EventArgs e)
        {
            //sự kiện khi click vào nút tiếp theo
            if (datagrid_Playlist.RowCount > 0)
            {
                int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
                int nextIndex = selectedIndex + 1;

                // Nếu bài hát tiếp theo tồn tại
                if (nextIndex < music_Files.Count)
                {
                    datagrid_Playlist.CurrentCell = datagrid_Playlist.Rows[nextIndex].Cells[0];
                    datagrid_Playlist.ClearSelection();
                    datagrid_Playlist.Rows[nextIndex].Selected = true;
                    datagrid_Playlist.FirstDisplayedScrollingRowIndex = nextIndex;

                    // Chuyển đến bài hát tiếp theo
                    Current_Song = music_Files[nextIndex];
                    musicPlayer.URL = Current_Song;
                    musicPlayer.Ctlcontrols.play();
                    isPause = false;
                }
            }
        }

        private void btn_Rewind_Click(object sender, EventArgs e)
        {
            //sự kiện khi click vào nút quay lại
            if (datagrid_Playlist.RowCount > 0)
            {
                int selectedIndex = datagrid_Playlist.CurrentCell.RowIndex;
                int previousIndex = selectedIndex - 1;

                // Nếu bài hát trước đó tồn tại
                if (previousIndex >= 0)
                {
                    datagrid_Playlist.CurrentCell = datagrid_Playlist.Rows[previousIndex].Cells[0];
                    datagrid_Playlist.ClearSelection();
                    datagrid_Playlist.Rows[previousIndex].Selected = true;
                    datagrid_Playlist.FirstDisplayedScrollingRowIndex = previousIndex;

                    // Chuyển đến bài hát trước đó
                    Current_Song = music_Files[previousIndex];
                    musicPlayer.URL = Current_Song;
                    musicPlayer.Ctlcontrols.play();
                    isPause = false;
                }
            }
        }

        private void timerPlayBack_Tick(object sender, EventArgs e)
        {
            // Nếu đang thay đổi vị trí phát nhạc thì không cập nhật thời gian
            if (!isChanging_Position && musicPlayer != null && musicPlayer.currentMedia != null)
            {
                // Lấy thời gian hiện tại và tổng thời gian của bài hát
                var currentPosition = musicPlayer.Ctlcontrols.currentPosition;
                var duration = musicPlayer.currentMedia.duration;

                lbl_timeStart.Text = FormatTime(currentPosition);
                lbl_timeEnd.Text = FormatTime(duration);

                // Update the trackbar's value
                if (duration != 0)
                {
                    TrackBar_Play.Value = (int)((currentPosition / duration) * 100);
                }
                else
                {
                    TrackBar_Play.Value = 0;
                }
            }
            
    }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            // Mở cửa sổ chọn file
            openFileDialog1.ShowDialog();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            // Nếu đang phát thì dừng, nếu đang dừng thì phát
            if (isPause)
            {
                musicPlayer.Ctlcontrols.play();
            }
            // Nếu đang phát thì dừng
            else
            {
                musicPlayer.Ctlcontrols.pause();
            }
            // Đảo trạng thái phát/dừng
            isPause = !isPause;
        }


        private string FormatTime(double second)
        {
            // Chuyển giây sang dạng mm:ss
            return TimeSpan.FromSeconds(second).ToString(@"mm\:ss");
        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Nếu bài hát kết thúc
            if (e.newState == 8) // MediaEnded
            {
                // Chuyển bài hát tiếp theo
                int nextIndex = datagrid_Playlist.CurrentCell.RowIndex + 1;
                if (nextIndex < music_Files.Count)
                {
                    // Chuyển đến bài hát tiếp theo
                    datagrid_Playlist.CurrentCell = datagrid_Playlist.Rows[nextIndex].Cells[0];

                    // Chọn bài hát tiếp theo
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
                    // Dừng phát
                    musicPlayer.Ctlcontrols.stop();
                    isPause = false;
                }
            }
        }

        private void TrackBar_Volumn_Scroll(object sender, ScrollEventArgs e)
        {
            // Đặt âm lượng phát nhạc
            musicPlayer.settings.volume = TrackBar_Volumn.Value;
        }

        private void TrackBar_Play_Scroll(object sender, ScrollEventArgs e)
        {
            // Đang thay đổi vị trí phát nhạc
            int trackbarValue = TrackBar_Play.Value;

            // Kiểm tra xem musicPlayer và currentMedia có null hay không
            if (musicPlayer != null && musicPlayer.currentMedia != null)
            {
                // Tính vị trí mới của bài hát dựa vào giá trị của trackbar
                double newPosition = (musicPlayer.currentMedia.duration / 100) * trackbarValue;

                // currentPosition là vị trí hiện tại của bài hát sau khi thay đổi
                musicPlayer.Ctlcontrols.currentPosition = newPosition;
            }
        }
    }
}
