using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class DonHang
    {
        public string idProduct {  get; set; }
        public string idBuyer { get; set; }
        public int quantity { get; set; }
        public DateTime dateBuy { get; set; }
        public string nameBuyer { get; set; }
        public string phoneBuyer {  get; set; }
        public string email {  get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public string idOrder {  get; set; }

        public DonHang(string idProduct, string idBuyer, int quantity, DateTime dateBuy, string nameBuyer, string phoneBuyer, string email, string address, string note, string idOrder)
        {
            this.idProduct = idProduct;
            this.idBuyer = idBuyer;
            this.quantity = quantity;
            this.dateBuy = dateBuy;
            this.nameBuyer = nameBuyer;
            this.phoneBuyer = phoneBuyer;
            this.email = email;
            this.address = address;
            this.note = note;
            this.idOrder = idOrder;
        }
    }
}
