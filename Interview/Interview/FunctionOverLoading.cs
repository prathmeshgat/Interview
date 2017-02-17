using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class FunctionOverLoading
    {
        string name;

        public void setName(string _name)
        {
            name = _name;
        }

        public void setName(string f_name,string l_name)
        {
            name = f_name + " "+l_name;
        }

        public void displayName()
        {
            Console.WriteLine("NAME::"+name);
        }
    }
}
