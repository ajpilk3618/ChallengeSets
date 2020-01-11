using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    result -= numbers[i];
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var a = new List<string>
            {
                str1,
                str2,
                str3,
                str4
            };
            int result = str1.Length;
            for (int i = 0; i < a.Count; i++)
            {
                if (result > a[i].Length)
                {
                    result = a[i].Length;
                }
            }
            return result;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var a = new int[] { number1, number2, number3, number4 };
            int result = number1;
            for (int i = 0; i < a.Length; i++)
            {
                if (result > a[i])
                {
                    result = a[i];
                }
            }
            return result;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool result = false;
            if (sideLength1 + sideLength2 > sideLength3)
            {
                if (sideLength2 + sideLength3 > sideLength1)
                {
                    if (sideLength1 + sideLength3 > sideLength2)
                    {
                        result = true; 
                    }
                }
            }
            return result;

        }

        public bool IsStringANumber(string input)
        {
            bool result = Double.TryParse(input, out _);
            return result; 

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    count++;
                }
            }
            if (count > (objs.Length / 2))
            {
                return true;
            }
            else return false; 
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var a = new List<double>();
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    a.Add(numbers[i]);
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            if (a.Count == 0)
            {
                return 0;
            }
            else
            {
                return sum / a.Count;
            }
        }

        public int Factorial(int number)
        {
            int fact = number;
            if (fact < 0)
            {
                throw new ArgumentOutOfRangeException("age", "All factorials must be positive.");
            }
            if (fact == 0)
            {
                fact = 1;
            }
            for (int i = number - 1; i >= 1; i--)
            {

                if (i > 0)
                {
                    i = Math.Abs(i);
                }
                fact *= i;

            }
            return fact;
        }
    }
}