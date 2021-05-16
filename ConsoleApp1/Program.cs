using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string str = "около кола-колокола";
            //str.Replace("около", "ч");
            //Console.WriteLine(str);

            int i, j, s = 0;
            for (i = 1, j = 5; i < j; ++i, --j)
            {
                s += i;
            }
            Console.WriteLine(s);

        }
    }
}
