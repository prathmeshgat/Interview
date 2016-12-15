using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class DynamicArray
    {
        private List<int> mylist;

        public DynamicArray()
        {
            mylist = new List<int>();
        }

        public void demo()
        {
            for (int i = 0; i < 10; i++)
            {
                mylist.Add(i);
            }
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
           
    }
}
