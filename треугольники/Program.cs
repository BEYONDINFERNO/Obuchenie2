using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace треугольники
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int lim = int.Parse(Console.ReadLine());  
            
            for (int l = 0; l < a; l++)
            { 
                Console.WriteLine("");
            for (int i = 0; i < a; i++)
            {
                Console.Write("#");                
            }
                a++;
                if (a == lim) break;
            }

            Console.WriteLine("");
            a = 1;
            b = 1;

            
            for (int k = lim; k > a; a++ )
            {
                Console.WriteLine();

                b++;
                for (int i = lim; i > b; i--)
                {
                    Console.Write("#");               
                }
               
            }

            Console.WriteLine("");
            a = 0; 
            b = 1;
            
            for (int k = lim; k > a; k--)
            { 
           
            }
            Console.ReadLine();
        }
    }
}
