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
    public partial class ProductTypesManager : Form
    {
        public ProductTypesManager()
        {
            InitializeComponent();
        }

        private void ProductTypesManager_Load(object sender, EventArgs e)
        {
            dgv_type.DataSource = new DB_Data_ProductType().getProductTypes();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DB_Data_ProductType().getProductTypeBy("PT_Name", txt_search.Text);
                dgv_type.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["AddProductType"] as AddProductType) != null))
            {
                using (AddProductType ab = new AddProductType())
                {
                    ab.ShowDialog();
                }
                dgv_type.DataSource = new DB_Data_ProductType().getProductTypes();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["EditProductType"] as EditProductType) != null))
            {
                using (EditProductType ab = new EditProductType())
                {
                    ab.ShowDialog();
                }
                dgv_type.DataSource = new DB_Data_ProductType().getProductTypes();
            }
        }
    }
}
