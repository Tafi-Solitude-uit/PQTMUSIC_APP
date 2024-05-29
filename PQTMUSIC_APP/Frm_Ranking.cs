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
using System.Media;
using NAudio.Wave;
using System.Security.Policy;
namespace PQTMUSIC_APP
{
    public partial class Frm_Ranking : Form
    {
        public Frm_Ranking()
        {
            InitializeComponent();
        }
        string apiUrl = "https://apimusic.bug.edu.vn/nhaccuatui/getTop100";
        string songDetailsApiUrl = "https://apimusic.bug.edu.vn/nhaccuatui/getSong";

        string songID;
        private Image ResizeImage(Image image, Size size)
        {
            return (Image)(new Bitmap(image, size));
        }
        private async void Frm_Ranking_Load(object sender, EventArgs e)
        {

            SongService songs = new SongService();
            AddDataToDataGridView(await songs.GetSongToDisplayFromApi(apiUrl));

        }
        private void AddDataToDataGridView(List<Class_SongFullData> songs)
        {

            foreach (var song in songs)
            {
                Image thumbnail = song.Thumbnail;
                thumbnail = ResizeImage(thumbnail, new Size(70, 70)); // Resize the thumbnail to 30x30

                DataGridViewImageCell imageCell = new DataGridViewImageCell
                {
                    Value = thumbnail
                };

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(imageCell);
                row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Title });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Artists[0].Name });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = song.Duration.ToString() });

                datagrid_Playlist_TOP100.Rows.Add(row);
                datagrid_Playlist_TOP100.Rows[datagrid_Playlist_TOP100.RowCount - 1].Tag = song;
                datagrid_Playlist_TOP100.Rows[datagrid_Playlist_TOP100.RowCount - 1].Height = thumbnail.Height;
                datagrid_Playlist_TOP100.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public static string streamURL;
        private async void Datagrid_Playlist_TOP100_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure user did not click the header
            {
                Class_SongFullData song = datagrid_Playlist_TOP100.Rows[e.RowIndex].Tag as Class_SongFullData;
                if (song != null)
                {
                    songID = song.Key;
                    SongService songService = new SongService();
                    streamURL = await songService.GetURLsFromApi(songDetailsApiUrl, songID, song);

                }
                else
                {
                    MessageBox.Show("No song data available.");
                }

            }
        }

    }
}