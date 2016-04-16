using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaGame
{
    class MafiaPlayer : Player
    {

        public MafiaPlayer(string name, string pass, string color) : base(name, pass, color)
        {

        }

        //Mafia players are allowed to select a player to eliminate. Mafia players must reach a consensus
        //on who to eliminate.
        public override Player SpecialAbility(List<Player> players)
        {
            //random for now
            Random rand = new Random();
            int eliminate = rand.Next(players.Count);
            while (players[eliminate] is MafiaPlayer)
            {
                eliminate = rand.Next(players.Count);
            }
            return players[eliminate];
        }

        public override string ToString()
        {
            return string.Format("Player: {0, -15} Role: Mafia", Name);
        }
    }
}
