using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaGame
{
    class Player
    {
        public string Name { set; get; }
        private string Password { set; get; }
        public string Color { set; get; }

        public Player(string name, string pass, string color)
        {
            Name = name;
            Password = pass;
            Color = color;
        }

        public Player Vote(List<Player> players)
        {
            //For now vote for random player
            Random r = new Random(System.DateTime.Now.Millisecond);
            int vote = r.Next(players.Count);

            //can't vote for yourself
            while (this == players[vote])
            {
                vote = r.Next(players.Count);
            }

            Console.WriteLine(string.Format("{0} votes for {1}", Name, players[vote].Name));
            return players[vote];
        }

        public virtual Player SpecialAbility(List<Player> players)
        {
            return null;
        }

        public override string ToString()
        {
            return string.Format("Player: {0, -15} Role: Townsperson", Name);
        }
    }
}
