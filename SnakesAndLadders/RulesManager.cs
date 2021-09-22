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
        private List<Tuple<int, int>> _specialSquares = new List<Tuple<int, int>>
        {
            new Tuple<int, int>( 2, 38),
            new Tuple<int, int>( 7, 14),
            new Tuple<int, int>( 8, 31),
            new Tuple<int, int>( 15, 26),
            new Tuple<int, int>(16, 6),
            new Tuple<int, int>(21, 42),
            new Tuple<int, int>(28, 84),
            new Tuple<int, int>(36, 44),
            new Tuple<int, int>(46, 25),
            new Tuple<int, int>(49, 11),
            new Tuple<int, int>(51, 67),
            new Tuple<int, int>(62, 19),
            new Tuple<int, int>(64, 60),
            new Tuple<int, int>(71, 91),
            new Tuple<int, int>(74, 53),
            new Tuple<int, int>(78, 98),
            new Tuple<int, int>(87, 94),
            new Tuple<int, int>(89, 68),
            new Tuple<int, int>(92, 88),
            new Tuple<int, int>(95, 75),
            new Tuple<int, int>(99, 80),
        };

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

        public virtual int CheckSpecialSquare(int tempPosition)
        {
            Tuple<int, int> result = _specialSquares.FirstOrDefault(x => x.Item1 == tempPosition);
            if(result is null)
            {
                return tempPosition;
            }
            return result.Item2;
        }

        #endregion
    }
}
