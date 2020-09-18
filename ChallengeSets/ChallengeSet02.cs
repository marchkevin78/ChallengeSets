﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 < length2)
            {
                return length1;
            }
            else return length2;
        }

        public int Sum(int[] numbers)
        {
            int num = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            foreach (int item in numbers)
            {
                num += item;
            }
            return num;
        }

        public int SumEvens(int[] numbers)
        {
            var evens = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        evens += num;
                    }
                }
                return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sum = 0;
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            foreach (var num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
