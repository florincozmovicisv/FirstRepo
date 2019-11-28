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

            //a doua problema Vowel
            Vowel vowel = new Vowel();
            Console.WriteLine("The following names are starting with Vowels: ");

            foreach (var name in namesList)
                if (vowel.StartsWithVowel(name))
                    Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
