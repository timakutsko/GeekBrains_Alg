using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class WordGen
    {
        public string GenString(Random rand)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string word = "";
            for (int j = 1; j <= 10; j++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                word += letters[letter_num];
            }
            return word;
        }
    }
}
