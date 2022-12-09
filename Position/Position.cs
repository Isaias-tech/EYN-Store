using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store
{
    internal class Position
    {
        private int ID;
        private string Name;
        private string Description;
        private double Salary;
        private string Status;

        public Position(string p_Name, string p_Description, double p_Salary)
        {
            Name = p_Name;
            Description = p_Description;
            Salary = p_Salary;
        }
        public Position(string p_Name, string p_Description, double p_Salary, string p_Status)
        {
            Name = p_Name;
            Description = p_Description;
            Salary = p_Salary;
            Status = p_Status;
        }

        public Position(int p_ID, string p_Name, string p_Description, double p_Salary, string p_Status)
        {
            ID = p_ID;
            Name = p_Name;
            Description = p_Description;
            Salary = p_Salary;
            Status = p_Status;
        }

        public int P_ID { get { return ID; } }

        public string P_Name { get { return Name; } set { Name = value; } }

        public string P_Description { get { return Description; } set { Description = value; } }

        public double P_Salary { get { return Salary; } set { Salary = value; } }

        public string P_Status { get { return Status; } set { Status = value; } }
    }
}
