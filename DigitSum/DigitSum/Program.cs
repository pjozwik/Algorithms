using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter input: ");
            int count = Int32.Parse(Console.In.ReadLine());
            int[] numbers = Array.ConvertAll(Console.In.ReadLine().Split(' '), int.Parse);
            int[] sums = new int[count];


            int digitSum = 0;

            //sum operation on all digits
            for(int i = 0; i < numbers.Length; i++)
            {
                while (numbers[i] != 0)
                {
                    digitSum += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                sums[i] = digitSum;                         //saving sum of each digits
                digitSum = 0;
            }

            int sumMax = sums.Max();
            int result = sums.ToList().IndexOf(sumMax);

            //checking if there's more than one position with the same digit sum and returnig the greatest one position 
            for (int i = 0; i < sums.Length; i++)
            {
                if (i > result && sums[i].Equals(sumMax)) result = i;
            }

            Console.Out.WriteLine("Output: {0}", result);
        }
    }
}
