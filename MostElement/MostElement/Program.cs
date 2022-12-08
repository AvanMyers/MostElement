using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            int arraySize = 10;
            int arrayDeep = 10;
            int minRandom = 0;
            int maxRandom = 100; 
            int maxElement = 0;
            int maxElementPosition = 0;
            int replacementNumber = 0;
            int[,] array =  new int[arraySize, arrayDeep];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minRandom, maxRandom);
                    Console.Write($"{array[i,j]} ");
                }

                Console.WriteLine(" ]");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] > maxElement)
                    {
                        maxElement = array[i,j];
                        maxElementPosition = j;
                    }
                }

                array[i, maxElementPosition] = replacementNumber;
                maxElement= 0;
                maxElementPosition = 0;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine(" ]");
            }

            Console.ReadKey();
        }
    }
}
