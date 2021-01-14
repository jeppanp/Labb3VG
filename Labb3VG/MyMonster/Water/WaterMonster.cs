using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Labb3VG.MyMonster.Water
{
    class WaterMonster:Monster
    {
        private string specialAttack;
        private string normalAttack;
        

        public string SpecialAttack { get => specialAttack; set => specialAttack = value; }
        public string NormalAttack { get => "Water Cannon" ; set => normalAttack =value; }


        public override int Attack()
        {
            int attack = 0;

            int nr = rnd.Next(1, 11);
            if (nr != 1)
            {
                nr = rnd.Next(1, 3);
            }
            else
            {
                nr = 3;
            }

            switch (nr)
            {


                case 1:
                    attack = Strength + 1;
                    Console.WriteLine($"The {Name} hits you with a {NormalAttack} , dealing {attack} damage.");
                    break;

                case 2:
                    attack = Strength + 2;
                    Console.WriteLine($"The {Name} hits you with a {SpecialAttack}, dealing {attack} damage.");
                    break;

                case 3:
                    Console.WriteLine("Wow! That Water Spout just passed your head, didn´t get hurt.");
                    attack = 0;
                    break;
            }

            return attack;
        }
    }
}
