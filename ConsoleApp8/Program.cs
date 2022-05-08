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
            string ВыУмерли = "                                                           ENEMY WIN";
            string ВыВыиграли = "ВЫ ВЫИГРАЛИ";
            string ВыПромахнулись = "Вы промахнулись (0 DMG)";          
            string ПротивникУмер = "                                                      YOU WIN";
            string КОНЕЦИГРЫ = "                                                        КОНЕЦ ИГРЫ";
            string НАЖМИТЕSPACEBAR = "НАЖМИТЕ BACKSPACE ЧТОБЫ НАЧАТЬ ЗАНОВО ИЛИ SPACEBAR ЧТОБЫ ЗАКОНЧИТЬ";
            string ВыЗамахиваетесь = "Вы замахиваетесь";
            string ПротивникЗамахивается = "Противник замахивается";
            string ПротивникПобедил = "ПРОТИВНИК ПОБЕДИЛ";
            string ВыГоворитеПротивнику = "Вы говорите противнику: ";
            string ПротивникГоворитВам = "Противник говорит вам: ";
            string Счёт = "СЧЁТ ";
            int Раунд0 = 1;
            int RoundH = 0;
            int RoundE = 0;
            string Раунд = "РАУНД : 1";
            string РаундR = "РАУНД : ";
            int АптечкаБольшая = 1;
            int АптечкаСредняя = 1;
            int АптечкаМаленькая = 1;
            int АптечкаПротивникаБольшая = 1;
            int АптечкаПротивникаСредняя = 1;
            int АптечкаПротивникаМаленькая = 1;
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
            foreach (char s in Раунд)
            {
                Console.Write(s);
                Thread.Sleep(30);
            }
            Thread.Sleep(1000);
            Console.Clear();

            for (; ; )
            {
                int Random1 = random.Next(1, 7);
                int Random2 = random.Next(1, 7);
                int Randomc1 = random.Next(1, 6);
                int Randomc2 = random.Next(1, 6);
                int RandomH1 = random.Next(1, 4);
                int RandomH2 = random.Next(1, 4);
                int RandomMockery1 = random.Next(1, 6);
                int RandomMockery2 = random.Next(1, 6);
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
                    Character.Round();
                    Enemy.Round();
                    Раунд0 += 1;
                    RoundH += 1;
                    АптечкаМаленькая += 1;
                    АптечкаСредняя += 1;
                    АптечкаМаленькая += 1;
                    АптечкаПротивникаБольшая += 1;
                    АптечкаПротивникаСредняя += 1;
                    АптечкаПротивникаМаленькая += 1;
                    foreach (char s in Счёт)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Write(RoundH + ":" + RoundE);
                    Thread.Sleep(1500);
                    Console.Clear();
                    if (RoundH == 2)
                    {
                        foreach (char s in ВыВыиграли)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                    foreach (char s in РаундR)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Console.Write(Раунд0);
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;

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
                    Character.Round();
                    Enemy.Round();
                    Раунд0 += 1;
                    RoundE += 1;
                    АптечкаМаленькая += 1;
                    АптечкаСредняя += 1;
                    АптечкаМаленькая += 1;
                    АптечкаПротивникаБольшая += 1;
                    АптечкаПротивникаСредняя += 1;
                    АптечкаПротивникаМаленькая += 1;
                    foreach (char s in Счёт)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Thread.Sleep(1000);
                    Console.Write(RoundH + ":" + RoundE);
                    Thread.Sleep(1500);
                    Console.Clear();
                    if (RoundE == 2)
                    {
                        foreach (char s in ПротивникПобедил)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                    foreach (char s in РаундR)
                    {
                        Console.Write(s);
                        Thread.Sleep(30);
                    }
                    Console.Write(Раунд0);
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                if (Random2 == 1 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit1 = random.Next(30, 51);
                    int HitR1 = random.Next(50, 71);
                    int ВыСпоткнулись1R = random.Next(10, 31);
                    int ВыСпоткнулись2R = random.Next(5, 21);
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
                else if (Random2 == 2 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit2 = random.Next(20, 41);
                    int HitR2 = random.Next(40, 61);
                    string Удар2 = "Вы нанесли противнику удар в глаз (" + Hit2 + "DMG)";
                    int ВыСпоткнулись1R = random.Next(10, 31);
                    int ВыСпоткнулись2R = random.Next(5, 21);
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
            
                else if (Random2 == 3 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit3 = random.Next(10, 31);
                    int HitR3 = random.Next(30, 51);
                    string Удар3 = "Вы пнули противника под зад (" + Hit3 + "DMG)";
                    int ВыСпоткнулись1R = random.Next(10, 31);
                    int ВыСпоткнулись2R = random.Next(5, 21);
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
                else if (Random2 == 4 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Heal1 = random.Next(50, 71);
                    int Heal2 = random.Next(30, 51);
                    int Heal3 = random.Next(10, 31);                    
                    string ВыИспользовалиБольшуюАптечку = "Вы используете большую аптечку (+" + Heal1 + "HP)";
                    string ВыИспользовалиСреднююАптечку = "Вы используете среднюю аптечку (+" + Heal2 + "HP)";
                    string ВыИспользовалиМаленькуюАптечку = "Вы используете маленькую аптечку (+" + Heal3 + "HP)";
                    string ВыРешаетесьИспользоватьБольшуюАптечку = "Вы решаетесь использовать большую аптечку";
                    string ВыРешаетесьИспользоватьСреднююАптечку = "Вы решаетесь использовать среднюю аптечку";
                    string ВыРешаетесьИспользоватьМаленькуюАптечку = "Вы решаетесь использовать маленькую аптечку";
                    string УВасНетБольшойАптечки = "У вас нет большой аптечки (+0HP)";
                    string УВасНетСреднейАптечки = "У вас нет средней аптечки (+0HP)";
                    string УВасНетМаленькойАптечки = "У вас нет маленькой аптечки (+0HP)";
                    if (RandomH2 == 1 && АптечкаБольшая == 0)
                    {
                        foreach (char s in ВыРешаетесьИспользоватьБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();                        
                        foreach (char s in УВасНетБольшойАптечки)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(0);
                        Thread.Sleep(3000);
                        Console.Clear();
                        
                    }
                    else if (RandomH2 == 2 && АптечкаСредняя == 0)
                    {
                        foreach (char s in ВыРешаетесьИспользоватьСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УВасНетСреднейАптечки)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(0);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomH2 == 3 && АптечкаМаленькая == 0)
                    {
                        foreach (char s in ВыРешаетесьИспользоватьСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УВасНетМаленькойАптечки)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        Enemy.HealHero(0);
                    }
                    if (RandomH2 == 1 && АптечкаБольшая == 1)
                    {
                        foreach (char s in ВыРешаетесьИспользоватьБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ВыИспользовалиБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(Heal1);
                        Thread.Sleep(3000);
                        Console.Clear();
                        АптечкаБольшая -= 1;
                    }
                    else if (RandomH2 == 2 && АптечкаСредняя == 1)
                    {
                        foreach (char s in ВыРешаетесьИспользоватьСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ВыИспользовалиСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(Heal2);
                        Thread.Sleep(3000);
                        Console.Clear();
                        АптечкаСредняя -= 1;
                    }
                    else if (RandomH2 == 3 && АптечкаМаленькая == 1)
                    {
                        foreach (char s in ВыРешаетесьИспользоватьМаленькуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ВыИспользовалиМаленькуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.HealHero(Heal3);
                        Thread.Sleep(3000);
                        Console.Clear();
                        АптечкаМаленькая -= 1;
                    }
                }               
                else if (Random2 == 5 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit5 = random.Next(50, 71);
                    int HitR5 = random.Next(70, 91);
                    int ВыСпоткнулись1R = random.Next(10, 31);
                    int ВыСпоткнулись2R = random.Next(5, 21);
                    string Удар5 = "Вы ударили противника в затылок (" + Hit5 + "DMG)";
                    string УдарR5 = "Вы ударили противника в затылок (" + HitR5 + "DMG)";
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
                        foreach (char s in Удар5)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Hit5);
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
                        foreach (char s in УдарR5)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(HitR5);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                else if (Random2 == 6 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Mockery1 = random.Next(25,31);
                    int Mockery3 = random.Next(15, 21);
                    int Mockery5 = random.Next(5, 11);
                    int Mockery2 = random.Next(20, 26);
                    int Mockery4 = random.Next(10, 16);
                    string MockeryH4 = "Вы посмеялись над пидорской чёлкой противника";
                    string MockeryH1 = "Ты плод инцеста брата и сестры";
                    string MockeryH5 = "Ебать важный, хуй бумажный";
                    string MockeryH3 = "У тебя рот в говне";
                    string MockeryH2 = "Я твою мать в канаве видел";
                    if (RandomMockery2 == 1)
                    {
                        string ВыОскорбилиПротивника = "Вы оскорбили противника (" + Mockery1 + "DMG)";
                        foreach (char s in ВыГоворитеПротивнику)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(500);
                        foreach (char s in MockeryH1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ВыОскорбилиПротивника)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Mockery1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomMockery2 == 2)
                    {
                        string ВыОскорбилиПротивника = "Вы оскорбили противника (" + Mockery2 + "DMG)";
                        foreach (char s in ВыГоворитеПротивнику)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        foreach (char s in MockeryH2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ВыОскорбилиПротивника)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Mockery2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomMockery2 == 3)
                    {
                        string ВыОскорбилиПротивника = "Вы оскорбили противника (" + Mockery3 + "DMG)";
                        foreach (char s in ВыГоворитеПротивнику)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        foreach (char s in MockeryH3)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ВыОскорбилиПротивника)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Mockery3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }                   
                   else if (RandomMockery2 == 4)
                    {
                        string ВыПосмеялисьНадПротивником = "Вы посмеялись над противником (" + Mockery4 + "DMG)";
                        foreach (char s in MockeryH4)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ВыПосмеялисьНадПротивником)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Mockery4);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomMockery2 == 5)
                    {
                        string ВыОскорбилиПротивника = "Вы оскорбили противника (" + Mockery5 + "DMG)";
                        foreach (char s in ВыГоворитеПротивнику)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        foreach (char s in MockeryH5)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ВыОскорбилиПротивника)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.GetDamage(Mockery5);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                if (Random1 == 1 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit1 = random.Next(30, 51);
                    int HitR1 = random.Next(50, 71);
                    int ПротивникСпоткнулся1R = random.Next(10, 31);
                    int ПротивникСпоткнулся2R = random.Next(5, 21);
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
                else if (Random1 == 2 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit2 = random.Next(20, 41);
                    int HitR2 = random.Next(40, 61);
                    int ПротивникСпоткнулся1R = random.Next(10, 31);
                    int ПротивникСпоткнулся2R = random.Next(5, 21);
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
                else if (Random1 == 3 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit3 = random.Next(10, 31);
                    int HitR3 = random.Next(30, 51);
                    int ПротивникСпоткнулся1R = random.Next(10, 31);
                    int ПротивникСпоткнулся2R = random.Next(5, 21);
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
                else if (Random1 == 4 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Heal1 = random.Next(50, 71);
                    int Heal2 = random.Next(30, 51);
                    int Heal3 = random.Next(10, 31);
                    string ПротивникИспользовалБольшуюАптечку = "Противник использует большую аптечку (+" + Heal1 + "HP)";
                    string ПротивникИспользовалСреднююАптечку = "Противник использует среднюю аптечку (+" + Heal2 + "HP)";
                    string ПротивникИспользовалМаленькуюАптечку = "Противник использует маленькую аптечку (+" + Heal3 + "HP)";
                    string ПротивникРешаетсяИспользоватьБольшуюАптечку = "Противник решается использовать большую аптечку";
                    string ПротивникРешаетсяИспользоватьСреднююАптечку = "Противник решается использовать среднюю аптечку";
                    string ПротивникРешаетсяИспользоватьМаленькуюАптечку = "Противник решается использовать маленькую аптечку";
                    string УПротивникаНетБольшойАптечки = "У противника нет большой аптечки (+0HP)";
                    string УПротивникаНетСреднейАптечки = "У противника нет средней аптечки (+0HP)";
                    string УПротивникаНетМаленькойАптечки = "У противника нет маленькой аптечки (+0HP)";
                    if (RandomH1 == 1 && АптечкаПротивникаБольшая == 0)
                    {
                        foreach (char s in ПротивникРешаетсяИспользоватьБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УПротивникаНетБольшойАптечки)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(0);
                        Thread.Sleep(3000);
                        Console.Clear();

                    }
                    else if (RandomH1 == 2 && АптечкаПротивникаСредняя == 0)
                    {
                        foreach (char s in ПротивникРешаетсяИспользоватьСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УПротивникаНетСреднейАптечки)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(0);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomH1 == 3 && АптечкаПротивникаМаленькая == 0)
                    {
                        foreach (char s in ПротивникРешаетсяИспользоватьМаленькуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in УПротивникаНетМаленькойАптечки)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        Character.HealEnemy(0);
                    }
                    if (RandomH1 == 1 && АптечкаПротивникаБольшая == 1)
                    {
                        foreach (char s in ПротивникРешаетсяИспользоватьБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ПротивникИспользовалБольшуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(Heal1);
                        Thread.Sleep(3000);
                        Console.Clear();
                        АптечкаПротивникаБольшая -= 1;
                    }
                    else if (RandomH1 == 2 && АптечкаПротивникаСредняя == 1)
                    {
                        foreach (char s in ПротивникРешаетсяИспользоватьСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ПротивникИспользовалСреднююАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(Heal2);
                        Thread.Sleep(3000);
                        Console.Clear();
                        АптечкаПротивникаСредняя -= 1;
                    }
                    else if (RandomH1 == 3 && АптечкаПротивникаМаленькая == 1)
                    {
                        foreach (char s in ПротивникРешаетсяИспользоватьМаленькуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ПротивникИспользовалМаленькуюАптечку)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Character.HealEnemy(Heal3);
                        Thread.Sleep(3000);
                        Console.Clear();
                        АптечкаПротивникаМаленькая -= 1;
                    }

                }
                if (Random1 == 5 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Hit5 = random.Next(50, 71);
                    int HitR5 = random.Next(70, 91);
                    int ПротивникСпоткнулся1R = random.Next(10, 31);
                    int ПротивникСпоткнулся2R = random.Next(5, 21);
                    string Удар5 = "Противник ударил вас в затылок (" + Hit5 + "DMG)";
                    string УдарR5 = "Противник ударил вас в затылок (" + HitR5 + "DMG)";
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
                        foreach (char s in Удар5)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Hit5);
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
                        foreach (char s in УдарR5)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(HitR5);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                else if (Random1 == 6 && Enemy.HeroDeath != true && Character.EnemyDeath != true)
                {
                    int Mockery1 = random.Next(25, 31);
                    int Mockery3 = random.Next(15, 21);
                    int Mockery5 = random.Next(5, 11);
                    int Mockery2 = random.Next(20, 26);
                    int Mockery4 = random.Next(10, 16);
                    string MockeryH3 = "Ты на ботана похож";
                    string MockeryH4 = "Противник посмеялся над вашим клоунским видом";
                    string MockeryH5 = "Ебать крутой, вытри сперму под губой";
                    string MockeryH2 = "Я мать твою ебал";
                    string MockeryH1 = "Ты приёмный";
                    if (RandomMockery1 == 1)
                    {
                        string ПротивникОскорбилВас = "Противник оскорбил вас (" + Mockery1 + "DMG)";
                        foreach (char s in ПротивникГоворитВам)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        foreach (char s in MockeryH1)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ПротивникОскорбилВас)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Mockery1);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }                   
                    else if (RandomMockery1 == 2)
                    {
                        string ПротивникОскорбилВас = "Противник оскорбил вас (" + Mockery2 + "DMG)";
                        foreach (char s in ПротивникГоворитВам)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        foreach (char s in MockeryH2)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ПротивникОскорбилВас)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Mockery2);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomMockery1 == 3)
                    {
                        string ПротивникОскорбилВас = "Противник оскорбил вас (" + Mockery3 + "DMG)";
                        foreach (char s in ПротивникГоворитВам)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        foreach (char s in MockeryH3)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ПротивникОскорбилВас)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Mockery3);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    if (RandomMockery1 == 4)
                    {
                        string ПротивникПосмеялсяНадВами = "Противник посмеялся над вами (" + Mockery4 + "DMG)";
                        foreach (char s in MockeryH4)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        foreach (char s in ПротивникПосмеялсяНадВами)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Mockery4);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (RandomMockery1 == 5)
                    {
                        string ПротивникОскорбилВас = "Противник оскорбил вас (" + Mockery5 + "DMG)";
                        foreach (char s in ПротивникГоворитВам)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1000);
                        foreach (char s in MockeryH5)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Thread.Sleep(1500);
                        Console.Clear();
                        foreach (char s in ПротивникОскорбилВас)
                        {
                            Console.Write(s);
                            Thread.Sleep(30);
                        }
                        Enemy.GetDamage(Mockery5);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
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

