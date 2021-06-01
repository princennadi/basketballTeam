using System;
using System.Collections.Generic;
using System.Text;

namespace team
{
    class Team1
    {

        private List<Players> Player;
        public void AddPlayer(Players player)
        {
            this.Player.Add(player);
        }

        public void RemovePlayer(Players player)
        {
            this.Player.Remove(player);
        }

        public List<Players> GetPlayers { get { return Player; } }

        public List<Players> GetStarting()
        {
            return Player.FindAll(x=>x.benched==false);
        }
        

        


    }
}
