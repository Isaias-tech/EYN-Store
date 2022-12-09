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
    }
}
