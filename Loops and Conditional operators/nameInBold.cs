using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_in_bold
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.Write("Из какого симфола сделать рамку: ");
            char simbol = Convert.ToChar(Console.ReadLine());
            
            int nameLenght = name.Length;
           
            for (int i = 0; i < (nameLenght + 4); i++)
            {
                Console.Write(simbol);
            }
            Console.WriteLine();

            Console.WriteLine(simbol + " " + name + " " + simbol);

            for (int i = 0; i < (nameLenght + 4); i++)
            {
                Console.Write(simbol);
            }
            Console.WriteLine();
        }
    }
}
