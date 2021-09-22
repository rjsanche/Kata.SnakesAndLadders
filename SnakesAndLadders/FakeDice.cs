using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class FakeDice : IDice
    {
        private int _defaultValue = 0;
        public FakeDice(int defaultValue)
        {
            _defaultValue = defaultValue;
        }

        public int Rolls()
        {
            return _defaultValue;
        }
    }
}
