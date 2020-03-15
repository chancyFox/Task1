            string password = "12345"; 
            int tryes = 3;
            bool isPasswordCorrect = false;

            while ((isPasswordCorrect != true) & (tryes != 0))
            {
                Console.WriteLine("Введите пароль!");
                Console.Write("Пароль: ");
                string userInput = Console.ReadLine();

                if (userInput == password)
                {
                    isPasswordCorrect = true;
                    Console.WriteLine("Авторизация прошла успешно. Добро пожаловать!");
                }
                else
                {
                    tryes -= 1;

                    if (tryes == 0)
                    {
                        Console.WriteLine("Провал миссии. До самоуничтожения остаётся: 3... 2...");
                    }
                    else
                    {
                        Console.WriteLine($"Пароль не верный! Осторожнее, попыток осталось всего {tryes}.");
                    }
                }
            }
