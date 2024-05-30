using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PQTMUSIC_APP
{
    public partial class Main_Form : Form
    {
        private string currentUser;
        public Main_Form(string currentUser)
        {
            InitializeComponent();
            frm_Explore explore = new frm_Explore();
            addForm_Child(explore);
            this.currentUser = currentUser;
        }

        private void addForm_Child(Form frm_child)
        {
            frm_child.Dock = DockStyle.Fill;
            frm_child.TopLevel = false;
            panel_Child.Controls.Clear();
            panel_Child.Controls.Add(frm_child);
            frm_child.Show();
        }

        private void btn_Offline_Click(object sender, EventArgs e)
        {
            frm_OffineMode Offline = new frm_OffineMode();
            addForm_Child(Offline);
        }

        private void btn_Explore_Click(object sender, EventArgs e)
        {
            frm_Explore explore = new frm_Explore();
            addForm_Child(explore);
        }
        

        private void btn_img_Play_Click(object sender, EventArgs e)
        {
            
        }

        private void pic_User_Click(object sender, EventArgs e)
        {
            ShowIn4 showINFO = new ShowIn4(currentUser);
            showINFO.Show();
        }

        private void btn_Genres_Click(object sender, EventArgs e)
        {
            ShowGenres showGenres = new ShowGenres();
            addForm_Child(showGenres);
        }

        private void btn_Albums_Click(object sender, EventArgs e)
        {
            frm_Album showAlbum = new frm_Album();
            addForm_Child(showAlbum);
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            //frm_FavSong showFavSong = new frm_FavSong();

        }

        private void btn_Ranks_Click(object sender, EventArgs e)
        {
            Frm_Ranking showRank = new Frm_Ranking();
            addForm_Child(showRank);
        }
    }
}
