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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            cmb_provider.DataSource = new DB_Data_Provider().getProviders();
            cmb_provider.DisplayMember = "Nombre";
            cmb_provider.ValueMember = "ID";
            cmb_type.DataSource = new DB_Data_ProductType().getProductTypes();
            cmb_type.DisplayMember = "Nombre";
            cmb_type.ValueMember = "ID";
            cmb_branch.DataSource = new DB_Data_Branch().getBranchs();
            cmb_branch.DisplayMember = "Sucursal";
            cmb_branch.ValueMember = "ID";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_cost.Text.Length > 0 && txt_price.Text.Length > 0)
            {
                new DB_Data_Products().addProduct(new Products(txt_name.Text, txt_description.Text, Convert.ToInt32(cmb_type.SelectedValue.ToString()), Convert.ToInt32(cmb_provider.SelectedValue.ToString()), Convert.ToInt32(cmb_branch.SelectedValue.ToString()),Convert.ToDouble(txt_cost.Text), Convert.ToDouble(txt_price.Text), dtp_expiration_date.Value.ToString()));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
