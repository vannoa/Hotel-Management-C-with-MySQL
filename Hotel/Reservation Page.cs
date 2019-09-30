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
    public partial class Reservation_Page : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Reservation_Page()
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

        private void Reservation_Page_Load(object sender, EventArgs e)
        {
            tbxreservationidclient.Text = generateKode();
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
        public void lemparidentity(string no_identity)
        {
            Data.Client dc = new Data.Client();
            koneksi konek = new koneksi();
            dc.No_identity = tbxclientidreserv.Text;
            konek.openConnection();
            string query = "select no_identity from tb_client where no_identity='" + no_identity + "'";
            MySqlDataReader dr = konek.DataReader(query);
            dr.Read();
            tbxclientidreserv.Text = dr["no_identity"].ToString();
            konek.closeConnection();
        }
        public void ClearField()
        {
            cbxroomtypereserv.Text = "";
            tbxnoroomreserv.Text = "";
            tbxroompricereserv.Text = "";
            dtbookingdate.Value = DateTime.Now;
            dtdatein.Value = DateTime.Now;
            dtdateout.Value = DateTime.Now;
            cbxcarabayarreserv.Text = "";

            lbladdreservationclient.Enabled = true;
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
        

        private void Cbxroomtypereserv_SelectedIndexChanged(object sender, EventArgs e)
        {
            pilihtipe();
        }
        public void pilihtipe()
        {
            Data.Reservation dr = new Data.Reservation();
            koneksi kon = new koneksi();
            kon.openConnection();
            string query = "select price_room from tb_room where type_room = '"+cbxroomtypereserv.Text+"'";
            MySqlDataReader dre = kon.DataReader1(query);
            dre.Read();
            tbxroompricereserv.Text = dre["price_room"].ToString();
            kon.closeConnection();
        }

        private void Lbladdreservationclient_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi kon = new koneksi();
                Data.Reservation drv = new Data.Reservation();
                drv.No_reservasi = tbxreservationidclient.Text;
                drv.Client_id = tbxclientidreserv.Text;
                drv.Room_type = cbxroomtypereserv.Text;
                drv.Room_price = Convert.ToInt32(tbxroompricereserv.Text);
                drv.No_room = Convert.ToInt32(tbxnoroomreserv.Text);
                drv.Booking_date = dtbookingdate.Value.ToString("yyyy-MM-dd hh:mm:ss");
                drv.Date_in = dtdatein.Value.ToString("yyyy-MM-dd hh:mm:ss");
                drv.Date_out = dtdateout.Value.ToString("yyyy-MM-dd hh:mm:ss");
                drv.Carabayar = cbxcarabayarreserv.Text;
                //drv.Lamahari = Convert.ToInt32(tbxjumlahhari.Text);
                if (new Controller.ClientReservation().reservationclient(drv))
                {
                    MessageBox.Show("Reservation '"+drv.No_reservasi+"' Success");
                    ClearField();
                }
                else
                    MessageBox.Show("Reservation Failed");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lengkapi persyaratan reservasi!");
            }
            /*kon.openConnection();
            string query = "insert into tb_reservation values('" + drv.No_reservasi + "', '" + drv.Client_id + "', '" + drv.Room_type + "', '" + drv.Room_price + "', '" + drv.No_room + "', '" + drv.Date_in + "', '" + drv.Date_out + "')";
            kon.ExecuteQueries(query);
            stat = true;
            kon.closeConnection();
            if (stat)
            {
                MessageBox.Show("Reservation Success");
            }
            else
                MessageBox.Show("Reservation Failed");*/
        }

        private void Lblclientidreserv_Click(object sender, EventArgs e)
        {

        }

        private void Btnclearfieldreservpage_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void Dtdateout_ValueChanged(object sender, EventArgs e)
        {
            //hitunghari();
            dtdateout.MinDate = DateTime.Now;
        }

        private void Btnbillingpayment_Click(object sender, EventArgs e)
        {
            Billing_and_Payment bp = new Billing_and_Payment();
            bp.Show();
            bp.lemparidentity(tbxclientidreserv.Text);
            this.Hide();
        }

        private void Btnmenureserv_Click(object sender, EventArgs e)
        {
            Client_Menu cm = new Client_Menu();
            cm.Show();
            cm.lemparidentity(tbxclientidreserv.Text);
            this.Hide();
        }

        private void Dtdatein_ValueChanged(object sender, EventArgs e)
        {
            dtdatein.MinDate = DateTime.Now;
        }
    }
}
