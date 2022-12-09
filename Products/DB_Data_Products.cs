using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    internal class DB_Data_Products
    {
        public DB_Data_Products () { }

        public DataTable getProductBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Products.ID, Products.P_Name AS `Nombre`, Products.P_Description AS `Descripción`, ProductTypes.PT_Name AS `Tipo de producto`, Providers.P_Name AS `Proveedor`, Branchs.B_Name AS `Sucursal`, Products.P_Cost AS `Costo de compra`, Products.P_Price AS `Precio de venta`, Products.P_Expiration_Date AS `Fecha de vencimiento`, Products.P_Status AS `Estado` FROM Products WHERE {by} LIKE '%{value}%' JOIN ProductTypes ON Products.ID_Type = ProductTypes.ID JOIN Provider ON Products.ID_Type = Provider.ID JOIN Branch ON Products.ID_Branch = Branch.ID;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener el producto.");
            }
            return new DataTable();
        }

        public DataTable getProducts()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB("SELECT Products.ID, Products.P_Name AS `Nombre`, Products.P_Description AS `Descripción`, ProductTypes.PT_Name AS `Tipo de producto`, Providers.P_Name AS `Proveedor`, Branchs.B_Name AS `Sucursal`, Products.P_Cost AS `Costo de compra`, Products.P_Price AS `Precio de venta`, Products.P_Expiration_Date AS `Fecha de vencimiento`, Products.P_Status AS `Estado` FROM Products JOIN ProductTypes ON Products.ID_Type = ProductTypes.ID JOIN Providers ON Products.ID_Type = Providers.ID JOIN Branchs ON Products.ID_Branch = Branchs.ID;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los productos.");
            }
            return new DataTable();
        }

        public DataTable addProduct(Products Product)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar el producto.");
            }
            return new DataTable();
        }

        public DataTable updateProduct(string id, Products Product)
        {
            try
            {
                return getProducts();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar update el producto.");
            }
            return new DataTable();
        }

        public DataTable deleteProduct(string ID)
        {
            try
            {
                return getProducts();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el producto.");
            }
            return new DataTable();
        }
    }
}
