using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Grass
{
    class Scarab : GrassMonster
    {
        public Scarab()
        {
            List<string> scarabNames = new List<string>() { "Insek", "Krypet", "Bäfis", "Tvestjärt", "Ekoxe", "millipede" };
            int nr = rnd.Next(6);
            Name = scarabNames[nr];
            Lvl = rnd.Next(1, 11);
            HP = 50 + (Lvl * 3);
            Gold = 10 + (Lvl * 3);
            AchieveExperience = 50 + (Lvl * 2);
            Strength = Lvl;
            Race = "Scarab";
            Sound = "You hear the sound of his movement: tik tik tik tik";
            SpecialAttack = "Bite";
            SpecialAttack2 = "Poison Hit";

        }
    }
}
