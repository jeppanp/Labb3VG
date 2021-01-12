using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Fire
{
    class DragonLord : FireMonster
    {

        public DragonLord ()
        {
            Name = "The Red Nightmare";
            Lvl = rnd.Next(7, 11);
            HP = 90 + (Lvl * 3);
            Gold = 80 + (Lvl * 3);
            AchieveExperience = 50 + (Lvl * 2);
            Strength = Lvl+5;
            Race = "Dragon Lord";
            Sound = " He Yells FCHHHHHHHH, YOU WILL BUUUUURN";

        }

    }
}
