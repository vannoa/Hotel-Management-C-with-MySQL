using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Manage_Rooms : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Manage_Rooms()
        {
            InitializeComponent();
            this.CenterToScreen();
            string connectionstring =
            "datasource=127.0.0.1;" +
            "port=3306;" +
            "username=root;" +
            "password=;" +
            "database=manajemen_hotel;";

            conn = new MySqlConnection(connectionstring);
        }
        public void binding()
        {
            koneksi kon = new koneksi();
            dataGridView1.DataSource = new koneksi().ShowDatainGridView(new Controller.RoomCtrl().getdataroom());
        }

        private void Btnshowallroom_Click(object sender, EventArgs e)
        {
            koneksi kon = new koneksi();
            string query = "select * from tb_room";
            adapter = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "tb_room");
            conn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tb_room";
        }

        private void Btnmenuroom_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void Btnclearfieldroom_Click(object sender, EventArgs e)
        {
            clearfieldrm();
        }

        private void Btnaddnewroom_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Room dr = new Data.Room();
                dr.Roomid = tbxroomidfrmroom.Text;
                dr.Roomtype = tbxroomtypefrmroom.Text;
                dr.Roomprice = Convert.ToInt32(tbxroompricefrmroom.Text);
                if (new Controller.RoomCtrl().addroom(dr))
                {
                    MessageBox.Show("Room ID '"+dr.Roomid+"' berhasil ditambahkan, silakan keluar dari page ini untuk merefresh room terbaru!");
                    binding();
                    clearfieldrm();
                }
                else
                    MessageBox.Show("Room gagal di tambahkan!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ruangan gagal ditambahkan, lengkapi data untuk menambahkan ruangan");
            }
        }

        private void Manage_Rooms_Load(object sender, EventArgs e)
        {
            linkcbx();
        }


        private void Btneditroom_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Room drm = new Data.Room();
                drm.Roomid = tbxroomidfrmroom.Text;
                drm.Roomtype = tbxroomtypefrmroom.Text;
                drm.Roomprice = Convert.ToInt32(tbxroompricefrmroom.Text);
                if (new Controller.RoomCtrl().editroom(drm))
                {
                    MessageBox.Show("Room ID '"+drm.Roomid+ "' berhasil di edit, silakan keluar dari page ini untuk merefresh room terbaru!");
                    binding();
                    clearfieldrm();
                }
                else
                    MessageBox.Show("Room gagal di edit!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pilih Room yang ingin di edit!");
            }
        }

        private void Btnremoveroom_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Room droom = new Data.Room();
                droom.Roomid = tbxroomidfrmroom.Text;
                if (new Controller.RoomCtrl().deleteroom(droom))
                {
                    MessageBox.Show("Room dengan ID '"+droom.Roomid+ "' berhasil di hapus, silakan keluar dari page ini untuk merefresh room terbaru!");
                    binding();
                    clearfieldrm();
                }
                else
                    MessageBox.Show("Room gagal di hapus!");
            }
            catch(Exception ex)
            {

            }
        }
        public void clearfieldrm()
        {
            tbxroomidfrmroom.Text = "";
            tbxroomtypefrmroom.Text = "";
            tbxroompricefrmroom.Text = "";

            btnaddnewroom.Enabled = true;
        }
        public void linkcbx()
        {
            koneksi kon = new koneksi();
            kon.openConnection();
            adapter = new MySqlDataAdapter("select type_room from tb_room order by room_id asc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            tbxroomtypefrmroom.DisplayMember = "type_room";
            tbxroomtypefrmroom.DataSource = dt;
            kon.closeConnection();
        }
        public void pilihtipe()
        {
            Data.Reservation dr = new Data.Reservation();
            koneksi kon = new koneksi();
            kon.openConnection();
            Data.Reservation drev = new Data.Reservation();
            drev.Room_type = tbxroomtypefrmroom.Text;
            string query = "select price_room from tb_room where type_room = '" + drev.Room_type + "'";
            MySqlDataReader dre = kon.DataReader1(query);
            dre.Read();
            tbxroompricefrmroom.Text = dre["price_room"].ToString();
            kon.closeConnection();
        }

        private void Tbxroomtypefrmroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            pilihtipe();
        }
    }
}
