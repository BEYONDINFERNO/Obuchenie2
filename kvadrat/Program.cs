using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.Clear();    
            for (int i = 0; i <= a; i++)
            {
                if (i == a-1)
                {
                    Console.Write("#");
                }
                    Console.Write("#");                
                if (i == a)
                { for (int j = 0; j < a; j++)
                    {                        Console.WriteLine("#");
                        Console.Write("#");
                        int k = 0;
                        if (j == a - 1)
                            continue;
                        do
                            {                          
                            Console.Write(" "); 
                                k++;                     
                            }
                        while (k <= a);                       
                    }
                    }
                if ( i==a ) 
                { 
                for (int k = 0; k <= a; k++)
                {
                    Console.Write("#");
                }
                }
            }
            Console.WriteLine("#");
            Console.ReadLine();
        }
    }
}
