using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EYN_Store
{
    public partial class EditProductType : Form
    {
        private string PT_ID, PT_Name, PT_Description ;

        public EditProductType(string pt_id, string pt_name, string pt_description)
        {
            InitializeComponent();
            this.PT_ID = pt_id;
            this.PT_Name = pt_name;
            this.PT_Description = pt_description;
            txt_name.Text = pt_name;
            txt_description.Text = pt_description;
        }

        private void btn_edit_type_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0)
            {
                if (txt_name.Text != PT_Name || txt_description.Text != PT_Description)
                {
                    new DB_Data_ProductType().updateProductType(PT_ID, new ProductType(txt_name.Text, txt_description.Text));
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
