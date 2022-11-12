using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliveryApp
{
    public partial class appForm : Form
    {
        public string shopFilter;
        public string itemFilter;
        public arrayItems arrayItemsCall = new arrayItems();

        public string[] storeArray = {"Falabella", "Ripley", "H&M", "Oechsle"};
        public string[] itemArray = {"Polo", "Camisa", "Pantalon", "Casaca", "Zapatillas", "Sudadera", "Polera" };
        public Image[] imageArray = new Image[7];

        public appForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            actualizarImagenes();
            inicializarLista();
            
        }

        private void menuFiltro_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (menuFiltro.SelectedNode.Parent != null)
            {
                itemFilter = menuFiltro.SelectedNode.Text.ToLower();
                actualizarLista(itemFilter, shopFilter);
            }
        }

        private void btn_borrarFiltros_Click(object sender, EventArgs e)
        {
            menuFiltro.SelectedNode = null;
            itemFilter = "no-filter";
            shopFilter = "no-filter";
            actualizarLista(itemFilter, shopFilter);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            shopFilter = "falabella";
            actualizarLista(itemFilter, shopFilter);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            shopFilter = "ripley";
            actualizarLista(itemFilter, shopFilter);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            shopFilter = "hm";
            actualizarLista(itemFilter, shopFilter);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            shopFilter = "oechsle";
            actualizarLista(itemFilter, shopFilter);
        }

        public void actualizarLista(string itemF, string shopF)
        {
            
        }

        public void actualizarImagenes()
        {
            imageArray[0] = Properties.Resources.polo;
            imageArray[1] = Properties.Resources.camisa;
            imageArray[2] = Properties.Resources.pantalon;
            imageArray[3] = Properties.Resources.casaca;
            imageArray[4] = Properties.Resources.zapatillas;
            imageArray[5] = Properties.Resources.sudadera;
            imageArray[6] = Properties.Resources.polera;
        }

        public void inicializarLista()
        {
            int codigo = 0;
            for (int i = 0; i < 52; i++)
            {
                arrayItemsCall.inicializarArray();

                ItemClass item = new ItemClass();
                Random rnd = new Random();
                int randomStore = rnd.Next(0, storeArray.Length);
                int randomItem = rnd.Next(0, itemArray.Length);
                int randomPrice = rnd.Next(50, 500);

                item.createItem(codigo, storeArray[randomStore], randomPrice, itemArray[randomItem]);
                arrayItemsCall.addItem(item, codigo);

                Panel newPanel = new Panel();
                newPanel.Width = 350;
                newPanel.Height = 400;
                newPanel.BackColor = SystemColors.ActiveBorder;
                newPanel.Margin = new Padding(10);


                Label newPrice = new Label();
                newPrice.Text =randomPrice.ToString();
                newPanel.Controls.Add(newPrice);
                newPrice.Dock = DockStyle.Top;
                newPrice.BackColor = Color.FromArgb(255, 80, 80);
                newPrice.ForeColor = Color.White;
                newPrice.Font = new Font("Roboto", 12);
                newPrice.TextAlign = ContentAlignment.MiddleCenter;
                newPrice.Height = 25;

                Label newName = new Label();
                newName.Text = itemArray[randomItem] + " - " + storeArray[randomStore];
                newPanel.Controls.Add(newName);
                newName.Dock = DockStyle.Top;
                newName.BackColor = Color.FromArgb(255, 80, 80);
                newName.ForeColor = Color.White;
                newName.Font = new Font("Roboto", 14, FontStyle.Bold);
                newName.TextAlign = ContentAlignment.MiddleCenter;
                newName.Height = 25;

                PictureBox newImage = new PictureBox();
                newPanel.Controls.Add(newImage);
                newImage.Dock = DockStyle.Top;
                newImage.BackgroundImage = imageArray[randomItem];
                newImage.BackgroundImageLayout = ImageLayout.Zoom;
                newImage.Height = 350;
                newImage.Width = 350;


                itemsContainer.Controls.Add(newPanel);
                codigo++;
            }
        }
    }
}
