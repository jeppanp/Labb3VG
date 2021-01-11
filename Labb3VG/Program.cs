using System;
using System.Collections.Generic;
using Labb3VG.MyMonster;
using Labb3VG.MyMonster.Fire;
using Labb3VG.MyMonster.Grass;

namespace Labb3VG
{
    class Program
    {

        static List<Monster> monsters = new List<Monster>();
        static void Main(string[] args)
        {
            CreateMonsters();

            Console.WriteLine("");


        }

        private static void CreateMonsters()
        {
            for (int i = 0; i < 6; i++)
            {
                Dragon dragon = new Dragon();
                monsters.Add(dragon);

            }
        }

    }
    }
}
