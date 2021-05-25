using System;

namespace Task2
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Какую операцию выполнить?\n 1.+\n 2.-\n 3.*\n 4./");
            int op = Convert.ToInt32(Console.ReadLine());
            Operation Add = (x, y) => x + y;
            Operation Sub = (x, y) => x - y;
            Operation Mult = (x, y) => x * y;
            Operation Div = (x, y) => x / y;
            int z;
            switch (op)
            {
                case 1:
                    z = Add(x, y);
                    Console.WriteLine(z);
                    break;
                case 2:
                    z = Sub(x, y);
                    Console.WriteLine(z);
                    break;
                case 3:
                    z = Mult(x, y);
                    Console.WriteLine(z);
                    break;
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Не правильно введены числа (y=0)");
                    }
                    else
                    {
                        z = Div(x, y);
                        Console.WriteLine(z);
                    }
                    break;
            }
        }
    }
}
