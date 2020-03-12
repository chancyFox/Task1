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
            int imageCount = 56;
            int imagesInLine = 3;

            int lines = imageCount / imagesInLine;
            int imageLeft = imageCount % imagesInLine; 

            Console.WriteLine($"У вас имеется {imageCount} картинок. ");
            Console.WriteLine($"Из них можно составить {lines} рядов. {imageLeft} картинки осталось");
        }
    }
}
