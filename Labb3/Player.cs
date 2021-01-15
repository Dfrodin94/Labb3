using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3
{
    class Player
    {
        private string name;
        private int lvl;
        private int exp;
        private int hp;
        private int dmg;

        public Player ()
        {

        }

        public Player(string name, int lvl, int exp, int hp, int dmg)
        {
            this.name = name;
            this.lvl = lvl;
            this.exp = exp;
            this.hp = hp;
            this.dmg = dmg;
        }

        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Exp 
        {
            get { return exp; }
            set { exp = value; }
        }
        public int Hp { get => hp; set => hp = value; }
        public int Dmg { get => dmg; set => dmg = value; }
    }
}
