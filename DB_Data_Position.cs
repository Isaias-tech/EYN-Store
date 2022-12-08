using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    internal class DB_Data_Position
    {
        public DB_Data_Position() { }


        public DataTable getPositionBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT * FROM Positions WHERE {by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la posición.");
            }
            return new DataTable();
        }

        public DataTable getPositionByID(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT * FROM Positions WHERE ID={ID};");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la posición.");
            }
            return new DataTable();
        }

        public DataTable getPositions()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`,`ID_User` AS `ID de usuario`,`E_Direction` AS `Dirección`,`E_Identification` AS `Identificación`,`ID_Position` AS `ID de posición`,`ID_Position` AS `ID de sucursal`,`E_Status` AS `Estado` FROM Employees;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los usuario.");
            }
            return new DataTable();
        }

        public DataTable addPosition(Employee employee)
        {
            return new DataTable();
        }

        public DataTable updatePosition(string id, Employee employee)
        {
            return new DataTable();
        }

        public DataTable deletePosition(string id)
        {
            return new DataTable();
        }
    }
}
