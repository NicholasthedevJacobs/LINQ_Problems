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
            //FIRST PROBLEM
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsThatContainTH = words.Where(w => w.Contains("th")); 
            foreach(var word in wordsThatContainTH)
            {
                Console.WriteLine(word);
            }
           


            //SECOND PROBLEM
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var listOfNamesNoDupes = names.Where(n => n.Contains(n));
            foreach(var name in listOfNamesNoDupes.Distinct())
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
