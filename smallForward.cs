using System;
using System.Collections.Generic;
using System.Text;

namespace team
{
    class smallForward : Players
    {
        public int athleticAbility;
        public int spg;
        public List<Players> Player;

        public smallForward(int height, int weight, string position, int ppg, bool benched, int athleticAbility, int spg) : base(height, weight, position, ppg, benched)
        {
            this.athleticAbility = athleticAbility;
            this.spg = spg;
        }

         
    }
}
