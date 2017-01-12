using System;

namespace CheckIfPalindrome
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("**Check if Palindrome**\n- Checks if the string entered by the user is a palindrome. That is that it reads the same forwards as backwards like “racecar”\n");
            while (true)
            {
                Console.WriteLine("Enter a word to check if it is a palindrome");
                string s = Console.ReadLine();
                string sReversed = ReverseString(s);

                if (s == sReversed)
                {
                    Console.WriteLine("{0} is a palindrome\n", s);
                }
                else
                {
                    Console.WriteLine("{0} is not a palindrome\n", s);
                }
            }
        }
        public static string ReverseString(string s)
        {
            string reversed = "";
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            foreach (var item in charArr)
            {
                reversed += item;
            }
            return reversed;
        }
    }
}
