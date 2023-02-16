using System;

namespace Module._9.Delegates
{
    class Program
    {
        public delegate void CalculateDelegate(int a, int b);

        static void Main(string[] args)
        {
            CalculateDelegate calcDelegate = Subtraction;
            calcDelegate += Addition;

            calcDelegate -= Addition;
            calcDelegate(7, 3);
        }

        static void Subtraction(int a, int b)
        {
            Console.WriteLine($"Вычитание: {a - b}");
        }

        static void Addition(int a, int b)
        {
            Console.WriteLine($"Сложение: {a + b}");
        }
    }
}
