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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            DB_Connection dB_Connection = new DB_Connection("199.192.22.113", "root", "VzSyZj7N7k2w8HB69h");
            dB_Connection.Connect();
            dgv_users.DataSource = Program.data;
        }
    }
}
