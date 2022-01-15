using System;

namespace access
{
    class Account {
        // public int accountBalance = 1000;
        // private int accountBalance  = 1000;
        int accountBalance  = 1000; //by default it is private
        public void setBalance(int val) {
            accountBalance = val;
        }
    
        public int getBalance() {
            return accountBalance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Public
            //Private
            //Protected
            //Internal -> Allows the class to expose to the other member variable and function
            //Internal Protected ->Google this
            Account myAccount = new Account();
            // myAccount.accountBalance = 100; //using public
            myAccount.setBalance(100);
            int bal = myAccount.getBalance();
            Console.WriteLine(bal);
            myAccount.accountBalance = 1000;
            Console.WriteLine(myAccount.accounBalance);
        }
    }
}
