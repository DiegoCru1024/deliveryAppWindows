namespace deliveryApp
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delivery App\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(150, 340);
            this.txt_user.MinimumSize = new System.Drawing.Size(200, 30);
            this.txt_user.Name = "txt_user";
            this.txt_user.PlaceholderText = "Ingrese su usuario...";
            this.txt_user.Size = new System.Drawing.Size(200, 30);
            this.txt_user.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 300);
            this.label2.MinimumSize = new System.Drawing.Size(120, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 380);
            this.label3.MinimumSize = new System.Drawing.Size(150, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(150, 420);
            this.txt_pass.MinimumSize = new System.Drawing.Size(200, 30);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PlaceholderText = "Ingrese su contraseña...";
            this.txt_pass.Size = new System.Drawing.Size(200, 30);
            this.txt_pass.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(175, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(175, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(482, 673);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_user;
        private Label label2;
        private Label label3;
        private TextBox txt_pass;
        private Button button1;
        private Button button2;
    }
}