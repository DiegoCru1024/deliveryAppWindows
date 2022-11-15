using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace deliveryApp
{
    public partial class loginForm : Form
    {
        string loginApiURL = "https://6371572b07858778617b1464.mockapi.io/deliveryAPI/deliveryLoginAccess";
        List<loadLoginApi> loginList = new List<loadLoginApi>();

        public loginForm()
        {
            InitializeComponent();
            deserializeAPI();
            formatLogin();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        public async void deserializeAPI()
        {
            string apiResponse = await getAPI();
            loginList = JsonConvert.DeserializeObject<List<loadLoginApi>>(apiResponse);
        }

        public async Task<string> getAPI()
        {
            HttpClient myClient = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });
            HttpResponseMessage response = await myClient.GetAsync(loginApiURL);
            string loginResponse = await response.Content.ReadAsStringAsync();
            return loginResponse;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string formPass, formUserName;
            string apiPass, apiUserName;

            formUserName = txt_user.Text;
            formPass = txt_pass.Text;

            apiUserName = string.Empty;
            apiPass = string.Empty;

            foreach (loadLoginApi login in loginList)
            {
                if (formUserName.ToLower().Equals(login.username.ToLower()))
                {
                    apiUserName= login.username;
                    apiPass = login.password;
                    break;
                }
                else
                {
                    apiPass = string.Empty;
                    apiUserName = string.Empty;
                }
            }

            if (apiUserName != string.Empty)
            {
                if (apiPass.Equals(formPass))
                {
                    this.Visible = false;
                    appForm newForm = new appForm(apiUserName);
                    newForm.Visible = true;
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta...", "Error");
                }
            }
            else
            {
                MessageBox.Show("El usuario no esta registrado...", "Error");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formatLogin()
        {
            //Window properties
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.None;

            //Convert BitMap to Icon
            Bitmap myBitmap = Properties.Resources.logo;
            IntPtr Hicon = myBitmap.GetHicon();
            Icon newIcon = Icon.FromHandle(Hicon);
            this.Icon = newIcon;
        }
    }
}

