using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericToRomanConverter
{
    class EnterZeroException:Exception
    {
       
        // if the numeric value is zero this exception is thrown
        

        public EnterZeroException(string p):base(p)
        {
            // TODO: Complete member initialization
            
        }

    }
}
