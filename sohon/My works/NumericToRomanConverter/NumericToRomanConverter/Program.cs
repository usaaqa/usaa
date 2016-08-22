using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
         //CONSOLE APPLICATION DEVELOPMENT FOR THE CONVERSION OF NUMERIC NUMBERS TO ROMAN
         //DEVELOPER NAME: Sohom Bhattacharya
         //DATE: 17/08/2016
namespace NumericToRomanConverter
{
    class Program
    {   
        //Entry Point of The Program
        static void Main(string[] args)
        {
            
                Console.WriteLine("enter the valid number");
                string k = Console.ReadLine();
                
                
                NumericConvertToRomanConverter.ConverttheNumber ob = new NumericConvertToRomanConverter.ConverttheNumber();
                Console.WriteLine(k + "-" + ob.ParseTheNumber(k)); //The input string is sent for Parsing into integer value and Testing 
                 Console.ReadKey();
        }

    }
}
