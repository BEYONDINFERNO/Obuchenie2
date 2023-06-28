using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obuchenie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 10; ///сколько раз сделать

            for (int i = 0; i < z; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                int stamina;
                Console.WriteLine("skolko stamini");
                stamina = int.Parse(Console.ReadLine());
                
                bool isInfected = false;
                bool ustal = false;
                if (stamina < 10) ustal = true;


                if (!isInfected && !ustal)
                {
                    Console.WriteLine("zaebis");
                }
                else 
                {
                Console.WriteLine("hueva");
                }


            }
        }
    }
}
