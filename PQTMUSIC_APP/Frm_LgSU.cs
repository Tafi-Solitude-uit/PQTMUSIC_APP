using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace PQTMUSIC_APP
{
    public partial class Frm_LgSU : Form
    {
        public static IFirebaseClient client;
        public static IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "CkIjEA3D7s7dxH1BWr0WF4VcU0ab7M068ojHUlDG",
            BasePath = "https://loginandregister-f73c6-default-rtdb.asia-southeast1.firebasedatabase.app/",
        };
        public Frm_LgSU()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);

        }
        public static string currentUser;
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
                
               
                
                Hide();

                string currentUser = await WhoInShiftNow();
                if (currentUser != null)
                {
                    Main_Form secondForm = new Main_Form(currentUser);
                    secondForm.ShowDialog();
                }
                Close();

            }
            else
            {
             
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
            }
        }
        private async Task<bool> IsValidLogin(string username, string password)
        {
            FirebaseResponse usernameResponse = await client.GetAsync("Users/" + username);
            if (usernameResponse.Body != "null")
            {
                var data = usernameResponse.ResultAs<UserData>();
                if (password != null)
                {
                    if (data.password.ToString() == password)
                    {
                        return true;
                    }
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
        private async Task<int> GetNextUserId()
        {
            FirebaseResponse usersResponse = await client.GetAsync("Users");
            var usersData = usersResponse.ResultAs<Dictionary<string, UserData>>();

            if (usersData != null && usersData.Count > 0)
            {
                return usersData.Values.Max(u => u.userid) + 1;
            }
            else
            {
                return 1;
            }
        }
        
        private async void btnSignUp_Click(object sender, EventArgs e)
        {

            int nextUserId = await GetNextUserId();
            UserData userData = new UserData()
            {
                username = txtSUusername.Text,
                password = txtSUpass.Text,
                userid = nextUserId,
                realname = txtRealName.Text,
                gender = cbmGender.SelectedItem.ToString(),
                birthday = int.Parse(txtBirthyear.Text),
            };

            // Xác thực thông tin đăng ký
            if (!IsValidSignUp(userData.username, userData.password))
            {
                MessageBox.Show("Thông tin đăng ký không hợp lệ hoặc tên người dùng đã tồn tại !");
                return;
            }
            FirebaseResponse response = await client.SetAsync("Users/" + userData.username, userData);
           
            MessageBox.Show("Đăng ký thành công! Mời về trang đăng nhập");
            pn_SignUp.Visible=false;
            pn_SignIn.Visible=true;
        }
       
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
        //valid pass, username when sign up
        private void txtSUpass_TextChanged(object sender, EventArgs e)
        {
            string password = txtSUpass.Text;

            if (password.Length < 6 || password.Length > 12)
            {
                lbSUPassError.Visible = true;
                
                txtSUpass.FillColor = Color.Plum;
                btnSignUp.Enabled = false;
            }
            else
            {
                lbSUPassError.Visible = false;
                txtSUpass.FillColor = Color.Transparent;
                btnSignUp.Enabled = true;
            }

        }
        private void txtSUusername_TextChanged(object sender, EventArgs e)
        {
            string username = txtSUusername.Text;

            if (ContainsSpecialCharacters(username))
            {
                
                txtSUusername.FillColor = Color.Plum;
                lblSIusernameError.Visible = true;
                btnSignUp.Enabled=false;
            }
            else
            {
                lblSIusernameError.Visible = false;
                txtSUusername.FillColor = Color.Transparent;
                btnSignUp.Enabled = true;
            }
        }

        private bool ContainsSpecialCharacters(string input)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.IsMatch(input);
        }
    }
}
