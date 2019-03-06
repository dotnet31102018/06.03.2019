using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Customer> dictionary = new Dictionary<int, Customer>();
            Customer c1 = new Customer(3, "moshe", 1980, "Jeruslame");
            Customer c2 = new Customer(100, "danny", 2900, "Mars");
            Customer c3 = new Customer(2, "peretz", 2010, "Tel Aviv");

            dictionary.Add(3, new Customer(3, "moshe", 1980, "Jeruslame"));

            dictionary.Add(c2.Id, c2);
            dictionary.Add(c3.Id, c3);

            Customer c = dictionary[100]; // hard-core get out element - can raise an excpetion
            
            if (dictionary.ContainsKey(103))
            {
                c = dictionary[103];
            }

            if (dictionary.TryGetValue(2, out Customer result))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("===========================");
            foreach (KeyValuePair<int, Customer> item in dictionary)
            {
                Console.WriteLine($"Key : {item.Key} ............... Value : {item.Value}");
            }

            Console.WriteLine("=============================");


            //Customer c1 = new Customer(3, "moshe", 1980, "Jeruslame");
            //Customer c2 = new Customer(100, "danny", 2900, "Mars");
            //Customer c3 = new Customer(2, "peretz", 2010, "Tel Aviv");

            int[] mosheSecret = { 97, 6, 8, 9 };
            int[] dannySecret = { -4, 0, 78, 19 };
            int[] peretzSecret = { 13, -5, 85, 97 };

            Dictionary<Customer, int[]> dictionarySecret = new Dictionary<Customer, int[]>();
            dictionarySecret.Add(c1, mosheSecret);
            dictionarySecret.Add(new Customer(3, "moshe", 1980, "Jeruslame"), mosheSecret); // not reasonable
            dictionarySecret.Add(c2, dannySecret);
            dictionarySecret.Add(c3, peretzSecret);

            //int[] resultArr = dictionarySecret[new Customer(1, "", 1, "")]; // crash for sure

            if (dictionarySecret.TryGetValue(c1, out int[] arrResult))
            {
                Console.WriteLine("c1");
                Console.WriteLine(arrResult[0]);
            }

            if (dictionarySecret.TryGetValue(c2, out int[] arrResult2))
            {
                Console.WriteLine("c2");
                Console.WriteLine(arrResult2[0]);
            }

            Console.WriteLine("===========================");
            foreach (KeyValuePair<Customer, int[]> item in dictionarySecret)
            {
                Console.WriteLine($"Key : {item.Key} ............... Value : {item.Value}");
            }

            Console.WriteLine("=============================");

            Console.WriteLine();
        }
        static void TryHere(Dictionary<Customer, int[]> dictionarySecret)
        {
            // cannot access here c1 ....

        }
    }
}
