using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    internal class DB_Data_Employee
    {
        public DB_Data_Employee() { }

        public DataTable getEmployeeBy (string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Employees.ID, Users.ID AS `ID Usuario`, Users.U_UserName AS `Nombre de usuario`, E_Direction AS `Dirección`, E_Identification AS `Identificación`, ID_Position AS `ID de posición`, ID_Branch AS `ID de sucursal`, E_Status AS `Estado` FROM Employees JOIN Users ON Employees.ID_User=Users.ID WHERE Users.{by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener el emleado.");
            }
            return new DataTable();
        }

        public DataTable getEmployees ()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Employees.ID, Users.ID AS `ID Usuario`, Users.U_UserName AS `Nombre de usuario`, E_Direction AS `Dirección`, E_Identification AS `Identificación`, ID_Position AS `ID de posición`, ID_Branch AS `ID de sucursal`, E_Status AS `Estado` FROM Employees JOIN Users ON Employees.ID_User=Users.ID;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los empleados.");
            }
            return new DataTable();
        }

        public DataTable addEmployee(Employee employee)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                string query = $"INSERT INTO Employees (ID_User, E_Direction, E_Identification, ID_Position, ID_Branch) VALUES (\"{employee.EC_ID_User}\", \"{employee.EC_E_Direction}\", \"{employee.EC_E_Identification}\", \"{employee.EC_ID_Position}\", \"{employee.EC_ID_Branch}\");";
                return ssh_DB_Connection.SendQueryToDB(query);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar el empleado.");
            }
            return new DataTable();
        }

        public DataTable updateEmployee(string id, Employee employee)
        {
            return new DataTable();
        }

        public DataTable deleteEmployee(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"DELETE FROM Employees WHERE ID={ID};");
                MessageBox.Show("El empleado ha sido eliminado.");
                return getEmployees();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el empleado.");
            }
            return new DataTable();
        }
    }
}
