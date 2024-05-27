using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnVer02
{
    internal class ImageNDecribe
    {
        public Image img { get; set; }
        public string decribe { get; set; }

        public ImageNDecribe (Image img, string dercibe) 
        {
            this.img = img;
            this.decribe = dercibe;
        }
    }
}
