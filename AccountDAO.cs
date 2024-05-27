using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class AccountDAO
    {
        DBConnection db = new DBConnection();

        public void Add(Account p)
        {
            string sqlStr = string.Format("Insert into Login (TenDangNhap, MatKhau) Values ('{0}','{1}')", p.tk, p.mk);
            db.thucThiAdd(sqlStr);
        }

        public void Update(Account p)
        {
            string sqlStr = string.Format("Update Login Set MatKhau = '{0}' where TenDangNhap = '{1}'", p.mk, p.tk);
            db.thucThiUpdate(sqlStr);
        }
    }
}
