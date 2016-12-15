using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class StringBuilderDemo
    {
        private StringBuilder demoStringBuilder;
        public StringBuilderDemo()
        {
            demoStringBuilder = new StringBuilder();
        }

        public void demo()
        {
            for (int i = 0; i < 10; i++)
            {
                string temp = i.ToString();
                demoStringBuilder.Append(temp);
            }
            Console.WriteLine(demoStringBuilder.ToString());
            Console.Read();
        }

    }
}
