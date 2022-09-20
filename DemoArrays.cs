using System;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            var number2 = new int[4] { 1, 3, 5, 7 };

            numbers[0] = 1;
            numbers[1] = 3;
            numbers[2] = 5;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            Console.WriteLine(number2[0]);
            Console.WriteLine(number2[1]);
            Console.WriteLine(number2[2]);
        }
    }
}
