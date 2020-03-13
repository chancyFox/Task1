using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_введение
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userAge, userZodiaс, userWork;

            Console.Write($"Здравствуй! Как тебя зовут? \n- ");
            userName = Console.ReadLine();

            Console.Write($"Сколько тебе лет? \n- ");
            userAge = Console.ReadLine();

            Console.Write($"Кто ты по знаку зодиака? \n- ");
            userZodiaс = Console.ReadLine();

            Console.Write($"Где ты работаешь? \n- ");
            userWork = Console.ReadLine();

            Console.WriteLine($"Тебя зовут {userName}, тебе {userAge} лет, по знаку зодиака ты {userZodiaс} и работаешь {userWork}. ");


        }   
    }
}
