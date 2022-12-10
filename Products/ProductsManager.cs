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
                var cells = dgv_product.SelectedRows[0].Cells;
                using (EditProduct ab = new EditProduct(Convert.ToString(cells[0].Value), Convert.ToString(cells[1].Value), Convert.ToString(cells[2].Value), Convert.ToString(cells[6].Value), Convert.ToString(cells[7].Value), Convert.ToString(cells[3].Value), Convert.ToString(cells[4].Value), Convert.ToString(cells[5].Value), Convert.ToString(cells[8].Value)))
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
