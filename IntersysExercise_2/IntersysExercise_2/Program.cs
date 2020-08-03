using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersysExercise_2
{
    class Program
    {
        static void Main()
        {
           
            Console.Write("Enter the word: ");
            string line = Console.In.ReadLine();      

            StringBuilder stringBuilder = new StringBuilder();
         
            //delating all signes except for letters
            foreach(char st in line)
            {
                if( char.IsWhiteSpace(st) || char.IsLetter(st))
                {
                    stringBuilder.Append(st);                   
                }
            }


            string str2 = stringBuilder.ToString();         
            char[] charTable = stringBuilder.ToString().ToCharArray();
            Array.Reverse(charTable);           

            //comparing 2 strings
            if (str2.Equals(new string(charTable)))
            {
                Console.WriteLine("YES");
            }else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
