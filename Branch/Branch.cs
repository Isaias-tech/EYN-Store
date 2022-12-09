using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store
{
    internal class Branch
    {
        private int ID;
        private string Name;
        private string Description;
        private string Direction;
        private string Phone;
        private string Status;

        public Branch(string name, string description, string direction, string phone)
        {
            Name = name;
            Description = description;
            Direction = direction;
            Phone = phone;
        }
        public Branch(string name, string description, string direction, string phone, string status)
        {
            Name = name;
            Description = description;
            Direction = direction;
            Phone = phone;
            Status = status;
        }

        public Branch (int iD, string name, string description, string direction, string phone, string status)
        {
            ID = iD;
            Name = name;
            Description = description;
            Direction = direction;
            Phone = phone;
            Status = status;
        }

        public int B_ID { get { return ID; } }

        public string B_Name { get { return Name; } set { Name = value; } }

        public string B_Description { get { return Description; } set { Description = value; } }

        public string B_Direction { get { return Direction; } set { Direction = value; } }

        public string B_Phone { get { return Phone; } set { Phone = value; } }

        public string B_Status { get { return Status; } set { Status = value; } }
    }
}
