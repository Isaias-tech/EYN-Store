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
                DataTable dt = new DB_Data_Employee().getEmployeeBy("E_Identification", txt_search.Text);
                dgv_employee.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }

        private void dgv_employee_DoubleClick(object sender, EventArgs e)
        {
            var cells = dgv_employee.SelectedRows[0].Cells;
            Program.selectedEmployee = new Employee(Convert.ToInt32(cells[0].Value), Convert.ToInt32(cells[1].Value), cells[2].Value.ToString(), cells[3].Value.ToString(), Convert.ToInt32(cells[4].Value), Convert.ToInt32(cells[5].Value), Convert.ToString(cells[6].Value));
            SueldoNeto_Empleado sne = new SueldoNeto_Empleado();
            sne.Show();
        }
    }
}
