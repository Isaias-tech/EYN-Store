using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    internal class DB_Data_ProductType
    {
        public DB_Data_ProductType() { }

        public DataTable getProductTypeBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT ID, PT_Name AS 'Nombre', PT_Description AS 'Descripción', P_Status AS 'Estado' FROM ProductTypes WHERE {by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener el tipo.");
            }
            return new DataTable();
        }

        public DataTable getProductTypes()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB("SELECT ID, PT_Name AS 'Nombre', PT_Description AS 'Descripción', P_Status AS 'Estado' FROM ProductTypes;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los tipos.");
            }
            return new DataTable();
        }

        public void addProductType(ProductType pt)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"INSERT INTO ProductTypes (PT_Name, PT_Description) VALUES ('{pt.PT_Name}', '{pt.PT_Description}');");
                MessageBox.Show("El tipo de producto ha sido agregado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar el tipo.");
            }
        }

        public void updateProductType(string id, ProductType pt)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"UPDATE ProductTypes SET PT_Name='{pt.PT_Name}', PT_Description='{pt.PT_Description}' WHERE ID={id};");
                MessageBox.Show("El tipo de producto ha sido actualizado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar update el tipo.");
            }
        }

        public void deleteProductType(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"DELETE FROM ProductTypes WHERE ID={ID}");
                MessageBox.Show("El tipo de producto ha sido eliminado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el tipo.");
            }
        }
    }
}
