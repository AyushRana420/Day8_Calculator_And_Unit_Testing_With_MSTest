using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo_Calculator;

namespace MathLibrary_MSTst.Tests
{
    [TestClass]
    public sealed class Test1
    {
        private Calculator calculates;
        [TestInitialize]
        public void Initialize()
        {
            calculates = new Calculator();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //One way to do it.

            // Arrange
            //int a = 6;
            //int b = 3;
            //int expected = 18;
            // Act
            //int result = calculates.Multiply(a, b);
            // Assert
            //Assert.AreEqual(expected, result);

            //Another way to do it.
            int result = calculates.Multiply(5, 5);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            //int a = 10;
            //int b = 2;
            //double expected = 5.0;
            // Act
            //double result = calculates.Divide(a, b);
            // Assert
            //Assert.AreEqual(expected, result);

            //Another way to do it.
            double result = calculates.Divide(10, 2);
            Assert.AreEqual(5.0, result);
        }
    }
}
