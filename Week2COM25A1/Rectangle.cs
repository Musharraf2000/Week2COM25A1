using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2COM25A1
{
    internal class Rectangle
    {
        public int length;
        public int width;

        public void PrintArea() {

            Console.WriteLine($"Area of the rectangle : {width * length}");

        }
    }
}
