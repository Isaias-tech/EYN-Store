namespace EYN_Store
{
    partial class Sign_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_In));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_sign_up = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sign_in = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2CirclePictureBox1.Image = global::EYN_Store.Properties.Resources.EYN___Ligth_blue_Logo;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, -56);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(331, 329);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_sign_up.BorderRadius = 5;
            this.btn_sign_up.BorderThickness = 2;
            this.btn_sign_up.CheckedState.Parent = this.btn_sign_up;
            this.btn_sign_up.CustomImages.Parent = this.btn_sign_up;
            this.btn_sign_up.FillColor = System.Drawing.Color.Transparent;
            this.btn_sign_up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_sign_up.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(112)))), ((int)(((byte)(193)))));
            this.btn_sign_up.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_sign_up.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(112)))), ((int)(((byte)(193)))));
            this.btn_sign_up.HoverState.Parent = this.btn_sign_up;
            this.btn_sign_up.Location = new System.Drawing.Point(17, 311);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.PressedColor = System.Drawing.Color.Blue;
            this.btn_sign_up.ShadowDecoration.Parent = this.btn_sign_up;
            this.btn_sign_up.Size = new System.Drawing.Size(145, 45);
            this.btn_sign_up.TabIndex = 6;
            this.btn_sign_up.Text = "Registrarme";
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.BorderRadius = 5;
            this.btn_sign_in.CheckedState.Parent = this.btn_sign_in;
            this.btn_sign_in.CustomImages.Parent = this.btn_sign_in;
            this.btn_sign_in.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_sign_in.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sign_in.ForeColor = System.Drawing.Color.White;
            this.btn_sign_in.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(112)))), ((int)(((byte)(193)))));
            this.btn_sign_in.HoverState.Parent = this.btn_sign_in;
            this.btn_sign_in.Location = new System.Drawing.Point(188, 311);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sign_in.ShadowDecoration.Parent = this.btn_sign_in;
            this.btn_sign_in.Size = new System.Drawing.Size(145, 45);
            this.btn_sign_in.TabIndex = 7;
            this.btn_sign_in.Text = "Iniciar Sesión";
            this.btn_sign_in.Click += new System.EventHandler(this.btn_sign_in_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña: ";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(13, 227);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(63, 19);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Usuario: ";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(113, 266);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(220, 26);
            this.txt_password.TabIndex = 4;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(113, 224);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(220, 26);
            this.txt_username.TabIndex = 2;
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(351, 371);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.btn_sign_up);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Sign_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_sign_up;
        private Guna.UI2.WinForms.Guna2Button btn_sign_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
    }
}