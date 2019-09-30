using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
    class Room
    {
        private string roomid;
        private string roomtype;
        private Int32 roomprice;

        public string Roomid { get => roomid; set => roomid = value; }
        public string Roomtype { get => roomtype; set => roomtype = value; }
        public int Roomprice { get => roomprice; set => roomprice = value; }
    }
}
