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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            DataTable dt = new DB_Data_Users().GetUsers($"SELECT * FROM Users WHERE U_UserName='{txt_username.Text}' AND U_Password='{txt_password.Text}'");
            if (dt.Rows.Count > 0)
            {
                Program.CurrentUser = new User(
                    Convert.ToInt32(dt.Rows[0][0]),
                    Convert.ToString(dt.Rows[0][1]),
                    Convert.ToString(dt.Rows[0][2]),
                    Convert.ToString(dt.Rows[0][3]),
                    Convert.ToString(dt.Rows[0][4]),
                    Convert.ToString(dt.Rows[0][5]),
                    Convert.ToString(dt.Rows[0][6]),
                    Convert.ToBoolean(dt.Rows[0][7]),
                    Convert.ToString(dt.Rows[0][8])
                    );
                Main_Menu main_Menu = new Main_Menu();
                main_Menu.Show();
                this.Hide();
                txt_username.Clear();
                txt_password.Clear();
            }
            else
            {
                MessageBox.Show("Los datos ingresados estan incompletos o incorrectos.", "¡Error!");
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_sign_in.PerformClick();
            }
        }
    }
}
