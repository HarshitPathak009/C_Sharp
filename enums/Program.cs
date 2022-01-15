using System;

namespace enums
{
    class Program
    {
        public enum Days {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday
        }
        static void Main(string[] args)
        {
            //Assignment 1
            int d = (int)Days.friday;
            Console.WriteLine(d);

            //Assignment 2
            //Print all the elements of enum
            foreach(Days i in Enum.GetValues(typeof(Days)))
            {
                int j = (int)i;
                Console.WriteLine(i + "\t"+j);
            }
        }
    }
}
