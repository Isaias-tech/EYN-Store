using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store
{
    internal class Products
    {
        private int ID;
        private string Name;
        private string Description;
        private int ID_Type;
        private int ID_Provider;
        private int ID_Branch;
        private double Cost;
        private double Price;
        private string ExpirationDate;
        private string CreatedAt;
        private string UpdatedAt;
        private string Status;

        public Products(string name, string description, int iD_Type, int iD_Provider, int iD_Branch, double cost, double price, string expirationDate)
        {
            Name = name;
            Description = description;
            ID_Type = iD_Type;
            ID_Provider = iD_Provider;
            ID_Branch = iD_Branch;
            Cost = cost;
            Price = price;
            ExpirationDate = expirationDate;
        }

        public Products(int iD, string name, string description, int iD_Type, int iD_Provider, int iD_Branch, double cost, double price, string expirationDate, string createdAt, string updatedAt, string status)
        {
            ID = iD;
            Name = name;
            Description = description;
            ID_Type = iD_Type;
            ID_Provider = iD_Provider;
            ID_Branch = iD_Branch;
            Cost = cost;
            Price = price;
            ExpirationDate = expirationDate;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Status = status;
        }

        public int P_ID { get { return ID; } }

        public string P_Name { get { return Name; } set { Name = value; } }

        public string P_Description { get { return Description; } set { Description = value; } }

        public int P_ID_Type { get { return ID_Type; } set { ID_Type = value; } }

        public int P_ID_Provider { get { return ID_Provider; } set { ID_Provider = value; } }

        public int P_ID_Branch { get { return ID_Branch; } set { ID_Branch = value; } }

        public double P_Cost { get { return Cost; } set { Cost = value; } }

        public double P_Price { get { return Price; } set { Price = value; } }

        public string P_ExpirationDate { get { return ExpirationDate; } set { ExpirationDate = value; } }

        public string P_CreatedAt { get { return CreatedAt; } set { CreatedAt = value; } }

        public string P_UpdatedAt { get { return UpdatedAt; } set { UpdatedAt = value; } }

        public string P_Status { get { return Status; } set { Status = value; } }
    }
}
