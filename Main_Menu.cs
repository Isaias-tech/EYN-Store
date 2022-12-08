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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "¡Atención!", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                Program.sign_in.Show();
                Program.CurrentUser = new User();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_user_manager_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            if (!Program.CurrentUser.Task_IsAdmin) btn_user_manager.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SueldoNeto_Empleado sueldoempleado = new SueldoNeto_Empleado();
            sueldoempleado.Show();
        }

        private void btn_employee_manager_Click(object sender, EventArgs e)
        {
            EmployeeManager em = new EmployeeManager();
            em.Show();
        }
    }
}
