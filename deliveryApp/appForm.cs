using deliveryApp.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliveryApp
{
    public partial class appForm : Form
    {
        string loadedUserName;
        string itemApiURL = "https://6371572b07858778617b1464.mockapi.io/deliveryAPI/itemList";
        List<loadItemAPI> itemList = new List<loadItemAPI>();
        List<loadItemAPI> filteredItemList = new List<loadItemAPI>();
        loadLoginApi userData;

        public appForm(loadLoginApi receivedData)
        {
            InitializeComponent();
            deserializeAPI();
            formatWindow();
            userData = receivedData;
        }

        private void appForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Bienvenido {userData.firstName}!";
        }

        public async void deserializeAPI()
        {
            string apiResponse = await getAPI();
            itemList = JsonConvert.DeserializeObject<List<loadItemAPI>>(apiResponse);
        }

        public async Task<string> getAPI()
        {
            HttpClient myClient = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });
            HttpResponseMessage response = await myClient.GetAsync(itemApiURL);
            string itemResponse = await response.Content.ReadAsStringAsync();
            return itemResponse;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formatWindow()
        {
            //Window properties
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            //Convert BitMap to Icon
            Bitmap myBitmap = Properties.Resources.logo;
            IntPtr Hicon = myBitmap.GetHicon();
            Icon newIcon = Icon.FromHandle(Hicon);
            this.Icon = newIcon;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
