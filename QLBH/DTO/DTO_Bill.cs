using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {
        private int BillID;
        private DateTime time;
        private int UserID;
        private float totalprice;




        public DTO_Bill() { }
        public DTO_Bill(int billID, DateTime time, int userID, float totalprice)
        {
            BillID = billID;
            this.time = time;
            UserID = userID;
            this.totalprice = totalprice;
        }
       

        public int BillID1 { get => BillID; set => BillID = value; }
        public DateTime Time { get => time; set => time = value; }
        public int UserID1 { get => UserID; set => UserID = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
