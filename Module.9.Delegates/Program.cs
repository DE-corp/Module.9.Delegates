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
            Console.WriteLine(result);
        }

        static int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
