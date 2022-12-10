using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliveryApp
{
    public partial class cartForm : Form
    {
        appForm mainForm;
        List<itemClass> shoppingCartList;
        loginClass userData;
        payForm payForm;

        int productCount = 0;
        double totalPrice = 0, finalPrice = 0;

        public cartForm(appForm mainForm,List<itemClass> receivedData, loginClass receivedUser)
        {
            this.mainForm = mainForm;
            userData = receivedUser;
            InitializeComponent();
            formatWindow();
            cartRefresh(receivedData);
        }

        private void cartForm_Load(object sender, EventArgs e)
        {

        }

        internal void cartRefresh(List<itemClass> receivedData)
        {
            foreach(itemClass itemClass in receivedData)
            {
                productCount++;
                totalPrice += Double.Parse(itemClass.price.ToString());

                Panel panel = new Panel();
                panel.Width = cartContainer.Width;
                panel.Height = 250;
                panel.BackColor = Color.Gray;
                panel.Margin = new Padding(20);

                Panel textPanel = new Panel();
                textPanel.Height = 250;
                textPanel.Dock = DockStyle.Left;
                panel.Controls.Add(textPanel);

                PictureBox image = new PictureBox();
                image.BackgroundImage = Properties.Resources.imgTest;
                image.BackgroundImageLayout = ImageLayout.Zoom;
                image.Dock = DockStyle.Left;
                image.Height = 250;
                image.Width = 250;
                panel.Controls.Add(image);

                Label productPrice = new Label();
                productPrice.Text = "Precio: " + itemClass.price;
                productPrice.Font = new Font("Tahoma", 16);
                productPrice.Padding = new Padding(20, 20, 0, 0);
                productPrice.Height = 50;
                productPrice.Dock = DockStyle.Top;
                textPanel.Controls.Add(productPrice);

                Label productName = new Label();
                productName.Text = itemClass.name;
                productName.Font = new Font("Tahoma", 20, FontStyle.Bold);
                productName.Padding = new Padding(20, 20, 0, 0);
                productName.Height = 50;
                productName.Width = 350;
                productName.Dock = DockStyle.Top;
                textPanel.Controls.Add(productName);

                cartContainer.Controls.Add(panel);
            }

            lbl_count.Text = productCount + " productos";
            lbl_price.Text = "S/. " + Math.Round(totalPrice, 2);
            if (totalPrice >= 250)
            {
                lbl_envio.Text = "S/. 0,00";
                finalPrice = Math.Round(totalPrice, 2);
                lbl_finalprice.Text = "S/. " + finalPrice;
            } else
            {
                lbl_envio.Text = "S/. " + Math.Round(productCount * 2.50, 2);
                finalPrice = Math.Round(totalPrice + productCount * 2.50, 2);
                lbl_finalprice.Text = "S/. " + finalPrice;
            }
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

            //Cargar datos de usuario
            txt_name.Text = userData.firstName + " " + userData.lastName;
            txt_address.Text = userData.address;
            txt_phone.Text = userData.phone;  
            txt_email.Text = userData.email;

            txt_name.Enabled = false;
            txt_address.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Enabled)
            {
                txt_name.Enabled = false;
                txt_address.Enabled = false;
                txt_phone.Enabled = false;
                txt_email.Enabled = false;
                button1.Text = "Editar datos";
            } else
            {
                txt_name.Enabled = true;
                txt_address.Enabled = true;
                txt_phone.Enabled = true;
                txt_email.Enabled = true;
                button1.Text = "Guardar datos";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (payForm == null || payForm.IsDisposed)
            {
                payForm = new payForm(mainForm, this, finalPrice);
                payForm.Visible = true;
                this.Visible = false;
            }
        }
    }
}
