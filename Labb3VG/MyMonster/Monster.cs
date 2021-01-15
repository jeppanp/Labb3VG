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

        public Random random = new Random();




        public string Name { get => name; set => name = value; }
        public int HP { get => hP; set => hP = value; }
        public int Strength { get => strength; set => strength = value; }
        public int DropGold { get => dropGold; set => dropGold = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public string Race { get => race; set => race = value; }
        public string Sound { get => sound; set => sound = value; }
        public string Element { get => element; set => element = value; }


        protected int RandomNames()
        {
            int randomNames = random.Next(6);
            return randomNames;
        }
        virtual public int Attack(Player player)
        { return 0; }
        

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
