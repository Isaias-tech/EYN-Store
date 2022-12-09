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
    public partial class InvoiceManager : Form
    {
        public InvoiceManager()
        {
            InitializeComponent();
        }

        private void InvoiceManager_Load(object sender, EventArgs e)
        {
            dgv_invoice.DataSource = new DB_Data_Invoice().getInvoices();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DB_Data_Invoice().getInvoiceBy("Users.U_UserName", txt_search.Text);
                dgv_invoice.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["InvoiceDetails"] as InvoiceDetails) != null))
            {
                using (InvoiceDetails invoiceDetails = new InvoiceDetails())
                {
                    invoiceDetails.ShowDialog();
                }
                dgv_invoice.DataSource = new DB_Data_Invoice().getInvoices();
            }
        }
    }
}
