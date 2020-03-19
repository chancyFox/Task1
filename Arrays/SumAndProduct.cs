using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndProd
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, product = 1, sum1 = 0, product1 = 1, rowForSum = 1, columnForMultiplication = 0;
            bool answerIsWritten = false;
            Random rand = new Random();
            int[,] array = new int[4,3];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1,5); 
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            //способ 1
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == rowForSum)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                        if (j == (array.GetLength(1) - 1))
                        {
                            Console.WriteLine("\nСумма элементов второй строки = " + sum);
                        } 
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == columnForMultiplication)
                    {
                        product *= array[i, j];
                       
                    }
                    if (((i == array.GetLength(0) - 1)) && (!answerIsWritten))
                    {
                        Console.WriteLine("Произведение элементов первого столбца = " + product);
                        answerIsWritten = true;
                    }
                }
            }
            //способ 2
            int row = 1;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum1 += array[row, j];
            }
            Console.WriteLine("\nСумма элементов второй строки (способ 2) = " + sum1);

            int colomn = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                product1 *= array[i, colomn];
            }
            Console.WriteLine("Произведение элементов первого столбца (способ 2) = " + product1 + "\n");
        }
    }
}
