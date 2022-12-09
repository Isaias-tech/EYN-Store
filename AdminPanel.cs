using EYN_Store.Provider;
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
            if (!((Application.OpenForms["ManageUsers"] as ManageUsers) != null))
            {
                ManageUsers manageUsers = new ManageUsers();
                manageUsers.Show();
            }
        }

        private void btn_employee_manager_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["EmployeeManager"] as EmployeeManager) != null))
            {
                EmployeeManager em = new EmployeeManager();
                em.Show();
            }
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["ProductsManager"] as ProductsManager) != null))
            {
                ProductsManager pm = new ProductsManager();
                pm.Show();
            }
        }

        private void btn_invoice_manager_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["InvoiceManager"] as InvoiceManager) != null))
            {
                InvoiceManager im = new InvoiceManager();
                im.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["ProductTypesManager"] as ProductTypesManager) != null))
            {
                ProductTypesManager pm = new ProductTypesManager();
                pm.Show();
            }
        }

        private void btn_branch_manager_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["BranchManager"] as BranchManager) != null))
            {
                BranchManager bm = new BranchManager();
                bm.Show();
            }
        }

        private void btn_position_manager_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["PositionsManager"] as PositionsManager) != null))
            {
                PositionsManager pm = new PositionsManager();
                pm.Show();
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
                if (f.Name != "Sign_In" && f.Name != "ClientProducts" && f.Name != "Cart" && f.Name != "GenerateInvoice" && f.Name != "AdminPanel" && f.Name != "Main_Menu") f.Close();
        }

        private void btn_providers_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["ProviderManager"] as ProviderManager) != null))
            {
                ProviderManager pm = new ProviderManager();
                pm.Show();
            }
        }
    }
}
