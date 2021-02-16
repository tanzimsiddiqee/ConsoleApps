using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter loop endpoint: ");
            int j = int.Parse(Console.ReadLine());

            for(int i = 1; i <= j; i++)
            {
                Console.WriteLine("Value of i: {0} of {1}", i, j);
            }
        }
    }
}
