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
    public partial class BranchManager : Form
    {
        public BranchManager()
        {
            InitializeComponent();
        }

        private void BranchManager_Load(object sender, EventArgs e)
        {
            dgv_branch.DataSource = new DB_Data_Branch().getBranchs();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DB_Data_Branch().getBranchBy("B_Name", txt_search.Text);
                dgv_branch.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ubo un error al buscar.", "!Error¡");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["AddBranch"] as AddBranch) != null))
            {
                using (AddBranch ab = new AddBranch())
                {
                    ab.ShowDialog();
                }
                dgv_branch.DataSource = new DB_Data_Branch().getBranchs();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!((Application.OpenForms["EditBranch"] as EditBranch) != null))
            {
                using (EditBranch eb = new EditBranch())
                {
                    eb.ShowDialog();
                }
                dgv_branch.DataSource = new DB_Data_Branch().getBranchs();
            }
        }
    }
}
