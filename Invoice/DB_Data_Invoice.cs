using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    internal class DB_Data_Invoice
    {
        public DB_Data_Invoice() { }

        public DataTable getInvoiceBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Invoices.ID, Users.U_UserName AS 'Nombre de usuario', Branchs.B_Name AS 'Sucursal', I_Date AS 'Fecha', I_Total_Price AS 'Precio total', I_Payment_Method AS 'Metodo de pago', I_Status AS 'Estado' FROM Invoices JOIN Employees ON Invoices.ID_Employee=Employees.ID JOIN Branchs ON Invoices.ID_Branch=Branchs.ID JOIN Users ON Employees.ID=Users.ID WHERE {by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la facturas.");
            }
            return new DataTable();
        }

        public DataTable getInvoiceByID(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Invoices.ID, Users.U_UserName AS 'Nombre de usuario', Branchs.B_Name AS 'Sucursal', I_Date AS 'Fecha', I_Total_Price AS 'Precio total', I_Payment_Method AS 'Metodo de pago', I_Status AS 'Estado'  FROM Invoices  JOIN Employees ON Invoices.ID_Employee=Employees.ID JOIN Branchs ON Invoices.ID_Branch=Branchs.ID JOIN Users ON Employees.ID=Users.ID WHERE ID={ID};");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la facturas.");
            }
            return new DataTable();
        }

        public DataTable getInvoices()
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Invoices.ID, Users.U_UserName AS 'Nombre de usuario', Branchs.B_Name AS 'Sucursal', I_Date AS 'Fecha', I_Total_Price AS 'Precio total', I_Payment_Method AS 'Metodo de pago', I_Status AS 'Estado' FROM Invoices JOIN Employees ON Invoices.ID_Employee=Employees.ID JOIN Branchs ON Invoices.ID_Branch=Branchs.ID JOIN Users ON Employees.ID=Users.ID;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener las facturas.");
            }
            return new DataTable();
        }

        public void addInvoice(Invoice invoice)
        {
            try
            {

                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"INSERT INTO Invoices (ID_Employee, ID_Branch, I_Total_Price, I_Payment_Method, ID_Product) VALUES ('{invoice.I_ID_Employee}', '{invoice.I_ID_Branch}', '{invoice.I_Total_Price}','{invoice.I_PaymentM_Method}', '{invoice.I_ID_Product}');");
                string values = "";
                using (DataTable dt = ssh_DB_Connection.SendQueryToDB($"SELECT * FROM Invoices ORDER BY ID DESC LIMIT 1"))
                {
                    for (int i = 0; i < Program.cart.Count; i++)
                    {
                        values += $"({Program.cart[i]}, {dt.Rows[0]["ID"]})" + (Program.cart.Count-1 == i ? "" : ", ");
                    }
                }
                ssh_DB_Connection.SendQueryToDB($"INSERT INTO Product_Invoice (ID_Product, ID_Invoice) VALUES {values}");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar generar la factura.");
            }
        }

        public DataTable updateInvoice(string id, Employee employee)
        {
            return new DataTable();
        }

        public DataTable deleteInvoicen(string id)
        {
            return new DataTable();
        }
    }
}
