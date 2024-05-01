using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

namespace PQTMUSIC_APP
{ 
    

    public partial class Fm_test : Form
    {
        class Program
        {
            static async Task Main()
            {
                var spotify = new SpotifyClient("BQAL4Gt8Ypm3nVWZfITU5Myn4OQ7msJ6_bSxADLCF2Zq6Wwiga7eb4kc8e35xq3uCF8TDAXXVF1ohrfzhnxQH8S5oq7Wb_h4azKK_P7m19UPqRuXQD0");

                var track = await spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
                Console.WriteLine(track.Name);
            }
        }
        public Fm_test()
        {
            InitializeComponent();
        }
    }
}
