using System;
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


namespace login_register
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

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtSIusername.Text;
            string password = txtSIpass.Text;

            // Xác thực thông tin đăng nhập
            if (await IsValidLogin(username, password))
            {
                // Hiển thị thông báo đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");

                // Chuyển đến trang chủ
                // ...

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
            if(checkShowPass.Checked) 
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
            int birthYear;
            if (!int.TryParse(txtBirthyear.Text, out birthYear))
            {
                MessageBox.Show("Thông tin không hợp lệ !");
                return;
            }
            UserData userData = new UserData()
            {
                username = txtSIusername.Text,
                password = txtSIpass.Text,
                userid = currentUserId,
                realname = txtRealName.Text,
                gender = cbmGender.SelectedItem.ToString(),
            };
            userData.birthday = birthYear;
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

            if (cbmGender.SelectedIndex == -1 || password != txtSUcomPass.Text || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(txtRealName.Text) || string.IsNullOrEmpty(txtBirthyear.Text.ToString()) || string.IsNullOrEmpty(txtSUcomPass.Text))
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
            pn_SignUp.Visible = false ;

        }

        private void Newest_Load(object sender, EventArgs e)
        {
            pn_SignIn.Visible=true;
            pn_SignUp.Visible=false ;
        }

        private void checkShPassSignUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShPassSignUp.Checked)
            {
                (txtSUpass.PasswordChar ) = '\0';
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
