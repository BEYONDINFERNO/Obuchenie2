using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASSIVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MASSIVE_1;
            MASSIVE_1 = new int[4];
            int[] MASSIVE_2 = new int[4] { 1, 2, 3, 4 };
            int[] MASSIVE_3 = new int[] { 1, 2, 3, 4 };
            int[] MASSIVE_4 = new[] { 1, 2, 3, 4 };
            int[] MASSIVE_5 = { 1, 2, 3, 4 };
            int[] MASSIVE_6 = Enumerable.Repeat(1, 4).ToArray();
            int[] MASSIVE_7 = Enumerable.Range(1, 9).ToArray();
            Console.WriteLine("Введите размер массива" );
            int Length = int.Parse(Console.ReadLine());
            int[] MASSIVE_8 = new int[Length];
            
            int index;

            for (int i = 0; i < Length; i++)
            {
                MASSIVE_8[i] = int.Parse(Console.ReadLine());
            }


            //for (int j = MASSIVE_7.Length-1; j >=0 ; j--)
            //{
            //    Console.Write(" " + MASSIVE_7[j]);
            //    Console.WriteLine(" ");
            //}
            Console.WriteLine(" Массив в обратном порядке: " );
            for (int j = MASSIVE_8.Length - 1; j >= 0; j--)
            {
                Console.Write(" " + MASSIVE_8[j]);
                Console.WriteLine(" ");
            }
            int smoll = MASSIVE_8[0];
            for (int i = 1; i < MASSIVE_8.Length - 1; )
            {
                
                if ((MASSIVE_8[i] < MASSIVE_8[i + 1]) && (MASSIVE_8[i] < MASSIVE_8[i - 1])) smoll = MASSIVE_8[i];
                i++;
                if (i == MASSIVE_8.Length - 1)  Console.WriteLine("смол  " + smoll);

            }
            
        }
}
            

        }
    

