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
    public partial class GenerateInvoice : Form
    {
        public GenerateInvoice()
        {
            InitializeComponent();
        }

        private void GenerateInvoice_Load(object sender, EventArgs e)
        {
            dgv_cart.DataSource = new DB_Data_Products().getProductsMultipleWhere();
            cmb_employee.DataSource = new DB_Data_Employee().getEmployees();
            cmb_employee.DisplayMember = "Nombre de usuario";
            cmb_employee.ValueMember = "ID";
            cmb_product.DataSource = new DB_Data_Products().getProducts();
            cmb_product.DisplayMember = "Nombre";
            cmb_product.ValueMember = "ID";
            cmb_branch.DataSource = new DB_Data_Branch().getBranchs();
            cmb_branch.DisplayMember = "Sucursal";
            cmb_branch.ValueMember = "ID";
            double oc = 0;
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                oc += Convert.ToDouble(row.Cells[7].Value);
            }
            txt_total_payment.Text = oc.ToString();
        }

        private void btn_generate_invoice_Click(object sender, EventArgs e)
        {
            if (txt_payment_method.Text.Length > 0)
            {
                new DB_Data_Invoice().addInvoice(new Invoice(Convert.ToInt32(cmb_employee.SelectedValue), Convert.ToInt32(cmb_branch.SelectedValue), "",Convert.ToDouble(txt_total_payment.Text), txt_payment_method.Text, Convert.ToInt32(cmb_product.SelectedValue)));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
