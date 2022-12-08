using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    internal class DB_Data_Branch
    {
        public DB_Data_Branch() { }

        public DataTable getBranchBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT * FROM Branchs WHERE {by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la rama.");
            }
            return new DataTable();
        }

        public DataTable getBranchByID(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT * FROM Branchs WHERE ID={ID};");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la rama.");
            }
            return new DataTable();
        }

        public DataTable getBranchs()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`,`ID_User` AS `ID de usuario`,`E_Direction` AS `Dirección`,`E_Identification` AS `Identificación`,`ID_Position` AS `ID de posición`,`ID_Branch` AS `ID de sucursal`,`E_Status` AS `Estado` FROM Employees;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los usuario.");
            }
            return new DataTable();
        }

        public DataTable addBranch(Employee employee)
        {
            return new DataTable();
        }

        public DataTable updateBranch(string id, Employee employee)
        {
            return new DataTable();
        }

        public DataTable deleteBranch(string id)
        {
            return new DataTable();
        }
    }
}
