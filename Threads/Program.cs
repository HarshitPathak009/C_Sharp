using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Renamed Thread";
            Console.WriteLine("Current Executing Thread is "+ t.Name);//Thread.CurrentThread.Name);
            Console.WriteLine("Is the Thread Alive "+  t.IsAlive); 

        }
    }
}
