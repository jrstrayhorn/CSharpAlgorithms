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
    }
}