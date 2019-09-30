using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controller
{
    class RegisClient
    {
        public bool login(string no_identity, string phone)
        {
            bool stat = false;
                koneksi kon = new koneksi();
                Data.Client dc = new Data.Client();
                kon.openConnection();
                string query = "select no_identity, phone from tb_client where no_identity='" + dc.No_identity + "' and phone='" + dc.Phone + "'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            
            return stat;
        }
        /*public bool readclientid(Data.Client dc)
        {
            bool stat = false;
            koneksi kon =new koneksi;
            try
            {
                kon.openConnection();
                string query = "select client_id from tb_reservation";

            }
        }*/
        public bool loginadmin(string no_identity, string phone)
        {
            bool stat = false;
                koneksi kon = new koneksi();
                Data.Client dc = new Data.Client();
                kon.openConnection();
                string query = "select no_identity, phone from tb_client where no_identity='admin' and phone='admin'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            
            return stat;
        }
        public bool registrasi(Data.Client dc)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "insert into tb_client values('" + dc.No_identity + "', '" + dc.Firstname + "', '" + dc.Lastname + "', '" + dc.Phone + "', '" + dc.Country + "')";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return stat;
        }
        public bool updateclient(Data.Client dc)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "update tb_client set firstname='"+dc.Firstname+"',lastname='"+dc.Lastname+"',phone='"+dc.Phone+"', country='"+dc.Country+"' where no_identity='"+dc.No_identity+"'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch(Exception ex)
            {

            }
            return stat;
        }
        public bool deleteclient(Data.Client dc)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "delete from tb_client where no_identity='" + dc.No_identity + "'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch(Exception ex)
            {

            }
            return stat;
        }
        public string getdataclient()
        {
            string query = "select * from tb_client order by no_identity asc";
            return query;
        }
    }
}
