using System;
using System.Collections.Generic;
using System.Text;

namespace GitTraining
{
    public class Vowel
    {
        public bool StartsWithVowel(string name)
        {
            string vowels = "aeiouAEIOU";
            return vowels.Contains(name[0]);
        }
    }
}
