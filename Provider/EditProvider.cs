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
    public partial class EditProvider : Form
    {
        private string P_ID;
        private string P_Name;
        private string P_Description;
        private string P_Direction;
        private string P_Phone;

        public EditProvider(string p_id, string p_name, string p_description, string p_direction, string p_phone)
        {
            InitializeComponent();
            P_ID = p_id;
            P_Name = p_name;
            P_Description= p_description;
            P_Direction = p_direction;
            P_Phone = p_phone;
            txt_name.Text = p_name;
            txt_description.Text = p_description;
            txt_direction.Text = p_direction;
            txt_phone.Text = p_phone;
        }

        private void btn_edit_provider_Click(object sender, EventArgs e)
        {

            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_direction.Text.Length > 0 && txt_phone.Text.Length > 0)
            {
                if (txt_name.Text != P_Name || txt_description.Text != P_Description || txt_direction.Text != P_Direction || txt_phone.Text != P_Phone)
                {
                    new DB_Data_Provider().updateProvider(P_ID, new Provider(txt_name.Text, txt_description.Text, txt_direction.Text, txt_phone.Text));
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
