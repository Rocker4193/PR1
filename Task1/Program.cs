using System;

namespace Task1
{
    class Program
    {
        delegate int Operation(int x, int y, int z);
        static void Main(string[] args)
        {
            Operation aver = delegate (int x, int y, int z)
            {
                return (x + y + z) / 3;
            };
            int d = aver(11, 5, 2);
            Console.WriteLine(d);
        }
    }
}
