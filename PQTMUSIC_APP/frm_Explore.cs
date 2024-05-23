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





namespace PQTMUSIC_APP
{
    public partial class frm_Explore : Form
    {
        private string streamUrl = "https://stream.nixcdn.com/NhacCuaTui2054/CoPhong-HoQuangHieuHuynhVan-14432441.mp3?st=Phd1Do2URcmlnfNhBt-Apg&e=1716560050";
        private string songTitle = "Cô Phòng";
        private string artistName = "Hồ Quang Hiếu, Huỳnh Văn";
        private IWavePlayer waveOutDevice;
        private WaveStream mainOutputStream;

        public frm_Explore()
        {
            InitializeComponent();
        }

        private void frm_Explore_Load(object sender, EventArgs e)
        {
            PlayAudio(streamUrl);
        }

        private void PlayAudio(string url)
        {
            waveOutDevice = new WaveOut();
            mainOutputStream = new MediaFoundationReader(url);
            waveOutDevice.Init(mainOutputStream);
            waveOutDevice.Play();
        }
    }
}