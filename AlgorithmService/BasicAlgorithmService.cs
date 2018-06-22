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
    }
}
