using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Dice : IDice
    {
        public int Rolls()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
    }
}
