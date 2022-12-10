namespace EYN_Store
{
    partial class GenerateInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateInvoice));
            this.dgv_cart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_generate_invoice = new Guna.UI2.WinForms.Guna2Button();
            this.txt_total_payment = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_employee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_branch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_product = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_payment_method = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_cart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cart.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cart.ColumnHeadersHeight = 25;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cart.EnableHeadersVisualStyles = false;
            this.dgv_cart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_cart.Location = new System.Drawing.Point(1, 200);
            this.dgv_cart.MultiSelect = false;
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.ReadOnly = true;
            this.dgv_cart.RowHeadersVisible = false;
            this.dgv_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cart.Size = new System.Drawing.Size(1476, 150);
            this.dgv_cart.TabIndex = 0;
            this.dgv_cart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_cart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_cart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_cart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_cart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_cart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_cart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_cart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_cart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_cart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_cart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_cart.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_cart.ThemeStyle.ReadOnly = true;
            this.dgv_cart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_cart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_cart.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_cart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_cart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_generate_invoice
            // 
            this.btn_generate_invoice.BorderRadius = 5;
            this.btn_generate_invoice.CheckedState.Parent = this.btn_generate_invoice;
            this.btn_generate_invoice.CustomImages.Parent = this.btn_generate_invoice;
            this.btn_generate_invoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_generate_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_generate_invoice.HoverState.Parent = this.btn_generate_invoice;
            this.btn_generate_invoice.Location = new System.Drawing.Point(21, 393);
            this.btn_generate_invoice.Name = "btn_generate_invoice";
            this.btn_generate_invoice.ShadowDecoration.Parent = this.btn_generate_invoice;
            this.btn_generate_invoice.Size = new System.Drawing.Size(180, 45);
            this.btn_generate_invoice.TabIndex = 1;
            this.btn_generate_invoice.Text = "Generar factura";
            this.btn_generate_invoice.Click += new System.EventHandler(this.btn_generate_invoice_Click);
            // 
            // txt_total_payment
            // 
            this.txt_total_payment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_total_payment.DefaultText = "";
            this.txt_total_payment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_total_payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_total_payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total_payment.DisabledState.Parent = this.txt_total_payment;
            this.txt_total_payment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total_payment.Enabled = false;
            this.txt_total_payment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_total_payment.FocusedState.Parent = this.txt_total_payment;
            this.txt_total_payment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_total_payment.HoverState.Parent = this.txt_total_payment;
            this.txt_total_payment.Location = new System.Drawing.Point(1193, 393);
            this.txt_total_payment.Name = "txt_total_payment";
            this.txt_total_payment.PasswordChar = '\0';
            this.txt_total_payment.PlaceholderText = "Pago total";
            this.txt_total_payment.SelectedText = "";
            this.txt_total_payment.ShadowDecoration.Parent = this.txt_total_payment;
            this.txt_total_payment.Size = new System.Drawing.Size(200, 36);
            this.txt_total_payment.TabIndex = 2;
            // 
            // cmb_employee
            // 
            this.cmb_employee.BackColor = System.Drawing.Color.Transparent;
            this.cmb_employee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_employee.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_employee.FocusedState.Parent = this.cmb_employee;
            this.cmb_employee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_employee.FormattingEnabled = true;
            this.cmb_employee.HoverState.Parent = this.cmb_employee;
            this.cmb_employee.ItemHeight = 30;
            this.cmb_employee.ItemsAppearance.Parent = this.cmb_employee;
            this.cmb_employee.Location = new System.Drawing.Point(419, 112);
            this.cmb_employee.Name = "cmb_employee";
            this.cmb_employee.ShadowDecoration.Parent = this.cmb_employee;
            this.cmb_employee.Size = new System.Drawing.Size(281, 36);
            this.cmb_employee.TabIndex = 3;
            // 
            // cmb_branch
            // 
            this.cmb_branch.BackColor = System.Drawing.Color.Transparent;
            this.cmb_branch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_branch.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_branch.FocusedState.Parent = this.cmb_branch;
            this.cmb_branch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.HoverState.Parent = this.cmb_branch;
            this.cmb_branch.ItemHeight = 30;
            this.cmb_branch.ItemsAppearance.Parent = this.cmb_branch;
            this.cmb_branch.Location = new System.Drawing.Point(739, 112);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.ShadowDecoration.Parent = this.cmb_branch;
            this.cmb_branch.Size = new System.Drawing.Size(299, 36);
            this.cmb_branch.TabIndex = 4;
            // 
            // cmb_product
            // 
            this.cmb_product.BackColor = System.Drawing.Color.Transparent;
            this.cmb_product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_product.FocusedState.Parent = this.cmb_product;
            this.cmb_product.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.HoverState.Parent = this.cmb_product;
            this.cmb_product.ItemHeight = 30;
            this.cmb_product.ItemsAppearance.Parent = this.cmb_product;
            this.cmb_product.Location = new System.Drawing.Point(1079, 112);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.ShadowDecoration.Parent = this.cmb_product;
            this.cmb_product.Size = new System.Drawing.Size(314, 36);
            this.cmb_product.TabIndex = 5;
            // 
            // txt_payment_method
            // 
            this.txt_payment_method.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_payment_method.DefaultText = "";
            this.txt_payment_method.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_payment_method.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_payment_method.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_payment_method.DisabledState.Parent = this.txt_payment_method;
            this.txt_payment_method.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_payment_method.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_payment_method.FocusedState.Parent = this.txt_payment_method;
            this.txt_payment_method.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_payment_method.HoverState.Parent = this.txt_payment_method;
            this.txt_payment_method.Location = new System.Drawing.Point(21, 112);
            this.txt_payment_method.Name = "txt_payment_method";
            this.txt_payment_method.PasswordChar = '\0';
            this.txt_payment_method.PlaceholderText = "Metodo de pago";
            this.txt_payment_method.SelectedText = "";
            this.txt_payment_method.ShadowDecoration.Parent = this.txt_payment_method;
            this.txt_payment_method.Size = new System.Drawing.Size(331, 36);
            this.txt_payment_method.TabIndex = 6;
            // 
            // GenerateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 450);
            this.Controls.Add(this.txt_payment_method);
            this.Controls.Add(this.cmb_product);
            this.Controls.Add(this.cmb_branch);
            this.Controls.Add(this.cmb_employee);
            this.Controls.Add(this.txt_total_payment);
            this.Controls.Add(this.btn_generate_invoice);
            this.Controls.Add(this.dgv_cart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenerateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EYN -  Generar factura";
            this.Load += new System.EventHandler(this.GenerateInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_cart;
        private Guna.UI2.WinForms.Guna2Button btn_generate_invoice;
        private Guna.UI2.WinForms.Guna2TextBox txt_total_payment;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_employee;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_branch;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_product;
        private Guna.UI2.WinForms.Guna2TextBox txt_payment_method;
    }
}