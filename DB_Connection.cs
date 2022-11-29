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

namespace EYN_Store
{
    internal class DB_Connection
    {
        private string host;
        private string username;
        private string password;

        public DB_Connection(string YOUR_SERVER_PATH, string YOUR_USERNAME, string YOUR_PASSWORD)
        {
            host = YOUR_SERVER_PATH;
            username = YOUR_USERNAME;
            password = YOUR_PASSWORD;
        }

        public void Connect ()
        {
            try
            {
                using(var client = new SshClient(host, username, password))
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        ForwardedPortLocal portForwarded = new ForwardedPortLocal("127.0.0.1", 7003, host, 7003);
                        client.AddForwardedPort(portForwarded);
                        portForwarded.Start();
                        using (MySqlConnection con = new MySqlConnection($"server=127.0.0.1; port=7003; user id=root; password=p9d49cih9KUu6XDEp7JbN245Dhw784qAPvwbna5Z; database=Store;"))
                        {
                            using (MySqlCommand com = new MySqlCommand("SELECT * FROM Users", con))
                            {
                                DataTable dt = new DataTable();
                                MySqlDataAdapter ad = new MySqlDataAdapter(com);

                                ad.Fill(dt);
                                Program.data = dt;
                                // dgv_data.DataSource = dt;
                            }
                        }
                        client.Disconnect();
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
        }
    }
}
