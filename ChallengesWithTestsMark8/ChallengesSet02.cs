using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers != null ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            var evens = new List<int>();     // List for even numbers

            var sum = 0;

            if (numbers == null)             // Check for Null 
            {
                return 0;
            }
            else
            {
                foreach (var num in numbers) // Check for even numbers
                {
                    if (num % 2 == 0)
                    {
                        evens.Add(num);      // Add even numbers to the list
                    }
                }

                foreach (var num in evens)   // Get sum of all even numbers 
                {
                    sum += num;
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            var sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        }
    }
}
