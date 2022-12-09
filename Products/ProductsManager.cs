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
    public partial class ProductsManager : Form
    {
        public ProductsManager()
        {
            InitializeComponent();
        }

        private void ProductsManager_Load(object sender, EventArgs e)
        {
            dgv_product.DataSource = new DB_Data_Products().getProducts();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DB_Data_Position().getPositionBy("P_Name", txt_search.Text);
                dgv_product.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["AddProduct"] as AddProduct) != null))
            {
                using ( AddProduct ab = new AddProduct())
                {
                    ab.ShowDialog();
                }
                dgv_product.DataSource = new DB_Data_Products().getProducts();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["EditProduct"] as EditProduct) != null))
            {
                using (EditProduct ab = new EditProduct())
                {
                    ab.ShowDialog();
                }
                dgv_product.DataSource = new DB_Data_Products().getProducts();
            }
        }

        private void dgv_product_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar este producto?", "¡Atención!", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                foreach (DataGridViewRow row in dgv_product.SelectedRows)
                {
                    new DB_Data_Products().deleteProduct(Convert.ToString(row.Cells[0].Value));
                    dgv_product.DataSource = new DB_Data_Products().getProducts();
                }
            }
        }
    }
}
