using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProduct
    {
        private string code { get; set; }
        private string name { get; set; }
        private int amount { get; set; }
        private int category { get; set; }
        private float price { get; set; }
        private DateTime creationDate { get; set; }
        public ENProduct()
        {

        }
        public ENProduct(string code, string name, int amount, float price, int category ,DateTime creationDate)
        {
            this.code = code;
            this.name = name;
            this.amount = amount;
            this.category = category;
            this.price = price;
            this.creationDate = creationDate;

        }
        public bool Create() //falta a base de CADProducts
        {
            return true;
        }
    }
}
