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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.ToLower().Equals("usuario") && txt_pass.Text.Equals("12345"))
            {
                appForm obj = new appForm();
                this.Opacity = 0;
                this.ShowInTaskbar = false;
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos...", "Error de credenciales");
            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
