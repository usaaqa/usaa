using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericToRomanConverter
{
    class NumberLimitExceedException: Exception
    {
        // if the numeric value is less than zero and exceeds 3000 this exception is thrown
        public NumberLimitExceedException(string s) : base(s) { }
    }
}
