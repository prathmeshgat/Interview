﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Subscriber1
    {
        public void TaskOnEvent(string message)
        {
            Console.WriteLine("In subscriber1::"+message);
        }
    }
}
