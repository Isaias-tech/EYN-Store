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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "¡Atención!", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                Program.sign_in.Show();
                Program.CurrentUser = new User();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
