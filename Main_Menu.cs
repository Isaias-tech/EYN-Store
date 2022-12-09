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
            if (!((Application.OpenForms["AdminPanel"] as AdminPanel) != null))
            {
                AdminPanel ap = new AdminPanel();
                ap.Show();
            }
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            if (!Program.CurrentUser.Task_IsAdmin) btn_admin_panel.Visible = false;
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["ClientProducts"] as ClientProducts) != null))
            {
                ClientProducts cp = new ClientProducts();
                cp.Show();
            }
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["Cart"] as Cart) != null))
            {
                Cart cart = new Cart();
                cart.Show();
            }
        }

        private void btn_invoice_manager_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["GenerateInvoice"] as GenerateInvoice) != null))
            {
                GenerateInvoice generateInvoice = new GenerateInvoice();
                generateInvoice.Show();
            }
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
                if (f.Name != "Sign_In") f.Close();
        }
    }
}
