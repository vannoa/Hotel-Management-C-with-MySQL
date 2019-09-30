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
    public partial class Manage_Client : Form
    {

        MySqlConnection conn = new MySqlConnection();
        MySqlDataAdapter adapter;
        public Manage_Client()
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
        private void Manage_Client_Load(object sender, EventArgs e)
        {

        }
        public void binding()
        {
            koneksi kon = new koneksi();
            dataGridView1.DataSource = new koneksi().ShowDatainGridView(new Controller.RegisClient().getdataclient());
        }
        private void Btnshowallclient_Click(object sender, EventArgs e)
        {
            koneksi kon = new koneksi();
            string query = "select * from tb_client";
            adapter = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "tb_client");
            conn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tb_client";
        }

        private void Btnmenuclient_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void Btnaddnewclientadmin_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Client dc = new Data.Client();
                dc.No_identity = tbxnoidentityadmin.Text;
                dc.Firstname = tbxfirstnameadmin.Text;
                dc.Lastname = tbxlastnameadmin.Text;
                dc.Phone = tbxphoneadmin.Text;
                dc.Country = tbxcountryadmin.Text;
                if (new Controller.RegisClient().registrasi(dc))
                {
                    MessageBox.Show("Registrasi dengan ID '"+dc.No_identity+"' telah terdaftar!");
                    binding();
                    clearfieldcl();
                }
                else
                    MessageBox.Show("Registrasi gagal, isi form dengan benar!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("isi form dengan benar!");
            }
        }

        private void Btneditclient_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Client dcl = new Data.Client();
                dcl.No_identity = tbxnoidentityadmin.Text;
                dcl.Firstname = tbxfirstnameadmin.Text;
                dcl.Lastname = tbxlastnameadmin.Text;
                dcl.Phone = tbxphoneadmin.Text;
                dcl.Country = tbxcountryadmin.Text;
                if (new Controller.RegisClient().updateclient(dcl))
                {
                    MessageBox.Show("Data dengan id '"+dcl.No_identity+"' berhasil di edit!");
                    binding();
                    clearfieldcl();
                }
                else
                    MessageBox.Show("Data gagal di edit!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pilih Client yang ingin di edit!");
            }
        }

        private void Btnclearfieldclient_Click(object sender, EventArgs e)
        {
            clearfieldcl();
        }

        private void Btnremoveclient_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Client dcle = new Data.Client();
                dcle.No_identity = tbxnoidentityadmin.Text;
                koneksi kon = new koneksi();
                if (new Controller.RegisClient().deleteclient(dcle))
                {
                    MessageBox.Show("Client dengan ID '"+dcle.No_identity+"' berhasil dihapus dari data!");
                    binding();
                    clearfieldcl();
                }
                else
                    MessageBox.Show("Client gagal di hapus!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pilih Client yang ingin di hapus!");
            }
        }
        public void clearfieldcl()
        {
            tbxnoidentityadmin.Text = "";
            tbxfirstnameadmin.Text = "";
            tbxlastnameadmin.Text = "";
            tbxphoneadmin.Text = "";
            tbxcountryadmin.Text = "";

            tbxnoidentityadmin.Enabled = true;
            btnaddnewclientadmin.Enabled = true;
        }
    }
}
