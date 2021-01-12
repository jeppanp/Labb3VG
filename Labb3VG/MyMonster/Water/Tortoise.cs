﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Water
{
    class Tortoise : WaterMonster
    {
        public Tortoise()
        {
            List<string> turtleNames = new List<string>() { "Rafael", "Ninja Turtle", "Squirtle", "Slowmo", "Blastoise", "Shellman" };
            int nr = rnd.Next(6);
            Name = turtleNames[nr];
            Lvl = rnd.Next(1, 11);
            HP = 50 + (Lvl * 3);
            Gold = 10 + (Lvl * 3);
            AchieveExperience = 50 + (Lvl * 2);
            Strength = Lvl;
            Race = "Tortoise";
            Sound = "You can hear the sound of \"Bluuuuub Bluuuuub\"";
            SpecialAttack = "Shell Squeezing";

        }
    }
}
