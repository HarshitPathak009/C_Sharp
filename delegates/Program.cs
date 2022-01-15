using System;

namespace delegates
{
    public delegate int PerformCalculation(int x, int y);
    class Program
    {
        public static event PerformCalculation add;


        static int Addition(int n, int b)
        {
            return n+b;
        }
        static void Main(string[] args)
        {
            PerformCalculation obj = new PerformCalculation(Program.Addition);
            Console.WriteLine("Addition of 3 + 4 is "+ obj(3,4));
            add = new PerformCalculation(obj);
            Console.WriteLine("Hey its an event "+add.Invoke(5,6));
        }
        // static int add1(int a, int b) 
        // {
        //     return a+b;
        // }
    }
}
