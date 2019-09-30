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
    public partial class Check_Out : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Check_Out()
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

        private void Check_Out_Load(object sender, EventArgs e)
        {
            
        }

        private void Btnsearchreseridcheckout_Click(object sender, EventArgs e)
        {
            
            koneksi kon = new koneksi();
            Data.Reservation dr = new Data.Reservation();
            dr.No_reservasi = tbxreservationidcheckout.Text;
            try
            {
                if (new Controller.ClientReservation().searchreservid(dr))
                {
                    binding();
                    kon.openConnection();
                    dr.No_reservasi = tbxreservationidcheckout.Text;
                    string query = "select date_in, date_out, checkin from tb_reservation where no_reservation='" + dr.No_reservasi + "'";
                    MySqlDataReader dre = kon.DataReader(query);
                    dre.Read();
                    tbxdateincheckout.Text = dre["date_in"].ToString();
                    tbxdateoutcheckout.Text = dre["date_out"].ToString();
                    tbxcheckincheckout.Text = dre["checkin"].ToString();
                    kon.closeConnection();
                }
                else
                    MessageBox.Show("Reservation ID belum terdaftar!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Masukan Reserv. ID");
            }
        }
        public void binding()
        {
            koneksi kon = new koneksi();
            dataGridView1.DataSource = new koneksi().ShowDatainGridView(getdatasearch());
        }
        public string getdatasearch()
        {
            Data.Reservation dr = new Data.Reservation();
            dr.No_reservasi = tbxreservationidcheckout.Text;
            string query = "select * from tb_reservation where no_reservation='" + dr.No_reservasi + "'";
            return query;
        }
        public int inputcheckout()
        {
            bool stat = false;
            int v = 0;
            DateTime checkin = DateTime.Now;
            checkin = dtcheckoutcheckout.Value;
            koneksi kon = new koneksi();
            Data.Reservation dre = new Data.Reservation();
            dre.Check_out =dtcheckoutcheckout.Value.ToString("yyyy-MM-dd hh:mm:ss");
            dre.Check_in = tbxcheckincheckout.Text;
            dre.No_reservasi = tbxreservationidcheckout.Text;
            try
            {
                //MySqlCommand cmd = new MySqlCommand("update tb_reservation set check_in='" + dre.Check_in + "' where no_reservation='" + dre.No_reservasi + "'", conn);
                //checkin = Convert.ToDateTime(tbxcheckinadmin.Text);
                kon.openConnection();
                string query = "update tb_reservation set checkout='" + dre.Check_out + "' where no_reservation='" + dre.No_reservasi + "'";
                kon.ExecuteQueries(query);
                v = 1;
                kon.closeConnection();
            }
            catch (Exception ex)
            {

            }
            return v;
        }

        private void Btnmenucheckout_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void Btnshowallreservationcheckout_Click(object sender, EventArgs e)
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

        private void Btncheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputcheckout() == 1)
                {
                    MessageBox.Show("Reservation ID '" + tbxreservationidcheckout.Text + "' berhasil Check Out");
                    binding();
                    clearfield();
                }
                else
                    MessageBox.Show("Reservation ID '"+tbxreservationidcheckout.Text+"' harus Check In terlebih dahulu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukan Reserv ID");
            }
        }
        public void clearfield()
        {
            tbxreservationidcheckout.Text = "";
            tbxdateincheckout.Text = "";
            tbxdateoutcheckout.Text = "";
            tbxcheckincheckout.Text = "";
            dtcheckoutcheckout.Value = DateTime.Now;

            btncheckout.Enabled = true;
        }
    }
}
