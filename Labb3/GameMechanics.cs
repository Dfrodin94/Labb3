using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3
{
    static class GameMechanics
    {

        public static bool AdventureChance()
        {

            Random random = new Random();

            int randomNbr = random.Next(1, 10);

            if (randomNbr == 1)
            {
                Console.WriteLine("You see nothing but swaying grass all around you...");
                Console.WriteLine("[Press enter to continue]");
                Console.ReadLine();
                return false;
                
            }
            else
            {
                return true;
            }

        }

        public static void Battle (Player p, SpecificMonster s)
        {

            bool keepGoing = true;

            while (keepGoing)
            
            {

            
            Console.WriteLine($"Uh oh! A {s.Name} appeared!");
            Console.WriteLine($"You hit the monster, dealing {p.Dmg} damage");
            Console.WriteLine("Uuoooah *slurp*");
            Console.WriteLine($"The monster hits you, dealing {s.Dmg} damage");
            LooseHealthPlayer(p, s);
            LooseHealthMonster(p, s);
                if (BattleWinner(p, s) && p.Hp != 0)
                {
                    GetExp(p, s);
                  
                    break;

                }
                else if (p.Hp == 0)
                {
                    Console.WriteLine("You were killed by the monster :(");
                        break;
                }

                Console.WriteLine($"{p.Name}: {p.Hp}");
            Console.WriteLine($"{s.Name}: {s.Hp}");
            Console.WriteLine("[press enter to continue]");
            Console.ReadLine();
            }

        }

        public static bool BattleWinner (Player p, SpecificMonster s)
        {
           
            if (s.Hp <= 0)
            {
                Console.WriteLine($"You killed the monster, gaining {s.Exp} experience! \n"); 
                
                return true;
            }

            return false;

        }

        public static void GetExp(Player p, SpecificMonster s)
        {
            p.Exp += s.Exp;
            LvlUp(p);
            Console.WriteLine($"You are level {p.Lvl}, and you have {p.Exp} exp and {p.Hp} hp");
        }

        public static void LooseHealthPlayer (Player p, SpecificMonster s)
        {
            p.Hp = p.Hp - s.Dmg;
            

        }

        public static void LooseHealthMonster(Player p, SpecificMonster s)
        {
            s.Hp = s.Hp - p.Dmg;

        }

        public static void LvlUp (Player p)
        {
            if(p.Exp >= 200)
            {
                p.Exp = 0;
                p.Lvl += 1;
            }
        }


    }
}
