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
using NAudio.Wave;
using NAudio.WaveFormRenderer;
using TagLib.Mpeg;
using NAudio;
using TagLib.Riff;

namespace PQTMUSIC_APP
{
    public partial class frm_Offline : Form
    {
        private IWavePlayer wavePlayer = new WaveOutEvent();
        private AudioFileReader audioFileReader ;
        private FileInfo file = null;

        public frm_Offline()
        {
            InitializeComponent();

            datagrid_Playlist.Columns[0].DefaultCellStyle.NullValue = null;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void guna2DataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
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

        private void datagrid_Playlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            file = ((FileInfo)datagrid_Playlist.Rows[e.RowIndex].Tag);
            Play();
        }

        private void Play()
        {
            Application.UseWaitCursor = true;
            Application.DoEvents();
            if(file == null ) return;
            audioFileReader = new AudioFileReader(file.FullName);
            if (wavePlayer.PlaybackState != PlaybackState.Stopped)
            {
                wavePlayer.Stop();
            }
            wavePlayer.Init(audioFileReader);
            GenarateWV();
            wavePlayer.Play();
            pic_Player.Enabled = true;
            Application.UseWaitCursor = false;
        }

        private void GenarateWV()
        {
            var my_RendererSettings = new StandardWaveFormRendererSettings();
            my_RendererSettings.Width = panel_WaveSong.Width;
            my_RendererSettings.TopHeight = panel_WaveSong.Height/2;
            my_RendererSettings.BottomHeight = panel_WaveSong.Height/2;
            my_RendererSettings.TopPeakPen = new Pen(Color.FromArgb(255, 109, 0));
            my_RendererSettings.BottomPeakPen = new Pen(Color.FromArgb(255, 221, 186));
            my_RendererSettings.BackgroundColor = this.BackColor;

            var my_RendererSettings2 = new StandardWaveFormRendererSettings();
            my_RendererSettings2.Width = panel_WaveSong.Width;
            my_RendererSettings2.TopHeight = panel_WaveSong.Height / 2;
            my_RendererSettings2.BottomHeight = panel_WaveSong.Height / 2;
            my_RendererSettings2.TopPeakPen = new Pen(Color.FromArgb(255, 109, 0));
            my_RendererSettings2.BottomPeakPen = new Pen(Color.FromArgb(255, 221, 186));
            my_RendererSettings2.BackgroundColor = this.BackColor;

            var renderer = new WaveFormRenderer();
            var audioFilePath = file.FullName;

            // Mở tệp âm thanh và tạo đối tượng WaveStream
            using (WaveFileReader wave_Reader = new WaveFileReader(audioFilePath))
            {
                
                panel_WaveSong.BackgroundImage = renderer.Render(wave_Reader, new AveragePeakProvider(3), my_RendererSettings);
                pic_Wv.BackgroundImage = renderer.Render(wave_Reader, new AveragePeakProvider(3), my_RendererSettings2);
            }
        }

        private void btn_img_Play_Click(object sender, EventArgs e)
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

        private void panel_WaveSong_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                pic_Wv.Width = e.X;
                var max = audioFileReader.Length;

                var val = (e.X * max) / panel_WaveSong.Width;
                audioFileReader.Position = val;
            }
            catch 
            {
                    
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(wavePlayer.PlaybackState == PlaybackState.Playing) 
            {
                lbl_Song.Text = file.Name;
                pic_Player.Enabled = true;
                SetSlider();

                if(!lbl_Artist.Text.Contains("🎵"))
                {
                    lbl_Artist.Text = "Now Playing 🎵🎵🎵";
                }
                else if(lbl_Artist.Text.Contains("🎵🎵🎵")) 
                {
                    lbl_Artist.Text = "Now Playing 🎵🎵";
                }
                else if (lbl_Artist.Text.Contains("🎵🎵"))
                {
                    lbl_Artist.Text = "Now Playing 🎵";
                }
                else
                { lbl_Artist.Text = "Now Playing"; }
            }
            else
            {
                lbl_Song.Text = "Name song";
                pic_Player.Enabled = false;
                lbl_Artist.Text = wavePlayer.PlaybackState.ToString();
            }
        }

        private void SetSlider()
        {
            double max = audioFileReader.Length;
            double cur = audioFileReader.Position;

            var val = cur * panel_WaveSong.Width / max;
            pic_Wv.Width = int.Parse(Math.Truncate(val).ToString());
        }

        private void btn_img_Play_Pause_Click(object sender, EventArgs e)
        {
            try
            {
                if (wavePlayer.PlaybackState == PlaybackState.Playing)
                {
                    wavePlayer.Pause();
                    btn_img_Play_Pause.Image = iconPlay.Image;
                }
                else
                {
                    wavePlayer.Play();
                    btn_img_Play_Pause.Image = iconPause.Image;
                }
            }
            catch (Exception)
            {
                goto a;
            a:
                if (datagrid_Playlist.RowCount == 0)
                {
                    openFileDialog1.ShowDialog();
                    if (datagrid_Playlist.RowCount > 0) goto a;
                }
                else
                {
                    file = ((FileInfo)datagrid_Playlist.CurrentRow.Tag);
                    Play();
                }
            }

            //try
            //{
            //    if (wavePlayer.PlaybackState == PlaybackState.Playing)
            //    {
            //        wavePlayer.Pause();
            //        btn_img_Play_Pause.Image = iconPlay.Image;
            //    }
            //    else
            //    {
            //        if (datagrid_Playlist.RowCount == 0)
            //        {
            //            openFileDialog1.ShowDialog();
            //            if (datagrid_Playlist.RowCount == 0)
            //            {
            //                MessageBox.Show("Không tìm thấy tệp âm thanh nào trong danh sách phát. Vui lòng thêm một số tệp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //        }

            //        file = ((FileInfo)datagrid_Playlist.CurrentRow.Tag);

            //        try
            //        {
            //            audioFileReader = new AudioFileReader(file.FullName);
            //            wavePlayer.Init(audioFileReader);
            //            wavePlayer.Play();
            //            btn_img_Play_Pause.Image = iconPause.Image;
            //            GenarateWV();
            //        }
            //        catch (Exception ex)
            //        {
            //            if (ex.Message.Contains("no RIFF header"))
            //            {
            //                MessageBox.Show("Tệp đã chọn không phải là tệp âm thanh WAV hợp lệ. Vui lòng chọn tệp WAV.", "Định dạng âm thanh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Đã xảy ra lỗi khi phát tệp âm thanh: " + ex.Message, "Lỗi phát lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    // Xử lý các ngoại lệ tiềm ẩn khác ở đây
            //}
        }
    }
}
