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

        private void Sign_Up_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv_data.DataSource = new DB_Data_Users().GetUsers();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
            sign_Up.FormClosing += Sign_Up_FormClosing;
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

        private void EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv_data.DataSource = new DB_Data_Users().GetUsers();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_data.SelectedRows.Count == 1)
            {
                var cells = dgv_data.SelectedRows[0].Cells;
                EditUser eu = new EditUser(Convert.ToString(cells[0].Value), Convert.ToString(cells[1].Value), Convert.ToString(cells[2].Value), Convert.ToString(cells[3].Value), Convert.ToString(cells[4].Value), Convert.ToString(cells[5].Value));
                eu.Show();
                eu.FormClosing += EditUser_FormClosing;
            }
            else
            {
                MessageBox.Show("Para editar debe seleccionar 1 fila.", "Ateción");
            }
        }

        private void dgv_data_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar este usuario?", "¡Atención!", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                foreach (DataGridViewRow row in dgv_data.SelectedRows)
                {
                    dgv_data.DataSource = new DB_Data_Users().DeleteUser(Convert.ToString(row.Cells[0].Value));
                }
            }
        }
    }
}
