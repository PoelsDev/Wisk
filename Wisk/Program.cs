using System;

namespace Wisk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var x = Wisk.Constrain();
            Console.WriteLine(WiskLib.WiskLib.Sq(2));
            Console.WriteLine(WiskLib.WiskLib.Sq(2));
        }
    }
}
