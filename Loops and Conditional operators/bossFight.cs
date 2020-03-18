using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss 
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double health = 200, damage, opponentHealth = 200, opponentDamage = rand.Next(20, 40), lowDamage, attackPowerIncreaced = 1.2;
            bool golemIsSummond = false, prayerIsRead = false;
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nСРАЖЕНИЕ!\nОтважный герой {name} VS Каменный Голем!!!");
            Console.WriteLine($"\nПеред вами противник - Каменный Голем." +
                $"\nЗдоровье: {opponentHealth} \nУрон: 20-40 \n\nВаши характеристики: \nЗдоровье: {health} \nУрон: 15-60");

            Console.WriteLine($"\nВ арсенале героя 4 возможных атаки " +
                $"\n\n'LetItBurn' \nОГНЕННЫЙ СМЕРЧ - наносит 15 очков урона и ослабляет атаку голема максимально на 40%. " +
                $"\n\n'AngelTheKeeper' \nПРИЗЫВ ОГНЕННОГО ЭЛЕМЕНТАЛЯ - призывает существо с 30hp, которое служит живым щитом и наносит 40 очков урона. " +
                $"\nНельзя призвать более одного раза за бой." +
                $"\n\n'BattleCry' \nКРИК ОТЧАЯНЬЯ - когда у героя остается менее 10% здоровья, \nон собирает все оставшиеся силы и совершает свой последний удар." +
                $"\nэто отнимает у него 50% оставшегося здоровья и наносит противнику 60 единиц урона." +
                $"\n\n'Prey' \nМОЛИТВА ОГНЕННОМУ БОГУ - сокращает урон, который будет нанесён противником максимально на 70%. " +
                $"\nУсиливает следующую атаку героя на 20%. Урон не наносится.\n\nДА НАЧНЁТСЯ БОЙ!\n");

            while ((health > 0) && (opponentHealth > 0))
            {
                Console.Write("Выберите атаку (LetItBurn, AngelTheKeeper, BattleCry, Prey): ");
                string spell = Console.ReadLine();

                switch (spell)
                {
                    case "LetItBurn":
                        damage = 15;
                        if (prayerIsRead == true)
                        {
                            damage *= attackPowerIncreaced;
                            Console.WriteLine("\nСила атаки увеличена на 20%\n");
                            opponentDamage *= 0.6;
                            health -= opponentDamage;
                            opponentHealth -= damage;
                            Console.WriteLine($"Голем наносит {opponentDamage} урона, герой наносит {damage} урона \nГолем: {opponentHealth}hp \nГерой: {health}hp");
                            prayerIsRead = false;
                        }
                        else
                        {
                            opponentDamage *= 0.6;
                            health -= opponentDamage;
                            opponentHealth -= damage;
                            Console.WriteLine($"Голем наносит {opponentDamage} урона, герой наносит {damage} урона \nГолем: {opponentHealth}hp \nГерой: {health}hp");
                        }
                        opponentDamage = rand.Next(20, 40);
                        break;
                    case "AngelTheKeeper":
                        if (golemIsSummond == false)
                        {
                            Console.WriteLine("На поле появляется огненный голем.\n");
                            damage = 40;

                            if (opponentDamage >= 30)
                            {
                                opponentDamage -= 30;
                            }
                            else
                            {
                                opponentDamage = 0;
                            }

                            if (prayerIsRead == true)
                            {
                                damage *= attackPowerIncreaced;
                                Console.WriteLine("\nСила атаки увеличена на 20%\n");
                                opponentHealth -= damage;
                                health -= opponentDamage;
                                Console.WriteLine($"Голем наносит {opponentDamage} урона, герой наносит {damage} урона \nГолем: {opponentHealth}hp \nГерой: {health}hp");
                                prayerIsRead = false;
                            }
                            else
                            {
                                opponentHealth -= damage;
                                health -= opponentDamage;
                                Console.WriteLine($"Голем наносит {opponentDamage} урона, герой наносит {damage} урона \nГолем: {opponentHealth}hp \nГерой: {health}hp");
                            }
                            opponentDamage = rand.Next(20, 40);
                            golemIsSummond = true;
                        }
                        else
                        {
                            Console.WriteLine("\nВы больше не можете призвать голема.\n");
                        }
                        break;
                    case "BattleCry":
                        if (health <= 25)
                        {
                            damage = 60;
                            if (prayerIsRead == true)
                            {
                                damage *= attackPowerIncreaced;
                                Console.WriteLine("\nСила атаки увеличена на 20%\n");
                                if (opponentHealth > 0)
                                {
                                    opponentHealth -= damage;
                                }
                                health /= 2;
                                health -= opponentDamage;
                                Console.WriteLine($"Голем наносит {opponentDamage} урона, герой наносит {damage} урона \nГолем: {opponentHealth}hp \nГерой: {health}hp");
                                prayerIsRead = false;
                            }
                            else
                            {
                                if (opponentHealth > 0)
                                {
                                    opponentHealth -= damage;
                                }
                                health /= 2;
                                Console.WriteLine($"Герой наносит {damage} урона \nГолем: {opponentHealth}hp \nГерой: {health}hp");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nВы ещё не можете использовать эту способность.");
                        }
                        break;
                    case "Prey":
                        damage = 0;
                        lowDamage = Convert.ToDouble(rand.Next(3, 7));
                        lowDamage /= 10;
                        opponentDamage *= lowDamage;
                        health -= opponentDamage;
                        prayerIsRead = true;
                        Console.WriteLine($"Голем наносит {opponentDamage} урона, герой наносит {damage} урона \nГолем: {opponentHealth}hp \nГерой: {health}hp");
                        opponentDamage = rand.Next(20, 40);
                        break;
                    default:
                        Console.WriteLine("\nЧто-то пошло не так, попробуйте ещё раз.\n");
                        break;
                }

                if ((opponentHealth > 0) && (health > 0))
                {
                    Console.WriteLine("\nБой продолжается!\n");
                }
                else if ((opponentHealth > 0) && (health >0))
                {
                    Console.WriteLine("\nНа поле не осталось живых, оба погибли.\n");
                }
                
                else if (opponentHealth <= 0)
                {
                    Console.WriteLine("\nПобеда героя! Голем повержен!\n");
                }
                else if (health <= 0)
                {
                    Console.WriteLine("\nГерой пал. Голем победил.\n");
                }
            }
        }
    }
}
