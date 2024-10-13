using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perudo_game
{
    public class the_draw
    {
        public int current_minimal;
        private Dice dice;
        public the_draw(List<Player> playes)
        {
            for (int i = 0; i < playes.Count; i++)
            {
                Player p = playes[i];
                dice.shake();
                int current_throw = dice.value;



            }
        }
    }
}
