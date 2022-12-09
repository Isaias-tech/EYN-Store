using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store.Provider
{
    internal class DB_Data_Provider
    {
        public DB_Data_Provider() { }

        public DataTable getProviderBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT ID, P_Name AS 'Nombre', P_Description AS 'Descripción', P_Direction AS 'Dirección', P_Phone AS 'Telefono', P_Status AS 'Estado' FROM Providers WHERE {by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener el provedor.");
            }
            return new DataTable();
        }

        public DataTable getProviders()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB("SELECT ID, P_Name AS 'Nombre', P_Description AS 'Descripción', P_Direction AS 'Dirección', P_Phone AS 'Telefono', P_Status AS 'Estado' FROM Providers;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los provedores.");
            }
            return new DataTable();
        }

        public void addProvider(Provider pt)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"INSERT INTO Providers (P_Name, P_Description, P_Direction, P_Phone) VALUES ('{pt.P_Name}', '{pt.P_Description}', '{pt.P_Direction}', '{pt.P_Phone}');");
                MessageBox.Show("El provedor ha sido agregado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar el provedor.");
            }
        }

        public void updateProvider(string id, Provider pt)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"UPDATE Providers SET P_Name='{pt.P_Name}', P_Description='{pt.P_Description}', P_Direction='{pt.P_Direction}', P_Phone='{pt.P_Phone}'  WHERE ID={id};");
                MessageBox.Show("El provedor ha sido actualizado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar actualuzar el provedor.");
            }
        }

        public void deleteProvider(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"DELETE FROM Providers WHERE ID={ID}");
                MessageBox.Show("El provedor ha sido eliminado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el provedor.");
            }
        }
    }
}
