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
        List<itemClass> itemList = new List<itemClass>();
        List<itemClass> filteredItemList = new List<itemClass>();
        List<itemClass> shoppingCart = new List<itemClass>();
        loginClass userData;

        //Filtros
        string categoryFilter = string.Empty;
        string brandFilter = string.Empty;
        string storeFilter = string.Empty;
        string priceFilter = string.Empty;

        //Formulario
        cartForm cartFormCall;
        supportForm supportFormCall;
        pucharsesForm pucharsesFormCall;

        internal appForm(loginClass receivedData)
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
            itemList = JsonConvert.DeserializeObject<List<itemClass>>(apiResponse);
            filteredItemList = itemList;
            showItems(itemList);
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
            if (e.Node.Parent != null)
            {
                resetFilters();
                string selectedNodeTag = e.Node.Parent.Tag.ToString().ToLower();
                string selectedNode = e.Node.Text.ToLower();

                if (selectedNodeTag == "category")
                {
                    categoryFilter = selectedNode;
                }
                if (selectedNodeTag == "brand")
                {
                    brandFilter = selectedNode;
                }
                if (selectedNodeTag == "store")
                {
                    storeFilter = selectedNode;
                }
                if (selectedNodeTag == "price")
                {
                    priceFilter = selectedNode;
                }

                filterItems();
            }
        }

        private void resetFilterButton(object sender, EventArgs e)
        {
            filterTree.SelectedNode = null;
            categoryFilter = string.Empty; 
            brandFilter = string.Empty; 
            storeFilter = string.Empty;
            priceFilter = string.Empty;
            resetFilters();
        }

        public void resetFilters()
        {
            foreach(Panel p in itemContainer.Controls)
            {
                p.Visible = true;
            }
        }

        private void filterItems()
        {
            foreach (Panel p in itemContainer.Controls)
            {
                int id = int.Parse(p.Tag.ToString());
                itemClass item = itemList[id-1];

                if (item.category != categoryFilter && categoryFilter != string.Empty)
                {
                    p.Visible = false;
                }
                if (item.brand != brandFilter && brandFilter != string.Empty)
                {
                    p.Visible = false;
                }
                if (item.store != storeFilter && storeFilter != string.Empty)
                {
                    p.Visible = false;
                }
            }
        }

        private void addToCart(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = (Panel)button.Parent;
            string itemID = panel.Tag.ToString();

            foreach (itemClass item in itemList)
            {
                if (item.id == itemID)
                {
                    shoppingCart.Add(item);
                }
            }
        }

        private void showItems(List<itemClass> itemsToShow)
        {
            itemContainer.Controls.Clear();

            foreach(itemClass item in itemsToShow)
            {
                //Panel design
                Panel itemPanel = new Panel();
                itemPanel.Width = 300;
                itemPanel.Height = 400;
                itemPanel.BackColor = Color.Gray;
                itemPanel.Margin = new Padding(10);
                itemPanel.Name = "Panel" + item.id;
                itemPanel.Tag = item.id;

                Button itemButton = new Button();
                itemButton.Text = "Añadir al carrito";
                itemButton.Click += new EventHandler(addToCart);
                itemButton.Height = 25;
                itemButton.ForeColor = Color.White;
                itemButton.BackColor = Color.FromArgb(255, 80, 80);
                itemButton.TextAlign = ContentAlignment.MiddleCenter;
                itemButton.Font = new Font("Tahoma", 12, FontStyle.Bold);
                itemButton.Dock = DockStyle.Top;
                itemButton.FlatStyle = FlatStyle.Flat;
                itemButton.FlatAppearance.BorderSize = 0;
                itemPanel.Controls.Add(itemButton);

                Label itemPrice = new Label();
                itemPrice.Text = "S/. " + item.price;
                itemPrice.ForeColor = Color.Black;
                itemPrice.TextAlign = ContentAlignment.MiddleCenter;
                itemPrice.Height = 25;
                itemPrice.Font = new Font("Tahoma", 12);
                itemPrice.Dock = DockStyle.Top;
                itemPanel.Controls.Add(itemPrice);

                Label itemName = new Label();
                itemName.Text = item.name;
                itemName.ForeColor = Color.Black;
                itemName.Font = new Font("Tahoma", 12, FontStyle.Bold);
                itemName.TextAlign = ContentAlignment.MiddleCenter;
                itemName.Height = 25;
                itemName.Dock = DockStyle.Top;
                itemPanel.Controls.Add(itemName);

                PictureBox itemImage = new PictureBox();
                itemImage.Image = Properties.Resources.imgTest;
                itemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                itemImage.Height = 325;
                itemImage.Dock = DockStyle.Top;
                itemPanel.Controls.Add(itemImage);

                itemContainer.Controls.Add(itemPanel);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (cartFormCall == null || cartFormCall.IsDisposed)
            {
                cartFormCall = new cartForm(this, shoppingCart, userData);
                cartFormCall.Visible = true;
                this.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (supportFormCall == null || supportFormCall.IsDisposed)
            {
                supportFormCall = new supportForm(this, userData);
                supportFormCall.Visible = true;
                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pucharsesFormCall == null || pucharsesFormCall.IsDisposed)
            {
                pucharsesFormCall = new pucharsesForm(this, userData);
                pucharsesFormCall.Visible = true;
                this.Visible = false;
            }
        }
    }
}
