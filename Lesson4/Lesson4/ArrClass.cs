using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ArrClass : WordGen
    {
        public string[] ArrayString;
        public void GenArr(Random rand, int lenWords)
        {
            string[] arrWords = new string[lenWords];
            for (int i = 0; i < lenWords - 1; i++)
            {
                string word = GenString(rand);
                arrWords[i] = word;
            }
            arrWords[lenWords - 1] = "TEST";
            ArrayString = arrWords;
        }
        public bool IsInsert(string checkStr)
        {
            return ArrayString.Contains(checkStr);
        }
    }
}
