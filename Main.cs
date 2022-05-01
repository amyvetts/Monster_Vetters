using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Vetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "0")
            {
                System.Console.Clear();
                System.Console.WriteLine("========================");
                System.Console.WriteLine("1 - PC");
                System.Console.WriteLine("2 - Skeleton");
                System.Console.WriteLine("3 - Ghost");
                System.Console.WriteLine("4 - Couatl");
                System.Console.WriteLine("5 - Deva");
                System.Console.WriteLine("6 - Crab");
                System.Console.WriteLine("7 - Owl");
                System.Console.WriteLine();
                System.Console.WriteLine("0 - EXIT");
                System.Console.WriteLine("========================");
                System.Console.WriteLine();
                System.Console.Write("Select a menu entry to create: ");
                input = System.Console.ReadLine();
                Creature creature = null;
                if (input == "1")
                {
                    creature = new PlayerCharacter();
                }
                else if (input == "2")
                {
                    creature = new Skeleton();
                }
                else if (input == "3")
                {
                    creature = new Ghost();
                }
                else if (input == "4")
                {
                    creature = new Couatl();
                }
                else if (input == "5")
                {
                    creature = new Deva();
                }
                else if (input == "6")
                {
                    creature = new Crab();
                }
                else if (input == "7")
                {
                    creature = new Owl();
                }

                if (input != "0")
                {
                    System.Console.Clear();
                    System.Console.WriteLine(creature);
                    System.Console.WriteLine("========================");
                    System.Console.WriteLine("\nPress ENTER to continue.");
                    System.Console.ReadLine();
                }
            }

            Crab denny = new Crab();
            Owl jack = new Owl();
            SparringMatch(denny, jack);

        }

        private static void SparringMatch(Creature attacker, Creature defender)
        {
            System.Console.Clear();
            System.Console.WriteLine("========================");
            System.Console.WriteLine("Pretend Fight between " + attacker.GetType().Name + " and " +
                                      defender.GetType().Name + "\n\n\n");
            while ((attacker.HP > 0) && (defender.HP > 0))
            {
                System.Console.WriteLine(attacker.Attack(defender));
                System.Console.WriteLine(defender.Attack(attacker));
            }

            if (attacker.HP <= 0)
            {
                System.Console.WriteLine("Attacker " + attacker.GetType().Name + " died!");
            }
            if (defender.HP <= 0)
            {
                System.Console.WriteLine("Defender " + defender.GetType().Name + " died!");
            }

        }
    }
}

