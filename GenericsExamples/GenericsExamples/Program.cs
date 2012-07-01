using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";
            
            
            Dictionary<string, int> frequencies = GenericsExamples.Dictionary.WordCounter.CountWords(text);

            Console.WriteLine("Text = {0}", text);
            Console.WriteLine("Number of words = {0}", frequencies.Count);
            
            foreach (KeyValuePair<string, int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("word = {0}: frequency = {1}", word, frequency);
            }
            Console.ReadLine();
        }
    }
}
