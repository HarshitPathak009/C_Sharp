using System;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, word_copy, reverse_word = "";
            Console.WriteLine("Enter a word");
            word = Console.ReadLine();
            word_copy = word;
            while (word.Length > 0)
            {
                reverse_word = reverse_word + word[word.Length - 1];
                word = word.Substring(0, word.Length - 1);
            }
            if(word_copy == reverse_word)
            {
                Console.WriteLine(reverse_word + " is Palindrome");
            }
            else
            {
                Console.WriteLine(reverse_word + " is not Palindrome as "+ word_copy);
            }
        }
    }
}
