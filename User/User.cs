using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store
{
    internal class User
    {
        private int ID;
        private string Name;
        private string LastName;
        private string Password;
        private string Email;
        private string PhoneNumber;
        private string UserName;
        private bool IsAdmin;
        private string Status;

        public User () { }

        public User(string name, string lastName, string email, string phoneNumber, string userName)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            UserName = userName;
        }

        public User(int iD, string name, string lastName, string email, string phoneNumber, string userName)
        {
            ID = iD;
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            UserName = userName;
        }

        public User(string name, string lastName, string password, string email, string phoneNumber, string userName)
        {
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            UserName = userName;
        }

        public User(int iD, string name, string lastName, string password, string email, string phoneNumber, string userName, bool isAdmin, string status)
        {
            ID = iD;
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            UserName = userName;
            IsAdmin = isAdmin;
            Status = status;
        }

        public int Task_ID { get { return ID; } }

        public string Task_Name { get { return Name; } set { Name = value; } }

        public string Task_LastName { get { return LastName; } set { LastName = value; } }

        public string Task_Password { get { return Password; } set { Password = value; } }

        public string Task_Email { get { return Email; } set { Email = value; } }

        public string Task_PhoneNumber { get { return PhoneNumber; } set { PhoneNumber = value; } }

        public string Task_UserName { get { return UserName; } set { UserName = value; } }

        public bool Task_IsAdmin { get { return IsAdmin; } set { IsAdmin = value; } }

        public string Task_Status { get { return Status; } set { Status = value; } }
    }
}
