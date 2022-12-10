using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace EYN_Store
{
    internal static class Program
    {
        public static Sign_In sign_in;
        public static User CurrentUser;
        public static DataTable data;
        public static Employee selectedEmployee;
        public static List<int> cart = new List<int>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sign_in = new Sign_In();
            Application.Run(sign_in);
        }
    }
}
