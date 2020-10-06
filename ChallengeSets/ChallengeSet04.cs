using System;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            throw new NotImplementedException();
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
            else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length)
            {
                return str3.Length;
            }
            else return str4.Length;
        } 

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
