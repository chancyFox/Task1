     
     int cristallsPrice = 5;
     int goldCount, cristallsToBye, spentGold, goldLeft;
     bool enoghGold;

     Console.WriteLine("Здравствуй, путник. У нас ты можешь купить кристаллы за золото.");
     Console.WriteLine($"Один кристалл стоит {cristallsPrice} монет.");
     Console.Write("Сколько золота у тебя в наличии: ");
     goldCount = Convert.ToInt32(Console.ReadLine());

     Console.Write("Сколько кристаллов ты хочешь купить: ");
     cristallsToBye = Convert.ToInt32(Console.ReadLine());

     spentGold = cristallsToBye * cristallsPrice;
     enoghGold = goldCount >= spentGold;
     cristallsToBye = cristallsToBye * Convert.ToInt32(enoghGold);

     goldLeft = goldCount - cristallsToBye * cristallsPrice;
     Console.WriteLine($"Отлично. Теперь у тебя {goldLeft} золота и {cristallsToBye} кристаллов");
    
