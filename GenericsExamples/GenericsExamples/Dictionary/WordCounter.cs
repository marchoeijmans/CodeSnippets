using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericsExamples.Dictionary
{
    public static class WordCounter
    {
        // counts the frequency of the words contained in the text
        public static Dictionary<string,int> CountWords(string text)
        {
            Dictionary<string,int> frequencies;
            frequencies = new Dictionary<string,int>();
            string[] words = Regex.Split(text, @"\W+");
            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }
            return frequencies;
        }
    }
}
