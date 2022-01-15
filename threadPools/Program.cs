using System;
using System.Threading;
namespace threadPools
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(DoSomething);
            Console.WriteLine("Main Thread Does Something");
            Console.WriteLine("Main Thread");
        }

        static void DoSomething(Object StateInfo)
        {
            Thread.Sleep(5000);
            Console.WriteLine("the Thread");
        }
    }
}
