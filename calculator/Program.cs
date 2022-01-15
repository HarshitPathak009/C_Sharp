using System;

namespace calculator
{
    class Program
    {
        int num1, num2;
        int result;
        void Add()
        {
            result = num1 + num2;
            Console.WriteLine("The addition of "+num1+" and "+num2+" is "+result);
        }
        void Subtract()
        {
            result = num1 - num2;
            Console.WriteLine("The subtraction of "+num2+" from "+num1+" is "+result);
        }
        void Multiply()
        {
            result = num1 * num2;
            Console.WriteLine("The multiplication of "+num1+" with "+num2+" is "+result);
        }
        void Divide()
        {
            result = num1 / num2;
            Console.WriteLine("The division of "+num1+" by "+num2+" is "+result);
        }
        void Remainder()
        {
            result = num1 % num2;
            Console.WriteLine("The remainder of "+num1+" divided by "+num2+" is "+result);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter the first number");
            obj.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            obj.num2 = Convert.ToInt32(Console.ReadLine());
            char ch;
            Console.WriteLine("Enter the operation to be performed");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+':
                    obj.Add(); 
                    break;
                case '-':
                    obj.Subtract();
                    break;
                case '*':
                    obj.Multiply();
                    break;
                case '/':
                    obj.Divide();
                    break;
                case '%':
                    obj.Remainder();
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
