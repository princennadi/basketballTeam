using System;
using System.Collections.Generic;
using System.Text;

namespace team
{
    class pointGuard:Players
    {
        public int passingAbility;
        public int apg;
        public int spg;
        
        public pointGuard(int height, int weight, string position, int ppg, bool benched, int passingAbility, int apg, int spg) : base(height, weight, position, ppg, benched)
        {
            this.passingAbility = passingAbility;
            this.apg = apg;
            this.spg = spg;
        }

        
    }
}
