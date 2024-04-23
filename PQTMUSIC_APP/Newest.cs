﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using NAudio.Wave;
using TagLib;

namespace PQTMUSIC_APP
{
    public partial class Newest : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "CkIjEA3D7s7dxH1BWr0WF4VcU0ab7M068ojHUlDG",
            BasePath = "https://loginandregister-f73c6-default-rtdb.asia-southeast1.firebasedatabase.app/",
        };
        public Newest()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);

        }
        public string currentUser;
        public async Task<string> WhoInShiftNow()
        {
            string username = txtSIusername.Text.Trim();
            string password = txtSIpass.Text;

            if (await IsValidLogin(username, password))
            {
                currentUser = username;
                return currentUser;
            }

            return null;
        }
        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtSIusername.Text;
            string password = txtSIpass.Text;

            // Xác thực thông tin đăng nhập
            if (await IsValidLogin(username, password))
            {
                // Hiển thị thông báo đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                
                this.Hide();

                string currentUser = await WhoInShiftNow();
                if (currentUser != null)
                {
                    Main_Form secondForm = new Main_Form(currentUser);
                    secondForm.ShowDialog();
                }
                this.Close();

            }
            else
            {
                // Hiển thị thông báo lỗi đăng nhập
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
            }
        }
        private async Task<bool> IsValidLogin(string username, string password)
        {
            FirebaseResponse usernameResponse = await client.GetAsync("Users/" + username);
            if (usernameResponse.Body != "null")
            {
                var data = usernameResponse.ResultAs<UserData>();
                if (data.password == password)
                {
                    return true;
                }
            }
            return false;
        }
        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                txtSIpass.PasswordChar = '\0';
            }
            else
            {
                txtSIpass.PasswordChar = '*';
            }
        }
        private async void UserIDLogic()
        {
            FirebaseResponse usersResponse = await client.GetAsync("users");
            var usersData = usersResponse.ResultAs<Dictionary<string, UserData>>();

            if (usersData != null && usersData.Count > 0)
            {
                currentUserId = usersData.Values.Max(u => u.userid) + 1;
            }
            else
            {
                currentUserId = 1;
            }
        }
        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            UserIDLogic();
            UserData userData = new UserData()
            {
                username = txtSIusername.Text,
                password = txtSIpass.Text,
                userid = currentUserId,
                realname = txtRealName.Text,
                gender = cbmGender.SelectedItem.ToString(),
                birthday = int.Parse(txtBirthyear.Text),
            };

            // Xác thực thông tin đăng ký
            if (!IsValidSignUp(userData.username, userData.password))
            {
                MessageBox.Show("Thông tin đăng ký không hợp lệ!");
                return;
            }
            FirebaseResponse response = await client.SetAsync("Users/" + userData.username, userData);
            currentUserId++;
            MessageBox.Show("Đăng ký thành công! Mời về trang đăng nhập");
            this.Close();
        }
        private int currentUserId;
        private bool IsValidSignUp(string username, string password)
        {

            if (password != txtSUcomPass.Text || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
            {

                return false;
            }
            else return true;

        }

        private void btnCTSU_Click(object sender, EventArgs e)
        {
            pn_SignIn.Visible = false;
            pn_SignUp.Visible = true;
        }

        private void btnCTLG_Click(object sender, EventArgs e)
        {
            pn_SignIn.Visible = true;
            pn_SignUp.Visible = false;

        }

        private void Newest_Load(object sender, EventArgs e)
        {
            pn_SignIn.Visible = true;
            pn_SignUp.Visible = false;
        }

        private void checkShPassSignUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShPassSignUp.Checked)
            {
                (txtSUpass.PasswordChar) = '\0';
                txtSUcomPass.PasswordChar = '\0';
            }
            else
            {
                txtSUpass.PasswordChar = '*';
                txtSUcomPass.PasswordChar = '*';
            }
        }
       
    }
}
