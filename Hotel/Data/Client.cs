using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
    class Client
    {
        private string no_identity;
        private string firstname;
        private string lastname;
        private string phone;
        private string country;

        public string No_identity { get => no_identity; set => no_identity = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Country { get => country; set => country = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
