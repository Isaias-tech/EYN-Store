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
    public partial class AddPosition : Form
    {
        public AddPosition()
        {
            InitializeComponent();
        }

        private void btn_add_position_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_salary.Text.Length > 0)
            {
                new DB_Data_Position().addPosition(new Position(txt_name.Text, txt_description.Text, Convert.ToDouble(txt_salary.Text)));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
