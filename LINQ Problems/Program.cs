﻿using System;
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
            var listOfNamesNoDupes = names.Distinct();
            foreach (var name in listOfNamesNoDupes)
            {
                Console.WriteLine(name);
            }
           

            //THIRD PROBLEM
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            var listOfGrades = classGrades.Select(c => c.Split(',')).Select(c => c.
            Select(grade => double.Parse(grade)).OrderBy(grade => grade).
            Skip(1)).SelectMany(c => c).Average();

            Console.WriteLine(listOfGrades);
           

            //FOURTH PROBLEM
            var originalName= "Terrill".ToUpper();
            var frequency = string.Join("", originalName.OrderBy(f => f).
                Distinct().Select(f => $"{f}{originalName.Count(num => num == f)}"));

            Console.WriteLine(frequency);
            Console.ReadLine();
            //mikeTerrill.Select(m => m.)

        }
    }
}
