using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Int32;

namespace Labb1_UnitTesting
{
    public class Resolver
    {
        public int StringCount(string var)
        {
            return var.Length;
        }

        public bool IsWord(string input)
        {
            return input.All(char.IsLetter);
        }

        public bool IsNumber(string input)
        {
            return input.All(char.IsNumber);
        }

        public bool IsNone(string input)
        {
            return input.All(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x));
        }

        public int NextPalindrome(int input)
        {
            if (input < 100 || input > 999)
                throw new Exception();

            for (int n = input + 1; n < MaxValue; n++)
            {
                int reverse = ReverseInt(n);

                if (n == reverse)
                {
                    return reverse;
                }
            }

            throw new Exception();
        }

        public List<int> NextPrime(int input)
        {
            List<int> cache = new List<int>();

            for (int n = input + 1; n < MaxValue; n++)
            {
                if (IsPrime(n))
                    cache.Add(n);

                if (cache.Count == 3)
                    return cache;
            }

            throw new Exception();
        }

        private bool IsPrime(int input)
        {
            if (input == 1)
                return false;

            if (input == 2)
                return true;


            if (input % 2 == 0)
                return false;    

            for (int i = 3; i < input; i += 2)
            {
                if (input % i == 0)
                    return false;
            }

            return true;
        }

        private int ReverseInt(int input)
        {
            int number = input;
            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }

            return reverse;
        }
    }
}
