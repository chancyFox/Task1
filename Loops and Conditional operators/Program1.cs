            double goldCount, silverCount, cristallsCount;
            int continueExchange = 1;

            Console.WriteLine("У нас Вы можете произвести обмен валют: \nЗолото: 5 серебряных монет или 1/2 кристалла " +
                "\nСеребро: 1/5 золотой монеты или 1/10 кристалла \nКристалл: 2 золотые монеты или 10 серебрянных монет \n");

            Console.Write("Ваш баланс золота: ");
            goldCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваш баланс серебра: ");
            silverCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваш баланс кристаллов: ");
            cristallsCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (continueExchange == 1)
            { 
                Console.Write("Что вы хотите купить? \n1 - золото \n2 - серебро \n3 - кристаллы \n\nВыбираю: ");
                String whatToBye = Console.ReadLine();

                switch (whatToBye)
                {
                    case "1":
                        Console.Write("Сколько золота вы хотите купить: ");
                        int boughtCount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Чем будете расплачиваться? \n1 - серебром \n2 - кристаллами \n\nВыбираю: ");
                        int givenToBye = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (givenToBye)
                        {
                            case 1:
                              
                                if ((silverCount - boughtCount * 5) >= 0)
                                {
                                    silverCount -= boughtCount * 5;
                                    goldCount += boughtCount;
                                    Console.WriteLine($"Теперь у вас {goldCount} золота, {silverCount} серебра и {cristallsCount} кристаллов \n");
                                }
                                else
                                {
                                    Console.WriteLine("Вы недостаточно богаты, чтобы сделать это. \n");
                                }
                                break;

                            case 2:
                                
                                if ((cristallsCount - boughtCount * 0.5) >= 0)
                                {
                                    cristallsCount -= boughtCount * 0.5;
                                    goldCount += boughtCount;
                                    Console.WriteLine($"Теперь у вас {goldCount} золота, {silverCount} серебра и {cristallsCount} кристаллов \n");
                                }
                                else
                                {
                                    Console.WriteLine("Вы недостаточно богаты, чтобы сделать это.\n");
                                }
                                break;

                            default:
                                Console.WriteLine("Вы сделали что-то не так... \n");
                                break;
                        }
                        break;

                    case "2":
                        Console.Write("Сколько серебра вы хотите купить: ");
                        int boughtCount1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nЧем будете расплачиваться? \n1 - золотом \n2 - кристаллами \n\nВыбираю: ");
                        int givenToBye1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        switch (givenToBye1)
                        {
                            case 1:
                                
                                if ((goldCount - boughtCount1 * 0.2) >= 0)
                                {
                                    goldCount -= boughtCount1 * 0.2;
                                    silverCount += boughtCount1;
                                    Console.WriteLine($"Теперь у вас {goldCount} золота, {silverCount} серебра и {cristallsCount} кристаллов \n");
                                }
                                else
                                {
                                    Console.WriteLine("Вы недостаточно богаты, чтобы сделать это. \n");
                                }
                                break;

                            case 2:
                              
                                if ((cristallsCount - boughtCount1 * 0.1) >= 0)
                                {
                                    cristallsCount -= boughtCount1 * 0.1;
                                    silverCount += boughtCount1;
                                    Console.WriteLine($"Теперь у вас {goldCount} золота, {silverCount} серебра и {cristallsCount} кристаллов \n");
                                }
                                else
                                {
                                    Console.WriteLine("Вы недостаточно богаты, чтобы сделать это.\n");
                                }
                                break;

                            default:
                                Console.WriteLine("Вы сделали что-то не так... \n");
                                break;
                        }
                        break;



                    case "3":

                        Console.Write("Сколько кристаллов вы хотите купить: ");
                        int boughtCount2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Чем будете расплачиваться? \n1 - золотом \n2 - серебром \n\nВыбираю ");
                        int givenToBye2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        switch (givenToBye2)
                        {
                            case 1:
                               
                                if ((goldCount - boughtCount2 * 2) >= 0)
                                {
                                    goldCount -= boughtCount2 * 2;
                                    cristallsCount += boughtCount2;
                                    Console.WriteLine($"Теперь у вас {goldCount} золота, {silverCount} серебра и {cristallsCount} кристаллов \n");
                                }
                                else
                                {
                                    Console.WriteLine("Вы недостаточно богаты, чтобы сделать это. \n");
                                }
                                break;

                            case 2:
                                
                                if ((silverCount - boughtCount2 * 10) >= 0)
                                {
                                    silverCount -= boughtCount2 * 10;
                                    cristallsCount += boughtCount2;
                                    Console.WriteLine($"Теперь у вас {goldCount} золота, {silverCount} серебра и {cristallsCount} кристаллов \n");
                                }
                                else
                                {
                                    Console.WriteLine("Вы недостаточно богаты, чтобы сделать это. \n");
                                }
                                break;

                            default:
                                Console.WriteLine("Вы сделали что-то не так...\n");
                                break;
                                
                                break;
                        }
                        break;
                }

                Console.Write("Хотите продолжить обмен? \n1 - продолжить \n2 - покинуть пункт обмена \n\nВыбираю: ");
                continueExchange = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
            }    
