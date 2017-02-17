using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static class StaticClassDemo
    {
        static int x;

        static StaticClassDemo()
        {
            x = 1000;
        }

        public static void display()
        {
            Console.WriteLine("x::"+x);
        }
    }
}
