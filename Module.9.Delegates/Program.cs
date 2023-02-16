﻿using System;

namespace Module._9.Delegates
{
    class Program
    {
        delegate int RandomNumberDelegate();

        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () =>
            {
                return new Random().Next(0, 100);
            };

            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}

