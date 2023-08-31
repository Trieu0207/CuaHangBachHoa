using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Category
    {
        private int CategoryID;
        private string categoryname;
        private string categorydescription;
        private string img;


        public DTO_Category() { }
        public DTO_Category(int categoryID, string categoryname, string categorydescription)
        {
            CategoryID = categoryID;
            this.categoryname = categoryname;
            this.categorydescription = categorydescription;
        }
        public DTO_Category( string categoryname, string categorydescription)
        {
            this.categoryname = categoryname;
            this.categorydescription = categorydescription;
            this.img = img;
        }

        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public string Categoryname { get => categoryname; set => categoryname = value; }
        public string Categorydescription { get => categorydescription; set => categorydescription = value; }
        public string Img { get => img; set => img = value; }
    }
}
