using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labb3VG
{
    class Player
    {
        private string name;
        private int lvl;
        private int gold;
        private int hP;
        private int toughness;
        private int strength;
        private string weapon;
        public Random rnd = new Random();

        public Player(string name)
        {
            Name = name;
            lvl = 1;
            gold = 0;
            hP= 100;
            Strength = lvl;
            Toughness = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Gold { get => gold; set => gold = value; }
        public int HP { get => hP; set => hP = value; }
        public int Toughness { get => toughness; set => toughness = value; }
        public int Strength { get => strength; set => strength = value; }
        public string Weapon { get => weapon; set => weapon = value; }

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
    }
 

}
