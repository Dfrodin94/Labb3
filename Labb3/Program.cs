using System;
using System.Transactions;

namespace Labb3
{
    class Program
    {

        static void Main(string[] args)
        {

            Player player = new Player("David", 1, 9, 200, 10);
            SpecificMonster monster = new SpecificMonster("Evil", 0, 40, 10);

            Meny.GameMeny(player, monster);

           
        }

 
    }
}
