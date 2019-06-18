using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_PrinterProject
{
    public class Photo
    {
        public string Size { get; set; }
        public bool BlackAndWhite { get; set; }
        public int SomeWiseParameter { get; set; }

        public Photo(string size, bool blackAndWhite, int someWiseParameter)
        {
            Size = size;
            BlackAndWhite = blackAndWhite;
            SomeWiseParameter = someWiseParameter;
        }
    }
}
