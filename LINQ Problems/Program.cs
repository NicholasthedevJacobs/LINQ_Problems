using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsThatContainTH = words.Where(w => w.Contains("th")); 
            foreach(var word in wordsThatContainTH)
            {
                Console.WriteLine(words);
            }
        }
    }
}
