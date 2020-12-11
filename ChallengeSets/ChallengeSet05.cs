using System;
using System.Collections.Generic;


namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var div = 1;
            if (startNumber == 0)
            {
                div += 1;
            }
            for (int i = startNumber + 1; i <= 105 ; i++)
            {
                if (i % n == 0) 
                {
                    div = i;
                    break;
                }
            }
            return div;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var item in businesses)
            {
                if (item.TotalRevenue == 0)
                {
                    item.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var asc = true;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    asc = false;
                    break;
                }
                else if (numbers[i] < numbers[i + 1])
                {
                    asc = true;
                }
            }
            return asc;    
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var even = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i+1];
                }
            }
            return even;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            var word1 = "";
            var word2 = "";
            return ($"{word1} {word2}");
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();

            //var fourth = 0.0;
            //for (int i = 0; i < elements.Count; i+=4)
            //{
            //    fourth += i;
            //}

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            var el1 = 0;
            var el2 = 0;
            foreach (var item in nums)
            {
                if (el1 + el2 == targetNumber)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
