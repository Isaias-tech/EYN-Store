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
    public partial class PositionsManager : Form
    {
        public PositionsManager()
        {
            InitializeComponent();
        }

        private void PositionsManager_Load(object sender, EventArgs e)
        {
            dgv_position.DataSource = new DB_Data_Position().getPositions();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DB_Data_Position().getPositionBy("P_Name", txt_search.Text);
                dgv_position.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["AddPosition"] as AddPosition) != null))
            {
                using (AddPosition ab = new AddPosition())
                {
                    ab.ShowDialog();
                }
                dgv_position.DataSource = new DB_Data_Position().getPositions();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["EditPosition"] as EditPosition) != null))
            {
                using (EditPosition ab = new EditPosition())
                {
                    ab.ShowDialog();
                }
                dgv_position.DataSource = new DB_Data_Position().getPositions();
            }
        }
    }
}
