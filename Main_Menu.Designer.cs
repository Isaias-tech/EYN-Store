namespace EYN_Store
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.btn_user_manager = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_products = new Guna.UI2.WinForms.Guna2Button();
            this.btn_services = new Guna.UI2.WinForms.Guna2Button();
            this.btn_employee_manager = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cart = new Guna.UI2.WinForms.Guna2Button();
            this.btn_invoice_manager = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_user_manager
            // 
            this.btn_user_manager.BorderColor = System.Drawing.Color.Cyan;
            this.btn_user_manager.BorderRadius = 5;
            this.btn_user_manager.BorderThickness = 2;
            this.btn_user_manager.CheckedState.Parent = this.btn_user_manager;
            this.btn_user_manager.CustomImages.Parent = this.btn_user_manager;
            this.btn_user_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_user_manager.FillColor = System.Drawing.Color.Transparent;
            this.btn_user_manager.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_manager.ForeColor = System.Drawing.Color.Cyan;
            this.btn_user_manager.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_user_manager.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_user_manager.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_user_manager.HoverState.Parent = this.btn_user_manager;
            this.btn_user_manager.Location = new System.Drawing.Point(3, 308);
            this.btn_user_manager.Name = "btn_user_manager";
            this.btn_user_manager.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_user_manager.ShadowDecoration.Parent = this.btn_user_manager;
            this.btn_user_manager.Size = new System.Drawing.Size(365, 60);
            this.btn_user_manager.TabIndex = 0;
            this.btn_user_manager.Text = "Manejador de usuarios";
            this.btn_user_manager.Click += new System.EventHandler(this.btn_user_manager_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_user_manager, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_products, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_services, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_employee_manager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_cart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_invoice_manager, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(429, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 371);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(800, 371);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // btn_products
            // 
            this.btn_products.BorderColor = System.Drawing.Color.Cyan;
            this.btn_products.BorderRadius = 5;
            this.btn_products.BorderThickness = 2;
            this.btn_products.CheckedState.Parent = this.btn_products;
            this.btn_products.CustomImages.Parent = this.btn_products;
            this.btn_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_products.FillColor = System.Drawing.Color.Transparent;
            this.btn_products.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.Cyan;
            this.btn_products.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_products.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_products.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_products.HoverState.Parent = this.btn_products;
            this.btn_products.Location = new System.Drawing.Point(3, 3);
            this.btn_products.Name = "btn_products";
            this.btn_products.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_products.ShadowDecoration.Parent = this.btn_products;
            this.btn_products.Size = new System.Drawing.Size(365, 55);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Productos";
            // 
            // btn_services
            // 
            this.btn_services.BorderColor = System.Drawing.Color.Cyan;
            this.btn_services.BorderRadius = 5;
            this.btn_services.BorderThickness = 2;
            this.btn_services.CheckedState.Parent = this.btn_services;
            this.btn_services.CustomImages.Parent = this.btn_services;
            this.btn_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_services.FillColor = System.Drawing.Color.Transparent;
            this.btn_services.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_services.ForeColor = System.Drawing.Color.Cyan;
            this.btn_services.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_services.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_services.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_services.HoverState.Parent = this.btn_services;
            this.btn_services.Location = new System.Drawing.Point(3, 64);
            this.btn_services.Name = "btn_services";
            this.btn_services.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_services.ShadowDecoration.Parent = this.btn_services;
            this.btn_services.Size = new System.Drawing.Size(365, 55);
            this.btn_services.TabIndex = 2;
            this.btn_services.Text = "Servicios";
            // 
            // btn_employee_manager
            // 
            this.btn_employee_manager.BorderColor = System.Drawing.Color.Cyan;
            this.btn_employee_manager.BorderRadius = 5;
            this.btn_employee_manager.BorderThickness = 2;
            this.btn_employee_manager.CheckedState.Parent = this.btn_employee_manager;
            this.btn_employee_manager.CustomImages.Parent = this.btn_employee_manager;
            this.btn_employee_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_employee_manager.FillColor = System.Drawing.Color.Transparent;
            this.btn_employee_manager.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee_manager.ForeColor = System.Drawing.Color.Cyan;
            this.btn_employee_manager.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_employee_manager.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_employee_manager.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_employee_manager.HoverState.Parent = this.btn_employee_manager;
            this.btn_employee_manager.Location = new System.Drawing.Point(3, 125);
            this.btn_employee_manager.Name = "btn_employee_manager";
            this.btn_employee_manager.ShadowDecoration.Parent = this.btn_employee_manager;
            this.btn_employee_manager.Size = new System.Drawing.Size(365, 55);
            this.btn_employee_manager.TabIndex = 3;
            this.btn_employee_manager.Text = "Manejador de empleados";
            this.btn_employee_manager.Click += new System.EventHandler(this.btn_employee_manager_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.BorderColor = System.Drawing.Color.Cyan;
            this.btn_cart.BorderRadius = 5;
            this.btn_cart.BorderThickness = 2;
            this.btn_cart.CheckedState.Parent = this.btn_cart;
            this.btn_cart.CustomImages.Parent = this.btn_cart;
            this.btn_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cart.FillColor = System.Drawing.Color.Transparent;
            this.btn_cart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.ForeColor = System.Drawing.Color.Cyan;
            this.btn_cart.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cart.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_cart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cart.HoverState.Parent = this.btn_cart;
            this.btn_cart.Location = new System.Drawing.Point(3, 186);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.ShadowDecoration.Parent = this.btn_cart;
            this.btn_cart.Size = new System.Drawing.Size(365, 55);
            this.btn_cart.TabIndex = 4;
            this.btn_cart.Text = "Carrito";
            // 
            // btn_invoice_manager
            // 
            this.btn_invoice_manager.BorderColor = System.Drawing.Color.Cyan;
            this.btn_invoice_manager.BorderRadius = 5;
            this.btn_invoice_manager.BorderThickness = 2;
            this.btn_invoice_manager.CheckedState.Parent = this.btn_invoice_manager;
            this.btn_invoice_manager.CustomImages.Parent = this.btn_invoice_manager;
            this.btn_invoice_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_invoice_manager.FillColor = System.Drawing.Color.Transparent;
            this.btn_invoice_manager.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice_manager.ForeColor = System.Drawing.Color.Cyan;
            this.btn_invoice_manager.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_invoice_manager.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_invoice_manager.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_invoice_manager.HoverState.Parent = this.btn_invoice_manager;
            this.btn_invoice_manager.Location = new System.Drawing.Point(3, 247);
            this.btn_invoice_manager.Name = "btn_invoice_manager";
            this.btn_invoice_manager.ShadowDecoration.Parent = this.btn_invoice_manager;
            this.btn_invoice_manager.Size = new System.Drawing.Size(365, 55);
            this.btn_invoice_manager.TabIndex = 5;
            this.btn_invoice_manager.Text = "Manejador de facturas";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::EYN_Store.Properties.Resources.EYN___Ligth_blue_Logo___No_BG;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(429, 371);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Menu";
            this.Text = "EYN - Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_user_manager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_products;
        private Guna.UI2.WinForms.Guna2Button btn_services;
        private Guna.UI2.WinForms.Guna2Button btn_employee_manager;
        private Guna.UI2.WinForms.Guna2Button btn_cart;
        private Guna.UI2.WinForms.Guna2Button btn_invoice_manager;
    }
}