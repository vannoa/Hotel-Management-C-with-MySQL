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
    public partial class Manage_Reservations : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlDataAdapter adapter;
        public Manage_Reservations()
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

        private void Btnshowallreservation_Click(object sender, EventArgs e)
        {
            koneksi kon = new koneksi();
            string query = "select * from tb_reservation";
            adapter = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "tb_reservation");
            conn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tb_reservation";
        }

        private void Btnmenureserv_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void Btnaddreservadmin_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation_Page rp = new Reservation_Page();
                koneksi kon = new koneksi();
                Data.Reservation drv = new Data.Reservation();
                drv.No_reservasi = tbxreservationid.Text;
                drv.Client_id = tbxclientidreserv.Text;
                drv.Room_type = cbxroomtypereserv.Text;
                drv.Room_price = Convert.ToInt32(tbxroompriceadmin.Text);
                drv.No_room = Convert.ToInt32(tbxnoroomadmin.Text);
                drv.Booking_date = dateTimePicker3.Value.ToString("yyyy-MM-dd hh:mm:ss");
                drv.Date_in = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
                drv.Date_out = dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss");
                drv.Carabayar = cbxcarabayarreservadmin.Text;

                //drv.Lamahari = Convert.ToInt32(tbxjumlahhari.Text);
                if (new Controller.ClientReservation().reservationclient(drv))
                {
                    MessageBox.Show("Reservation '"+drv.No_reservasi+"' Success");
                    binding();
                    generateKode();
                    clearfieldrv();
                }
                else
                    MessageBox.Show("Reservation Failed");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lengkapi persyaratan dengan benar");
            }
        }

        private void Cbxroomtypereserv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation_Page rp = new Reservation_Page();
            pilihtipe();
        }
        public void binding()
        {
            koneksi kon = new koneksi();
            dataGridView1.DataSource = new koneksi().ShowDatainGridView(new Controller.ClientReservation().getdatareservation());
        }
        private void Manage_Reservations_Load(object sender, EventArgs e)
        {
            linkcbx();
        }
        public void linkcbx()
        {
            koneksi kon = new koneksi();
            kon.openConnection();
            adapter = new MySqlDataAdapter("select type_room from tb_room order by room_id asc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbxroomtypereserv.DisplayMember = "type_room";
            cbxroomtypereserv.DataSource = dt;
            kon.closeConnection();
        }
        private void Btnclearfieldadmin_Click(object sender, EventArgs e)
        {
            Reservation_Page rp = new Reservation_Page();
            clearfieldrv();
        }

        private void Lbldateinreserv_Click(object sender, EventArgs e)
        {

        }

        private void Btneditreservadmin_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Reservation dre = new Data.Reservation();
                dre.No_reservasi = tbxreservationid.Text;
                dre.Client_id = tbxclientidreserv.Text;
                dre.Room_type = cbxroomtypereserv.Text;
                dre.Room_price = Convert.ToInt32(tbxroompriceadmin.Text);
                dre.No_room = Convert.ToInt32(tbxnoroomadmin.Text);
                dre.Booking_date = dateTimePicker3.Value.ToString("yyyy-MM-dd hh:mm:ss");
                dre.Date_in = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                dre.Date_out = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                dre.Carabayar = cbxcarabayarreservadmin.Text;
                //dre.Lamahari =Convert.ToInt32(tbxjumlahhari.Text);

                if (new Controller.ClientReservation().editreservation(dre))
                {
                    MessageBox.Show("Reservasi dengan ID '"+dre.No_reservasi+"' berhasil di edit!");
                    binding();
                    clearfieldrv();
                }
                else
                    MessageBox.Show("Reservasi gagal di edit!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pilih Reservation yang ingin di edit");
            }
        }

        private void Btnremovereservadmin_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Reservation drev = new Data.Reservation();
                drev.No_reservasi = tbxreservationid.Text;

                if (new Controller.ClientReservation().deletereservation(drev))
                {
                    MessageBox.Show("Reservation dengan ID '"+drev.No_reservasi+"' berhasil di hapus!");
                    binding();
                    clearfieldrv();
                }
                else
                    MessageBox.Show("Data gagal di hapus!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pilih reservation yang ingin di hapus");
            }
        }
        public void clearfieldrv()
        {
            tbxreservationid.Text = "";
            tbxclientidreserv.Text = "";
            cbxroomtypereserv.Text = "";
            tbxroompriceadmin.Text = "";
            tbxnoroomadmin.Text = "";
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            cbxcarabayarreservadmin.Text = "";
            //tbxjumlahhari.Text = "";

            btnaddreservadmin.Enabled = true;
        }
        public void pilihtipe()
        {
            Data.Reservation dr = new Data.Reservation();
            koneksi kon = new koneksi();
            kon.openConnection();
            string query = "select price_room from tb_room where type_room = '" + cbxroomtypereserv.Text + "'";
            MySqlDataReader dre = kon.DataReader1(query);
            dre.Read();
            tbxroompriceadmin.Text = dre["price_room"].ToString();
            kon.closeConnection();
        }
        public string generateKode()
        {
            string query = "Select Max(no_reservation) as ReservID from tb_reservation";
            koneksi k = new koneksi();
            k.openConnection();
            MySqlDataReader dr = k.DataReader(query);
            dr.Read();
            string kode = dr["ReservID"].ToString();
            int angka;
            if (kode == "")
            {
                angka = 0;
            }
            else
            {
                angka = int.Parse(kode.Substring(3, 3));
            }
            angka += 1;
            string id = "RV-" + (string.Format("{0:00}", angka.ToString().PadLeft(3, '0')));
            k.closeConnection();
            return id;
        }
        /*public void hitunghariadmin()
        {
            Data.Reservation dr = new Data.Reservation();
            dr.Date_in = dateTimePicker1.Value.ToString(" d");
            dr.Date_out = dateTimePicker2.Value.ToString(" d");
            lamahariadmin = Convert.ToInt32(dr.Date_in) - Convert.ToInt32(dr.Date_out);
            lamahariadmin = Convert.ToInt32(tbxjumlahhari.Text);
        }*/
    }
}
