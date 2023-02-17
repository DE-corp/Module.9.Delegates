using System;

namespace Module._9.Delegates
{
    class Car { }
    class Lexus : Car { }

    class Program
    {
        delegate Car CarDelegate();

        static void Main(string[] args)
        {
            CarDelegate carDelegate = BuildLexus;
        }

        static Lexus BuildLexus()
        {
            return null;
        }
    }
}

