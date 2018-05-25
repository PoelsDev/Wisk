using System;

namespace WiskLib
{
    public static class WiskLib
    {
        public static int Sq(int x)
        {
            return x * x;

        }

        public static int Constrain(int amt, int low, int high)
        {
            if (amt < low)
            {
                return low;
            }
            else if (amt > high)
            {
                return high;
            }
            else
            {
                return amt;
            }
        }
    }
}
