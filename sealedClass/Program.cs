using System;

namespace sealedClass
{
    sealed class Time
    {
        public int n = 5;
        public void print()
        {
            Console.WriteLine("This is in sealed class" + n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sealed class cannot be inherited");
            Time obj = new Time();
            obj.n = 10;
            obj.print();
            Console.WriteLine("Called the sealed class by creating its object");
        }
    }
}
