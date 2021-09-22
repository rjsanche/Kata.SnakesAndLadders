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
        private IDice _dice;
        #endregion

        #region Constructor

        public SnakesAndLaddersEngine(IDice dice)
        {
            _dice = dice;
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
            int tempPosition = _currentPosition + diceNumber;
            tempPosition = CheckSpecialSquare(tempPosition);
            if(tempPosition <= END_POSITION)
            {
                _currentPosition = tempPosition;
            }
        }

        private int CheckSpecialSquare(int tempPosition)
        {
            if (tempPosition == 12)
                return 2;
            return tempPosition;
        }

        public bool PlayerWin()
        {
            return GetCurrentPosition() == END_POSITION;
        }

        public int RollDie()
        {            
            int result =  _dice.Rolls();
            Move(result);
            return result;
        }

        #endregion
    }
}
