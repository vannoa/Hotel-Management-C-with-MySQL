using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controller
{
    class RoomCtrl
    {
        public bool addroom(Data.Room dr)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "insert into tb_room values('" + dr.Roomid + "', '" + dr.Roomtype + "', '" + dr.Roomprice + "')";
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
        public bool editroom(Data.Room dro)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "update tb_room set type_room='" + dro.Roomtype + "',price_room='" + dro.Roomprice + "' where room_id='"+dro.Roomid+"'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch (Exception ex)
            {
                
            }
            return stat;
        }
        public bool deleteroom(Data.Room drm)
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "delete from tb_room where room_id='" + drm.Roomid + "'";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch (Exception ex)
            {

            }
            return stat;
        }
        public string getdataroom()
        {
            string query = "select * from tb_room order by room_id asc";
            return query;
        }
    }
}
