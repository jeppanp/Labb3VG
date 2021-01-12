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
        private int gold;
        private int achieveExperience;
        private int lvl;
        private string race;
        private string sound;
        public Random rnd = new Random();



        public string Name { get => name; set => name = value; }
        public int HP { get => hP; set => hP = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Gold { get => gold; set => gold = value; }
        public int AchieveExperience { get => achieveExperience; set => achieveExperience = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public string Race { get => race; set => race = value; }
        public string Sound { get => sound; set => sound = value; }

        virtual public int Attack()
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

        virtual public bool Defense()
        {
            bool defense = false;

            int lucky = rnd.Next(1, 101);
            if (lucky<=5)
            {
                defense = true;
            }
            return defense;
            
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
