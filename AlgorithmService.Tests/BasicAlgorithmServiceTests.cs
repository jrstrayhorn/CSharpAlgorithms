using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmService;

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
    }
}