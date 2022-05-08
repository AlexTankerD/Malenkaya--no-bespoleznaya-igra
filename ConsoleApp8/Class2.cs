using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp8
{
    public class Enemy
    {
        public int EnemyHP { get; set; }
        public int Heal;
        public int HeroHP { get; set; }
        public bool HeroDeath = false;
        public Enemy()
        {
            EnemyHP = 100;
            Heal = 50;
            HeroHP = 100;
            HeroDeath = false;
        }

                                 
        public virtual void GetDamage(int Damage)
        {
            string ЗдоровьеГероя = "\nВаше здоровье: ";
            HeroHP -= Damage; 
            if (HeroHP <= 0)
            {
                HeroDeath = true;
                foreach (char s in ЗдоровьеГероя)
                {
                    Console.Write(s);
                    Thread.Sleep(30);
                }
                Console.Write(HeroHP);
                return;
            }
            foreach (char s in ЗдоровьеГероя)
            {
                Console.Write(s);
                Thread.Sleep(30);
            }
            Console.Write(HeroHP);
        }       
        public virtual void HealHero(int Heal)
        {
            string ЗдоровьеГероя = "\nВаше здоровье: ";
            HeroHP += Heal;
            if (HeroHP > 100)
            {
                HeroHP = 100;
            }
                     
            foreach (char s in ЗдоровьеГероя)
            {
                Console.Write(s);
                Thread.Sleep(30);
            }
            Console.Write(HeroHP);

        }
        public void SetDamage(int dmg)
        {
            GetDamage(dmg);
        }
        public void Round()
        {
            HeroHP = 100;
            if (HeroHP > 0)
            {
                HeroDeath = false;
            }
        }


    }
}
