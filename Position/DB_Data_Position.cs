using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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

        public void addPosition(Position position)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"INSERT INTO Positions (P_Name, P_Description, P_Salary) VALUES ('{position.P_Name}', '{position.P_Description}', {position.P_Salary});");
                MessageBox.Show("La posicion ha sido agregada correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar la posicion.");
            }
        }

        public void updatePosition(string id, Position position)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"UPDATE Positions SET P_Name='{position.P_Name}', P_Description='{position.P_Description}', P_Salary={position.P_Salary} WHERE ID={id};");
                MessageBox.Show("La posicion ha sido actualizada correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar actualizar la posicion.");
            }
        }

        public void deletePosition(string id)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"DELETE FROM Positions WHERE ID={id}");
                MessageBox.Show("La posicion ha sido eliminada correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar la posicion.");
            }
        }
    }
}
