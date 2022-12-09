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
    public partial class EditPosition : Form
    {
        private string P_ID, P_Name, P_Description, P_Salary;

        public EditPosition(string p_id, string p_name, string p_description, string p_salary)
        {
            InitializeComponent();
            P_ID = p_id;
            P_Name = p_name;
            P_Description = p_description;
            P_Salary = p_salary;
            txt_name.Text = p_name;
            txt_description.Text = p_description;
            txt_salary.Text = p_salary;
        }

        private void btn_edit_position_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_salary.Text.Length > 0)
            {
                if (txt_name.Text != P_Name || txt_description.Text != P_Description || txt_salary.Text != P_Salary)
                {
                    new DB_Data_Position().updatePosition(P_ID, new Position(txt_name.Text, txt_description.Text, Convert.ToDouble(txt_salary.Text)));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debes de realizar almenos un cambio. ");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
