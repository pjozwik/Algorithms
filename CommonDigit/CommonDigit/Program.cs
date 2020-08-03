using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDigit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Input: ");
            string count = Console.In.ReadLine();
            string line = Console.In.ReadLine();

            int[] digitOccurrance = new int[10];                            
            
            string lineWithoutSpaces = line.Replace(" ", "");               //delating spaces 

            int[] digits = new int[lineWithoutSpaces.Length];

            //adding digits to table
            for (int i = 0; i < lineWithoutSpaces.Length; i++)
            {
                digits[i] = Int32.Parse(lineWithoutSpaces[i].ToString());
            }

            
            //the index of the table is also a digit that appears and the value behind this index is the number of its occuracy
            for (int j = 0; j < digits.Length; j++) {
                digitOccurrance[digits[j] % 10] += 1;
            }

            int maxValue = digitOccurrance.Max();
            int result = digitOccurrance.ToList().IndexOf(maxValue);

            //checing if more than one digit has the same number of occuracy and returnig the bigger one
            for (int i = 0; i < digitOccurrance.Length; i++)
            {
                if (i > result && digitOccurrance[i].Equals(maxValue)) result = i;
                
            }
            
            //zrobic aby jeszcze uwzględniało ten pierwszy argument,np:3 
            Console.WriteLine("The most common digit: {0}", result);
            
        }

      
    }

}
