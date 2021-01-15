using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3
{
    class SpecificMonster : Monster
    {
        private int exp;
        private int hp;
        private int dmg;

        public SpecificMonster(string name, int exp, int hp, int dmg)
        {
            this.Name = name;
            this.Exp = exp;
            this.hp = hp;
            this.dmg = dmg;
        }

        public int Dmg { get => dmg; set => dmg = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Exp { get => exp; set => exp = value; }
    }
}
