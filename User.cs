using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class User
    {
        public string id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string sdt { get; set; }
        public string sex { get; set; }
        public DateTime dob { get; set; }

        public User(string id, string name, string address, string sdt, string sex, string email, DateTime dob) 
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.sdt = sdt;
            this.sex = sex;
            this.email = email;
            this.dob = dob;
        }

    }
}
