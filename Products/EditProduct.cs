using EYN_Store.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    public partial class EditProduct : Form
    {
        private string ID;
        private string productName;
        private string productDescription;
        private string productCost;
        private string productPrice;
        private string productType;
        private string productProvider;
        private string productBranch;
        private string ExpirationDate;

        public EditProduct(string id, string pName, string pDescription, string pCost, string pPrice, string pType, string pProvider, string pBranch, string expirationDate)
        {
            InitializeComponent();
            cmb_provider.DataSource = new DB_Data_Provider().getProviders();
            cmb_provider.DisplayMember = "Nombre";
            cmb_provider.ValueMember = "ID";
            cmb_type.DataSource = new DB_Data_ProductType().getProductTypes();
            cmb_type.DisplayMember = "Nombre";
            cmb_type.ValueMember = "ID";
            cmb_branch.DataSource = new DB_Data_Branch().getBranchs();
            cmb_branch.DisplayMember = "Sucursal";
            cmb_branch.ValueMember = "ID";
            ID= id;
            productName= pName;
            productDescription= pDescription;
            productCost= pCost;
            productPrice= pPrice;
            productType= pType;
            productProvider= pProvider;
            productBranch= pBranch;
            ExpirationDate = expirationDate;
            txt_name.Text = pName;
            txt_description.Text = pDescription;
            txt_cost.Text = pCost;
            txt_price.Text = pPrice;
            cmb_type.SelectedIndex= cmb_type.FindStringExact(pType);
            cmb_provider.SelectedIndex = cmb_provider.FindStringExact(pProvider);
            cmb_branch.SelectedIndex = cmb_branch.FindStringExact(pBranch);
            txt_date.Text = expirationDate;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != productName || txt_description.Text != productDescription || txt_cost.Text != productCost || txt_price.Text != productPrice || txt_date.Text != ExpirationDate || cmb_type.SelectedText.ToString() != productType || cmb_provider.SelectedText.ToString() != productProvider || cmb_branch.SelectedText.ToString() != productBranch)
            {
                if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_cost.Text.Length > 0 && txt_price.Text.Length > 0 && txt_date.Text.Length > 0)
                {
                    new DB_Data_Products().updateProduct(ID, new Products(txt_name.Text, txt_description.Text, Convert.ToInt32(cmb_type.SelectedValue.ToString()), Convert.ToInt32(cmb_provider.SelectedValue.ToString()), Convert.ToInt32(cmb_branch.SelectedValue.ToString()), Convert.ToDouble(txt_cost.Text), Convert.ToDouble(txt_price.Text), txt_date.Text));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Todos los campos deben ser completados. ");
                }
            }
            else
            {
                MessageBox.Show("Debe de generar al menos un cambio");
            }
        }
    }
}
