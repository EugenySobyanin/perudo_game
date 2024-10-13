using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Perudo_game
{
    public class Dice
    {
        Random random = new Random();
        public int value {  get; set; }
        public Dice() 
        {
            this.shake();
        }

        public void shake()
        {
            value = random.Next(1, 7);
        }

    }
}
