using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCUL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string astr = "0";
            string bstr = "0";

            double a = 0;
            double b = 0;
            double c = 0;
            int i = 1;
         //   double j = 0;

            ConsoleKey consoleKey = Console.ReadKey().Key;
           

            //  while (j==0) {
            while (i == 1)
                {
                consoleKey = Console.ReadKey().Key;
           
                switch (consoleKey)
                    {
                        case ConsoleKey.D0:
                        case ConsoleKey.NumPad0:
                           // astr = astr;
                            Console.Clear();
                            // Console.WriteLine(astr);
                            break;
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:                            
                                astr = "1";
                                // Console.Clear();
                                //Console.WriteLine(astr);

                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            break;
                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            break;
                        case ConsoleKey.D6:
                        case ConsoleKey.NumPad6:
                            break;
                        case ConsoleKey.D7:
                        case ConsoleKey.NumPad7:
                            break;
                        case ConsoleKey.D8:
                        case ConsoleKey.NumPad8:
                            break;
                        case ConsoleKey.D9:
                        case ConsoleKey.NumPad9:
                            break;

                        case ConsoleKey.Add:
                        case ConsoleKey.OemPlus:
                        //Console.WriteLine("+");

                            i++; 

                            break;


                    }


            }
                while (i == 2)
                {                
                consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:


                            bstr = bstr + "1";
                            // Console.Clear();
                            //Console.WriteLine(astr);
                            break;


                        case ConsoleKey.Enter:
                            i++;
                            break;
                    }
                    
                }
                if (i == 3) {
                
               Console.Clear();
                a = Convert.ToDouble(astr);
                b = Convert.ToDouble(bstr);
                c = a + b;

                Console.Clear();
                Console.WriteLine(astr);
                Console.WriteLine(bstr);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                    Console.WriteLine("555555");

            }
          // }
        }
    } 
}
