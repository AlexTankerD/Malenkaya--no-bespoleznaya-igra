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
        public virtual void HealHero()
        {
            string ЗдоровьеГероя = "\nВаше здоровье: ";
            HeroHP += Heal;
            if (HeroHP == 150)
            {
                HeroHP -= Heal;
            }
            if (HeroHP == 140)
            {
                HeroHP -= 40;
            }
            if (HeroHP == 130)
            {
                HeroHP -= 30;
            }
            if (HeroHP == 120)
            {
                HeroHP -= 20;
            }
            if (HeroHP == 110)
            {
                HeroHP -= 10;
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



    }
}
