using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersysExercise_1
{
    class Program
    {
        static void Main()
        {
            int count;
            
            Console.Write("Table size: ");
            string line = Console.In.ReadLine();
            count = Int32.Parse(line);

            Console.Write("Table elements: ");
            string line2 = Console.In.ReadLine();
            string[] splitted = line2.Split(' ');

            int[] array = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(splitted[i]);
            }
           
            Array.Reverse(array);

            Console.Write("Output: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

        }
    }
}
