using System;

namespace Module._9.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception myEx = new Exception();

            myEx.Data.Add("Дата", DateTime.Now);

        }
    }
}
