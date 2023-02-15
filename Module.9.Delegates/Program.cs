using System;

namespace Module._9.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception myEx = new Exception("Какая то ошибка..");

            myEx.HelpLink = "https://www.google.com/";

        }
    }
}
