using System;
using System.Threading;

namespace TheadsLocking
{
    class Program
    {
        public void Display()
        {
            lock(this){
                Console.WriteLine("[ C# is an ");
                Thread.Sleep(5000);
                Console.WriteLine("object-oriented programming language ]");
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
        } 
    }
}
