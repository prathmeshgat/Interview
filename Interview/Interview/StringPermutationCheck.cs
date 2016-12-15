using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class StringPermutationCheck
    {
        public string input1;
        public string input2;

        public StringPermutationCheck(string _inp1,string _inp2)
        {
            input1 = _inp1;
            input2 = _inp2;
        }

        public bool PermutationCheck()
        {
            if (input1.Length != input2.Length)
                return false;

            input1 = String.Concat(input1.OrderBy(c => c));
            input2 = String.Concat(input2.OrderBy(c => c));
            if (input1 != input2)
                return false;
            return true;
        }
    }
}
