using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healhtbar
{
    class Program
    {
        static void Main(string[] args)
        {
            int happyness = 0, maxHappyness = 10;
            
            while (happyness < maxHappyness)
            {
                DrowBar(happyness, maxHappyness, ConsoleColor.Magenta);

                Console.SetCursorPosition(0, 3);
                Console.Write("На сколько повысился уровень вашего счастья: ");
                int change = Convert.ToInt32(Console.ReadLine());
                happyness += change;

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrowBar(int data, int maxData, ConsoleColor barColor, int cursorY = 0)
        {
            string bar = "";
            char symbol = '#', voidSymbol = '_';
            ConsoleColor mainColor = Console.BackgroundColor;
            Console.SetCursorPosition(0, cursorY);
    
            for(int i = 0; i < data; i++)
            {                             
                bar += symbol;
            }

            Console.BackgroundColor = mainColor;
            Console.Write("[");
            Console.BackgroundColor = barColor;
            Console.Write(bar);
            Console.BackgroundColor = mainColor;

            bar = "";

            for (int i = data; i < maxData; i++)
            {
                bar += voidSymbol;
            }

            Console.WriteLine(bar + "]");         
        }
    }
}
