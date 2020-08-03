using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPrimes
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
         
            List<int> ints = new List<int>();                   
            List<string> strings = new List<string>();

            Console.WriteLine("Enter input: ");
            string testCases = Console.In.ReadLine();
            string line = string.Empty;
            
            //adding intervals
            for(int i = 0; i < Int32.Parse(testCases); i++)
            {
                line = Console.In.ReadLine();
                strings.Add(line);               
            }

            Console.WriteLine("Output: ");

            //finding primes
            for (int i = 0; i < Int32.Parse(testCases); i++)
            {
                string[] splitted = strings[i].Split(' ');
                findPrimes(Int32.Parse(splitted[0]), Int32.Parse(splitted[1]));
            }
            
        }

        public static void findPrimes(int m, int n)
        {
            List<int> ints = new List<int>();

            for (int i = m; i <= n; i++)
            {
                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2) ints.Add(i);
            }
            
            Console.WriteLine(ints.Count);
        }
    }
}
