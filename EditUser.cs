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
    public partial class EditUser : Form
    {
        private User u;

        public EditUser(string name, string lastname, string password, string email, string phone, string username)
        {
            InitializeComponent();
            this.u = new User(name, lastname, password, email,phone,username);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            txt_name.Text = this.u.Task_Name;
            txt_lastname.Text = this.u.Task_LastName; 
            txt_password.Text = this.u.Task_Password; 
            txt_email.Text = this.u.Task_Email; 
            txt_phone.Text = this.u.Task_PhoneNumber; 
            txt_username.Text = this.u.Task_UserName;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != this.u.Task_Name || txt_lastname.Text != this.u.Task_LastName || txt_password.Text != this.u.Task_Password || txt_email.Text != this.u.Task_Email || txt_phone.Text != this.u.Task_Password || txt_username.Text != this.u.Task_UserName)
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
            else
            {
                MessageBox.Show("Debe de generar al menos un cambio");
            }
        }
    }
}
