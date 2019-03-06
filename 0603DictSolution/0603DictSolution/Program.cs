using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603DictSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = string.Empty;

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");
            dictionary.Add(6, "Six");
            dictionary.Add(7, "Seven");
            dictionary.Add(8, "Eight");
            dictionary.Add(9, "Nine");
            dictionary.Add(-1, "Exit");

            do
            {
                Console.Write("Enter Number :");
                int number = Convert.ToInt32(Console.ReadLine());

                if (dictionary.TryGetValue(number, out result))
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Not Found!");
                }
            }
            while (result != "Exit");

        }
    }
}
