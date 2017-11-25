using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Palindrome
    {
        int len;
        String temp;
        char a;
        public Palindrome(string input)
        {
            len = input.Length - 1;
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                a = input[len];
                temp += a;
                len--;                
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != temp[i])
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Not a Palindrome!");
            }
        }

        public void Print()
        {
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Palindrome pal = new Palindrome("MaDaM");
        }
    }
}
