using System;

namespace arm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2, sum=0, i=1;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            n2 = n;
            while(n!=0)
            {
                sum += Convert.ToInt32(Math.Pow(n%10,3));
                i++;
                n/=10;
            }
            if(n2==sum)
                Console.WriteLine(n2 + " is a Armstrong Number");
            else    
                Console.WriteLine(n2 + " is not a Armstrong Number because the result is "+ sum);
        }
    }
}
