using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BillDetail
    {
        private int BillDetailID;
        private int BillID;
        private int ProductID;
        private string productname;
        private int quantity;
        private float UnitPrice;

        public DTO_BillDetail() { }
        public DTO_BillDetail(int billDetailID, int billID, int productID,string productname, int quantity, float unitPrice)
        {
            BillDetailID = billDetailID;
            BillID = billID;
            ProductID = productID;
            UnitPrice = unitPrice;
            this.productname = productname;
            this.quantity = quantity;

        }

        public int BillDetailID1 { get => BillDetailID; set => BillDetailID = value; }
        public int BillID1 { get => BillID; set => BillID = value; }
        public int ProductID1 { get => ProductID; set => ProductID = value; }
        public float UnitPrice1 { get => UnitPrice; set => UnitPrice = value; }
        public string Productname { get => productname; set => productname = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
