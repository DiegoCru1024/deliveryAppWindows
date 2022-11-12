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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calzado");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Camisas");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Camisetas y Polos");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pantalones");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Poleras y Sudaderas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Categorías", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Adidas");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Converse");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Gotcha");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("John Holdens");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Levi\'s");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Navigata");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("New Balance");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Nike");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Puma");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Reebok");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Under Armor");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Woallance");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Marca", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("0 - 100");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("101 - 250");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("251 - 500");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("500 a más");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Precio", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuFiltro = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_borrarFiltros = new System.Windows.Forms.Button();
            this.itemsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 120);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1102, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1182, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delivery App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
          
            // 
            // menuFiltro
            // 
            this.menuFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuFiltro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuFiltro.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuFiltro.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.menuFiltro.Location = new System.Drawing.Point(30, 150);
            this.menuFiltro.Name = "menuFiltro";
            treeNode1.Name = "Nodo3";
            treeNode1.Text = "Calzado";
            treeNode2.Name = "Nodo4";
            treeNode2.Text = "Camisas";
            treeNode3.Name = "Nodo5";
            treeNode3.Text = "Camisetas y Polos";
            treeNode4.Name = "Nodo0";
            treeNode4.Text = "Pantalones";
            treeNode5.Name = "Nodo12";
            treeNode5.Text = "Poleras y Sudaderas";
            treeNode6.ForeColor = System.Drawing.Color.Black;
            treeNode6.Name = "Categorías";
            treeNode6.Text = "Categorías";
            treeNode7.Name = "Nodo6";
            treeNode7.Text = "Adidas";
            treeNode8.Name = "Nodo7";
            treeNode8.Text = "Converse";
            treeNode9.Name = "Nodo21";
            treeNode9.Text = "Gotcha";
            treeNode10.Name = "Nodo19";
            treeNode10.Text = "John Holdens";
            treeNode11.Name = "Nodo20";
            treeNode11.Text = "Levi\'s";
            treeNode12.Name = "Nodo17";
            treeNode12.Text = "Navigata";
            treeNode13.Name = "Nodo8";
            treeNode13.Text = "New Balance";
            treeNode14.Name = "Nodo13";
            treeNode14.Text = "Nike";
            treeNode15.Name = "Nodo15";
            treeNode15.Text = "Puma";
            treeNode16.Name = "Nodo14";
            treeNode16.Text = "Reebok";
            treeNode17.Name = "Nodo22";
            treeNode17.Text = "Under Armor";
            treeNode18.Name = "Nodo16";
            treeNode18.Text = "Woallance";
            treeNode19.Name = "Nodo1";
            treeNode19.Text = "Marca";
            treeNode20.Name = "Nodo9";
            treeNode20.Text = "0 - 100";
            treeNode21.Name = "Nodo10";
            treeNode21.Text = "101 - 250";
            treeNode22.Name = "Nodo11";
            treeNode22.Text = "251 - 500";
            treeNode23.Name = "Nodo18";
            treeNode23.Text = "500 a más";
            treeNode24.Name = "Nodo2";
            treeNode24.Text = "Precio";
            this.menuFiltro.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode19,
            treeNode24});
            this.menuFiltro.ShowRootLines = false;
            this.menuFiltro.Size = new System.Drawing.Size(200, 500);
            this.menuFiltro.TabIndex = 1;
            this.menuFiltro.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuFiltro_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(250, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 100);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(710, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(200, 80);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(490, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 80);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(50, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 80);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(270, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 80);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btn_borrarFiltros
            // 
            this.btn_borrarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_borrarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_borrarFiltros.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_borrarFiltros.ForeColor = System.Drawing.Color.White;
            this.btn_borrarFiltros.Location = new System.Drawing.Point(55, 600);
            this.btn_borrarFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.btn_borrarFiltros.Name = "btn_borrarFiltros";
            this.btn_borrarFiltros.Size = new System.Drawing.Size(150, 40);
            this.btn_borrarFiltros.TabIndex = 3;
            this.btn_borrarFiltros.Text = "Borrar Filtros";
            this.btn_borrarFiltros.UseVisualStyleBackColor = false;
            this.btn_borrarFiltros.Click += new System.EventHandler(this.btn_borrarFiltros_Click);
            // 
            // itemsContainer
            // 
            this.itemsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsContainer.AutoScroll = true;
            this.itemsContainer.Location = new System.Drawing.Point(250, 270);
            this.itemsContainer.Name = "itemsContainer";
            this.itemsContainer.Size = new System.Drawing.Size(980, 380);
            this.itemsContainer.TabIndex = 4;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.itemsContainer);
            this.Controls.Add(this.btn_borrarFiltros);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuFiltro);
            this.Controls.Add(this.panel1);
            this.Name = "appForm";
            this.Text = "Delivery App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private TreeView menuFiltro;
        private Panel panel2;
        private Button btn_borrarFiltros;
        private FlowLayoutPanel itemsContainer;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}