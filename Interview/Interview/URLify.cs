using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class URLify
    {
        public char[] input;
        public int realLength;

        public URLify(string _input, int _realLength)
        {
            input = new char[_input.Length];
            for (int i = 0; i < _input.Length; i++)
            {
                input[i] = _input[i];
            }
            
            realLength = _realLength;
        }

        public string modify()
        {
            if (input.Length>0)
            {
                int position1 = realLength - 1;
                int position2 = input.Length - 1;

                for (int i = position1; i >= 0; i--)
                {
                    if (input[i] == ' ' && position2>=0)
                    {
                        input[position2] = '0';
                        input[position2-1] = '2';
                        input[position2-2] = '%';
                        position2 = position2 - 3;
                    }
                    else
                    {
                        input[position2] = input[i];
                        position2 = position2 - 1;
                    }
                }
                
                return String.Concat(input);
            }
            return null;
        }
    }
}
