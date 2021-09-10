using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class SnakesAndLaddersEngine
    {
        #region Fields
        private const int INIT_POSITION = 1;
        private const int END_POSITION = 100;
        private int  _currentPosition;
        #endregion

        #region Constructor

        public SnakesAndLaddersEngine()
        {
            _currentPosition = INIT_POSITION;
        }
        #endregion

        #region Public Methods

        public int GetCurrentPosition()
        {
            return _currentPosition;
        }

        public void Move(int diceNumber)
        {
            _currentPosition += diceNumber;
            if(_currentPosition > 100)
            {
                _currentPosition = 97;
            }
        }

        public bool PlayerWin()
        {
            return GetCurrentPosition() == END_POSITION;
        }
        #endregion
    }
}
