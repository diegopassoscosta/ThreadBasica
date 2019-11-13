using System;
using System.Threading;

namespace Thread00
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaThread0 = new Thread(acaoAlo);
            minhaThread0.Start();

            var minhaThread1 = new Thread(acaoTchau);
            minhaThread1.Start();
        }

        public static void acaoAlo()
        {
            do
            {
                Console.WriteLine("alo");
                Thread.Sleep(1000);

            } while (true);

        }

        public static void acaoTchau()
        {
            do
            {

                Console.WriteLine("tchau");
                Thread.Sleep(2000);
            } while (true);
        }

    }
}
