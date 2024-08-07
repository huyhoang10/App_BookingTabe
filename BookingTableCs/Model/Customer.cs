using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTableCs.Model
{
    class Customer
    {
        private int idCustomer;
        private string nameCustomer;
        private string numPhone ;

        public Customer(int idCustomer, string nameCustomer)
        {
            this.idCustomer = idCustomer;
            this.nameCustomer = nameCustomer;
        }

        public Customer()
        { }

        public int IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }

        public string NameCustomer
        {
            get { return nameCustomer; }
            set { nameCustomer = value; }
        }

        public string NumPhone
        {
            get { return numPhone; }
            set { numPhone = value; }

        }
    }
}
