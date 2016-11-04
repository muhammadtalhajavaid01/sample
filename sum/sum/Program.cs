using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    class Program
    {
        public double sum (double x,double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Program o = new Program();
            Console.WriteLine("Sum:" + o.sum(2.0, 3.0));
        }
    }
}
