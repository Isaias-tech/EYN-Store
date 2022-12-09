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
    public partial class AddProductType : Form
    {
        public AddProductType()
        {
            InitializeComponent();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0)
            {
                new DB_Data_ProductType().addProductType(new ProductType(txt_name.Text, txt_description.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
