using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp8
{

    internal class Program
    {
        public static void Приветствие()
        {
            string Пропустить = "ПРОПУСТИТЬ? (SPACEBAR)";
            string Приветствую = "                                                       Приветствую!";
            string СутьИгры = "Суть этой маленькой, но бесполезной игры заключается в наличии вашего героя и врага. У вашего героя и врага есть определенное количество здоровья, а также есть возможность нанести урон врагу в зависимости от рандома, не исключая того, что враг тоже имеет данную возможность. Если противник опустошит вашу полоску HP то вы проиграете, если наоборот то выиграете.";
            int a = 30;
            int b = 1000;
            int c = 500;
            foreach (char s in Пропустить)
            {
                Console.Write(s);
                Thread.Sleep(30);
            }            
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                return;
            }
            Console.Clear();
                foreach (char s in Приветствую)
            {
                Console.Write(s);
                Thread.Sleep(1);
            }

            Thread.Sleep(1000);
            Console.Clear();
            foreach (char s in СутьИгры)
            {
                Console.Write(s);
                Thread.Sleep(a);
            }
            Thread.Sleep(b);
            Console.Clear();
        }
        public static void Main()
        {          
            Enemy Enemy = new Enemy();
            Character Character = new Character();
            Random random = new Random();            
            string Начать = "НАЧАТЬ (SPACEBAR): ";
            string Начать1 = "НАЧАТЬ? (SPACEBAR): ";
            string Удар1 = "Противник нанёс вам удар в паховую область (50 DMG)";
            string Удар2 = "Противник нанёс вам удар в глаз (40 DMG)";
            string Удар3 = "Противник пнул вас под зад (30 DMG)";
            string ПротивникПромахнулся = "Противник промахнулся (0 DMG)";
            string ВыУмерли = "                                                           YOU DIED";
            string ПротивникИспользовалАптечку = "Противник использовал аптечку(+50HP)";
            string ВыИспользовалиАптечку = "Вы использовали аптечку(+50HP)";
            string УдарПротивника1 = "Вы нанесли противнику удар в паховую область (50 DMG)";
            string УдарПротивника2 = "Вы нанесли противнику удар в глаз (40 DMG)";
            string ВыПромахнулись = "Вы промахнулись (0 DMG)";
            string УдарПротивника3 = "Вы пнули противника под зад (30 DMG)";
            string ПротивникУмер = "                                                      ENEMY DIED";
            string КОНЕЦИГРЫ = "                                                        КОНЕЦ ИГРЫ";
            string НАЖМИТЕSPACEBAR = "НАЖМИТЕ BACKSPACE ЧТОБЫ НАЧАТЬ ЗАНОВО ИЛИ SPACEBAR ЧТОБЫ ЗАКОНЧИТЬ";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Приветствие();
            
            foreach (char s in Начать)
            {
                Console.Write(s);
                Thread.Sleep(30);
            }
            
            for (; ; )
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    foreach (char s in Начать1)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    continue;

                }
                
            }
            for (; ; )
            {
                int Random1 = random.Next(1,6);
                int Random2 = random.Next(1,6);                
                if (Random2 == 1)
                {
                    foreach (char s in УдарПротивника1)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Character.GetDamage(50);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random2 == 2)
                {
                    foreach (char s in УдарПротивника2)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Character.GetDamage(40);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random2 == 3)
                {
                    foreach (char s in ВыПромахнулись)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Character.GetDamage(0);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random2 == 4)
                {
                    foreach (char s in УдарПротивника3)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Character.GetDamage(30);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random2 == 5)
                {
                    foreach (char s in ВыИспользовалиАптечку)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Enemy.HealHero();
                    Thread.Sleep(3000);
                    Console.Clear();

                }
                if (Character.EnemyDeath == true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (char s in ПротивникУмер)
                    {
                        Console.Write(s);
                        Thread.Sleep(1);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                }
                if (Random1 == 1)
                {
                    foreach (char s in Удар1)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Enemy.GetDamage(50);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random1 == 2)
                {
                    foreach (char s in Удар2)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Enemy.GetDamage(40);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random1 == 3)
                {
                    foreach (char s in ПротивникПромахнулся)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Enemy.GetDamage(0);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random1 == 4)
                {
                    foreach (char s in Удар3)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Enemy.GetDamage(30);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (Random1 == 5)
                {
                    foreach (char s in ПротивникИспользовалАптечку)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Character.HealEnemy();
                    Thread.Sleep(3000);
                    Console.Clear();

                }
                if (Enemy.HeroDeath == true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (char s in ВыУмерли)
                    {
                        Console.Write(s);
                        Thread.Sleep(1);
                    }
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                }
            }
            foreach (char s in КОНЕЦИГРЫ)
            {
                Console.Write(s);
                Thread.Sleep(1);
            }
            Thread.Sleep(1000);
            Console.Clear();
            
            for (; ; )
            {
                Console.Clear();
                foreach (char s in НАЖМИТЕSPACEBAR)
                {
                    Console.Write(s);
                    Thread.Sleep(30);
                }
                if (Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    Main();
                }
                else if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    break;
                }
                else
                    continue;

            }
            Console.Clear();
            return;
            
        }
    }
}
