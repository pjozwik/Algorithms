using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter two 11 integer array elements: ");

            string line = Console.In.ReadLine();
            string line2 = Console.In.ReadLine();

            int[] array = Array.ConvertAll(line.Split(' '), int.Parse);
            int[] array2 = Array.ConvertAll(line2.Split(' '), int.Parse);

            Array.Sort(array);  
            Array.Sort(array2);

            //checing if there is a permutation
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(array2[i]))
                {
                    if (i == array.Length - 1) Console.Write("YES");
                    continue;                  
                }else
                {
                    Console.Write("NO");
                    break;
                }

            }
        }
    }
}
