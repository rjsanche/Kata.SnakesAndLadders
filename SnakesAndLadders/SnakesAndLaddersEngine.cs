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
        #endregion
    }
}
