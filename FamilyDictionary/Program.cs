using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Cameron" }, { "age", "29" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Forrest" }, { "age", "64" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Sharon" }, { "age", "61" } });

            foreach (var person in myFamily)
            {
                Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]} years old.");
            }
        }

    }
}
