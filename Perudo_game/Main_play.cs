using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perudo_game
{
    internal class Main_play
    {
        private List<Player> _players;
        public Main_play(int players_count)
        {
            for (int i = 0; i < players_count; i++)
            {
                _players.Add(new Player());
            }
        }

            
    }
}
