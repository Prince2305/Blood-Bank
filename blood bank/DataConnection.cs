using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blood_bank
{
 
    class DataConnection
    {
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=bloodbank");
        public void openconnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            { connect.Open(); }
        }
        public void closeconnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            { connect.Close(); }
        }

        public MySqlDataReader executeReader(string sql)
        {
            MySqlDataReader msc;
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            msc = cmd.ExecuteReader();
            return msc;
        }
        public MySqlDataAdapter sda(String sql)
        {
            MySqlDataAdapter cmd = new MySqlDataAdapter(sql, connect);
            return cmd;
        }
    }
}
