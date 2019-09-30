using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Controller
{
    class ClientReservation
    {
        public bool reservationclient(Data.Reservation drv)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "insert into tb_reservation values('" + drv.No_reservasi + "', '" + drv.Client_id + "', '" + drv.Room_type + "', '" +drv.Room_price + "', '" + drv.No_room + "', '"+drv.Booking_date+"', '"+drv.Date_in+"', '"+drv.Date_out+ "', null, null, '"+drv.Room_price+"' * '"+drv.No_room+"','"+drv.Carabayar+"', null, null, 'Belum Lunas')";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return stat;
        }
        public bool searchreservid(Data.Reservation dr)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "select * from tb_reservation where no_reservation='" + dr.No_reservasi + "'";
                //kon.ExecuteQueries("select * from tb_reservation where no_reservation='" + dr.No_reservasi + "'");
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }

            catch(Exception ex)
            {

            }
            return stat;
        }
        public bool editreservation(Data.Reservation drv)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "update tb_reservation set client_id='" + drv.Client_id + "',room_type='" + drv.Room_type + "',room_price='" + drv.Room_price + "', no_room='" + drv.No_room + "',booking_date='"+drv.Booking_date+"', date_in='"+drv.Date_in+"',date_out='"+drv.Date_out+"', cara_bayar='"+drv.Carabayar+"' where no_reservation='"+drv.No_reservasi+"'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch (Exception ex)
            {

            }
            return stat;
        }
        public bool deletereservation(Data.Reservation dre)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "delete from tb_reservation where no_reservation='" + dre.No_reservasi + "'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch(Exception ex)
            {

            }
            return stat;
        }
        public string getdatareservation()
        {
            string query = "select * from tb_reservation order by no_reservation asc";
            return query;
        }
        public bool bilpay(Data.Reservation dr)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "update tb_reservation set pembayaran='" + dr.Pembayaran + "',kembalian=@kembalian-'" + dr.Pembayaran + "', keterangan='" + dr.Keterangan + "' where no_reservation='" + dr.No_reservasi + "' ";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch (Exception ex)
            {

            }
            return stat;
        }
    }
}
