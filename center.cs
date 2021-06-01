using System;
using System.Collections.Generic;
using System.Text;

namespace team
{
    class center:Players
    {
        public int blkpg;
        public int dunkspg;
        public int defensiveAbility;
        public List<Players> Player;

        public center(int height, int weight, string position, int ppg, bool benched, int blkpg, int dunkspg, int defensiveAbility) : base(height, weight, position, ppg, benched)
        {
            this.blkpg = blkpg;
            this.dunkspg = dunkspg;
            this.defensiveAbility = defensiveAbility;
        }

        public void AddPlayer(Players center)
        {
            this.Player.Add(center);
        }

        public void RemovePlayer(Players center)
        {
            this.Player.Remove(center);
        }
    }
}
