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
    public partial class Billing_and_Payment : Form
    {
        public Billing_and_Payment()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Billing_and_Payment_Load(object sender, EventArgs e)
        {
            /*if (binding2() == 1)
            {
                MessageBox.Show("Anda masih Reservation yang belum di bayar!");
                binding2();
            }
            else
                MessageBox.Show("Anda tidak memiliki tunggakan reservasi!");*/

            /*binding2();
            Data.Reservation dr = new Data.Reservation();
            dr.No_reservasi = label6.Text;
            try
            {
                if (readbilpay())
                {
                    MessageBox.Show("Anda mempunyai Reservation yang belum di bayar!");
                }
                else
                    MessageBox.Show("Reservation anda sudah lunas!");
            }
            catch(Exception ex)
            {
                
            }*/
        }
        public bool readbilpay()
        {
            bool stat = false;
            koneksi kon = new koneksi();
            try
            {
                kon.openConnection();
                string query = "select * from tb_reservation where client_id='" + label6 + "' and keterangan=Belum Lunas";
                kon.ExecuteQueries(query);
                stat = true;
                kon.closeConnection();
            }
            catch (Exception ex)
            {

            }
            return stat;
        }
        public void lemparidentity(string no_identity)
        {
            Data.Client dc = new Data.Client();
            koneksi konek = new koneksi();
            dc.No_identity = label6.Text;
            konek.openConnection();
            string query = "select no_identity from tb_client where no_identity='" + no_identity + "'";
            MySqlDataReader dr = konek.DataReader(query);
            dr.Read();
            label6.Text = dr["no_identity"].ToString();
            konek.closeConnection();
        }
        public void binding()
        {
            koneksi kon = new koneksi();
            dataGridView1.DataSource = new koneksi().ShowDatainGridView(getdatasearch());
        }
        public int binding2()
        {
            int a = 0;
            koneksi kon = new koneksi();
            bool stat = false;
            dataGridView1.DataSource = new koneksi().ShowDatainGridView(getdataread());
            a = 1;
            return a;
        }
        public string getdatasearch()
        {
            Data.Reservation dr = new Data.Reservation();
            dr.No_reservasi = tbxreservationidbilpay.Text;
            string query = "select * from tb_reservation where no_reservation='" + dr.No_reservasi + "'";
            return query;
        }
        public string getdataread()
        {
            Data.Reservation dr = new Data.Reservation();
            dr.No_reservasi = tbxreservationidbilpay.Text;
            string query = "select * from tb_reservation where no_reservation='" + dr.No_reservasi + "' and keterangan='Belum Lunas'";
            return query;
        }
        private void Btnmenureserv_Click(object sender, EventArgs e)
        {
            Client_Menu cm = new Client_Menu();
            cm.Show();
            cm.lemparidentity(label6.Text);
            this.Hide();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsearchreservbilpay_Click(object sender, EventArgs e)
        {
            koneksi kon = new koneksi();
            Data.Reservation dr = new Data.Reservation();
            dr.No_reservasi = tbxreservationidbilpay.Text;
            try
            {
                if (new Controller.ClientReservation().searchreservid(dr))
                {
                    binding();
                    Data.Reservation drv = new Data.Reservation();
                    kon.openConnection();
                    drv.No_reservasi = tbxreservationidbilpay.Text;
                    string query = "select billing, cara_bayar from tb_reservation where no_reservation='" + drv.No_reservasi + "'";
                    MySqlDataReader dre = kon.DataReader(query);
                    dre.Read();
                    tbxbilling.Text = dre["billing"].ToString();
                    tbxcarabayarbilpay.Text = dre["cara_bayar"].ToString();
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

        private void Tbxreservationidbilpay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Tbxpembayaranbilpay_TextChanged(object sender, EventArgs e)
        {
            payment();
        }
        public void payment()
        {
            int sisabayar = 0;
            Data.Reservation dr = new Data.Reservation();
            try
            {
                sisabayar = Convert.ToInt32(tbxpembayaranbilpay.Text) - Convert.ToInt32(tbxbilling.Text);
                tbxkembalianbilpay.Text = sisabayar.ToString();
                if (Convert.ToInt32(tbxpembayaranbilpay.Text) > Convert.ToInt32(tbxbilling.Text))
                {
                    tbxketeranganbilpay.Text = "Pembayaran Lunas";
                }
                else
                    tbxketeranganbilpay.Text = "Pembayaran Kurang";
            }
            catch(Exception ex)
            {

            }
        }

        private void Btnbsysrreserv_Click(object sender, EventArgs e)
        {
            bool stat = false;
            Data.Reservation dr = new Data.Reservation();
            try
            {
                if (Convert.ToInt32(tbxpembayaranbilpay.Text) > Convert.ToInt32(tbxbilling.Text))
                {
                    dr.No_reservasi = tbxreservationidbilpay.Text;
                    dr.Pembayaran = Convert.ToInt32(tbxpembayaranbilpay.Text);
                    dr.Kembali = Convert.ToInt32(tbxkembalianbilpay.Text);
                    dr.Keterangan = tbxketeranganbilpay.Text;
                    koneksi kon = new koneksi();
                    kon.openConnection();
                    string query = "update tb_reservation set pembayaran='" + dr.Pembayaran + "', kembalian='" + dr.Kembali + "', keterangan='" + dr.Keterangan + "' where no_reservation='" + dr.No_reservasi + "'";
                    kon.ExecuteQueries(query);
                    stat = true;
                    kon.closeConnection();
                    MessageBox.Show("Pembayaran berhasil!");
                    binding();
                }
                else
                    MessageBox.Show("Uang anda tidak mencukupi!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Anda belum memasukan nominal pembayaran");
            }
        }
        public void clearfieldbilpay()
        {
            tbxreservationidbilpay.Text = "";
            tbxbilling.Text = "";
            tbxcarabayarbilpay.Text = "";
            tbxpembayaranbilpay.Text = "";
            tbxkembalianbilpay.Text = "";
            tbxketeranganbilpay.Text = "";

            btnbsysrreserv.Enabled = true;
            btnsearchreservbilpay.Enabled = true;
        }
    }
}
