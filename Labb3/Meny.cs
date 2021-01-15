using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3
{
    static class Meny
    {

         public static void GameHeader ()
        {
            String menyHeader = 
                "************************ \n" +
                "* Welcome to the game! * \n" +
                "************************";

            Console.WriteLine(menyHeader);

            Console.Write("Enter your name: ");
            String text = Console.ReadLine();

        }

        public static void GameMeny (Player p, SpecificMonster s)
        {

            GameHeader();

            GameData data = new GameData();

            List<SpecificMonster> monsterList = data.TestData();

            Random random = new Random();

            while (true)
            {

                if(p.Hp == 0)
                {
                    break;
                }

                if(p.Lvl == 10)
                {
                    Console.WriteLine("Congratulations, you won the game!");
                    break;
                    
                }


                Console.WriteLine("1. Go Adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Exit game");
                Console.Write("> ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        if (GameMechanics.AdventureChance())
                        {
                            s = monsterList[0]; // random.Next(1, 5)

                            GameMechanics.Battle(p, s);


                        }
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                }
                
                    
                

            }

        }

     
    }
}
