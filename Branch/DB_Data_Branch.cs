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
    internal class DB_Data_Branch
    {
        public DB_Data_Branch() { }

        public DataTable getBranchBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`,`B_Name` AS `Sucursal`, `B_Description` AS `Descripción`,`B_Direction` AS `Dirección`, `B_Phone` AS `Telefono`,`B_Status` AS `Estado` FROM Branchs WHERE {by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la sucursal.");
            }
            return new DataTable();
        }

        public DataTable getBranchByID(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`,`B_Name` AS `Sucursal`, `B_Description` AS `Descripción`,`B_Direction` AS `Dirección`, `B_Phone` AS `Telefono`,`B_Status` AS `Estado` FROM Branchs WHERE ID={ID};");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la sucursal.");
            }
            return new DataTable();
        }

        public DataTable getBranchs()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`,`B_Name` AS `Sucursal`, `B_Description` AS `Descripción`,`B_Direction` AS `Dirección`, `B_Phone` AS `Telefono`,`B_Status` AS `Estado` FROM Branchs;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener las sucursales.");
            }
            return new DataTable();
        }

        public void addBranch(Branch branch)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"INSERT INTO Branchs (B_Name, B_Description, B_Direction, B_Phone) VALUES ('{branch.B_Name}', '{branch.B_Description}', '{branch.B_Direction}', '{branch.B_Phone}')");
                MessageBox.Show("La sucursal ha sido agregada correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar el sucursal.");
            }
        }

        public void updateBranch(string id, Branch branch)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"UPDATE Branchs Set B_Name='{branch.B_Name}', B_Description='{branch.B_Description}', B_Direction='{branch.B_Direction}', B_Phone='{branch.B_Phone}' WHERE ID={id};");
                MessageBox.Show("La sucursal ha sido actualizada correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar actualizar el sucursal.");
            }
        }

        public void deleteBranch(string id)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"DELETE FROM Branchs WHERE ID={id};");
                MessageBox.Show("La sucursal ha sido eliminada correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el sucursal.");
            }
        }
    }
}
