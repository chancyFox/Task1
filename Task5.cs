            Console.WriteLine("Утро. Поликлиника. Вы в очереди за справкой.");
            Console.WriteLine("Казалось бы - что может пойти не так? Но вот вы видите старушек.");
            Console.Write("Сколько их: "); 

            int countOldLadies = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Их действительно " + countOldLadies);

            int waitingTime = countOldLadies * 10;
            int hourseWaiting = waitingTime / 60;
            int minutesWaiting = waitingTime % 60;

            Console.WriteLine($"И вы понимаете, что ждать вам осталось {hourseWaiting} часов {minutesWaiting} минут...");
