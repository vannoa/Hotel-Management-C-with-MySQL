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
    public partial class Check_In : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Check_In()
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

        private void Check_In_Load(object sender, EventArgs e)
        {

        }

        private void Btnmenucheckin_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void Btnshowallreservationcheckin_Click(object sender, EventArgs e)
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

        public void binding()
        {
            koneksi kon = new koneksi();
            dataGridView1.DataSource = new koneksi().ShowDatainGridView(getdatasearch());
        }
        public string getdatasearch()
        {
            Data.Reservation dr = new Data.Reservation();
            dr.No_reservasi = tbxreservationid.Text;
            string query = "select * from tb_reservation where no_reservation='" + dr.No_reservasi + "'";
            return query;
        }

        private void Btnsearchreservidcheckin_Click(object sender, EventArgs e)
        {
            koneksi kon = new koneksi();
            Data.Reservation drev = new Data.Reservation();
            drev.No_reservasi = tbxreservationid.Text;
            try
            {
                if (new Controller.ClientReservation().searchreservid(drev))
                {
                    binding();
                    kon.openConnection();
                    drev.No_reservasi = tbxreservationid.Text;
                    string query = "select date_in, date_out from tb_reservation where no_reservation='" + drev.No_reservasi + "'";
                    MySqlDataReader dre = kon.DataReader(query);
                    dre.Read();
                    tbxdateincheckin.Text = dre["date_in"].ToString();
                    tbxdateoutcheckin.Text = dre["date_out"].ToString();
                    kon.closeConnection();
                }
                else
                    MessageBox.Show("Reservation ID belum terdaftar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukan Reserv. ID");
            }
        }
        public int inputcheckin2()
        {
            bool stat = false;
            int v = 0;
            DateTime checkin = DateTime.Now;
            checkin = dtcheckincheckin.Value;
            koneksi kon = new koneksi();
            Data.Reservation dre = new Data.Reservation();
            dre.Check_in = dtcheckincheckin.Value.ToString("yyyy-MM-dd hh:mm:ss");
            dre.No_reservasi = tbxreservationid.Text;
            try
            {
                //MySqlCommand cmd = new MySqlCommand("update tb_reservation set check_in='" + dre.Check_in + "' where no_reservation='" + dre.No_reservasi + "'", conn);
                //checkin = Convert.ToDateTime(tbxcheckinadmin.Text);
                kon.openConnection();
                string query = "update tb_reservation set checkin='" + dre.Check_in + "' where no_reservation='" + dre.No_reservasi + "'";
                kon.ExecuteQueries(query);
                v = 1;
                kon.closeConnection();
            }
            catch (Exception ex)
            {

            }
            return v;
        }
        public int inputcheckin()
        {
            bool stat = false;
            int v = 0;
            DateTime checkin = DateTime.Now;
            checkin = dtcheckincheckin.Value;
            koneksi kon = new koneksi();
            Data.Reservation dre = new Data.Reservation();
            dre.Check_in = dtcheckincheckin.Value.ToString("yyyy-MM-dd hh:mm:ss");
            dre.No_reservasi = tbxreservationid.Text;
            try
            {
                //MySqlCommand cmd = new MySqlCommand("update tb_reservation set check_in='" + dre.Check_in + "' where no_reservation='" + dre.No_reservasi + "'", conn);
                //checkin = Convert.ToDateTime(tbxcheckinadmin.Text);
                kon.openConnection();
                string query = "update tb_reservation set checkin='" + dre.Check_in + "' where no_reservation='" + dre.No_reservasi + "'";
                kon.ExecuteQueries(query);
                v = 1;
                kon.closeConnection();
            }
            catch(Exception ex)
            {

            }
            return v;
        }

        private void Btncheckin_Click(object sender, EventArgs e)
        {
            Data.Reservation dre = new Data.Reservation();
            dre.No_reservasi = tbxreservationid.Text;
            try
            {
                if (inputcheckin()==1)
                {
                    //MessageBox.Show("Reservation '" + dre.No_reservasi + "' belum lunas, lunaskan terlebih dahulu agar dapat Check In!");
                    MessageBox.Show("Reservation ID '" + tbxreservationid.Text + "' berhasil Check In");
                    binding();
                    clearfield();
                }
                /*else if (inputcheckin2()==1)
                {
                    //MessageBox.Show("Reservation '" + dre.No_reservasi + "' belum lunas, lunaskan terlebih dahulu agar dapat Check In!");
                    MessageBox.Show("Reservation ID '" + tbxreservationid.Text + "' berhasil Check In");
                    binding();
                    clearfield();
                }*/
                else
                    MessageBox.Show("Reservation '"+dre.No_reservasi+"' gagal Check In!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Masukan Reserv ID");
            }
        }
        public void clearfield()
        {
            tbxreservationid.Text = "";
            tbxdateincheckin.Text = "";
            tbxdateoutcheckin.Text = "";
            dtcheckincheckin.Value = DateTime.Now;

            btncheckin.Enabled = true;
        }
    }
}
