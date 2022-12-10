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
        public EditProduct()
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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if ()
            {
                if ()
                {
                    new DB_Data_Products();
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
