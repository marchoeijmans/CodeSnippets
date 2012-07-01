using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic hello world example
            string[] greetings = { "hello world", "hello LINQ", "hello Apress" };
            var items = from s in greetings
                        where s.EndsWith("LINQ")
                        select s;
            
            foreach (var item in items)
                Console.WriteLine(item);

            // converting strings to integers and ordering it
            string[] numbers = { "0042", "010", "9", "27" };
            int[] nums = numbers.Select(s => Int32.Parse(s)).OrderBy(s => s).ToArray();
            foreach (int num in nums)
                Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
