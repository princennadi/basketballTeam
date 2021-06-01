using System;
using System.Collections.Generic;
using System.Text;

namespace team
{
    class powerForward:Players
    {
        public int strength;
        public int rpg;
        public List<Players> Player;
        public powerForward(int height, int weight, string position, int ppg, bool benched, int strength, int rpg) : base(height, weight, position, ppg, benched)
        {
            this.strength = strength;
            this.rpg = rpg;
        }

         
    }
}
