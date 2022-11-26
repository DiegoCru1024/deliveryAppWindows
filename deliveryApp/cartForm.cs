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
    }
}
