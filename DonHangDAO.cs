using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class DonHangDAO
    {
        DBConnection db = new DBConnection();

        public void AddDH(DonHang dh)
        {
            string sqlStr = string.Format("insert into DonHang Values ('{0}', '{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', N'{7}', N'{8}', N'Chờ xác nhận', '{9}')", dh.idProduct, dh.idBuyer, dh.quantity, DateTime.Now.ToShortDateString(), dh.nameBuyer, dh.phoneBuyer, dh.email, dh.address, dh.note, dh.idOrder);
            db.thucThiAdd(sqlStr);
            string sqlStr1 = string.Format("Update inforProduct Set quantityProduct = quantityProduct - '{0}' Where idProduct = '{1}'", dh.quantity, dh.idProduct);
            db.thucThiUpdate(sqlStr1);
            string sqlStr2 = string.Format("Delete From productInCart Where idProduct = '{0}' and idUser = '{1}'", dh.idProduct, dh.idBuyer);
            db.thucThiDel(sqlStr2);
        }
    }
}
