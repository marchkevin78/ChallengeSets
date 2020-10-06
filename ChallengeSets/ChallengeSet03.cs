using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool cont = false;
            if (vals == null)
            {
                return false;
            }
            foreach (var item in vals)
            {
                if (item == false)
                {
                    cont = true;
                }
            }
            if (cont == true)
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var odd = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    odd += num;
                }
            }
            if (odd % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool lower = false;
            bool upper = false;
            bool num = false;
            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    upper = true;
                }
                if (char.IsLower(item))
                {
                    lower = true;
                }
                if (char.IsNumber(item))
                {
                    num = true;
                }
            }
            if (upper == true && lower == true && num == true)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {

            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            else return nums.Last() - nums.First();
        }
        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            var x = 0;
            //var x = 1;
            //for (int i = 0; i < 50; i++)
            //{
            //    odds[i] = x;
            //    x += 2;
            //}
            //return odds;
            for (int i = 1; i < 100; i += 2)
            {
                odds[x] = i;
                x++;
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
