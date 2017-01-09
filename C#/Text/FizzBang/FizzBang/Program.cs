using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBang
{
    internal class Program
    {
        //Fizz Buzz - Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz”
        //instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.
        private static void Main(string[] args)
        {
            NewFizzBang();

            Console.ReadLine();
        }

        public static void NewFizzBang()
        {
            int num = 100;

            for (int i = 1; i < num +1; i++)
            {
                if (i % 5 == 0 && i % 3 ==0)
                {
                    Console.WriteLine("FizzBang");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Bang");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }


        //MY OLD VERSION OF FIZZBANG (bad):
        //Completed Jul 2015
        public static void OldFizzBang()
        {
            int[] arrThrees = new int[33];
            int[] arrFives = new int[20];
            int x = 0;
            int y = 0;

            for (int i = 0; i < arrThrees.Length; i++)
            {
                x = x + 3;
                arrThrees[i] = x;
                Console.WriteLine("{0}", arrThrees[i]);
            }

            for (int i = 0; i < arrFives.Length; i++)
            {
                y = y + 5;
                arrFives[i] = y;
                Console.WriteLine("{0}", arrFives[i]);
            }

            string print = "";

            for (int i = 0; i < 100; i++)
            {
                if (arrThrees.Contains(i) && arrFives.Contains(i))
                {
                    print = "FizzBang";
                }
                else if (arrThrees.Contains(i))
                {
                    print = "Fizz";
                }
                else if (arrFives.Contains(i))
                {
                    print = "Bang";
                }
                else
                {
                    print = i.ToString();
                }
                Console.WriteLine("{0}", print);
            }

        }
    }
}

