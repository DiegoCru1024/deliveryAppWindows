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
    public partial class appForm : Form
    {
        public string shopFilter;
        public string itemFilter;

        public appForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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
            int contador = 0;
            foreach (Panel p in itemsContainer.Controls.OfType<Panel>())
            {
                contador++;
            }
            label1.Text = "hay " + contador;
        }

        public void inicializarLista()
        {
            for (int i = 0; i < 52; i++)
            {
                Panel newPanel = new Panel();
                newPanel.Width = 350;
                newPanel.Height = 400;
                newPanel.BackColor = SystemColors.ActiveBorder;
                newPanel.Margin = new Padding(10);
                itemsContainer.Controls.Add(newPanel);
            }
        }
    }
}
