using System;
using System.Collections.Generic;

namespace GitTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //prima problema UpperCase
            UpperCase upperCase = new UpperCase();
            List<string> namesList = new List<string>() { "anA", "elena", "MARIA", "cRisTiAn" };
            namesList = upperCase.CapitalizingNames(namesList);
            foreach (var name in namesList)
                Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
