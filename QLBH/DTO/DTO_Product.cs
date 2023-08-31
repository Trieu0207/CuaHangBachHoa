using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {
        private int ProductID;
        private int CategoryID;
        private string productname;
        private float price;
        private int quantity;
        private string note;

        public DTO_Product() { }

        public DTO_Product(int productID, int categoryID, string productname, float price, int quantity, string note)
        {
            this.ProductID = productID;
            this.CategoryID = categoryID;
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
            this.note = note;
        }
      

        public int ProductID1 { get => ProductID; set => ProductID = value; }
        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public string Productname { get => productname; set => productname = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Note { get => note; set => note = value; }
    }
}
