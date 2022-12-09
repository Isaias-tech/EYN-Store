using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYN_Store
{
    internal class Invoice
    {
        private int ID;
        private int ID_Employee;
        private int ID_Branch;
        private string Date;
        private double Total_Price;
        private string Payment_Method;
        private string Status;

        public Invoice(int iD_Employee, int iD_Branch, string date, double total_Price, string payment_Method)
        {
            ID_Employee = iD_Employee;
            ID_Branch = iD_Branch;
            Date = date;
            Total_Price = total_Price;
            Payment_Method = payment_Method;
        }

        public Invoice (int iD, int iD_Employee, int iD_Branch, string date, double total_Price, string payment_Method, string status)
        {
            ID = iD;
            ID_Employee = iD_Employee;
            ID_Branch = iD_Branch;
            Date = date;
            Total_Price = total_Price;
            Payment_Method = payment_Method;
            Status = status;
        }

        public int I_ID { get { return ID; } }

        public int I_ID_Employee { get { return ID_Employee; } }

        public string I_Date { get { return Date; } }

        public double I_Total_Price { get { return Total_Price; } }

        public string I_PaymentM_Method { get { return Payment_Method; } }

        public string I_Status { get { return Status; } }
    }
}
