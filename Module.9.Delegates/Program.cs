using System;

namespace Module._9.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException();
            }

            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }

            finally
            {
                Console.Read();
            }
        }
    }
}
