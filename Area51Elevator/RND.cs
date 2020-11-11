using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    public static class RND
    {
        public static Random rnd = new Random();

        public static int Range(int a, int b)
        {
            return rnd.Next(a, b);
        }

    }
}
