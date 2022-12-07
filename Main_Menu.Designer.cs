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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_user_manager
            // 
            this.btn_user_manager.CheckedState.Parent = this.btn_user_manager;
            this.btn_user_manager.CustomImages.Parent = this.btn_user_manager;
            this.btn_user_manager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_user_manager.ForeColor = System.Drawing.Color.White;
            this.btn_user_manager.HoverState.Parent = this.btn_user_manager;
            this.btn_user_manager.Location = new System.Drawing.Point(551, 218);
            this.btn_user_manager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_user_manager.Name = "btn_user_manager";
            this.btn_user_manager.ShadowDecoration.Parent = this.btn_user_manager;
            this.btn_user_manager.Size = new System.Drawing.Size(240, 55);
            this.btn_user_manager.TabIndex = 0;
            this.btn_user_manager.Text = "Manegador de usuarios";
            this.btn_user_manager.Click += new System.EventHandler(this.btn_user_manager_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(205, 218);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(213, 55);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_user_manager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Menu";
            this.Text = "EYN - Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_user_manager;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}