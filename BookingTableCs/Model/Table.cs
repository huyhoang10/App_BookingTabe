using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTableCs.Model
{
    class OBJTable
    {
        private int numTable;
        private int maxGuest;
        private string status;

        public OBJTable(int numTable, int maxGuest)
        {
            this.numTable = numTable;
            this.maxGuest = maxGuest;
        }

        public int NumTable
        {
            get { return numTable; }
            set { numTable = value; }
        }

        public int MaxGuest
        {
            get { return maxGuest; }
            set { maxGuest = value; }
        }
    }
}
