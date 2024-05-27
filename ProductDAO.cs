using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class ProductDAO
    {

        DBConnection db = new DBConnection();


        public void Add(Product p)
        {
            string sqlStr = string.Format("Insert into inforProduct Values ('{0}', '{1}', N'{2}', N'{3}','{4}', '{5}','{6}',N'{7}',N'{8}',N'{9}')", p.idProduct, p.idSeller, p.nameProduct, p.type, p.quantity, p.retail, p.resell, p.brand, p.decribe,p.address);
            db.thucThiAdd(sqlStr);
        }

        public void Update(Product p)
        {
            string sqlStr = string.Format("Update inforProduct Set nameProduct = N'{0}', typeProduct = N'{1}', quantityProduct = '{2}', retailProduct = '{3}', resellProduct = '{4}', brandProduct = N'{5}', decribeProduct = N'{6}', addressProduct = N'{9}' Where idProduct ='{7}' and idSeller = '{8}'", p.nameProduct, p.type, p.quantity, p.retail, p.resell, p.brand, p.decribe, p.idProduct, p.idSeller, p.address);
            db.thucThiUpdate(sqlStr);
        }

        public void Delete(Product p)
        {
            string sqlStr = string.Format("Delete From inforProduct Where  idProduct = '{0}' and idSeller = '{1}'", p.idProduct, p.idSeller);
            db.thucThiDel(sqlStr);
        }

        public DataTable Load(string ID)
        {
            DataTable dt = new DataTable();
            string sqlStr = string.Format("Select idProduct as 'Mã sản phẩm', nameProduct as 'Tên sản phẩm', typeProduct as 'Loại sản phẩm', quantityProduct as 'Số lượng', retailProduct as 'Giá niêm yết', resellProduct as 'Giá bán', brandProduct as 'Hãng sản xuất', decribeProduct as 'Mô tả', addressProduct as 'Địa chỉ' From inforProduct Where idSeller = '{0}'", ID);
            return db.thucThiLoadDGV(sqlStr);
        }

    }
}
