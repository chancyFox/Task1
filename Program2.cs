            Console.WriteLine("Утро. Поликлиника. Вы в очереди за справкой.");
            Console.WriteLine("Казалось бы - что может пойти не так? Но вот вы видите старушек.");
            Console.Write( "Сколько их: "); 

            int countOldLadies = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Их действительно " + countOldLadies);

            int hourseWaiting = (countOldLadies * 10) / 60;
            int minutesWaiting = (countOldLadies * 10) % 60;

            Console.WriteLine($"И вы понимаете, что ждать вам осталось {hourseWaiting} часов {minutesWaiting} минут...");
