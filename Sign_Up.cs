using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_lastname.Text.Length > 0 && txt_password.Text.Length > 0 && txt_email.Text.Length > 0 && txt_phone.Text.Length > 0 && txt_username.Text.Length > 0)
            {
                new DB_Data_Users().AddUser(new User(txt_name.Text, txt_lastname.Text, txt_password.Text, txt_email.Text, txt_phone.Text, txt_username.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
