using System;
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
    }
}
