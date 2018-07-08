using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmService;
using System.Collections;

namespace AlgorithmService.Tests
{
    [TestClass]
    public class BasicAlgorithmServiceTests
    {
        private readonly BasicAlgorithmService _basicAlgorithmService;

        public BasicAlgorithmServiceTests()
        {
            _basicAlgorithmService = new BasicAlgorithmService();
        }

        [TestMethod]
        public void ConvertToF_ReturnCorrectType()
        {
            var result = _basicAlgorithmService.ConvertToF(0);

            Assert.IsInstanceOfType(result, typeof(double));
        }

        [DataTestMethod]
        [DataRow(-30, -22)]
        [DataRow(-10, 14)]
        [DataRow(0, 32)]
        [DataRow(20, 68)]
        [DataRow(30, 86)]
        public void ConvertToF_ReturnCorrectValue(double input, double expected)
        {
            var result = _basicAlgorithmService.ConvertToF(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseString_ReturnCorrectType()
        {
            var result = _basicAlgorithmService.ReverseString("hello");

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [DataTestMethod]
        [DataRow("hello", "olleh")]
        [DataRow("Howdy", "ydwoH")]
        [DataRow("Greetings from Earth", "htraE morf sgniteerG")]
        public void ReverseString_ReturnCorrectValue(string input, string expected)
        {
            var result = _basicAlgorithmService.ReverseString(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Factorialize_ReturnCorrectType()
        {
            var result = _basicAlgorithmService.Factorialize(5);

            Assert.IsInstanceOfType(result, typeof(long));
        }

        [DataTestMethod]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        [DataRow(20, 2432902008176640000)]
        [DataRow(0, 1)]
        public void Factorialize_ReturnCorrectValue(int input, long expected)
        {
            var result = _basicAlgorithmService.Factorialize(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindLongestWordLength_ReturnCorrectType()
        {
            var result = _basicAlgorithmService.FindLongestWordLength("The quick brown fox jumped over the lazy dog");

            Assert.IsInstanceOfType(result, typeof(int));
        }

        [DataTestMethod]
        [DataRow("The quick brown fox jumped over the lazy dog", 6)]
        [DataRow("May the force be with you", 5)]
        [DataRow("Google do a barrel roll", 6)]
        [DataRow("What is the average airspeed velocity of an unladen swallow", 8)]
        [DataRow("What if we try a super-long word such as otorhinolaryngology", 19)]
        public void FindLongestWordLength_ReturnCorrectValue(string input, int expected)
        {
            var result = _basicAlgorithmService.FindLongestWordLength(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LargestOfFour_ReturnCorrectType()
        {
            var input = new int[4][]
            {
                new int[4] { 4, 5, 1, 3 },
                new int[4] { 13, 27, 18, 26 },
                new int[4] { 32, 35, 37, 39 },
                new int[4] { 1000, 1001, 857, 1 },
            };

            var result = _basicAlgorithmService.LargestOfFour(input);

            Assert.IsInstanceOfType(result, typeof(IEnumerable));
        }

        [TestMethod]
        public void LargestOfFour_ReturnCorrectValue()
        {
            var input = new int[4][]
            {
                new int[4] { 4, 5, 1, 3 },
                new int[4] { 13, 27, 18, 26 },
                new int[4] { 32, 35, 37, 39 },
                new int[4] { 1000, 1001, 857, 1 },
            };

            var expected = new int[4] { 5, 27, 39, 1001 };

            var result = _basicAlgorithmService.LargestOfFour(input);

            CollectionAssert.AreEqual(expected, result);

            input = new int[4][]
            {
                new int[4] { 4, 9, 1, 3 },
                new int[4] { 13, 35, 18, 26 },
                new int[4] { 32, 35, 97, 39 },
                new int[4] { 1000000, 1001, 857, 1 },
            };

            expected = new int[4] { 9, 35, 97, 1000000 };

            result = _basicAlgorithmService.LargestOfFour(input);

            CollectionAssert.AreEqual(expected, result);

            input = new int[4][]
            {
                new int[4] { 17, 23, 25, 12 },
                new int[4] { 25, 7, 34, 48 },
                new int[4] { 4, -10, 18, 21 },
                new int[4] { -72, -3, -17, -10 },
            };

            expected = new int[4] { 25, 48, 21, -3 };

            result = _basicAlgorithmService.LargestOfFour(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("Bastian", "n", true)]
        [DataRow("Congratulation", "on", true)]
        [DataRow("Connor", "n", false)]
        [DataRow("Walking on water and developing software from a specification are easy if both are frozen", "specification", false)]
        [DataRow("He has to give me a new name", "name", true)]
        [DataRow("Open sesame", "same", true)]
        [DataRow("Open sesame", "pen", false)]
        [DataRow("Open sesame", "game", false)]
        [DataRow("If you want to save our world, you must hurry. We dont know how much longer we can withstand the nothing", "mountain", false)]
        [DataRow("Abstraction", "action", true)]
        public void ConfirmEnding_ReturnCorrectType(string input, string target, bool expected)
        {
            var result = _basicAlgorithmService.ConfirmEnding(input, target);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("*", 3, "***")]
        [DataRow("abc", 3, "abcabcabc")]
        [DataRow("abc", 4, "abcabcabcabc")]
        [DataRow("abc", 1, "abc")]
        [DataRow("*", 8, "********")]
        [DataRow("abc", -2, "")]
        public void RepeatStringNumTimes_ReturnCorrectValue(string input, int numOfTimes, string expected)
        {
            var result = _basicAlgorithmService.RepeatStringNumTimes(input, numOfTimes);

            Assert.AreEqual(expected, result);
        }
    }
}