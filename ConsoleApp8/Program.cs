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
            string ПротивникПромахнулся = "Противник промахнулся (0 DMG)";
            string ВыУмерли = "                                                           YOU DIED";          
            string ВыПромахнулись = "Вы промахнулись (0 DMG)";          
            string ПротивникУмер = "                                                      ENEMY DIED";
            string КОНЕЦИГРЫ = "                                                        КОНЕЦ ИГРЫ";
            string НАЖМИТЕSPACEBAR = "НАЖМИТЕ BACKSPACE ЧТОБЫ НАЧАТЬ ЗАНОВО ИЛИ SPACEBAR ЧТОБЫ ЗАКОНЧИТЬ";
            string ВыЗамахиваетесь = "Вы замахиваетесь";
            string ПротивникЗамахивается = "Противник замахивается";
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
                int Random1 = random.Next(1,5);
                int Random2 = random.Next(1,5);
                int Randomc1 = random.Next(1,6);
                int Randomc2 = random.Next(1,6);
                int RandomH1 = random.Next(1,4);
                int RandomH2 = random.Next(1,4);
                if (Random2 == 1)
                {
                    int Hit1 = random.Next(30, 51);
                    int HitR1 = random.Next(50, 71);
                    int ВыСпоткнулись1R = random.Next(10, 31);
                    int ВыСпоткнулись2R = random.Next(0, 21);
                    string Удар1 = "Вы нанесли противнику удар в паховую область (" + Hit1 + "DMG)";
                    string УдарR1 = "Вы нанесли противнику удар в паховую область (" + HitR1 + "DMG)";
                    string ВыСпоткнулись1 = "Вы споткнулись и сломали копчик (" + ВыСпоткнулись1R + "DMG)";
                    string ВыСпоткнулись2 = "Вы споткнулись и сломали нос (" + ВыСпоткнулись2R + "DMG)";
                    string ВыНаноситеПовшенныйУрон = "Вы поднабрались сил и наносите повышенный урон";
                    foreach (char s in ВыЗамахиваетесь)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (Randomc2 == 1)
                    {
                        foreach (char s in Удар1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Hit1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 2)
                    {
                        foreach (char s in ВыСпоткнулись1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(ВыСпоткнулись1R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 3)
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
                    else if (Randomc2 == 4)
                    {
                        foreach (char s in ВыСпоткнулись2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(ВыСпоткнулись2R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 5)
                    {
                        foreach (char s in ВыНаноситеПовшенныйУрон)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УдарR1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(HitR1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                else if (Random2 == 2)
                {
                    int Hit2 = random.Next(20, 41);
                    int HitR2 = random.Next(40, 61);
                    string Удар2 = "Вы нанесли противнику удар в глаз (" + Hit2 + "DMG)";
                    int ВыСпоткнулись1R = random.Next(10, 31);
                    int ВыСпоткнулись2R = random.Next(0, 21);
                    string ВыСпоткнулись1 = "Вы споткнулись и сломали копчик (" + ВыСпоткнулись1R + "DMG)";
                    string ВыСпоткнулись2 = "Вы споткнулись и сломали нос (" + ВыСпоткнулись2R + "DMG)";
                    string ВыНаноситеПовшенныйУрон = "Вы поднабрались сил и наносите повышенный урон";
                    string УдарR2 = "Вы нанесли противнику удар в глаз (" + HitR2 + "DMG)";
                    foreach (char s in ВыЗамахиваетесь)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (Randomc2 == 1)
                    {
                        foreach (char s in Удар2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Hit2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 2)
                    {
                        foreach (char s in ВыСпоткнулись1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(ВыСпоткнулись1R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 3)
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
                    else if (Randomc2 == 4)
                    {
                        foreach (char s in ВыСпоткнулись2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(ВыСпоткнулись2R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 5)
                    {
                        foreach (char s in ВыНаноситеПовшенныйУрон)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УдарR2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(HitR2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                else if (Random2 == 3)
                {
                    int Hit3 = random.Next(10, 31);
                    int HitR3 = random.Next(30, 51);
                    string Удар3 = "Вы пнули противника под зад (" + Hit3 + "DMG)";
                    int ВыСпоткнулись1R = random.Next(10, 31);
                    int ВыСпоткнулись2R = random.Next(0, 21);
                    string ВыСпоткнулись1 = "Вы споткнулись и сломали копчик (" + ВыСпоткнулись1R + "DMG)";
                    string ВыСпоткнулись2 = "Вы споткнулись и сломали нос (" + ВыСпоткнулись2R + "DMG)";
                    string ВыНаноситеПовшенныйУрон = "Вы поднабрались сил и наносите повышенный урон";
                    string УдарR3 = "Вы нанесли противнику удар в глаз (" + HitR3 + "DMG)";
                    foreach (char s in ВыЗамахиваетесь)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (Randomc2 == 1)
                    {
                        foreach (char s in Удар3)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Hit3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 2)
                    {
                        foreach (char s in ВыСпоткнулись1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(ВыСпоткнулись1R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 3)
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
                    else if (Randomc2 == 4)
                    {
                        foreach (char s in ВыСпоткнулись2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(ВыСпоткнулись2R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc2 == 5)
                    {
                        foreach (char s in ВыНаноситеПовшенныйУрон)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УдарR3)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(HitR3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                else if (Random2 == 4)
                {
                    int Heal1 = random.Next(50, 71);
                    int Heal2 = random.Next(30, 51);
                    int Heal3 = random.Next(10, 31);
                    string ВыИспользовалиБольшуюАптечку = "Вы использовали большую аптечку (+" + Heal1 + "HP)";
                    string ВыИспользовалиСреднююАптечку = "Вы использовали среднюю аптечку (+" + Heal2 + "HP)";
                    string ВыИспользовалиМаленькуюАптечку = "Вы использовали маленькую аптечку (+" + Heal3 + "HP)";
                    if (RandomH2 == 1)
                    {
                        foreach (char s in ВыИспользовалиБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(Heal1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomH2 == 2)
                    {
                        foreach (char s in ВыИспользовалиСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(Heal2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomH2 == 3)
                    {
                        foreach (char s in ВыИспользовалиМаленькуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(Heal3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
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
                if (Random1 == 1)
                {
                    int Hit1 = random.Next(30, 51);
                    int HitR1 = random.Next(50, 71);
                    int ПротивникСпоткнулся1R = random.Next(10, 31);
                    int ПротивникСпоткнулся2R = random.Next(0, 21);
                    string Удар1 = "Противник нанёс вам удар в паховую область (" + Hit1 + "DMG)";
                    string УдарR1 = "Противник нанёс вам удар в паховую область (" + HitR1 + "DMG)";
                    string ПротивникСпоткнулся1 = "Противник споткнулся и сломал копчик (" + ПротивникСпоткнулся1R + "DMG)";
                    string ПротивникСпоткнулся2 = "Противник споткнулся и сломал нос (" + ПротивникСпоткнулся2R + "DMG)";
                    string ПротивникНаноситПовшенныйУрон = "Противник поднабрался сил и наносит повышенный урон";
                    foreach (char s in ПротивникЗамахивается)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (Randomc1 == 1)
                    {
                        foreach (char s in Удар1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Hit1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 2)
                    {
                        foreach (char s in ПротивникСпоткнулся1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(ПротивникСпоткнулся1R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 3)
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
                    else if (Randomc1 == 4)
                    {
                        foreach (char s in ПротивникСпоткнулся2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(ПротивникСпоткнулся2R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 5)
                    {
                        foreach (char s in ПротивникНаноситПовшенныйУрон)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УдарR1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(HitR1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                else if (Random1 == 2)
                {
                    int Hit2 = random.Next(20, 41);
                    int HitR2 = random.Next(40, 61);
                    int ПротивникСпоткнулся1R = random.Next(10, 31);
                    int ПротивникСпоткнулся2R = random.Next(0, 21);
                    string Удар2 = "Противник нанёс вам удар в глаз (" + Hit2 + "DMG)";
                    string УдарR2 = "Противник нанёс вам удар в глаз (" + HitR2 + "DMG)";
                    string ПротивникСпоткнулся1 = "Противник споткнулся и сломал копчик (" + ПротивникСпоткнулся1R + "DMG)";
                    string ПротивникСпоткнулся2 = "Противник споткнулся и сломал нос (" + ПротивникСпоткнулся2R + "DMG)";
                    string ПротивникНаноситПовшенныйУрон = "Противник поднабрался сил и наносит повышенный урон";
                    foreach (char s in ПротивникЗамахивается)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (Randomc1 == 1)
                    {
                        foreach (char s in Удар2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Hit2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 2)
                    {
                        foreach (char s in ПротивникСпоткнулся1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(ПротивникСпоткнулся1R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 3)
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
                    else if (Randomc1 == 4)
                    {
                        foreach (char s in ПротивникСпоткнулся2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(ПротивникСпоткнулся2R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 5)
                    {
                        foreach (char s in ПротивникНаноситПовшенныйУрон)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УдарR2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(HitR2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }                
                else if (Random1 == 3)
                {
                    int Hit3 = random.Next(10, 31);
                    int HitR3 = random.Next(30, 51);
                    int ПротивникСпоткнулся1R = random.Next(10, 31);
                    int ПротивникСпоткнулся2R = random.Next(0, 21);
                    string Удар3 = "Противник пнул вас под зад (" + Hit3 + "DMG)";
                    string УдарR3 = "Противник пнул вас под зад (" + HitR3 + "DMG)";
                    string ПротивникСпоткнулся1 = "Противник споткнулся и сломал копчик (" + ПротивникСпоткнулся1R + "DMG)";
                    string ПротивникСпоткнулся2 = "Противник споткнулся и сломал нос (" + ПротивникСпоткнулся2R + "DMG)";
                    string ПротивникНаноситПовшенныйУрон = "Противник поднабрался сил и наносит повышенный урон";
                    foreach (char s in ПротивникЗамахивается)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (Randomc1 == 1)
                    {
                        foreach (char s in Удар3)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Hit3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 2)
                    {
                        foreach (char s in ПротивникСпоткнулся1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(ПротивникСпоткнулся1R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 3)
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
                    else if (Randomc1 == 4)
                    {
                        foreach (char s in ПротивникСпоткнулся2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(ПротивникСпоткнулся2R);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (Randomc1 == 5)
                    {
                        foreach (char s in ПротивникНаноситПовшенныйУрон)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УдарR3)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(HitR3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                else if (Random1 == 4)
                {
                    int Heal1 = random.Next(50, 71);
                    int Heal2 = random.Next(30, 51);
                    int Heal3 = random.Next(10, 31);
                    string ПротивникИспользовалБольшуюАптечку = "Противник использовал большую аптечку (+" + Heal1 + "HP)";
                    string ПротивникИспользовалСреднююАптечку = "Противник использовал среднюю аптечку (+" + Heal2 + "HP)";
                    string ПротивникИспользовалМаленькуюАптечку = "Противник использовал маленькую аптечку (+" + Heal3 + "HP)";
                    if (RandomH2 == 1)
                    {
                        foreach (char s in ПротивникИспользовалБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(Heal1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomH2 == 2)
                    {
                        foreach (char s in ПротивникИспользовалСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(Heal2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomH2 == 3)
                    {
                        foreach (char s in ПротивникИспользовалМаленькуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(Heal3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }

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
            
            
        }
    }
}
