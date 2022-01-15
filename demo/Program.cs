using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.ReadLine();
            int x =100, y = x/2;
            Console.Write(x+"\t"+y+"\n");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Value entered is "+a);
            int c = a%2;
            if(c==0) {
                Console.WriteLine("The number is even");
            }
            else {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
