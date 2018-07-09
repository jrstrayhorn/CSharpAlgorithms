using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmService
{
    public class BasicAlgorithmService
    {
        public double ConvertToF(double celsius)
        {
            return ((celsius * 1.8) + 32);
        }

        public string ReverseString(string original)
        {
            if (original == null)
                throw new ArgumentNullException(nameof(original));

            if (original.Length == 0)
                return "";

            return string.Join("", original.ToCharArray().Reverse());
        }

        public long Factorialize(int value)
        {
            if (value < 0)
                throw new InvalidOperationException("Please enter a value greater than or equal to zero.");

            // using recursion
            if (value == 0)
            {
                return 1;       // base case
            }
            else
            {
                return value * Factorialize(value - 1); // recursive case
            }

            // using iterative
            // long sum = 1;
            // for (var i = 1; i <= value; i++)
            // {
            //     sum = sum * i;
            // }
            // return sum;
        }

        // Return the length of the longest word in a provided sentence.
        // The response should be a number.
        public int FindLongestWordLength(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new InvalidOperationException("Your input cannot be blank.");

            return input
                    .Split(' ')
                    .Select(w => w.Length)
                    .Max();
        }

        // Return an array consisting of the largest number from each
        // provided sub-array.
        public int[] LargestOfFour(int[][] input)
        {
            if (input.Length != 4)
                throw new InvalidOperationException("Your array must have 4 items");

            return input
                    .Select(i => i.Max())
                    .ToArray();
        }

        // Check if a string (first argument) ends with the given target
        // string (second argument)
        public bool ConfirmEnding(string input, string target)
        {
            return input.Substring(input.Length - target.Length) == target;
        }

        public string RepeatStringNumTimes(string input, int numOfTimes)
        {
            if (numOfTimes <= 0)
                return "";

            var inputList = new List<string>();
            for (int i = 0; i < numOfTimes; i++)
            {
                inputList.Add(input);
            }

            return string.Join("", inputList);
        }

        // Truncate a string (first argument) if it is longer than the
        // given maximum string length (second argument)
        // Return the truncated string with a ... ending
        public string TruncateString(string input, int length)
        {
            throw new NotImplementedException("writing tests first");
        }
    }
}
