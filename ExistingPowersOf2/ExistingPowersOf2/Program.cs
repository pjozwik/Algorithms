using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingPowersOf2
{
    class Program
    {
        static void Main()
        {
            Console.Out.WriteLine("Enter Input: ");
            List<int> list = new List<int>();
            string line = string.Empty;
            List<int> result = new List<int>();

            while (true)
            {
                line = Console.In.ReadLine();
                if (String.IsNullOrEmpty(line)) break;
                list.Add(Int32.Parse(line));
            };

            bool ifOdd = false;

            for(int i =0; i < list.Count(); i++)
            {
                //checing if powers of 2 are present
                if (list[i] % 2 == 0 && ifOdd == false)
                {
                    ifOdd = true;
                    i = 0;
                }               

                //if yes, do the decomposition
                if (ifOdd)  
                {
                    int j = 1;
                    int c = 0;
                    while (j <= list[i])
                    {
                        c = j & list[i];
                        j <<= 1;
                    }
                    result.Add(c);
                }
            }

            Console.Out.Write("Output: ");

            if (ifOdd == false)
            {
                Console.Out.WriteLine("NA");
            }
            else {
                List<int> result2 = result.Distinct().ToList();
                result2.Sort();

                foreach (int item in result2)
                {
                    Console.Write("{0}, ", item);
                }
            };

        }
    }
}
