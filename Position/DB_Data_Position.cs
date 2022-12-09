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
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`, `P_Name` AS `Nombre`, `P_Description` AS `Descripción`, `P_Salary` AS `Salario`,`P_Status` AS `Estado` FROM Positions WHERE {by} LIKE '%{value}%';");
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
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`, `P_Name` AS `Nombre`, `P_Description` AS `Descripción`, `P_Salary` AS `Salario`,`P_Status` AS `Estado` FROM Positions WHERE ID={ID};");
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
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`, `P_Name` AS `Nombre`, `P_Description` AS `Descripción`, `P_Salary` AS `Salario`,`P_Status` AS `Estado` FROM Positions;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener las posiciones.");
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
