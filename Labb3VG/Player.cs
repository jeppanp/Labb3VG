using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Labb3VG
{
    class Player
    {
        private string name;
        private int lvl;
        private double lvlBar;
        private int experience;
        private int gold;
        private double hpCurrently;
        private double hpBar;
        private int toughness;
        private int strength;
        private string weapon;
        private bool weaponInbool;
        private bool amulett;
        public Random rnd = new Random();

        public Player()
        {
            lvl = 1;
            gold = 0;
            HpBar = 100;
            hpCurrently= HpBar;
            lvlBar = 100;
            experience = 0;
            Strength = lvl;
            Toughness = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Gold { get => gold; set => gold = value; }
        public double HpCurrently { get => hpCurrently; set => hpCurrently = value; }
        public int Toughness { get => toughness; set => toughness = value; }
        public int Strength { get => strength; set => strength = value; }
        public string Weapon { get => weapon; set => weapon = value; }
        public bool WeaponInbool { get => weaponInbool; set => weaponInbool = value; }
        public bool Amulett { get => amulett; set => amulett = value; }
        public double LvlBar { get => lvlBar; set => lvlBar = value; }
        public int Experience { get => experience; set => experience = value; }
        public double HpBar { get => hpBar; set => hpBar = value; }

        public int Attack()                     
        {
            int attack = 0;

            int nr = rnd.Next(1, 22);                      // Låg risk att missa attacken, 5 procent. 
            if (nr != 1)
            {
                nr = rnd.Next(1, 4);
            }
            else
            {
                nr = 4;
            }

            switch (nr)
            {
                case 1:

                    attack = Strength;
                    Console.WriteLine($"You hit the monster, dealing {attack} damage");
                    break;

                case 2:
                    attack = Strength + 2;
                    Console.WriteLine($"You hit the monster, dealing {attack} damage");
                    break;

                case 3:
                    attack = Strength + 5;
                    Console.WriteLine($"You hit the monster with Great strengt. dealing {attack} damage");
                    break;

                case 4:
                    attack = 0;
                    Console.WriteLine("what happen´ bro? Get your shit together cause you just missed an open hit. Dealing 0 damage");
                    break;
            }

            return attack;
        }

        public string LvlUp()
        {
            if (Experience >= LvlBar)
            {
                Lvl++;
                Experience = Experience - (int)LvlBar;
                LvlBar = Math.Round(LvlBar*1.25);   
                HpBar =Math.Round(HpBar* 1.15);
                Strength++;
                
                hpCurrently = HpBar;

                return $"Congratulations! You leveled up! \nYou are now level {Lvl}, and you have {Experience} experience and {HpCurrently} hp and {gold} gold";
            }
            else
            {
                return "";
            }
            
        }

        public override string ToString()
        {
            return $"***********\n* Name: {Name}\n* Level: {Lvl}\n* HP: {HpCurrently}/{HpBar}\n* Exp: {Experience}/{LvlBar}\n* Gold: {Gold}\n* Strength: {Strength}\n* Toughness: {Toughness}\n***********";
        }
    }
 

}
