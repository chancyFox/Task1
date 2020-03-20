using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand;          
            bool continueProgram = true;
            int[] array = new int[0];

            while (continueProgram)
            {
                Console.SetCursorPosition(0, 15);
                Console.Write("Массив: ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Вам нужно заполнить массив произвольного размера. \n\nВведите: " +
              "\nsum - чтобы узнать сумму элементов полученного массива \nsort - чтобы отсортировать массив в порядке возрастания " +
              "\nend - чтобы закончить выполнение программы");

                Console.Write("\nВведите элемент массива или команду: ");
                inputCommand = Console.ReadLine();

                inputCommand = Convert.ToString(inputCommand);
                switch (inputCommand)
                {
                    case "sum":
                        int sum = 0;
                        for (int i = 0; i < array.Length; i++)
                        {                          
                            sum += array[i];
                            if (i == array.Length - 1)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(0, 13);
                                Console.WriteLine("Сумма элементов массива: " + sum);
                            }
                        }
                        break;
                    case "sort":
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Clear();
                            for (int j = 0; j < array.Length - 1; j++)
                            {
                                if (array[j] > array[j + 1])
                                {
                                    int tempImt = array[j + 1];
                                    array[j + 1] = array[j];
                                    array[j] = tempImt;
                                }
                            }
                        }
                        break;
                    case "end":
                        Console.WriteLine("Программа завершена.\n");
                        continueProgram = false;
                        break;
                    default:                     
                        int inputNumber = Convert.ToInt32(inputCommand);
                        int[] tempArray = new int[array.Length + 1];
                        for (int i = 0; i < array.Length; i++)
                        {
                            tempArray[i] = array[i];
                        }
                        tempArray[tempArray.Length - 1] = inputNumber;
                        array = tempArray;
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
