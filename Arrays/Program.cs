using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int minElement = int.MinValue, localMax = 0;
            int[] array = new int[30];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = rand.Next(0, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        localMax = array[i];
                        Console.Write(localMax + " ");
                    }                       
                }

                if (i > 0 && i < array.GetLength(0) - 1)
                {
                  if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        localMax = array[i];
                        Console.Write(localMax + " ");
                    }
                }

                if (i == (array.GetLength(0) - 1))
                {
                    if (array[i] > array[i - 1])
                    {
                        localMax = array[i];
                        Console.Write(localMax + " ");
                    }                     
                }
            }                      
        }
    }
}
