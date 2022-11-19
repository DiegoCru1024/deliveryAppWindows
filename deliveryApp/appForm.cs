using deliveryApp.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //API de Inventario
        string itemApiURL = "https://6371572b07858778617b1464.mockapi.io/deliveryAPI/itemList";

        //Contenedores de Datos
        List<loadItemAPI> itemList = new List<loadItemAPI>();
        List<loadItemAPI> filteredItemList = new List<loadItemAPI>();
        List<loadItemAPI> shoppingCart = new List<loadItemAPI>();
        loadLoginApi userData;

        //Filtros
        string categoryFilter = string.Empty;
        string brandFilter = string.Empty;
        string priceFilter = string.Empty;

        internal appForm(loadLoginApi receivedData)
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

        private async void deserializeAPI()
        {
            string apiResponse = await getAPI();
            itemList = JsonConvert.DeserializeObject<List<loadItemAPI>>(apiResponse);
            filteredItemList = itemList;
            showItems(filteredItemList);
        }

        private async Task<string> getAPI()
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

        private void filterTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeTag = e.Node.Tag.ToString().ToLower();
            string selectedNode = e.Node.Text;

            if (e.Node.Parent != null)
            {
                if (selectedNodeTag == "category")
                {
                    categoryFilter = selectedNode;
                }
                if (selectedNodeTag == "brand")
                {
                    brandFilter = selectedNode;
                }
                if (selectedNodeTag == "price")
                {
                    priceFilter = selectedNode;
                }

                filterItems();
            }
        }

        private void resetFilter(object sender, EventArgs e)
        {
            filterTree.SelectedNode = null;
            categoryFilter = string.Empty; 
            brandFilter = string.Empty; 
            priceFilter = string.Empty;

            filteredItemList = itemList;
            showItems(filteredItemList);
        }

        private void filterItems()
        {
            //se filtran los items en filtereditemlist



            showItems(filteredItemList);
        }

        private void onPanelEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            Panel p = (Panel)picBox.Parent;

            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    control.Visible = true;
                }
            }
        }

        private void onPanelExit(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            Panel p = (Panel)picBox.Parent;

            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    control.Visible = false;
                }
            }
        }

        private void showItems(List<loadItemAPI> itemsToShow)
        {
            int contador = 1;
            foreach(loadItemAPI item in itemsToShow)
            {
                //Panel design
                Panel itemPanel = new Panel();
                itemPanel.Width = 300;
                itemPanel.Height = 400;
                itemPanel.BackColor = Color.Gray;
                itemPanel.Margin = new Padding(10);
                itemPanel.Name = "Panel" + contador;

                Label itemPrice = new Label();
                itemPrice.Text = "S/. " + item.price;
                itemPrice.ForeColor = Color.White;
                itemPrice.BackColor = Color.FromArgb(255, 80, 80);
                itemPrice.TextAlign = ContentAlignment.MiddleCenter;
                itemPrice.Height = 25;
                itemPrice.Font = new Font("Tahoma", 12);
                itemPrice.Dock = DockStyle.Top;
                itemPanel.Controls.Add(itemPrice);

                Label itemName = new Label();
                itemName.Text = item.name;
                itemName.ForeColor = Color.White;
                itemName.BackColor = Color.FromArgb(255, 80, 80);
                itemName.Font = new Font("Tahoma", 12, FontStyle.Bold);
                itemName.TextAlign = ContentAlignment.MiddleCenter;
                itemName.Height = 25;
                itemName.Dock = DockStyle.Top;
                itemPanel.Controls.Add(itemName);

                PictureBox itemImage = new PictureBox();
                itemImage.Image = Properties.Resources.imgTest;
                itemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                itemImage.Height = 350;
                itemImage.Dock = DockStyle.Top;
                itemImage.MouseEnter += new EventHandler(onPanelEnter);
                itemImage.MouseLeave += new EventHandler(onPanelExit);
                itemPanel.Controls.Add(itemImage);

                Button itemAdd = new Button();
                itemAdd.Text = "Añadir";
                itemAdd.Height = 25;
                itemAdd.Dock = DockStyle.Top;
                itemAdd.Visible = false;
                itemPanel.Controls.Add(itemAdd);


                
                itemContainer.Controls.Add(itemPanel);
                contador++;
            }
        }
    }
}
