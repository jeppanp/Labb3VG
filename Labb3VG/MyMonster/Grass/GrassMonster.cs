using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Grass
{
    class GrassMonster:Monster
    {
        private string specialAttack;
        private string specialAttack2;
        private string normalAttack;

        public string SpecialAttack { get => specialAttack; set => specialAttack = value; }
        public string NormalAttack { get => "Lice Attack"; set => normalAttack = value; }
        public string SpecialAttack2 { get => specialAttack2; set => specialAttack2 = value; }

        public override int Attack()
        {
            int attack = 0;

            
 
            switch (rnd.Next(1, 4))
            {


                case 1:
                    attack = Strength + 1;
                    Console.WriteLine($"{Name} hits you with a {NormalAttack} , dealing {attack} damage.");
                    break;

                case 2:
                    attack = Strength + 2;
                    Console.WriteLine($"{Name} hits you with a {SpecialAttack}, dealing {attack} damage.");
                    break;

                case 3:
                    attack = Strength + 3;
                    Console.WriteLine($"{Name} hits you with a {SpecialAttack2}, dealing {attack} damage.");
                    break;
            }

            return attack;
        }
    }
}
