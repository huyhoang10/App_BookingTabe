using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTableCs.Model
{
    class Booking
    {
        private string numPhone;
        private string nameCustomer;
        private DateTime dateBooking;
        private int numTable;
        private int numGuest;

        public Booking(DateTime dateBooking, string nameCustomer, string numPhone, int numTable, int numGuest)
        {
            this.dateBooking = dateBooking;
            this.nameCustomer = nameCustomer;
            this.numPhone = numPhone;
            this.numTable = numTable;
            this.numGuest = numGuest;
        }

    }
}
