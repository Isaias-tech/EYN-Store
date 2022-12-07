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
    public partial class SueldoNeto_Empleado : Form
    {
        public SueldoNeto_Empleado()
        {
            InitializeComponent();
        }

     

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            double AFP = 0.07,ARS=0.03,Cooperativa=0.02,totalimpuesto,TOTAL;
            
            if (Convert.ToInt32(sueldosinimpuesto.Text) >= 34334 && Convert.ToInt32(sueldosinimpuesto.Text) < 50000)
            {
                TOTAL = AFP + ARS + Cooperativa+0.15;
                totalimpuesto = (Convert.ToDouble(sueldosinimpuesto.Text) * TOTAL);
                sueldoconimpuesto.Text = Convert.ToString(Convert.ToDouble(sueldosinimpuesto.Text) - totalimpuesto);
            }
            else if (Convert.ToInt32(sueldosinimpuesto.Text) >= 51000 && Convert.ToInt32(sueldosinimpuesto.Text) < 100000)
            {
                TOTAL = AFP + ARS + Cooperativa + 0.20;
                totalimpuesto = (Convert.ToDouble(sueldosinimpuesto.Text) * TOTAL);
                sueldoconimpuesto.Text = Convert.ToString(Convert.ToDouble(sueldosinimpuesto.Text) - totalimpuesto);
            }
            else if (Convert.ToInt32(sueldosinimpuesto.Text) > 100000)
            {
                TOTAL = AFP + ARS + Cooperativa + 0.25;
                totalimpuesto = (Convert.ToDouble(sueldosinimpuesto.Text) * TOTAL);
                sueldoconimpuesto.Text = Convert.ToString(Convert.ToDouble(sueldosinimpuesto.Text) - totalimpuesto);
            }
            else
            {
                TOTAL = AFP + ARS + Cooperativa ;
                totalimpuesto = (Convert.ToDouble(sueldosinimpuesto.Text) * TOTAL);
                sueldoconimpuesto.Text = Convert.ToString(Convert.ToDouble(sueldosinimpuesto.Text) - totalimpuesto);
            }
            //sueldoconimpuesto.Text = Convert.ToString(Convert.ToDouble(sueldosinimpuesto.Text)*AFP*ARS*Cooperativa);
            
        }

       
    }
}
