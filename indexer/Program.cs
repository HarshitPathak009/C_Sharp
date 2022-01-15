using System;

namespace indexer
{
    class SampleCollection<T>
    {
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get => arr[i]; 
            set => arr[i] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World.";
            stringCollection[1] = "Hi";
            Console.WriteLine(stringCollection[0]);
            Console.WriteLine(stringCollection[1]);
            stringCollection[3] = stringCollection[0]+stringCollection[1];
            Console.WriteLine(stringCollection[3]);
        }    
    }
}
