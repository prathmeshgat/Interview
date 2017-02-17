using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();

            //instantiate deligate and subscribe it to topic/event
            pub.StockPriceTopic += new Publisher.TaskHandler(sub1.TaskOnEvent);
            pub.StockPriceTopic += new Publisher.TaskHandler(sub2.TaskOnEvent);

            pub.process("stock hiked!!!");

            Console.Read();
        }
    }
}
