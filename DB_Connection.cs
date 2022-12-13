using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci;
using Renci.SshNet;
using System.Windows.Forms;
using System.Data;
using MySqlX.XDevAPI;

namespace EYN_Store
{
    internal class DB_Connection
    {
        private string host;
        private string username;
        private string password;

        public DB_Connection()
        {
            host = "199.192.22.113";
            username = "root";
            password = "VzSyZj7N7k2w8HB69h";
        }

        public DataTable SendQueryToDB (string query)
        {
            try
            {
                using (var client = new SshClient(host, username, password))
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        ForwardedPortLocal portForwarded = new ForwardedPortLocal("127.0.0.1", 7003, host, 7003);
                        client.AddForwardedPort(portForwarded);
                        portForwarded.Start();
                        DataTable dt = new DataTable();
                        using (MySqlConnection con = new MySqlConnection($"server=127.0.0.1; port=7003; user id=root; password=p9d49cih9KUu6XDEp7JbN245Dhw784qAPvwbna5Z; database=Store;"))
                        {
                            using (MySqlCommand com = new MySqlCommand(query, con))
                            {
                                MySqlDataAdapter ad = new MySqlDataAdapter(com);
                                ad.Fill(dt);
                            }
                        }
                        client.Disconnect();
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("Client cannot be reached...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
