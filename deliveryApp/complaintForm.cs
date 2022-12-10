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
    public partial class complaintForm : Form
    {
        supportForm supportForm;
        loginClass userData;

        public complaintForm(supportForm supportForm, loginClass userData)
        {
            this.supportForm = supportForm;
            this.userData = userData;

            InitializeComponent();
            formatWindow();
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

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            supportForm.Visible = true;
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su reclamo ha sido enviado...", "Confirmacion");
            supportForm.Visible = true;
            this.Close();
        }
    }
}
