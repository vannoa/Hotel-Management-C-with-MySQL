using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class koneksi
    {
        //MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection();
        string connectionString =
                    "datasource=127.0.0.1;" +
                    "port=3306;" +
                    "username=root;" +
                    "password=;" +
                    "database=manajemen_hotel;";
        public object ShowDatainGridView(string Query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            object data = ds.Tables[0];
            return data;
        }
        public object ShowDatainGridViewSearch(string Query)
        {
            Data.Reservation drv = new Data.Reservation();
            //string query = "select * from tb_reservation where no_reservation='" + drv.No_reservasi + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "select * from tb_reservation where no_reservation='" + drv.No_reservasi + "'");
            object data = ds.Tables[0];
            return data;
        }
        public MySqlDataReader datareader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public void openConnection()
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }

        public void closeConnection()
        {
            conn = new MySqlConnection(connectionString);
            conn.Close();
        }

        public void ExecuteQueries(string Query)
        {
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
        }
        public void ExecuteQuery(string Query)
        {
            Data.Reservation dr = new Data.Reservation();
            MySqlCommand cmd = new MySqlCommand("select * from tb_reservation where no_reservation='" + dr.No_reservasi + "'");
            cmd.ExecuteNonQuery();
        }
        public MySqlDataReader DataReader(string Query)
        {
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public MySqlDataReader DataReader1(string Query)
        {
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataReader dre = cmd.ExecuteReader();
            return dre;
        }
        public int loginreader(string query)
        {
            //bool stat = false;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else
                return 0;
        }
        public int checkidreader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else
                return 0;
        }
        public int reservreader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else
                return 0;
        }
        public int roomreader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else
                return 0;
        }
        public int clientreader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else
                return 0;
        }
        public int checkinreader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else
                return 0;
        }
        public int checkoutreader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else
                return 0;
        }
        public void clientidreader(string query)
        {
            bool stat = false;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                stat = true;
        }
        /*public void GetData(string Query, string table)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, table);

        }*/
        /*public object ShowDatainGridView(string Query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            object data = ds.Tables[0];
            return data;
        }*/
    }
}
