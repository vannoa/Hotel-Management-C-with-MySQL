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
    public partial class Client_Page : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Client_Page()
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

        private void Btnaddnewclientregis_Click(object sender, EventArgs e)
        {
            Data.Client dc = new Data.Client();
            dc.No_identity = tbxnoidentityregis.Text;
            dc.Firstname = tbxfirstnameregis.Text;
            dc.Lastname = tbxlastnameregis.Text;
            dc.Phone = tbxphoneregis.Text;
            dc.Country = tbxcountryregis.Text;
            if (new Controller.RegisClient().registrasi(dc))
            {
                MessageBox.Show("Registrasi '" + dc.No_identity + "' berhasil!");
                Client_Page cp = new Client_Page();
            }
            else
                MessageBox.Show("Registrasi gagal, isi form dengan benar atau ID sudah terpakai!");

        }

        private void Btnsigninregis_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void Client_Page_Load(object sender, EventArgs e)
        {

        }

        private void Tbxnoidentityregis_TextChanged(object sender, EventArgs e)
        {
            /*koneksi kon = new koneksi();
            Data.Client dc = new Data.Client();
            dc.No_identity = tbxnoidentityregis.Text;
            kon.openConnection();
            string query = "select client_id from tb_client";
            if (kon.clientidreader(query) = tbxnoidentityregis.Text)
            {
                label2.Text = "Client ID sudah terpakai!";
            }
            else
                label2.Text = "Client ID bisa digunakan!";*/
        }
        public void checkid()
        {
                bool stat = false;
                Data.Client dc = new Data.Client();
                koneksi kon = new koneksi();
                dc.No_identity = tbxnoidentityregis.Text;
                kon.openConnection();
                string query = "select no_identity from tb_client where no_identity = '"+dc.No_identity+"'";
                if (kon.checkidreader(query) == 1)
                {
                    lblcheckidclient.Text = "'" + tbxnoidentityregis.Text + "' sudah terpakai!";
                }
                else
                {
                    lblcheckidclient.Text = "'" + tbxnoidentityregis.Text + "' bisa digunakan!";                   
                }
            kon.closeConnection();
            //return stat;
        }

        private void Btncheckid_Click(object sender, EventArgs e)
        {
            checkid();
        }
    }
}
