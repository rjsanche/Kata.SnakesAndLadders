using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public interface IRulesManager
    {
        void Move(int diceNumber);
        int GetCurrentPosition();

        bool PlayerWin();

        int CheckSpecialSquare(int number);
    }
}
