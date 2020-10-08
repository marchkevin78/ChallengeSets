using System;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var even = 0;
            var odd = 0;
            foreach (var item in numbers)
                if (item % 2 == 0)
                {
                    even += item;
                }
                else if (item % 2 != 0)
                {
                    odd += item;
                }
            return even - odd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            {
                return str1.Length;
            }
            else if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            {
                return str2.Length;
            }
            else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length < str4.Length)
            {
                return str3.Length;
            }
            else return str4.Length;
        } 

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            else return number4;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }
            var number = int.TryParse(input, out int x);
            var number1 = double.TryParse(input, out double y);
            if (number == true || number1 == true)
                return true;
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            //var even = 0.0;
            //foreach (var item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        even += item;
            //    }
            //}
            //return

            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            int num = 1;
            while (number != 1)
            {
                num = num * number;
                number = number - 1;
            }
            return num;
        }
    }
}
