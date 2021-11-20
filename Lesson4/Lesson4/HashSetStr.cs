using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class HashSetStr : WordGen
    {
        public HashSet<string> UserHS;

        public void GenHS(Random rand, int lenWords)
        {
            var hsWords = new HashSet<string>();
            for (int i = 0; i < lenWords - 1; i++)
            {
                string word = GenString(rand);
                hsWords.Add(word);
            }
            hsWords.Add("TEST");
            UserHS = hsWords;
        }
        
        public override bool Equals(object obj)
        {
            var str = obj as string;
            if (str == null)
                return false;
            return UserHS.Contains(str);
        }

    }
}
