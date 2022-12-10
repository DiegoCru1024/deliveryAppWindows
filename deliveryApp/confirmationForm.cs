using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliveryApp
{
    public partial class confirmationForm : Form
    {
        appForm mainForm;

        public confirmationForm(appForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            formatWindow();
            this.mainForm = mainForm;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            surveyForm surveyForm = new surveyForm(mainForm);
            surveyForm.Visible = true;
            this.Close();
        }
    }
}
