using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store
{
    internal class Employee
    {
        private int ID;
        private int ID_User;
        private string E_Direction;
        private string E_Identification;
        private int ID_Position;
        private int ID_Branch;
        private string E_Status;

        public Employee(int iD_User, string e_Direction, string e_Identification, int iD_Position, int iD_Branch)
        {
            ID_User = iD_User;
            E_Direction = e_Direction;
            E_Identification = e_Identification;
            ID_Position = iD_Position;
            ID_Branch = iD_Branch;
        }

        public Employee(int iD, int iD_User, string e_Direction, string e_Identification, int iD_Position, int iD_Branch, string e_Status)
        {
            ID = iD;
            ID_User = iD_User;
            E_Direction = e_Direction;
            E_Identification = e_Identification;
            ID_Position = iD_Position;
            ID_Branch = iD_Branch;
            E_Status = e_Status;
        }

        public int EC_ID { get { return ID; } }

        public int EC_ID_User { get { return ID_User; } set { ID_User = value; } }

        public string EC_E_Direction { get { return E_Direction; } set { E_Direction = value; } }

        public string EC_E_Identification { get { return E_Identification; } set { E_Identification = value; } }

        public int EC_ID_Position { get { return ID_Position; } set { ID_Position = value; } }

        public int EC_ID_Branch { get { return ID_Branch; } set { ID_Branch = value; } }

        public string EC_E_Status { get { return E_Status; } set { E_Status = value; } }
    }
}
