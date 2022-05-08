using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp8
{
    public class Character
    {
        public int EnemyHP { get; set; }
        public int Heal;
        public int HeroHP { get; set; }
        public bool HeroDeath = false;
        public bool EnemyDeath = false;
        public Character()
        {
            EnemyHP = 200;
            Heal = 50;
            HeroHP = 200;
            HeroDeath = false;
            EnemyDeath = false;
        }


        public virtual void GetDamage(int Damage)
        {
            string ЗдоровьеПротивника = "\nЗдоровье противника: ";
            EnemyHP -= Damage;
            if (EnemyHP <= 0)
            {
                EnemyDeath = true;
                foreach (char s in ЗдоровьеПротивника)
                {
                    Console.Write(s);
                    Thread.Sleep(30);
                }
                Console.Write(EnemyHP);
                return;
            }
            foreach (char s in ЗдоровьеПротивника)
            {
                Console.Write(s);
                Thread.Sleep(30);
            }
            Console.Write(EnemyHP);
        }
        public virtual void HealEnemy(int Heal)
        {
            string ЗдоровьеПротивника = "\nЗдоровье противника: ";
            EnemyHP += Heal;
            if (EnemyHP > 200)
            {
                EnemyHP = 200;
            }
         
            foreach (char s in ЗдоровьеПротивника)
            {
                Console.Write(s);
                Thread.Sleep(30);
            }
            Console.Write(EnemyHP);

        }
        public void SetDamage(int dmg)
        {
            GetDamage(dmg);
        }



    }






}

