using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConvertToRomanConverter
{
    public class ConverttheNumber
    {
        public string ParseTheNumber(string r)
        {
            int i;
            String s = null;
            try
            {
                if (Int32.Parse(r).GetType() != typeof(Int32))
                {
                    throw new FormatException(); // For a alphanumeric invalid string Number Format Exception will be thrown 
                }
                else
                {
                    i = Int32.Parse(r);
                    s = TesttheNumber(i); // Number is sent for testing after being parsed
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return s;
        }
        public string TesttheNumber(int number)
        {
            String k=null;

            try
            {
                if (number == 0)
                {
                    throw new NumericToRomanConverter.EnterZeroException("value must not be zero");// if the number is zero Exception is thrown
                }
                else if ((number < 0) || (number > 3000))
                    throw new NumericToRomanConverter.NumberLimitExceedException("value must not exceed 3000 or be below zero");// if the number is less than zero and greater than 3000 exception is thorwon
                else
                    k = ConvertToRoman(number);// The numeric value is sent to retrieve roman value
            }
            catch (NumericToRomanConverter.EnterZeroException xe)
            {
                Console.WriteLine(xe.Message);
            }
            catch (NumericToRomanConverter.NumberLimitExceedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return k;   
        }

        public string ConvertToRoman(int value)
        {
            /*For each value associated which is 10 times of 1,4,5,9,10  upto 3000 is used produce the symbols 
              for roman values  through recurring calls. suppose for the number 1502 first 1000 value is stripped off and we 
              get the symbol for 1000 that is 'M 'then we call the same recurring function with subtracted value 502 and we reduce 500 from it and
              get 'D' and now get only 2. using the if condition and recurring calls we get reduce it twice and get 'I' twice. so the roman for 1502 is 'MDII'
               */
            if (value < 1) return string.Empty;
                if (value >= 1000) return "M" + ConvertToRoman(value - 1000);
                if (value >= 900) return "CM" + ConvertToRoman(value - 900);
                if (value >= 500) return "D" + ConvertToRoman(value - 500);
                if (value >= 400) return "CD" + ConvertToRoman(value - 400);
                if (value >= 100) return "C" + ConvertToRoman(value - 100);
                if (value >= 90) return "XC" + ConvertToRoman(value - 90);
                if (value >= 50) return "L" + ConvertToRoman(value - 50);
                if (value >= 40) return "XL" + ConvertToRoman(value - 40);
                if (value >= 10) return "X" + ConvertToRoman(value - 10);
                if (value >= 9) return "IX" + ConvertToRoman(value - 9);
                if (value >= 5) return "V" + ConvertToRoman(value - 5);
                if (value >= 4) return "IV" + ConvertToRoman(value - 4);
                if (value >= 1) return "I" + ConvertToRoman(value - 1);
            return null;
            }
        }
    }

