using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Labb3VG.MyMonster.Fire
{
    class Dragon : FireMonster
    {
     
        
        public Dragon()
        {
            List<string> dragonNames = new List<string>() { "Onyxia", "Katla", "Twiligt Eye", "Saphira", "Smaug", "Mushu"};
            int nr = rnd.Next(6);
            Name = dragonNames[nr];
            Lvl = rnd.Next(1, 11);
            HP = 50 + (Lvl * 3);
            DropGold = 10 + (Lvl * 3);
            Experience = 50 + (Lvl * 2);
            Strength = Lvl;
            Race = "Dragon";
            Sound = "You hear the sound of FCHHHHHHHH";
            Element = "fire";

        }

      


    }
}
