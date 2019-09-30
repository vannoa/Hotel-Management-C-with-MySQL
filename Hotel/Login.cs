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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btnregisfrmlogin_Click(object sender, EventArgs e)
        {
            Client_Page cp = new Client_Page();
            cp.Show();
            this.Hide();
        }

        private void Btnloginfrmlogin_Click(object sender, EventArgs e)
        {
            koneksi kon = new koneksi();
            Data.Client dc = new Data.Client();
            dc.No_identity = tbxnoidentitylogin.Text;
            dc.Phone = tbxphonelogin.Text;
            kon.openConnection();
            string query = "select no_identity, phone from tb_client where no_identity='" + dc.No_identity + "' and phone='" + dc.Phone + "'";
            if (kon.loginreader(query) == 1)
            {
                Client_Menu cp = new Client_Menu();
                MessageBox.Show("'"+dc.No_identity+"' Login berhasil!");
                cp.Show();
                cp.lemparidentity(tbxnoidentitylogin.Text);
                this.Hide();
            }
            else if (tbxnoidentitylogin.Text == "admin" && tbxphonelogin.Text == "admin")
            {
                Menu mn = new Menu();
                MessageBox.Show("Login sebagai admin berhasil!");
                mn.Show();
                this.Hide();
            }
            else if (tbxnoidentitylogin.Text == "" && tbxphonelogin.Text == "")
                MessageBox.Show("Masukan No. Identity dan Phone!");
            else
                MessageBox.Show("No. Identity atau Phone salah!");
            kon.closeConnection();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
