using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funk1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWork = true;
            string position;
            int command;
            string[] personData = new string[0], positionData = new string[0];

            while (continueWork)
            {
                WriteMenue();

                Console.Write("Введите номер команды: ");
                command = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (command)
                {
                    case 1:
                        string surname, name, fatherName;

                        Console.Write("Введите фамилию сотрудника: ");
                        surname = Console.ReadLine();

                        Console.Write("Введите имя сотрудника: ");
                        name = Console.ReadLine();

                        Console.Write("Введите отчество сотрудника: ");
                        fatherName = Console.ReadLine();

                        Console.Write("Введите должность сотрудника: ");
                        position = Console.ReadLine();

                        surname = Reformat(surname);
                        name = Reformat(name);
                        fatherName = Reformat(fatherName);
                        position = Reformat(position);

                        string wholeName = surname + " " + name + " " + fatherName;

                        personData = FillingData(ref personData, wholeName);
                        positionData = FillingData(ref positionData, position);
                        Console.Clear();
                        break;
                    case 2:
                        WriteAllData(ref personData, ref positionData);
                        break;
                    case 3:
                        Console.Write("Введите номер строки, данные которой вы хотите удалить: ");
                        int numberOfData = Convert.ToInt32(Console.ReadLine()) - 1;

                        personData = DeleteData(ref personData, numberOfData);
                        positionData = DeleteData(ref positionData, numberOfData);
                        break;
                    case 4:
                        Console.Write("Введите фамилию сотрудника, которого вы хотите найти: ");
                        string personToFind = Console.ReadLine();
                        string found = FindPerson(personData, personToFind);

                        int result = 0;
                        
                        if(Int32.TryParse(found, out result))
                        {
                            result = Convert.ToInt32(found);
                            Console.WriteLine((result + 1) + " " + personData[result] + " - " + positionData[result]);
                        }
                        else
                        {
                            Console.WriteLine(found);
                        }
                      
                        break;
                    case 5:
                        Console.WriteLine("Вы завершили выполнение программы.");
                        continueWork = false;
                        break;
                }
            }
        }

        static void WriteMenue()
        {
            Console.WriteLine("\nМЕНЮ: \n1 - добавить досье \n2 - вывести все досье" +
                "\n3 - удалить досье \n4 - поиск по фамилии \n5 - выход\n");
        }

        static string[] FillingData(ref string[] data, string someData)
        {
            string[] tempData = new string[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                tempData[i] = data[i];
            }
            tempData[tempData.Length - 1] = someData;
            return tempData;
        }

        static string Reformat(string someData)
        {
            someData = someData.Substring(0, 1).ToUpper() + someData.Substring(1).ToLower();
            return someData;
        }

        static string FindPerson(string[] datForSearch, string lookingFor)
        {
            bool isFound = false;
            string found = "Личность не найдена";

            for (int i = 0; i < datForSearch.Length; i++)
            {
                isFound = datForSearch[i].Contains(lookingFor);
                if(isFound == true)
                {
                    Console.WriteLine("Личность найдена: ");
                    found = Convert.ToString(i);
                }
            }           

            return found;
        }

        static string[] DeleteData(ref string[] data, int numberOfData)
        {
            string[] tempData = new string[data.Length - 1];

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (i >= numberOfData)
                {
                    data[i] = data[i + 1];
                }
            }

            for (int i = 0; i < tempData.Length; i++)
            {
                tempData[i] = data[i];
            }

            return tempData;
        }

        static void WriteAllData(ref string[] personData, ref string[] position)
        {
            Console.WriteLine("\nФАМИЛИЯ / ИМЯ / ОТЧЕСТВО / ДОЛЖНОСТЬ\n");
            for (int i = 0; i < personData.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + personData[i] + " - " + position[i]);
            }

            Console.Write("Нажмите любую клавишу, чтобы продолжиить.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

