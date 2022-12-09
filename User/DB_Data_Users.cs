using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYN_Store
{
    internal class DB_Data_Users
    {
        public DB_Data_Users() { }

        public DataTable GetUsers(string query = "SELECT `ID`, `U_Name` AS `Nombre/s`, `U_LastName` AS `Apellido/s`, `U_Email` AS `Email`, `U_PhoneNumber` AS `Numero de telefono`, `U_UserName` AS `Nombre de usuario`, `U_IsAdmin` AS `Es Administrador`, `U_Status` AS `Estado` FROM Users;")
        {
            DB_Connection dB_Connection = new DB_Connection();
            return dB_Connection.SendQueryToDB(query);
        }

        public void AddUser(User user)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();
                dB_Connection.SendQueryToDB($"INSERT INTO Users (`U_Name`, `U_LastName`, `U_Password`, `U_Email`, `U_PhoneNumber`, `U_UserName`) VALUES ('{user.Task_Name}','{user.Task_LastName}','{user.Task_Password}','{user.Task_Email}','{user.Task_PhoneNumber}','{user.Task_UserName}');");
            }
            catch
            {
                MessageBox.Show("A ocurrido un error.");
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();
                dB_Connection.SendQueryToDB($"UPDATE Users SET `U_Name`='{user.Task_Name}', `U_LastName`='{user.Task_LastName}', `U_Password`='{user.Task_Password}', `U_Email`='{user.Task_Email}', `U_PhoneNumber`='{user.Task_PhoneNumber}', `U_UserName`='{user.Task_UserName}';");
            }
            catch
            {
                MessageBox.Show("A ocurrido un error.");
            }
        }

        public DataTable GetUserBy(string by, string value)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`, `U_Name` AS `Nombre/s`, `U_LastName` AS `Apellido/s`, `U_Email` AS `Email`, `U_PhoneNumber` AS `Numero de telefono`, `U_UserName` AS `Nombre de usuario`, `U_IsAdmin` AS `Es Administrador`, `U_Status` AS `Estado` FROM Users WHERE {by} LIKE '%{value}%';");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener el usuario.");
                return null;
            }
        }

        public DataTable GetUserByID(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                return ssh_DB_Connection.SendQueryToDB($"SELECT `ID`, `U_Name` AS `Nombre/s`, `U_LastName` AS `Apellido/s`, `U_Email` AS `Email`, `U_PhoneNumber` AS `Numero de telefono`, `U_UserName` AS `Nombre de usuario`, `U_IsAdmin` AS `Es Administrador`, `U_Status` AS `Estado` FROM Users WHERE ID={ID};");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener el usuario.");
            }
            return new DataTable();
        }

        public DataTable DeleteUser(string ID)
        {
            try
            {
                DB_Connection ssh_DB_Connection = new DB_Connection();
                ssh_DB_Connection.SendQueryToDB($"DELETE FROM Users WHERE ID={ID};");
                MessageBox.Show("El usuario ha sido eliminado.");
                return GetUsers();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el usuario.");
            }
            return new DataTable();
        }
    }
}
