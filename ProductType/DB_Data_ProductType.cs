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

        public DataTable addProductType(Products Product)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar el tipo.");
            }
            return new DataTable();
        }

        public DataTable updateProductType(string id, Products Product)
        {
            try
            {
                return getProductTypes();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar update el tipo.");
            }
            return new DataTable();
        }

        public DataTable deleteProductType(string ID)
        {
            try
            {
                return getProductTypes();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el tipo.");
            }
            return new DataTable();
        }
    }
}
