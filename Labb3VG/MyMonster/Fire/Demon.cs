using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Fire
{
    class Demon : FireMonster
    {
        public Demon()
        {
            string[] demonNames = new string[] { "Hades", "Satan", "Lucifer", "Beelzebub", "Mammon", "Leviathan" };
            int nr = rnd.Next(6);
            Name = demonNames[nr];
            Lvl = rnd.Next(1, 11);
            HP = 50 + (Lvl * 3);
            Gold = 10 + (Lvl * 3);
            AchieveExperience = 50 + (Lvl * 2);
            Strength = Lvl;
            Race = "Demon";
            Sound = "He Yells WELCOME TO HELL!!";

        }


    }
}
