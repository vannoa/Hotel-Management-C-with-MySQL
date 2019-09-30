using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
    class Reservation
    {
        private string no_reservasi;
        private string client_id;
        private string room_type;
        private int room_price;
        private int no_room;
        private string booking_date;
        private string date_in;
        private string date_out;
        private string check_in;
        private string check_out;
        private int billing;
        private string carabayar;
        private int pembayaran;
        private int kembali;
        private int lamahari;
        private string keterangan;
        public string Client_id { get => client_id; set => client_id = value; }
        public string Room_type { get => room_type; set => room_type = value; }
        public int Room_price { get => room_price; set => room_price = value; }
        public string No_reservasi { get => no_reservasi; set => no_reservasi = value; }
        public string Date_in { get => date_in; set => date_in = value; }
        public string Date_out { get => date_out; set => date_out = value; }
        public int No_room { get => no_room; set => no_room = value; }
        public string Check_in { get => check_in; set => check_in = value; }
        public string Check_out { get => check_out; set => check_out = value; }
        public int Billing { get => billing; set => billing = value; }
        public int Pembayaran { get => pembayaran; set => pembayaran = value; }
        public int Kembali { get => kembali; set => kembali = value; }
        public int Lamahari { get => lamahari; set => lamahari = value; }
        public string Carabayar { get => carabayar; set => carabayar = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
        public string Booking_date { get => booking_date; set => booking_date = value; }
    }
}
