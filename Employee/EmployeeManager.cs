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
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            InitializeComponent();
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            dgv_employee.DataSource = new DB_Data_Employee().getEmployees();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DB_Data_Employee().getEmployeeBy("U_UserName", txt_search.Text);
                dgv_employee.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }

        private void dgv_employee_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar este empleado?", "¡Atención!", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                foreach (DataGridViewRow row in dgv_employee.SelectedRows)
                {
                    dgv_employee.DataSource = new DB_Data_Employee().deleteEmployee(Convert.ToString(row.Cells[0].Value));
                }
            }
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            using (AddEmployee ae = new AddEmployee())
            {
                ae.ShowDialog();
            }
            dgv_employee.DataSource = new DB_Data_Employee().getEmployees();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            var cells = dgv_employee.SelectedRows[0].Cells;
            if (Convert.ToString(cells[0].Value).Length > 0)
            {
                if (!((Application.OpenForms["SueldoNeto_Empleado"] as SueldoNeto_Empleado) != null))
                {
                    Employee u = new Employee(Convert.ToInt32(cells[1].Value), Convert.ToString(cells[3].Value), cells[4].Value.ToString(), Convert.ToInt32(cells[5].Value), Convert.ToInt32(cells[6].Value));
                    Program.selectedEmployee = u;
                    SueldoNeto_Empleado sne = new SueldoNeto_Empleado();
                    sne.Show();
                }
            }
        }
    }
}
