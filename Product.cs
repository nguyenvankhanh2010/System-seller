using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class Product
    {
        public string idProduct { get; set; }
        public string idSeller { get; set; }
        public string nameProduct { get; set; }
        public string brand { get; set; }
        public double retail { get; set; }
        public double resell { get; set; }
        public string type { get; set; }
        public string decribe { get; set; }
        public int quantity { get; set; }
        public string address { get; set; }

        public Product(string idProduct, string idSeller, string nameProduct, string type, int quantity, double retail, double resell, string brand, string decribe, string address)
        {
            this.idProduct = idProduct;
            this.idSeller = idSeller;
            this.nameProduct = nameProduct;
            this.type = type;
            this.quantity = quantity;
            this.retail = retail;
            this.resell = resell;
            this.brand = brand;
            this.decribe = decribe;
            this.address = address;
        }
    }
}
