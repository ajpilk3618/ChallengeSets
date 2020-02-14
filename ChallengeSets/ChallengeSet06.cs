using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var result = false;

            if (words == null)
            {
                return false;
            }
            List<string> myList = words.ToList();
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList.Contains(null))
                {
                    break;
                }
                if (myList[i] == word)
                {
                    result = true;
                }
                if (myList[i].ToLower() == word && ignoreCase == true)
                {
                    result = true;
                }

            }
            return result;

        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2)
            {
                return true;
            }
            if (num < 2 || num % 2 == 0)
            {
                return false;
            }

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int indexOfLetter = -1;

            if (str.Length == 0)
            {
                return indexOfLetter;
            }

            string secondstr;

            for (int i = 0; i < str.Length; i++)
            {
                secondstr = str.Substring(i, 1);

                if (str.IndexOf(secondstr) == str.LastIndexOf(secondstr))
                {
                    indexOfLetter = i;
                }
            }
            return indexOfLetter;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int maxCount = 1;
            int count = 1;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if (numbers[i + 1] == numbers[i])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }

            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 1)
            {
                return new double[0];
            }
            List<double> myList = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                myList.Add(elements[i]);
            }
            return myList.ToArray();
        }
    }
}