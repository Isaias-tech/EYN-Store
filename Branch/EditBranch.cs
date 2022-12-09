using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    public partial class EditBranch : Form
    {
        private string ID;
        private string B_Name;
        private string B_Description;
        private string B_Phone;
        private string B_Direction;

        public EditBranch(string id, string name, string description, string phone, string direction)
        {
            InitializeComponent();
            ID = id;
            B_Name = name;
            B_Description = description;
            B_Phone = phone;
            B_Direction = direction;
            txt_name.Text = name;
            txt_direction.Text = description;
            txt_description.Text = description;
            txt_phone.Text = phone; 
            txt_direction.Text = direction;
        }

        private void btn_update_branch_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_direction.Text.Length > 0 && txt_phone.Text.Length > 0)
            {
                if (txt_name.Text != B_Name || txt_description.Text != B_Description || txt_direction.Text != B_Direction || txt_phone.Text != B_Phone)
                {
                    new DB_Data_Branch().updateBranch(ID, new Branch(txt_name.Text, txt_description.Text, txt_direction.Text, txt_phone.Text));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe de generar al menos un cambio");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados. ");
            }
        }
    }
}
