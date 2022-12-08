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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_user_manager_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void btn_employee_manager_Click(object sender, EventArgs e)
        {
            EmployeeManager em = new EmployeeManager();
            em.Show();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            ProductsManager pm = new ProductsManager();
            pm.Show();
        }

        private void btn_invoice_manager_Click(object sender, EventArgs e)
        {
            InvoiceManager im = new InvoiceManager();
            im.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProductTypesManager pm = new ProductTypesManager();
            pm.Show();
        }

        private void btn_branch_manager_Click(object sender, EventArgs e)
        {
            BranchManager bm = new BranchManager();
            bm.Show();
        }

        private void btn_position_manager_Click(object sender, EventArgs e)
        {
            PositionsManager pm = new PositionsManager();
            pm.Show();
        }
    }
}
