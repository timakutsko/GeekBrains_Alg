using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class HashSetStr : WordGen
    {
        public string RandString { get; set; }
        
        public override bool Equals(object obj)
        {
            var str = obj as HashSetStr;
            if (str == null)
                return false;
            return RandString == str.RandString;
        }

        public override int GetHashCode()
        {
            int wordHashCode = RandString?.GetHashCode() ?? 0;
            return wordHashCode;
        }
    }
}
