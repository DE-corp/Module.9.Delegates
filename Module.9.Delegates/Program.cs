using System;

namespace Module._9.Delegates
{
    class Program
    {
        public delegate int CalculateDelegate(int a, int b);

        static void Main(string[] args)
        {
            CalculateDelegate calcDelegate = Calculate;
            int result = calcDelegate.Invoke(2, 5);
            int result1 = calcDelegate(2, 5);
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }

        static int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
