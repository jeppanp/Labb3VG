using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Labb3VG.MyMonster
{
    class Monster
    {
        private string name;
        private int hP;
        private int strength;
        private int dropGold;
        private int experience;
        private int lvl;
        private string race;
        private string sound;
        private string element;

        public Random rnd = new Random();



        public string Name { get => name; set => name = value; }
        public int HP { get => hP; set => hP = value; }
        public int Strength { get => strength; set => strength = value; }
        public int DropGold { get => dropGold; set => dropGold = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public string Race { get => race; set => race = value; }
        public string Sound { get => sound; set => sound = value; }
        public string Element { get => element; set => element = value; }

        virtual public int Attack(Player player)
        {

            int attack=0;
           
            switch (rnd.Next(1, 4))
            {
                case 1:
                    attack = Strength;
                break;

                case 2:
                    attack = Strength + 1;
                break;

                case 3:
                    attack = Strength + 2;
                break;
            }

            return attack;
        }



        virtual public string Greetings()
        {
            return $" Ooohh. You run into {Name}, a {Race} (lvl {Lvl}).{Sound}";
        }

        public override string ToString()
        {
            return "Name: "+ Name +  "\nHP: " + HP + "\nLvl: " + Lvl + "\nRace: " + Race; ;
        }
    }


}
