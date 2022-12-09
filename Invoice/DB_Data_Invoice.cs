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
                return ssh_DB_Connection.SendQueryToDB($"SELECT Invoices.ID, Users.U_UserName AS 'Nombre de usuario', Branchs.B_Name AS 'Sucursal', I_Date AS 'Fecha', I_Total_Price AS 'Precio total', I_Payment_Method AS 'Metodo de pago', I_Status AS 'Estado' FROM Invoices WHERE {by} LIKE '%{value}%' JOIN Employees ON Invoices.ID_Employee=Employees.ID JOIN Branchs ON Invoices.ID_Branch=Branchs.ID JOIN Users ON Employees.ID=Users.ID;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la posición.");
            }
            return new DataTable();
        }

        public DataTable getInvoiceByID(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT Invoices.ID, Users.U_UserName AS 'Nombre de usuario', Branchs.B_Name AS 'Sucursal', I_Date AS 'Fecha', I_Total_Price AS 'Precio total', I_Payment_Method AS 'Metodo de pago', I_Status AS 'Estado'  FROM Invoices WHERE ID={ID} JOIN Employees ON Invoices.ID_Employee=Employees.ID JOIN Branchs ON Invoices.ID_Branch=Branchs.ID JOIN Users ON Employees.ID=Users.ID;");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener la posición.");
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
                MessageBox.Show("Ha ocurrido un error al intentar obtener las posiciones.");
            }
            return new DataTable();
        }

        public DataTable addInvoice(Employee employee)
        {
            return new DataTable();
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
