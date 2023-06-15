using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Story
    {
        private Character player;
        public void Start()
        {
            Console.WriteLine("Добро пожаловать в игру!");

            Console.WriteLine("Выберите класс:");
            Console.WriteLine("1. Маг");
            Console.WriteLine("2. Лучник");
            Console.WriteLine("3. Воин");
            int classChoice = Convert.ToInt32(Console.ReadLine());

            switch (classChoice)
            {
                case 1:
                    player = new Mage();
                    break;
                case 2:
                    player = new Archer();
                    break;
                case 3:
                    player = new Warrior();
                    break;
                default:
                    Console.WriteLine("Недопустимый выбор. Выбран класс по умолчанию: Маг");
                    player = new Mage();
                    break;
            }

            Console.WriteLine($"Вы выбрали класс: {player.ClassName}");
            Console.WriteLine($"Пассивное умение: {player.PassiveAbility}");

            // Использование пассивного умения
            player.UsePassiveAbility();

            Console.WriteLine("Вы начинаете свое путешествие...");

            Console.WriteLine("Вы оказались на краю темного леса.");
            Console.WriteLine("Путь ведет глубже в лес. Пойдете ли вы дальше? (да/нет)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "да")
            {
                Console.Clear();
                Console.WriteLine("Вы продвигаетесь дальше по тропинке, когда вдруг слышите странный звук.");
                Console.WriteLine("Внезапно из-за деревьев выскакивает огромный волк!");
                Console.WriteLine("Битва начинается!");
                Character spider = new Enemy("Паук", 80, 30, 10, 0);
                Battle battle = new Battle(player, spider);
                battle.StartBattle();

                if (player.Health > 0)
                {
                    Console.WriteLine("Вы победили волка и продолжаете свое путешествие.");
                    Console.WriteLine("Вы находите таинственную пещеру. Зайдете ли вы внутрь? (да/нет)");
                    choice = Console.ReadLine();

                    if (choice.ToLower() == "да")
                    {
                        Console.WriteLine("Вы входите в пещеру и видите глаза, светящиеся в темноте.");
                        Console.WriteLine("Из тьмы выпрыгивает летучая мышь и атакует вас!");
                        Character volk = new Enemy("Волк", 80, 30, 10, 0);
                        battle = new Battle(player, volk);
                        battle.StartBattle();

                        if (player.Health > 0)
                        {
                            Console.WriteLine("Вы победили летучую мышь и идете дальше по пещере.");

                            Console.WriteLine("Вы выходите из пещеры и видите реку. Переплыть через реку? (да/нет)");
                            choice = Console.ReadLine();

                            if (choice.ToLower() == "да")
                            {
                                Console.WriteLine("Вы начинаете плыть через реку...");

                                // Миниигра "Камень-ножницы-бумага"
                                bool minigameResult = MiniGame();

                                if (minigameResult)
                                {
                                    Console.WriteLine("Ура! Вы выиграли в игре и успешно переплыли реку.");
                                    Console.WriteLine("Вы достигаете конечной точки своего путешествия. Поздравляю, вы успешно завершили игру!");
                                }
                                else
                                {
                                    Console.WriteLine("О нет! Вы проиграли в игре и утонули в реке. Игра окончена!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы обходите реку и продолжаете свое путешествие.");

                                Console.WriteLine("Вы натыкаетесь на старую избу. Зайдете ли вы внутрь? (да/нет)");
                                choice = Console.ReadLine();

                                if (choice.ToLower() == "да")
                                {
                                    Console.WriteLine("Вы заходите в избу и видите темную фигуру в углу комнаты.");
                                    Console.WriteLine("Это оказывается злобный ведьмак!");
                                    Character vedmak = new Enemy("Ведьмак", 150, 40, 20, 0);
                                    battle = new Battle(player, vedmak);
                                    battle.StartBattle();

                                    if (player.Health > 0)
                                    {
                                        Console.WriteLine("Вы победили ведьмака и продолжаете свое путешествие.");
                                        Console.WriteLine("Вы находите древний храм, скрытый в глубинах леса.");
                                        Console.WriteLine("Зайдете ли вы внутрь храма? (да/нет)");
                                        choice = Console.ReadLine();
                                        if (choice.ToLower() == "да")
                                        {
                                            Console.WriteLine("Вы входите в храм и ощущаете мощную энергию вокруг себя.");
                                            Console.WriteLine("После нескольких шагов перед вами возникает финальный босс!");
                                            Dialogue();
                                            Character finalBoss = new Enemy("Финальный Босс", 200, 50, 30, 0);
                                            battle = new Battle(player, finalBoss);
                                            battle.StartBattle();

                                            if (player.Health > 0)
                                            {
                                                Console.WriteLine("Поздравляю! Вы победили финального босса и завершили свое путешествие!");
                                                Console.WriteLine("Вы стали героем мира и ваша история запомнится навсегда!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Финальный босс оказался слишком сильным. Вы погибли. Игра окончена!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы решаете не заходить в храм и продолжаете свое путешествие.");

                                            Console.WriteLine("Вы натыкаетесь на сокровищницу, спрятанную в глубине леса!");
                                            Console.WriteLine("Ура! Вы собрали все сокровища и завершили игру!");
                                        }
                                        Console.WriteLine("Вы достигаете конечной точки своего путешествия. Поздравляю, вы успешно завершили игру!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ведьмак оказался слишком сильным. Вы погибли. Игра окончена!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Вы решаете не заходить в избу и продолжаете свое путешествие.");

                                    Console.WriteLine("Вы находите сокровищницу, спрятанную в дупле дерева!");
                                    Console.WriteLine("Ура! Вы собрали все сокровища и завершили игру!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Летучая мышь оказалась сильнее. Вы погибли. Игра окончена!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы решаете не заходить в пещеру и продолжаете свое путешествие.");

                        Console.WriteLine("Вы натыкаетесь на старый замок. Зайдете ли вы внутрь? (да/нет)");
                        choice = Console.ReadLine();

                        if (choice.ToLower() == "да")
                        {
                            Console.WriteLine("Вы входите в замок и слышите шорох за спиной.");
                            Console.WriteLine("Вы оборачиваетесь и видите гигантского паука!");
                            
                            battle = new Battle(player, spider);
                            battle.StartBattle();

                            if (player.Health > 0)
                            {
                                Console.WriteLine("Вы победили паука и продолжаете свое путешествие.");
                                Console.WriteLine("Вы достигаете конечной точки своего путешествия. Поздравляю, вы успешно завершили игру!");
                            }
                            else
                            {
                                Console.WriteLine("Паук оказался смертоносным. Вы погибли. Игра окончена!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы решаете не заходить в замок и продолжаете свое путешествие.");

                            Console.WriteLine("Вы находите сокровищницу, спрятанную в дупле дерева!");
                            Console.WriteLine("Ура! Вы собрали все сокровища и завершили игру!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Волк оказался сильнее. Вы погибли. Игра окончена!");
                }
            }
            else
            {
                Console.WriteLine("Вы решаете не продвигаться дальше по лесу и завершаете игру.");
            }
        }

        private bool MiniGame()
        {
            Console.WriteLine("Вы встречаете русалку!");
            Console.WriteLine("Русалка: Здравствуй! Я не пропущу тебя дальше, если ты не выиграешь у меня в 'камень,ножницы,бумага'");
            
            int playerWins = 0;
            int computerWins = 0;

            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine($"Раунд {round}:");
                Console.WriteLine("Выберите одну из следующих опций:");
                Console.WriteLine("1. Камень");
                Console.WriteLine("2. Ножницы");
                Console.WriteLine("3. Бумага");
                int playerChoice = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                int computerChoice = random.Next(1, 4);

                Console.WriteLine($"Вы выбрали {GetOptionName(playerChoice)}");
                Console.WriteLine($"Русалка выбрала {GetOptionName(computerChoice)}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Ничья в этом раунде!");
                }
                else if ((playerChoice == 1 && computerChoice == 2) ||
                         (playerChoice == 2 && computerChoice == 3) ||
                         (playerChoice == 3 && computerChoice == 1))
                {
                    Console.WriteLine("Вы выиграли этот раунд!");
                    playerWins++;
                }
                else
                {
                    Console.WriteLine("Русалка выиграл этот раунд!");
                    computerWins++;
                }

                Console.WriteLine();
            }

            if (playerWins > computerWins)
            {
                Console.WriteLine("Вы победили русалку и двигаетесь дальше!");
                return true;
            }
            else
            {
                Console.WriteLine("К сожалению, вы проиграли!");
                Console.WriteLine("Вы утонули...");
                return false;
            }
        }

        private string GetOptionName(int option)
        {
            switch (option)
            {
                case 1:
                    return "Камень";
                case 2:
                    return "Ножницы";
                case 3:
                    return "Бумага";
                default:
                    return "Недопустимая опция";
            }
        }

        public void Dialogue()
        {
            Console.WriteLine("Финальный Босс: Так, ты добрался до меня, ничтожество!");
            Console.WriteLine("Финальный Босс: Я позволю тебе пройти, если ответишь на мою загадку.");
            Console.WriteLine("Финальный Босс: Готов ли ты к вызову? (да/нет)");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "да")
            {
                Console.WriteLine("Финальный Босс: Хорошо, вот моя загадка:");
                Console.WriteLine("Финальный Босс: Всегда вижу вперед, но никогда не двигаюсь. Что я?");
                Console.WriteLine("Выберите ваш ответ:");
                Console.WriteLine("1. Глаз");
                Console.WriteLine("2. Мозг");
                Console.WriteLine("3. Компас");

                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 2) // Правильный ответ
                {
                    Console.WriteLine("Финальный Босс: Правильно! Ты проявил ум и смекалку.");
                    Console.WriteLine("Финальный Босс: Проходи, ты достоин моего уважения.");
                }
                else // Неправильный ответ
                {
                    Console.WriteLine("Финальный Босс: Ты ошибся! За такую наглость приготовься к смерти!");
                }
            }
            else
            {
                Console.WriteLine("Финальный Босс: Ну что ж, если ты не готов, то тебе здесь не место!");
            }
        }

    }

}
