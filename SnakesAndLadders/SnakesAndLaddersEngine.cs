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

        private IDice _dice;
        private IRulesManager _rulesManager;
        #endregion

        #region Constructor

        public SnakesAndLaddersEngine(IRulesManager rulesManager, IDice dice)
        {
            _dice = dice;
            _rulesManager = rulesManager;
        }
        #endregion

        #region Public Methods

        public int GetCurrentPosition()
        {
            return _rulesManager.GetCurrentPosition();
        }

        public void Move(int diceNumber)
        {
            _rulesManager.Move(diceNumber);
        }

        public bool PlayerWin()
        {
            return _rulesManager.PlayerWin();
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
