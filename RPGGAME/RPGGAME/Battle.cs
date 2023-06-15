using System;
using System.Threading;

namespace RPGGAME
{
    public class Battle
    {
        private Character player;
        private Character enemy;

        public Battle(Character player, Character enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        public void StartBattle()
        {
            Console.WriteLine($"Вы сражаетесь против {enemy.ClassName}!");
            Console.WriteLine("Битва начинается!");

            while (player.Health > 0 && enemy.Health > 0)
            {
                player.UsePassiveAbility();
                enemy.UsePassiveAbility();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ваше здоровье: {player.Health}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Здоровье {enemy.ClassName}: {enemy.Health}");
                Console.ResetColor();

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Обычная атака");
                Console.WriteLine("2. Суператака");

                int choice;
                bool validChoice = false;
                do
                {
                    Console.Write("Введите номер выбранного действия: ");
                    string choiceStr = Console.ReadLine();
                    validChoice = int.TryParse(choiceStr, out choice);
                    if (!validChoice)
                    {
                        Console.WriteLine("Недопустимый выбор. Попробуйте снова.");
                    }
                } while (!validChoice);

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        player.Attack(enemy);
                        break;
                    case 2:
                        player.UseSuperAttack(enemy);
                        break;
                    default:
                        Console.WriteLine("Недопустимый выбор. Пропускаю ход.");
                        break;
                }

                if (enemy.Health > 0)
                {
                    int enemyDamage = CalculateDamage(); // Рассчет урона врага
                    player.Health -= enemyDamage;
                    Console.WriteLine($"{enemy.ClassName} нанес вам {enemyDamage} урона.");

                    Thread.Sleep(1000); // Задержка перед выводом следующего сообщения
                }

                Console.WriteLine();
            }

            if (player.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Вы победили {enemy.ClassName}!");
                Console.ResetColor();

                // Анимация победы
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вы погибли в битве с {enemy.ClassName}. Игра окончена!");
                Console.ResetColor();

                // Анимация поражения
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
            }

            Console.Clear();
        }

        private int CalculateDamage()
        {
            Random random = new Random();
            int minDamage = 1;
            int maxDamage = 10;
            int damage = random.Next(minDamage, maxDamage + 1);

            return damage;
        }
    }
}
