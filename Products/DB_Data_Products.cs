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

        public DataTable getClientProductBy(string by, string value, string type)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Products.ID, Products.P_Name AS `Nombre`, Products.P_Description AS `Descripción`, ProductTypes.PT_Name AS `Tipo de producto`, Providers.P_Name AS `Proveedor`, Branchs.B_Name AS `Sucursal`, Products.P_Cost AS `Costo de compra`, Products.P_Price AS `Precio de venta`, Products.P_Expiration_Date AS `Fecha de vencimiento`, Products.P_Status AS `Estado` FROM Products JOIN ProductTypes ON Products.ID_Type = ProductTypes.ID JOIN Providers ON Products.ID_Type = Providers.ID JOIN Branchs ON Products.ID_Branch = Branchs.ID WHERE Products.{by} LIKE '%{value}%' AND Products.ID_Type={type};");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener el producto.");
            }
            return new DataTable();
        }

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

        public void addProduct(Products product)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"INSERT INTO Products (P_Name, P_Description, ID_Type, ID_Provider, ID_Branch, P_Cost, P_Price, P_Expiration_Date) VALUES ('{product.P_Name}', '{product.P_Description}', {product.P_ID_Type}, {product.P_ID_Provider}, {product.P_ID_Branch}, {product.P_Cost}, {product.P_Price}, {product.P_ExpirationDate});");
                MessageBox.Show("El producto ha sido agregado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar el producto.");
            }
        }

        public void updateProduct(string id, Products product)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"UPDATE Products SET P_Name='{product.P_Name}', P_Description='{product.P_Description}', ID_Type={product.P_ID_Type}, ID_Provider={product.P_ID_Provider}, ID_Branch={product.P_ID_Branch}, P_Cost={product.P_Cost}, P_Price={product.P_Price}, P_Expiration_Date='{product.P_ExpirationDate}' WHERE ID={id};");
                MessageBox.Show("El producto ha sido actualizado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar actualizar el producto.");
            }
        }

        public void deleteProduct(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"DELETE FROM Products WHERE ID={ID};");
                MessageBox.Show("El producto ha sido eliminado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el producto.");
            }
        }
    }
}
