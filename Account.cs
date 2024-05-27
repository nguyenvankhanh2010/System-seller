using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class Account
    {
        public string tk {  get; set; }
        public string mk { get; set; }

        public Account(string tk, string mk)
        {
            this.tk = tk;
            this.mk = mk;
        }
    }
}
