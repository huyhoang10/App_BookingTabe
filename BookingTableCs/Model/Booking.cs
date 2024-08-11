using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTableCs.Model
{
    class Booking
    {
        private string idCustomer;
        private DateTime dateBooking;
        private int idTable;
        private int numGuest;

        public Booking()
        { }
        public Booking(DateTime dateBooking, string idCustomer, int idTable, int numGuest)
        {
            this.dateBooking = dateBooking;
            this.idCustomer = idCustomer;
            this.idTable = idTable;
            this.numGuest = numGuest;
        }

        public DateTime DateBooking
        {
            get { return dateBooking; }
            set { dateBooking = value; }
        }

        public string IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        public int IdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }
        public int NumGuest
        {
            get { return numGuest; }
            set { numGuest = value; }
        }

    }
}
