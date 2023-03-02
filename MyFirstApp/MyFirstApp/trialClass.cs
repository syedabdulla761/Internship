using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class trialClass
    {
        public int l { get; set; }
        public int h { get; set; }
        public int w { get; set; }
        public int v { get; set; }

        public void displayinfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}, volume is {3}",l,h,w,v=l*h*w);
        }
    }
}
