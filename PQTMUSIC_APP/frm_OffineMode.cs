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

namespace PQTMUSIC_APP
{
    public partial class frm_OffineMode : Form
    {
        private List<string> songs = new List<string>(); // Danh sách đường dẫn đến tệp tin bài hát
        //private DataGridView<string> music_file;
        //private string Curren_Song;
        //private bool isPause;
        //private bool isChanging_Position;
        private int currentIndex = 0;
        private int volume = 50;

        public frm_OffineMode()
        {
            InitializeComponent();
            datagrid_Playlist.Columns[0].DefaultCellStyle.NullValue = null;
            musicPlayer.settings.volume = volume;
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) // Click vào cột đường dẫn tệp tin
            {
                string songPath = datagrid_Playlist.Rows[e.RowIndex].Cells[1].Value.ToString();
                currentIndex = e.RowIndex;

                PlaySong();
            }
        }

        private void PlaySong()
        {
            if (currentIndex >= songs.Count)
            {
                currentIndex = 0;
            }

            string songPath = songs[currentIndex];
            musicPlayer.URL = songPath;
            musicPlayer.Ctlcontrols.play();

            //UpdateButtonStates();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= songs.Count)
            {
                currentIndex = 0;
            }

            PlaySong();
        }

        private void btn_Rewind_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = songs.Count - 1;
            }

            PlaySong();
        }

        private void frm_OffineMode_Load(object sender, EventArgs e)
        {
            datagrid_Playlist.AllowDrop = true;
            datagrid_Playlist.DragEnter += new DragEventHandler(datagrid_Playlist_DragEnter);
            datagrid_Playlist.DragDrop += new DragEventHandler(datagrid_Playlist_DragDrop);
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
        //private void UpdateButtonStates()
        //{
        //    btn_Play.Enabled = !musicPlayer.Playing;
        //    btn_Pause.Enabled = musicPlayer.Playing;

        //    btn_Next.Enabled = songs.Count > 1;
        //    btn_Rewind.Enabled = songs.Count > 1;
        //}

    }
}
