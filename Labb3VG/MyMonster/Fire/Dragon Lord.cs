using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Fire
{
    class DragonLord : FireMonster
    {

        public DragonLord ()
        {
            Name = "Dragon Lord";
            Lvl = rnd.Next(1, 11);
            HP = 20 + (Lvl * 2);
            Gold = 10 + (Lvl * 3);
            AchieveExperience = 50 + (Lvl * 2);
            Strength = Lvl;

        }

    }
}
