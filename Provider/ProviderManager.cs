using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store.Provider
{
    public partial class ProviderManager : Form
    {
        public ProviderManager()
        {
            InitializeComponent();
        }

        private void ProviderManager_Load(object sender, EventArgs e)
        {
            dgv_provider.DataSource = new DB_Data_Provider().getProviders();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["AddProvider"] as AddProvider) != null))
            {
                using (AddProvider ab = new AddProvider())
                {
                    ab.ShowDialog();
                }
                dgv_provider.DataSource = new DB_Data_Provider().getProviders();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["EditProvider"] as EditProvider) != null))
            {
                var cells = dgv_provider.SelectedRows[0].Cells;
                using (EditProvider eb = new EditProvider(Convert.ToString(cells[0].Value), Convert.ToString(cells[1].Value), Convert.ToString(cells[2].Value), Convert.ToString(cells[3].Value), Convert.ToString(cells[4].Value)))
                {
                    eb.ShowDialog();
                }
                dgv_provider.DataSource = new DB_Data_Provider().getProviders();
            }
        }

        private void dgv_provider_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar este provedor?", "¡Atención!", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                foreach (DataGridViewRow row in dgv_provider.SelectedRows)
                {
                    new DB_Data_Provider().deleteProvider(Convert.ToString(row.Cells[0].Value));
                    dgv_provider.DataSource = new DB_Data_Provider().getProviders();
                }
            }
        }
    }
}
