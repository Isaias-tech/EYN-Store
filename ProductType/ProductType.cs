using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store
{
    internal class ProductType
    {
        private int ID;
        private string Name;
        private string Description;
        private string Status;

        public ProductType(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public ProductType (int iD, string name, string description, string status)
        {
            ID = iD;
            Name = name;
            Description = description;
            Status = status;
        }

        public int PT_ID { get { return ID; } }

        public string PT_Name { get { return Name; } set { Name = value; } }

        public string PT_Description { get { return Description; } set { Description = value; } }

        public string PT_Status { get { return Status; } set { Status = value; } }
    }
}
