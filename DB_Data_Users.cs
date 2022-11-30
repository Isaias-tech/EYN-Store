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

        public DataTable GetUsers(string query = "SELECT * FROM Users;")
        {
            DB_Connection dB_Connection = new DB_Connection();
            return dB_Connection.SendQueryToDB(query);
        }

        public void AddUser(User user)
        {
            DB_Connection dB_Connection = new DB_Connection();
            dB_Connection.SendQueryToDB($"INSERT INTO Users (`U_Name`, `U_LastName`, `U_Password`, `U_Email`, `U_PhoneNumber`, `U_UserName`) VALUES ('{user.Task_Name}','{user.Task_LastName}','{user.Task_Password}','{user.Task_Email}','{user.Task_PhoneNumber}','{user.Task_UserName}');");
            MessageBox.Show($"El usuario '{user.Task_UserName}' ha sido añadido exitosamente.");
        }
    }
}
