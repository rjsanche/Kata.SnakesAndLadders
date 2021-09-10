﻿using System;
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
            int tempPosition = _currentPosition + diceNumber;
            if(tempPosition <= END_POSITION)
            {
                _currentPosition = tempPosition;
            }
        }

        public bool PlayerWin()
        {
            return GetCurrentPosition() == END_POSITION;
        }

        public int RollDie()
        {            
            Random random = new Random();
            return random.Next(1, 6);
        }

        public void Roll(int fixDie)
        {
            Move(fixDie);
        }
        #endregion
    }
}
