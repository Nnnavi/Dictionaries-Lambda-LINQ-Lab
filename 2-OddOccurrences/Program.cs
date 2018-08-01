using System;
using System.Collections.Generic;

namespace _2_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that extracts from a given sequence of words all elements that presents in it odd number of times (case INsensitive)
            string [] wordsInput = Console.ReadLine().ToLower().Split();
            var countElem = new Dictionary<string,int>();

            foreach(var element in wordsInput)
            {
                if (!countElem.ContainsKey(element))
                {
                    countElem.Add(element, 1);
                }
                else
                {
                    countElem[element]++;
                }
            }
            List <string> result = new List<string>();

            
            foreach (var element in countElem)
            {
                if (element.Value % 2 != 0)
                {
                    result.Add(element.Key);
                                  
                }
            }
            Console.WriteLine(string.Join(", ",result));






        }
    }
}
