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
    public partial class payForm : Form
    {
        cartForm cartForm;
        appForm mainForm;
        double price;

        public payForm(appForm appForm,cartForm cartForm, double price)
        {
            this.cartForm = cartForm;
            this.price = price;
            this.mainForm = appForm;
            InitializeComponent();
            formatWindow();
        }

        public void formatWindow()
        {
            //Window properties
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.None;

            //Convert BitMap to Icon
            Bitmap myBitmap = Properties.Resources.logo;
            IntPtr Hicon = myBitmap.GetHicon();
            Icon newIcon = Icon.FromHandle(Hicon);
            this.Icon = newIcon;

            //Cargar datos
            lbl_precio.Text = "Total a pagar: S/. " + price;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cartForm.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            confirmationForm confirmationForm = new confirmationForm(mainForm);
            confirmationForm.Visible = true;
            this.Close();
        }
    }
}
