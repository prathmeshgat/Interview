using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class SingeltonClass
    {
        private static SingeltonClass instance;

        public int prop1;
        public string name;

        protected SingeltonClass()
        {
            name = "prathmesh";
            prop1 = 25;
        }

        public static SingeltonClass getInstance()
        {
            if (instance == null)
                instance = new SingeltonClass();

            return instance;
        }
    }
}
