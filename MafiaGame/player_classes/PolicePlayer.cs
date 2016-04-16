using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaGame
{
    class PolicePlayer : Player
    {
        public PolicePlayer(string name, string pass, string color) : base(name, pass, color)
        {

        }

        //Police special ability is to learn if a Player is Mafia or not
        public override Player SpecialAbility(List<Player> players)
        {
            //Select at random for now
            Random rand = new Random();
            int target = rand.Next(players.Count);
            //Console.WriteLine(string.Format("Police {0} targets {1}.", Name, players[target].Name));
            return players[target];
        }

        public override string ToString()
        {
            return string.Format("Player: {0, -15} Role: Police", Name);
        }
    }
}
