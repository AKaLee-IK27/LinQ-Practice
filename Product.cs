using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Practice
{
    internal class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime expireDate { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }
        public string from { get; set; }

        public Product(string id, string name, DateTime expireDate, double price, double quantity, string from)
        {
            this.id = id;
            this.name = name;
            this.expireDate = expireDate;
            this.price = price;
            this.quantity = quantity;
            this.from = from;
        }

        public Product()
        {
        }

        ~Product()
        {
            Console.WriteLine("Product object is destroyed");
        }
    }
}
