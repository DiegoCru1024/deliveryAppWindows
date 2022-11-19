using System.Numerics;

namespace deliveryApp
{
    partial class appForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Polos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Pantalones");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Camisas");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Poleras");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Shorts y Bermudas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Chompas y Chalecos");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Casacas y Abrigos");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ropa de baño");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ropa formal");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Categorías", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Adidas");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Billabong");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Calvin Klein");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Converse");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("DC Shoes");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Diadora");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Doo Australia");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Fila");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Gap");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("John Holden");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("LaCoste");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Levis");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Marathon");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("New Balance");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Nike");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Norton");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Reebok");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("The North Face");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Umbro");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Under Armor");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Marcas", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("0 - 100");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("101 - 250");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("251 - 500");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("501 - 750");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("750 a más");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Precio", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.filterTree = new System.Windows.Forms.TreeView();
            this.btn_resetFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_welcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.BackgroundImage = global::deliveryApp.Properties.Resources.cart;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1022, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackgroundImage = global::deliveryApp.Properties.Resources.cross;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1100, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(100, 35);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(212, 29);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Bienvenido usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::deliveryApp.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidePanel.AutoSize = true;
            this.sidePanel.BackColor = System.Drawing.Color.Silver;
            this.sidePanel.Controls.Add(this.panel4);
            this.sidePanel.Controls.Add(this.btn_resetFilter);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Location = new System.Drawing.Point(12, 113);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(20);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(5);
            this.sidePanel.Size = new System.Drawing.Size(250, 512);
            this.sidePanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.filterTree);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 447);
            this.panel4.TabIndex = 3;
            // 
            // filterTree
            // 
            this.filterTree.BackColor = System.Drawing.Color.Silver;
            this.filterTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTree.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterTree.Indent = 20;
            this.filterTree.ItemHeight = 25;
            this.filterTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.filterTree.Location = new System.Drawing.Point(0, 0);
            this.filterTree.Name = "filterTree";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Polos";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Pantalones";
            treeNode3.Name = "Nodo3";
            treeNode3.Text = "Camisas";
            treeNode4.Name = "Nodo4";
            treeNode4.Text = "Poleras";
            treeNode5.Name = "Nodo5";
            treeNode5.Text = "Shorts y Bermudas";
            treeNode6.Name = "Nodo6";
            treeNode6.Text = "Chompas y Chalecos";
            treeNode7.Name = "Nodo7";
            treeNode7.Text = "Casacas y Abrigos";
            treeNode8.Name = "Nodo8";
            treeNode8.Text = "Ropa de baño";
            treeNode9.Name = "Nodo9";
            treeNode9.Text = "Ropa formal";
            treeNode10.Name = "Nodo0";
            treeNode10.Tag = "category";
            treeNode10.Text = "Categorías";
            treeNode11.Name = "Nodo11";
            treeNode11.Text = "Adidas";
            treeNode12.Name = "Nodo12";
            treeNode12.Text = "Billabong";
            treeNode13.Name = "Nodo13";
            treeNode13.Text = "Calvin Klein";
            treeNode14.Name = "Nodo14";
            treeNode14.Text = "Converse";
            treeNode15.Name = "Nodo15";
            treeNode15.Text = "DC Shoes";
            treeNode16.Name = "Nodo16";
            treeNode16.Text = "Diadora";
            treeNode17.Name = "Nodo17";
            treeNode17.Text = "Doo Australia";
            treeNode18.Name = "Nodo18";
            treeNode18.Text = "Fila";
            treeNode19.Name = "Nodo19";
            treeNode19.Text = "Gap";
            treeNode20.Name = "Nodo20";
            treeNode20.Text = "John Holden";
            treeNode21.Name = "Nodo21";
            treeNode21.Text = "LaCoste";
            treeNode22.Name = "Nodo22";
            treeNode22.Text = "Levis";
            treeNode23.Name = "Nodo23";
            treeNode23.Text = "Marathon";
            treeNode24.Name = "Nodo24";
            treeNode24.Text = "New Balance";
            treeNode25.Name = "Nodo25";
            treeNode25.Text = "Nike";
            treeNode26.Name = "Nodo26";
            treeNode26.Text = "Norton";
            treeNode27.Name = "Nodo27";
            treeNode27.Text = "Reebok";
            treeNode28.Name = "Nodo28";
            treeNode28.Text = "The North Face";
            treeNode29.Name = "Nodo29";
            treeNode29.Text = "Umbro";
            treeNode30.Name = "Nodo30";
            treeNode30.Text = "Under Armor";
            treeNode31.Name = "Nodo10";
            treeNode31.Tag = "brand";
            treeNode31.Text = "Marcas";
            treeNode32.Name = "Nodo32";
            treeNode32.Text = "0 - 100";
            treeNode33.Name = "Nodo33";
            treeNode33.Text = "101 - 250";
            treeNode34.Name = "Nodo34";
            treeNode34.Text = "251 - 500";
            treeNode35.Name = "Nodo35";
            treeNode35.Text = "501 - 750";
            treeNode36.Name = "Nodo36";
            treeNode36.Text = "750 a más";
            treeNode37.Name = "Nodo31";
            treeNode37.Tag = "price";
            treeNode37.Text = "Precio";
            this.filterTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode31,
            treeNode37});
            this.filterTree.ShowPlusMinus = false;
            this.filterTree.ShowRootLines = false;
            this.filterTree.Size = new System.Drawing.Size(240, 447);
            this.filterTree.TabIndex = 0;
            this.filterTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.filterTree_AfterSelect);
            // 
            // btn_resetFilter
            // 
            this.btn_resetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_resetFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_resetFilter.FlatAppearance.BorderSize = 0;
            this.btn_resetFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_resetFilter.ForeColor = System.Drawing.Color.White;
            this.btn_resetFilter.Location = new System.Drawing.Point(5, 477);
            this.btn_resetFilter.Name = "btn_resetFilter";
            this.btn_resetFilter.Size = new System.Drawing.Size(240, 30);
            this.btn_resetFilter.TabIndex = 2;
            this.btn_resetFilter.Text = "Borrar Filtros";
            this.btn_resetFilter.UseVisualStyleBackColor = false;
            this.btn_resetFilter.Click += new System.EventHandler(this.resetFilter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtros de búsqueda:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(285, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 150);
            this.panel2.TabIndex = 3;
            // 
            // itemContainer
            // 
            this.itemContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemContainer.AutoScroll = true;
            this.itemContainer.BackColor = System.Drawing.Color.Silver;
            this.itemContainer.Location = new System.Drawing.Point(285, 276);
            this.itemContainer.Margin = new System.Windows.Forms.Padding(10);
            this.itemContainer.Name = "itemContainer";
            this.itemContainer.Size = new System.Drawing.Size(865, 349);
            this.itemContainer.TabIndex = 4;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 637);
            this.Controls.Add(this.itemContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel1);
            this.Name = "appForm";
            this.Text = "appForm";
            this.Load += new System.EventHandler(this.appForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_welcome;
        private PictureBox pictureBox2;
        private Panel sidePanel;
        private Panel panel2;
        private Label label1;
        private Button btn_resetFilter;
        private Panel panel4;
        private TreeView filterTree;
        private FlowLayoutPanel itemContainer;
        private PictureBox pictureBox3;
    }
}