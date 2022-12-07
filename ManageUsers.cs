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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            dgv_data.DataSource = new DB_Data_Users().GetUsers();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DB_Data_Users().GetUserBy("U_Name", txt_search.Text);
                dgv_data.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }
    }
}
