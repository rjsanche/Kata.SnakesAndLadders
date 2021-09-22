using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class FakeRulesManager : RulesManager
    {
        public override int CheckSpecialSquare(int tempPosition)
        {
            if(tempPosition == 8)
            {
                return 8;
            }
            return tempPosition;   
        }
    }
}
