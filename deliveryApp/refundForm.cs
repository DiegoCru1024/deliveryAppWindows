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
    public partial class refundForm : Form
    {
        supportForm supportForm;
        loginClass userData;
        public refundForm(supportForm supportForm, loginClass userData)
        {
            this.supportForm = supportForm;
            this.userData = userData;
            InitializeComponent();
            formatWindow();
            cargarDatos();
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

        public void cargarDatos() {
            txt_nombre.Text = userData.firstName;
            txt_apellido.Text = userData.lastName;
            txt_correo.Text = userData.email;
            txt_telefono.Text = userData.phone;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            supportForm.Visible = true;
            this.Close();
        }
            
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su solicitud ha sido enviada...", "Confirmacion");
            supportForm.Visible = true;
            this.Close();
        }
    }


}
