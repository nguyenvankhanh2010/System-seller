using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoDoAnVer02
{
    internal class UserDAO
    {
        DBConnection db = new DBConnection();
        public void Add(User p)
        {
            string sqlStr = string.Format("Insert into ThongTinUser (HoTen, Diachi, SDT, Email, GioiTinh, NgaySinh, ID) Values (N'{0}',N'{1}', '{2}','{3}', N'{4}','{5}', '{6}')", p.name, p.address, p.sdt, p.email, p.sex, p.dob, p.id);
            db.thucThiAdd(sqlStr);
        }

        public void Update(User p)
        {
            string sqlStr = string.Format("Update ThongTinUser Set HoTen = N'{0}', Diachi = N'{1}', SDT = '{2}', Email = '{3}', GioiTinh = N'{4}', NgaySinh = '{5}' Where ID = '{6}'", p.name, p.address, p.sdt, p.email, p.sex, p.dob, p.id);
            db.thucThiUpdate(sqlStr);
        }

    }
}
