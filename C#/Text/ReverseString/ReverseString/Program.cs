using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse");
            string s = Console.ReadLine();
            s = ReverseString(s);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        public static string ReverseString(string s)
        {
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
