using System;
using System.Collections.Generic;

namespace Inheritance
{
    class A
    {
        public int Result()
        {
            return 11 / 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new A();
            Console.WriteLine("Hello World! {0}", ob.Result());
        }
    }
}
