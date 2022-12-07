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
            this.SuspendLayout();
            // 
            // btn_user_manager
            // 
            this.btn_user_manager.CheckedState.Parent = this.btn_user_manager;
            this.btn_user_manager.CustomImages.Parent = this.btn_user_manager;
            this.btn_user_manager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_user_manager.ForeColor = System.Drawing.Color.White;
            this.btn_user_manager.HoverState.Parent = this.btn_user_manager;
            this.btn_user_manager.Location = new System.Drawing.Point(413, 177);
            this.btn_user_manager.Name = "btn_user_manager";
            this.btn_user_manager.ShadowDecoration.Parent = this.btn_user_manager;
            this.btn_user_manager.Size = new System.Drawing.Size(180, 45);
            this.btn_user_manager.TabIndex = 0;
            this.btn_user_manager.Text = "Manegador de usuarios";
            this.btn_user_manager.Click += new System.EventHandler(this.btn_user_manager_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_user_manager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.Text = "EYN - Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_user_manager;
    }
}