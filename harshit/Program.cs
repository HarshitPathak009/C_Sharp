using System;

namespace harshit
{
     public abstract class ball {
        public int force;
        public abstract void bounce();
        public void print(string Name) {
            Console.WriteLine("Ball is "+ Name);
        }
    }
    class Program:ball
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program leather = new Program();
            leather.force = 10;
            leather.print("Leather");
            leather.bounce();
            Program crazyBall = new Program();
            crazyBall.force = 100;
            leather.print("Crazy");
            crazyBall.bounce();
        }

              public override void bounce()
        {
            Console.WriteLine("New height is "+ (force));
        }
    }
}
