using System;

namespace getset
{    
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student obj = new Student();
            obj.set(10);
            Console.WriteLine(obj.get());
        }
    }
     class Student {
        int n;
        public void set(int val)
        {
            n = val;
        }
        public int get() {
            return n;
        }
    }
}
