using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Labb3VG.MyMonster.Water
{
    class SwampTroll:WaterMonster
    {
        public SwampTroll()
        {
      
                List<string> trollNames = new List<string>() { "Goliat", "Ymer", "Rölli", "Melker", "Rumpnisse", "Smegael" };
                int nr = rnd.Next(6);
                Name = trollNames[nr];
                Lvl = rnd.Next(1, 11);
                HP = 50 + (Lvl * 3);
                Gold = 15 + (Lvl * 3);
                AchieveExperience = 50 + (Lvl * 2);
                Strength = Lvl;
                Race = "Troll";
                Sound = " He mumble for himself \"Hmmm, bugs\"";
                SpecialAttack = "Fist Punch";

        

        }
    }
}
