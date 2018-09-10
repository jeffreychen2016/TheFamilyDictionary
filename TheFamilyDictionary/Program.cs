using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>{
                {"name","Kevin"},
                {"age","8"}
            });

            myFamily.Add("cousin", new Dictionary<string, string>{
                {"name","Paul"},
                {"age","14"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                // do something with entry.Value or entry.Key
                Console.WriteLine("My name is " + member.Value["name"] + " and is " + member.Value["age"] + " years old!");
            }
        }
    }
}
