using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private int CustomerID;
        private string name;
        private string addrees;
        private string phone;
        private int point;

        public DTO_Customer() { }
        public DTO_Customer(int customerID, string name, string addrees, string phone, int point)
        {
            CustomerID1 = customerID;
            this.name = name;
            this.Addrees = addrees;
            this.Phone = phone;
            this.Point = point;
        }
   


        public int CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public string Name { get => name; set => name = value; }
        public string Addrees { get => addrees; set => addrees = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Point { get => point; set => point = value; }

    }
}
