using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3
{
    class GameData
    {

        public List<SpecificMonster> GetMonsters ()
        {
            List<SpecificMonster> monsterList = new List<SpecificMonster>();
            monsterList.Add(new SpecificMonster("Devil", 100, 60, 10));
            monsterList.Add(new SpecificMonster("Worm", 20, 30, 4));
            monsterList.Add(new SpecificMonster("Imp", 50, 20, 8));
            monsterList.Add(new SpecificMonster("Demonic Fire", 5, 10, 12));
            monsterList.Add(new SpecificMonster("spirit", 7, 15, 10));

            return monsterList;
               
        }

        public List<SpecificMonster> TestData ()
        {
            List<SpecificMonster> monsterList = new List<SpecificMonster>();
            monsterList.Add(new SpecificMonster("Test",200,1,1));
  
            return monsterList;
        }


    }
}
