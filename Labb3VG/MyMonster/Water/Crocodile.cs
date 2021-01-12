using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Water
{
    class Crocodile:WaterMonster
    {
        public Crocodile()
        {
         
                List<string> crocNames = new List<string>() { "Crocks", "Allie", "Green Tail", "Lolong", "Steve Irwin", "Delta" };
                int nr = rnd.Next(6);
                Name = crocNames[nr];
                Lvl = rnd.Next(1, 11);
                HP = 50 + (Lvl * 3);
                Gold = 10 + (Lvl * 3);
                AchieveExperience = 50 + (Lvl * 2);
                Strength = Lvl;
                Race = "Crocodile";
                Sound = "He yells \"Graaaaoouuurr\"";
                SpecialAttack = "Tail snapper";

            
        }
    }
}
