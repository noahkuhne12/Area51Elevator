using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Area51Elevator
{
    abstract class ITakeTime
    {
        public static void TakeTime()
        {
            Thread.Sleep(1000);
        }
    }
}
