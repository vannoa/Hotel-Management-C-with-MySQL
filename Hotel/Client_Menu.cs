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
    public partial class Client_Menu : Form
    {
        public Client_Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Btnreservationmenuclient_Click(object sender, EventArgs e)
        {
            Reservation_Page rp = new Reservation_Page();
            rp.Show();
            rp.lemparidentity(lblnoidentity.Text);
            this.Hide();
        }

        private void Client_Menu_Load(object sender, EventArgs e)
        {

        }
        public void lemparidentity(string no_identity)
        {
            Data.Client dc = new Data.Client();
            koneksi konek = new koneksi();
            dc.No_identity = lblnoidentity.Text;
            konek.openConnection();
            string query = "select no_identity from tb_client where no_identity='" + no_identity + "'";
            MySqlDataReader dr = konek.DataReader(query);
            dr.Read();
            lblnoidentity.Text = dr["no_identity"].ToString();
            konek.closeConnection();
        }

        private void Btnlogoutclient_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Btnbillpayclient_Click(object sender, EventArgs e)
        {
            Billing_and_Payment bp = new Billing_and_Payment();
            bp.Show();
            bp.lemparidentity(lblnoidentity.Text);
            this.Hide();
        }
    }
}
