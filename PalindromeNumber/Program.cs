using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, number_copy, reverse_number = 0, remainder;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            number_copy = number;
            while(number!=0)
            {   
                remainder = number % 10;
                reverse_number = reverse_number * 10 + remainder;
                number /= 10;
            }
            if(reverse_number == number_copy)
            {
                Console.WriteLine(number_copy+ " is a Palindrome Number");
            }
            else 
            {
                Console.WriteLine(number_copy+ " is not a Palindrome Number as the reverse is "+reverse_number);
            }
        }
    }
}
