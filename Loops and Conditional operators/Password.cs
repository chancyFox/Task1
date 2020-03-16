using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "12345";
            int tryes = 3;
            bool passwordIsCorrect = false;

            for (int i = 0; i < tryes; i++)
            {
                while ((passwordIsCorrect == false) && (tryes != 0))
                {
                    Console.Write("Чтобы получить доступ к секретному сообщению, введите пароль! \nПароль: ");
                    string input = Console.ReadLine();

                    if (input == password)
                    {
                        passwordIsCorrect = true;
                        Console.WriteLine("Вы справились с заданием!\n\nСЕКРЕТНОЕ СООБЩЕНИЕ: Вы превращаетесь в пингвина и это не остановить.\n");
                    }
                    else
                    {
                        tryes -= 1;
                        Console.WriteLine($"ПАРОЛЬ НЕВЕРНЫЙ. \n\nВы потратили одну попытку. Осталось {tryes}. \nБудьте внимательней.\n");
                    }
                }
            }
 
        }
    }
}
