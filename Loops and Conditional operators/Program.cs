using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace about_change
{
    class Program
    {
        static void Main(string[] args)
        {
            String command = "1";
            string name = "Вася";
            int healthPoint = 5, powerPoint = 5;

            Console.WriteLine($"Добрый день! \n\nИмя: {name} \nСила: {powerPoint}  \nЗдоровье: {healthPoint}\n"); 
            Console.WriteLine("Список доступных комманд: \nGLC - изменить цвет шрифта \nChangeName - изменить имя " +
                "\nTrain - потренироваться и увеличить количество очков силы \nRest - отдохнуть и увеличить количество очков здоровья " +
                "\nReturn - вернуть изначальные настройки \nEsc - выйти из программы\n");

            while (command != "Esc")
            {
                Console.Write("Что вы хотите сделать? \nКоманда: ");
                command = Console.ReadLine();

                switch (command)
                {
                    case "GLC":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine();
                        break;

                    case "ChangeName":
                        Console.Write("Введите ваше новое имя: ");
                        name = Console.ReadLine();
                        Console.WriteLine();
                        break;

                    case "Train":
                        powerPoint += 5;
                        Console.WriteLine();
                        break;

                    case "Rest":
                        healthPoint += 5;
                        Console.WriteLine();
                        break;

                    case "Retutn":
                        name = "Вася";
                        healthPoint = 1; 
                        powerPoint = 1;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        break;

                    case "Esc":
                        Console.WriteLine("До встречи!");
                        break;
                }

                Console.WriteLine($"Теперь ваши характеристики таковы: \nИмя: {name} \nСила: {powerPoint}  \nЗдоровье: {healthPoint}\n");
            }

        }
    }
}
