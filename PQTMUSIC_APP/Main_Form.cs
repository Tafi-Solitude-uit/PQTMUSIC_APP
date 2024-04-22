using login_register;
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
        public Main_Form()
        {
            InitializeComponent();
            frm_Explore explore = new frm_Explore();
            addForm_Child(explore);
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
            frm_Offline Offline = new frm_Offline();
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
            showIn4 in4= new showIn4();
            in4.Show();
        }
    }
}
