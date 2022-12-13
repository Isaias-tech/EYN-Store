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

        private void SueldoNeto_Empleado_Load(object sender, EventArgs e)
        {
            DataTable user = new DB_Data_Users().GetUserByID(Convert.ToString(Program.selectedEmployee.EC_ID_User));
            DataTable position = new DB_Data_Position().getPositionByID(Convert.ToString(Program.selectedEmployee.EC_ID_Position));
            DataTable branch = new DB_Data_Branch().getBranchByID(Convert.ToString(Program.selectedEmployee.EC_ID_Branch));
            txt_id.Text = Convert.ToString(Program.selectedEmployee.EC_E_Identification);
            txt_name.Text = Convert.ToString(user.Rows[0].ItemArray[1]);
            txt_phone.Text = Convert.ToString(user.Rows[0].ItemArray[5]);
            txt_direction.Text = Convert.ToString(Program.selectedEmployee.EC_E_Direction);
            txt_branch.Text = Convert.ToString(branch.Rows[0].ItemArray[1]);
            txt_position.Text = Convert.ToString(position.Rows[0].ItemArray[1]);
            txt_salary.Text = Convert.ToString(position.Rows[0].ItemArray[3]);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double AFP = 0.07, ARS = 0.03, Cooperativa = 0.02, totalimpuesto, TOTAL;
            double salary = Convert.ToDouble(txt_salary.Text);
            if (salary >= 34334 && salary < 50000)
            {
                TOTAL = AFP + ARS + Cooperativa + 0.15;
                //muestra impuestos separados
                txt_ars.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * ARS);
                txt_cope.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * Cooperativa);
                txt_afp.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * AFP);
                txt_isr.Text= Convert.ToString(Convert.ToDouble(txt_salary.Text) * 0.15);

                totalimpuesto = (Convert.ToDouble(txt_salary.Text) * TOTAL);

                txt_salary_neto.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) - totalimpuesto);
            }
            else if (salary >= 51000 && salary < 100000)
            {
                TOTAL = AFP + ARS + Cooperativa + 0.20;
                //muestra impuestos separados
                txt_ars.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * ARS);
                txt_cope.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * Cooperativa);
                txt_afp.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * AFP);
                txt_isr.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * 0.20);
                totalimpuesto = (salary * TOTAL);
                txt_salary_neto.Text = Convert.ToString(salary - totalimpuesto);
            }
            else if (salary > 100000)
            {
                TOTAL = AFP + ARS + Cooperativa + 0.25;
                //muestra impuestos separados
                txt_ars.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * ARS);
                txt_cope.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * Cooperativa);
                txt_afp.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * AFP);
                txt_isr.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * 0.25);
                totalimpuesto = (salary * TOTAL);
                txt_salary_neto.Text = Convert.ToString(salary - totalimpuesto);
            }
            else
            {
                TOTAL = AFP + ARS + Cooperativa;
                //muestra impuestos separados
                txt_ars.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * ARS);
                txt_cope.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * Cooperativa);
                txt_afp.Text = Convert.ToString(Convert.ToDouble(txt_salary.Text) * AFP);
                totalimpuesto = (salary * TOTAL);
                txt_salary_neto.Text = Convert.ToString(salary - totalimpuesto);
            }
            //sueldoconimpuesto.Text = Convert.ToString(Convert.ToDouble(sueldosinimpuesto.Text)*AFP*ARS*Cooperativa);
        }
    }
}
