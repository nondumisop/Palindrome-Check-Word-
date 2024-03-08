using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Check__Word_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it's a palindrome:");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }

        static bool IsPalindrome(string word)
        {
            word = word.ToLower(); // Convert to lowercase for case-insensitive comparison
            int length = word.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - 1 - i])
                {
                    return false;
                }
            }

            return true;

        }
    }
}
