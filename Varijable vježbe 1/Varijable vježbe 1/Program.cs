using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_vježbe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = -1000;
            string c = "a";
            float d = 3.123f;
            double e = 3.123456789;
            bool f = true;
            string g = "\"true\"";
            Console.Write("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                a, b, c, d, e, f, g);
            Console.ReadKey();
        }
    }
}
