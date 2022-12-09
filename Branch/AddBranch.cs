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
    public partial class AddBranch : Form
    {
        public AddBranch()
        {
            InitializeComponent();
        }

        private void btn_add_branch_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_direction.Text.Length > 0 && txt_phone.Text.Length > 0)
            {
                new DB_Data_Branch().addBranch(new Branch(txt_name.Text, txt_description.Text, txt_direction.Text, txt_phone.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
