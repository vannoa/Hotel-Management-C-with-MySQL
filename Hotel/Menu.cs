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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Btnmanageclientmenu_Click(object sender, EventArgs e)
        {
            Manage_Client mc = new Manage_Client();
            mc.Show();
            this.Hide();
        }

        private void Btnmanageroommenu_Click(object sender, EventArgs e)
        {
            Manage_Rooms mro = new Manage_Rooms();
            mro.Show();
            this.Hide();
        }

        private void Btnmanagereservationmenu_Click(object sender, EventArgs e)
        {
            Manage_Reservations mrv = new Manage_Reservations();
            mrv.Show();
            this.Hide();
        }

        private void Btnlogoutadmin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Btncheckinmenu_Click(object sender, EventArgs e)
        {
            Check_In cin = new Check_In();
            cin.Show();
            this.Hide();
        }

        private void Btncheckoutmenu_Click(object sender, EventArgs e)
        {
            Check_Out cout = new Check_Out();
            cout.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
