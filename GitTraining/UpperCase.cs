using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTraining
{
    public class UpperCase
    {
        public List<string> CapitalizingNames(List<string> listOfNames)
        {
            for (int i = 0; i < listOfNames.Count(); i++)
            {
                char[] nameArray = listOfNames[i].ToArray();
                int j = 0;
                while (j < nameArray.Length)
                {
                    if (j == 0) nameArray[j] = char.ToUpper(nameArray[j]);
                    else nameArray[j] = char.ToLower(nameArray[j]);
                    j++;
                }
                listOfNames[i] = new string(nameArray);
            }
            return listOfNames;
        }
    }
}
