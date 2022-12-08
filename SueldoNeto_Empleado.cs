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
            
            if (Convert.ToInt32(txt_salary.Text) >= 34334 && Convert.ToInt32(txt_salary.Text) < 50000)
            {
                TOTAL = AFP + ARS + Cooperativa+0.15;
                totalimpuesto = (Convert.ToDouble(txt_salary.Text) * TOTAL);
                txt_salary_neto.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) - totalimpuesto);
            }
            else if (Convert.ToInt32(txt_salary.Text) >= 51000 && Convert.ToInt32(txt_salary.Text) < 100000)
            {
                TOTAL = AFP + ARS + Cooperativa + 0.20;
                totalimpuesto = (Convert.ToDouble(txt_salary.Text) * TOTAL);
                txt_salary_neto.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) - totalimpuesto);
            }
            else if (Convert.ToInt32(txt_salary.Text) > 100000)
            {
                TOTAL = AFP + ARS + Cooperativa + 0.25;
                totalimpuesto = (Convert.ToDouble(txt_salary.Text) * TOTAL);
                txt_salary_neto.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) - totalimpuesto);
            }
            else
            {
                TOTAL = AFP + ARS + Cooperativa ;
                totalimpuesto = (Convert.ToDouble(txt_salary.Text) * TOTAL);
                txt_salary_neto.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) - totalimpuesto);
            }
            //sueldoconimpuesto.Text = Convert.ToString(Convert.ToDouble(sueldosinimpuesto.Text)*AFP*ARS*Cooperativa);
            
        }

        private void SueldoNeto_Empleado_Load(object sender, EventArgs e)
        {
            txt_id.Text = Convert.ToString(Program.selectedEmployee.EC_ID);
            txt_direction.Text = Convert.ToString(Program.selectedEmployee.EC_E_Direction);
            txt_direction.Text = Convert.ToString(Program.selectedEmployee.EC_E_Identification);
            txt_direction.Text = Convert.ToString(Program.selectedEmployee.EC_ID);
            txt_direction.Text = Convert.ToString(Program.selectedEmployee.EC_ID_Position);
            txt_direction.Text = Convert.ToString(Program.selectedEmployee.EC_ID_Position);
            txt_direction.Text = Convert.ToString(Program.selectedEmployee.EC_ID_Position);
        }
    }
}
