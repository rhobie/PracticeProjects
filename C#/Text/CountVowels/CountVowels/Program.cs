using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;

            Console.WriteLine("Enter a string, this program will count the vowels and tally them.");
            string s = Console.ReadLine();

            char[] charArr = s.ToCharArray();
            foreach (var c in charArr)
            {
                switch (c)
                {
                    default:
                        break;
                    case 'a':
                        a++;
                        break;
                    case 'e':
                        e++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'u':
                        u++;
                        break;
                }
            }

            Console.WriteLine("Entered string contains {0} vowels", a + e + i + o + u);
            Console.WriteLine("A={0,-5} E={1,-5} I={2,-5} O={3,-5} U={4,-5}", a, e, i, u, o);

            Console.ReadLine();
        }
    }
}
