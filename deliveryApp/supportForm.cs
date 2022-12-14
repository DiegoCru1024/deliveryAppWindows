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
    public partial class supportForm : Form
    {
        //Formularios
        appForm mainForm;
        complaintForm complaintForm;
        refundForm refundForm;

        loginClass userData;

        public supportForm(appForm mainForm, loginClass userData)
        {
            this.mainForm = mainForm;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (refundForm == null || refundForm.IsDisposed)
            {
                refundForm = new refundForm(this, userData);
                refundForm.Visible = true;
                this.Visible = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (complaintForm == null || complaintForm.IsDisposed)
            {
                complaintForm = new complaintForm(this, userData);
                complaintForm.Visible = true;
                this.Visible = false;
            }
        }
    }
}
