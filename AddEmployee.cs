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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            cmb_users.DataSource = new DB_Data_Users().GetUsers();
            cmb_users.DisplayMember = "Nombre de usuario";
            cmb_users.ValueMember = "ID";
            cmb_position.DataSource = new DB_Data_Position().getPositions();
            cmb_position.DisplayMember = "Nombre";
            cmb_position.ValueMember = "ID";
            cmb_branch.DataSource = new DB_Data_Branch().getBranchs();
            cmb_branch.DisplayMember = "Sucursal";
            cmb_branch.ValueMember = "ID";
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            if (txt_direction.Text.Length > 0 && txt_identification.Text.Length > 0)
            {
                new DB_Data_Employee().addEmployee(new Employee(Convert.ToInt32(cmb_users.SelectedValue), txt_direction.Text, txt_identification.Text, Convert.ToInt32(cmb_position.SelectedValue), Convert.ToInt32(cmb_branch.SelectedValue)));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
