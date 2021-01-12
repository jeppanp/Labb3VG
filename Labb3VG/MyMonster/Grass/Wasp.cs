using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Grass
{
    class Wasp : GrassMonster
    {
        public Wasp()
        {
            List<string> waspNames = new List<string>() { "Stingie", "Sssssixten", "Zed", "Sticky", "Beeritt", "Buzz" };
            int nr = rnd.Next(6);
            Name = waspNames[nr];
            Lvl = rnd.Next(1, 11);
            HP = 50 + (Lvl * 3);
            Gold = 10 + (Lvl * 3);
            AchieveExperience = 50 + (Lvl * 2);
            Strength = Lvl;
            Race = "Wasp";
            Sound = "You can hear the sound when he fly, \"Bssssss\"";
            SpecialAttack = "Annoying Sound";
            SpecialAttack2 = "Posion stinger";

        }
    }
}
