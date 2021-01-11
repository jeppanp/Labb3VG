using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Labb3VG.MyMonster.Fire
{
    class Dragon : FireMonster
    {
        private string race; 
        
        public Dragon()
        {
            List<string> dragonNames = new List<string>() { "Onyxia", "Katla", "The Red Nightmare", "Saphira", "Smaug", "Mushu"};
            int nr = rnd.Next(6);
            Name = dragonNames[nr];
            Lvl = rnd.Next(1, 11);
            HP = 50 + (Lvl * 3);
            Gold = 10 + (Lvl * 3);
            AchieveExperience = 50 + (Lvl * 2);
            Strength = Lvl;
            Race = "Dragon";

        }

        public string Race { get => race; set => race = value; }

        public override string ToString()
        {
            return base.ToString() + "\nRace: " + Race;
        }
    }
}
