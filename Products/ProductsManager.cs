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
    }
}
