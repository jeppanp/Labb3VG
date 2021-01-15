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
                Name = crocNames[RandomNames()];
                Lvl = random.Next(1, 11);
                HP = 50 + (Lvl * 3);
                DropGold = 10 + (Lvl * 3);
                Experience = 50 + (Lvl * 2);
                Strength = Lvl;
                Race = "Crocodile";
                Sound = "He yells \"Graaaaoouuurr\"";
                SpecialAttack = "Tail snapper";
                Element = "water";


        }
    }
}
