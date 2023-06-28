using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("a = " + a);
            switch (a)
            {
                case 1:
                    Console.WriteLine("неудобно же пиздец 1= " + a);
                    break;
                case 2:
                    {
                        Console.WriteLine("неудобно же пиздец 2= " + a);
                    }
                    break;
                case 3:
                case 4:
                    Console.WriteLine("неудобно же пиздец 3 или 4  - " + a);
                    break;

                default:
                    Console.WriteLine("неудобно же пиздец что то другое" + a);
                    break;

            }
            Console.WriteLine("введите а ");
            string b = Console.ReadLine();
            switch (b)
            {

                case "a":
                    Console.WriteLine("заебись");
                    break;
                default:
                    Console.WriteLine("чел ты");
                    break;

            }
        }
    }
}



