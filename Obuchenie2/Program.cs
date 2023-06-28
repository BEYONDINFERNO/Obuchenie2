using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obuchenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) { 
            Console.WriteLine("Введите зачение А ");
            string astr = Console.ReadLine();
            Console.WriteLine("Введите зачение B ");
            string bstr = Console.ReadLine();
            //Console.WriteLine("Введите зачение C ");
            //string cstr = Console.ReadLine();
            double a = Convert.ToDouble(astr);
            double b = Convert.ToDouble(bstr);
            // double c = Convert.ToDouble(cstr);
            /*
             double d = a / b;
             Console.WriteLine(" А/B =   " + d);
             d = a % b;
             Console.WriteLine("Остаток от деления А/B =   " + d);
             Console.WriteLine()
            */
            Console.WriteLine(a == b);
                bool isInfected = a==b;

                if (isInfected) Console.WriteLine("реально тру");
               else Console.WriteLine("не тру");              
                Console.WriteLine("////////////////");
            }
            Console.ReadLine();
            //всё остальное в других папках в этом же репозитории
        }
    }
}
