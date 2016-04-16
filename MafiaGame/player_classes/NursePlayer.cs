using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaGame
{
    class NursePlayer : Player
    {
        public NursePlayer(string name, string pass, string color) : base(name, pass, color)
        {

        }

        //Nurse ability is to save a player
        public override Player SpecialAbility(List<Player> players)
        {
            //random for now
            Random rand = new Random();
            int save = rand.Next(players.Count);
            return players[save];
        }

        public override string ToString()
        {
            return string.Format("Player: {0, -15} Role: Nurse", Name);
        }
    }
}
