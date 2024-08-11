using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTableCs.Model
{
    class Customer
    {
        private int idCustomer;                 // OOP: Encapsulation (đóng gói)
        private string nameCustomer;
        private string numPhone ;

        public Customer(int idCustomer, string nameCustomer, string numPhone)
        {
            this.idCustomer = idCustomer;
            this.nameCustomer = nameCustomer;
            this.numPhone = numPhone;
        }

        public Customer()
        { }

        public int IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }

        public string NameCustomer          //      OOP: Encapsulation (đóng gói)
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

    abstract class CustomerVip : Customer           // OOP: abstract (trừu tượng): không thể tạo đối tượng từ lớp này
    {
        private float discount;
        public virtual float Discount()
        {
            discount = 0;
            return discount;
        }
    }

    class SilverCustomer : CustomerVip              // OOP: Inheritance (kế thừa): 
    {
        private float discount = 0.04f;
        public override float Discount()            // OOP: Polymorphism (đa hình)
        {
            return discount;
            return base.Discount();
        }
    }
    class GoldCustomer : CustomerVip
    {
        private float discount = 0.07f;
        public override float Discount()            // OOP: Polymorphism (đa hình)
        {
            return discount;
            return base.Discount();
        }
    }

}
