using System;
using System.Threading;
namespace ThreadJoin
{
    class Program
    {
        public void function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("fun1 "+i+" ");
            }
        }
        public void function2()
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("fun2 "+i+" ");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.function1);
            Thread t2 = new Thread(p.function2);
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            Console.WriteLine("\nMain Thread");
        }
    }
}
