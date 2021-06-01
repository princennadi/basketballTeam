using System;
using System.Collections.Generic;
using System.Text;

namespace team
{
    class shootingGuard : Players
    {
        public int shootingAbility;
        public int threesMade;
        public int threesAttempted;
        public List<Players> Player;
        public shootingGuard(int height, int weight, string position, int ppg, bool benched, int shootingAbility, int threesMade, int threesAttempted) : base(height, weight, position, ppg, benched)
        {
            this.shootingAbility = shootingAbility;
            this.threesMade = threesMade;
            this.threesAttempted = threesAttempted;

        }
            



    }
}
