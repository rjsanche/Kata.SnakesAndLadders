using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class RulesManager : IRulesManager
    {
        #region Fields

        private const int INIT_POSITION = 1;
        private const int END_POSITION = 100;
        private int _currentPosition;

        #endregion

        #region Constructor
        public RulesManager()
        {
            _currentPosition = INIT_POSITION;
        }
        #endregion

        #region IRulesManager implementation

        public void Move(int diceNumber)
        {
            int tempPosition = _currentPosition + diceNumber;
            tempPosition = CheckSpecialSquare(tempPosition);
            if (tempPosition <= END_POSITION)
            {
                _currentPosition = tempPosition;
            }
        }

        public int GetCurrentPosition()
        {
            return _currentPosition;
        }

        public bool PlayerWin()
        {
            return GetCurrentPosition() == END_POSITION;
        }

        public int CheckSpecialSquare(int tempPosition)
        {
            if (tempPosition == 12)
                return 2;
            return tempPosition;
        }

        #endregion
    }
}
