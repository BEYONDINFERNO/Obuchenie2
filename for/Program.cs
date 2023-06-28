using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string a_str;
            int a;
            a_str = Console.ReadLine();
            a=Convert.ToInt32(a_str);
            */
            int a = int.Parse(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < (a + 1); i++, j++)
            {
                //if (a == 10) break;
                //  Console.WriteLine(a);
                // Console.WriteLine(i);
                //   System.Threading.Thread.Sleep(10);
                if (i < (a / 2)) 
                { 
                Console.Write(j);
                Console.WriteLine(" хуев");
                j++;
                }
               
                for (j = 0; ((a + 1) > i) && (i > (a / 2) ) ; i++,j++) 
                {
                    
                    Console.Write(j);
                Console.WriteLine(" пиздов");
            }
        } 






    } 
}
}



        
    

