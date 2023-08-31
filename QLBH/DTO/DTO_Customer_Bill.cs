using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer_Bill
    {
        private int id;
        private int customerid;
        private string billid;

        public DTO_Customer_Bill(int id, int customerid, string billid)
        {
            this.id = id;
            this.customerid = customerid;
            this.billid = billid;
        }

        public int Id { get => id; set => id = value; }
        public int Customerid { get => customerid; set => customerid = value; }
        public string Billid { get => billid; set => billid = value; }
    }
}
