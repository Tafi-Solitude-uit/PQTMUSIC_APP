﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;

namespace PQTMUSIC_APP
{
    public partial class ShowIn4 : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "CkIjEA3D7s7dxH1BWr0WF4VcU0ab7M068ojHUlDG",
            BasePath = "https://loginandregister-f73c6-default-rtdb.asia-southeast1.firebasedatabase.app/",
        };
        private string currentUser;
        public ShowIn4(string currentUser)
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            this.currentUser = currentUser;
        }
        private async void showIn4_Load(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Users/" + currentUser);
            if (response.Body != "null")
            {
                var userData = response.ResultAs<Dictionary<string, object>>();
                {
                    txtShowName.Text = userData["realname"].ToString();
                    txtShowID.Text = userData["userid"].ToString();
                    txtShowYear.Text = userData["birthday"].ToString();
                    txtShowGender.Text = userData["gender"].ToString();
                }
            }

        }

        private void ShowIn4_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_showIN4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
