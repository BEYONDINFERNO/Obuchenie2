using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlozhenie_cikli
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            /*
            for (int i = 0; i <= a; i++)
            {

                Console.WriteLine("Цыкл " + i);
                for (int j = 0; j <= a; j++)
                {
                    Console.WriteLine("\tJ = " + j);

                    for (int k = 0; k <= a; k++)
                    {
                        Console.WriteLine("\t\tk = " + k );
                    }
                }

            }
            */
            for (int i = 0; i <= a; i++)
            {
                Console.Write("#");
                if (i==a)
                {
                    
                        Console.WriteLine("#");

                    
                        Console.Write("#");                   
                        for (int j = 0; j < a; j++) 
                     {
                      Console.Write(" ");
                        if (j==a-1)
                        {
                            Console.WriteLine("#");
                        }

                        if (j == a - 1)
                        {
                            for (int k = 0; k <= a + 1; k++)
                            {
                                Console.Write("#");

                            }
                        }

                    }


                    
                }
            }
            Console.ReadLine();
        }

    }
}
