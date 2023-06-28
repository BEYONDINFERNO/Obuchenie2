using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_kontinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int a = int.Parse(Console.ReadLine());
            /*
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(i);
                string msg = Console.ReadLine();
                if (msg == "хуй") break;
                

            }
            */
            for (int i = 0; i <= a; i++)
            {
                if (i == 10) continue;
                Console.WriteLine(i);
                
                


            }



        }
    }
}
