using System;
using System.Collections.Generic;
using System.Text;

namespace team
{
    class Players: IPlayer
    {
        public int height;
        public int weight;
        public string position;
        public int ppg;
        public bool benched;

        public Players(int height, int weight, string position, int ppg, bool benched)
        {
            this.height = height;
            this.weight = weight;
            this.position = position;
            this.ppg = ppg;
        }

        public bool CanJump { get; set; }

        public bool CanRun { get; set; }

        public double ShootingPercentage { get; set; }
        public bool canJump()
        {
            if (CanJump == true)
            {
                return true;
            }
            else  
            {
                return false;
            }
        }

        public bool canRun()
        {
            if (CanRun == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string shootingPercentage()
        {
            return ShootingPercentage.ToString() + "%";
        }
    }
}
