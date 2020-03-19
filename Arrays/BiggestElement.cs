using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int biggestElement = int.MinValue;
            int[,] array = new int[10, 10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] > biggestElement)
                    {
                        biggestElement = array[i, j];
                    }
                    if ((i == (array.GetLength(0) - 1)) && (j == (array.GetLength(1) - 1)))
                    {
                        Console.WriteLine("\n\nНаибольший элемент матрицы: " + biggestElement + "\n");
                    }
                }
            }
        }
    }
}
