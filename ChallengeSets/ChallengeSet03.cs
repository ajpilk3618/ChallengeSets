using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (Array.IndexOf<bool>(vals, false) != -1)
            {
                return true;
            }
            else return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int result = 0;
            int total = 0;
            foreach (int num in numbers)
            {
                int number = num % 2;
                if (number != 0)
                {
                    total = result += num;
                }
            }
            if (total % 2 != 0)
            {
                return true;
            }
            else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else return false;
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
            //int last = nums[^1];
            //int first = nums[0];
            //return last - first;
            return nums[^1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            List<int> list = new List<int>();
            for (int i = 1; i < 100; i+=2)
            {
                list.Add(i);
            }
            return list.ToArray(); 
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
