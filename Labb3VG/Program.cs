using System;
using System.Collections.Generic;
using System.Threading;
using Labb3VG.MyMonster;
using Labb3VG.MyMonster.Fire;
using Labb3VG.MyMonster.Grass;
using Labb3VG.MyMonster.Water;

namespace Labb3VG
{
    class Program
    {

        static List<Monster> fireMonsters = new List<Monster>();
        static List<Monster> waterMonsters = new List<Monster>();
        static List<Monster> grassMonsters = new List<Monster>();
        static Player player = new Player();
        static Random rnd = new Random();
        static bool keepGoing = true;
        static int userAnswer;
        static bool userAnswerInBool;
        static Monster monsterToFight;

        static void Main(string[] args)
        {
            CreateMonsters();
           
            Start();

        }

        private static void Start()
        {
            //Console.WriteLine("**********************");
            //Console.WriteLine("*Welcome to the Game!*");
            //Console.WriteLine("**********************");
            //Console.Write("Enter your namne: ");
            //player.Name = Console.ReadLine();

            player.Name = "jesper";

            
            Meny();
        }

        private static void Meny()
        {
            while (keepGoing)
            {
                Console.WriteLine("1. Go adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Shop");
                Console.WriteLine("4. Exit Game");
                Console.Write(">");
                userAnswerInBool = Int32.TryParse(Console.ReadLine(), out userAnswer);

                switch (userAnswer)
                {

                    case 1:
                        GoAdventuring();
                        break;

                    case 2:
                        PlayerDetails();
                        break;

                    case 3:
                        break;

                    case 4:
                        keepGoing = false;
                        break;

                }

            }
        }

     
        private static void GoAdventuring()
        {
                                    //TODO: 10 procent, ingen träff alls
            switch (rnd.Next(1, 4))
            {
                case 1:                    
                    monsterToFight = DecideLVLMonster(grassMonsters);

                    while (monsterToFight.HP >= 1 && player.HpCurrently >= 1)
                    {
                        monsterToFight.HP -= player.Attack();
                        player.HpCurrently -= monsterToFight.Attack();
                        Console.WriteLine($"{player.Name}: {player.HpCurrently}");
                        Console.WriteLine($"{monsterToFight.Name}: {monsterToFight.HP}");   // Lägg in så att inte -hp skrivs ut. 0 är min
                        Console.WriteLine("[Press enter to continue]");
                        Console.ReadKey();
                    }                                                   // TODO: Börja koda fighten! och bryt sedan ut. 

                    break;
                case 2:
                    monsterToFight = DecideLVLMonster(fireMonsters);                    
                    break;
                case 3:
                    monsterToFight = DecideLVLMonster(waterMonsters);     
                    break;

            }
        }

        private static Monster DecideLVLMonster(List<Monster>monsters)
        {
            if (player.Lvl <= 3)
            {
                monsterToFight = monsters.Find(x => x.Lvl <= 3);
                Console.WriteLine(monsterToFight.Greetings());
                monsters.Remove(monsterToFight);             // Removing the monster from the list, so I don´t fight the same monster all the time. 


            }
            else if (player.Lvl >= 4 && player.Lvl < 7)
            {
                monsterToFight = monsters.Find(x => x.Lvl <= 7);
                Console.WriteLine(monsterToFight.Greetings());
                monsters.Remove(monsterToFight);

            }
            else if (player.Lvl >= 7)
            {
                monsterToFight = monsters.Find(x => x.Lvl <= 10);
                Console.WriteLine(monsterToFight.Greetings());
                monsters.Remove(monsterToFight);

            }
            return monsterToFight;
        }

        private static void PlayerDetails()
        {
            Console.WriteLine(player);
            Console.WriteLine("[Press enter to go back to menu]");
            Console.ReadKey();
            Console.Clear();
        }


        private static void CreateMonsters()   // Just because i want random kind of monsters, in different lvls i go through this loop. And the settings gives them random lvls and names. 
        {

            for (int i = 0; i < 20; i++)
            {
                Dragon dragon = new Dragon();
                fireMonsters.Add(dragon);

                Demon demon = new Demon();
                fireMonsters.Add(demon);

                Tortoise tortoise = new Tortoise();
                waterMonsters.Add(tortoise);

                SwampTroll troll = new SwampTroll();
                waterMonsters.Add(troll);

                Crocodile croc = new Crocodile();
                waterMonsters.Add(croc);

                RabiesBear bear = new RabiesBear();
                grassMonsters.Add(bear);

                Wasp wasp = new Wasp();
                grassMonsters.Add(wasp);

                Scarab scarab = new Scarab();
                grassMonsters.Add(scarab);
            }

            DragonLord dL = new DragonLord();  // but only one dragon lord.
            fireMonsters.Add(dL);



        }


    }
}
