using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Publisher
    {
        //declare delegate
        public delegate void TaskHandler(string Message);

        //define event based on delegate
        public event TaskHandler StockPriceTopic;

        public void process(string message)
        {
            
            raiseEvent(message);
        }

        protected void raiseEvent(string message)
        {
            //invocation of delegate
            if (StockPriceTopic != null)
                StockPriceTopic(message);
        }

    }
}
