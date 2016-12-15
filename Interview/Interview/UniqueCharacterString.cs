using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class UniqueCharacterString
    {
        private string input;
        public UniqueCharacterString(string input)
        {
            this.input = input;
        }

        public bool isUnique()
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] == c)
                        return false;
                }
            }
            return true;
        }

        public bool isunique2()
        {
            bool[] char_set = new bool[128];
            if (input.Length > 128)
                return false;
            for (int i = 0; i < input.Length; i++)
            {
                int val = input[i];
                if (char_set[val])
                    return false;
                char_set[val] = true;
            }
            return true;
        }
    }
}
