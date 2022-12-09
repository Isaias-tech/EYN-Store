using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store.Provider
{
    internal class Provider
    {
        private int ID;
        private string Name;
        private string Description;
        private string Direction;
        private string Phone;
        private string Status;

        public Provider(string name, string description, string direction, string phone)
        {
            Name = name;
            Description = description;
            Direction = direction;
            Phone = phone;
        }

        public Provider (int iD, string name, string description, string direction, string phone, string status)
        {
            ID = iD;
            Name = name;
            Description = description;
            Direction = direction;
            Phone = phone;
            Status = status;
        }

        public int P_ID { get { return ID; } }

        public string P_Name { get { return Name; } set { Name = value; } }

        public string P_Description { get { return Description; } set { Description = value;} }

        public string P_Direction { get { return Direction; } set { Direction = value; } }

        public string P_Phone { get { return Phone; } set { Phone = value; } }

        public string P_Status { get { return Status; } set { Status = value; } }
    }
}
