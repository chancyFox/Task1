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
            string userInputCommand;
            int userInputNumber, sum = 0;
            bool continueProgram = true;
            int[] userArray = new int[0];

            while (continueProgram)
            {
                Console.SetCursorPosition(0, 15);
                Console.Write("Массив: ");
                
                for (int i = 0; i < userArray.Length; i++)
                {
                    Console.Write(userArray[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Вам нужно заполнить массив произвольного размера. \n\nВведите: " +
              "\nsum - чтобы узнать сумму элементов полученного массива \nsort - чтобы отсортировать массив в порядке возрастания " +
              "\nend - чтобы закончить выполнение программы");
                
                Console.Write("\nВведите элемент массива или команду: ");
                userInputCommand = Console.ReadLine();         
       
                userInputCommand = Convert.ToString(userInputCommand);
                switch (userInputCommand)
                {
                    case "sum":
                        for (int i = 0; i < userArray.Length; i++)
                        {
                            sum += userArray[i];
                            if (i == userArray.Length - 1)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(0, 13);
                                Console.WriteLine("Сумма элементов массива: " + sum);
                            }
                        }
                        break;
                    case "sort":
                        for (int i = 0; i < userArray.Length; i++)
                        {
                            Console.Clear();
                            for (int j = 0; j < userArray.Length - 1; j++)
                            {
                                if (userArray[j] > userArray[j + 1])
                                {
                                    int tempImt = userArray[j + 1];
                                    userArray[j + 1] = userArray[j];
                                    userArray[j] = tempImt;
                                }
                            }                                                      
                        }
                        break;
                    case "end":
                        Console.WriteLine("Программа завершена.\n");
                        continueProgram = false;
                        break;
                    default:
                        int value;
                        if (int.TryParse(userInputCommand, out value))                         
                        {   
                            userInputNumber = Convert.ToInt32(userInputCommand);
                            int[] tempUserArray = new int[userArray.Length + 1];
                            for (int i = 0; i < userArray.Length; i++)
                            {
                                tempUserArray[i] = userArray[i];
                            }
                            tempUserArray[tempUserArray.Length - 1] = userInputNumber;
                            userArray = tempUserArray;
                            Console.Clear();
                        }
                        break;
                }      
            }
        }
    }
}

