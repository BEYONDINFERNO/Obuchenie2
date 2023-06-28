using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int i = 1;
            string astr = Console.ReadLine();
            a=Convert.ToInt32(astr);
            /*
            while (i<a) {
                Console.WriteLine("Выполняется" + i);
                i++;
            }
            */
            do {
                Console.WriteLine(a);
                    }
            while (i < a);


            

        }
    }
}
