using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG.MyMonster.Fire
{
    class FireMonster : Monster
    {
        public override int Attack()
        {
            int attack = 0;

            int nr = rnd.Next(1, 11);
            if (nr != 1) 
            {
                nr = rnd.Next(1, 4);
            }
            else
            { nr = 4;
            }

            switch (nr)
            {
                case 1:
                    
                    attack = Strength;
                    Console.WriteLine($"The {Name} hits you with a fireflame, dealing {attack} damage.");
                    break;

                case 2:
                    attack = Strength + 2;
                    Console.WriteLine($"The {Name} hits you with a fireflame, dealing {attack} damage.");
                    break;

                case 3:
                    attack = Strength + 5;
                    Console.WriteLine($"aaaoouuch. The {Name} hits you with a wall of fire, dealing {attack} damage.");
                    break;

                case 4:
                    Console.WriteLine("Nice j! You managed to avoid the burning fire!");
                    attack = 0;
                    break;
            }

            return attack;
        }
    }
}
