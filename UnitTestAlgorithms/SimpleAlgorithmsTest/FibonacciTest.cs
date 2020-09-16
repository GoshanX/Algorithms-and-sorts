using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAlgorithms.SimpleAlgorithmsTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            //Arrange
            var fib = new Algorithms.Fibonacci(79);

            //Act
            fib.Compute();

            //Assert
            Assert.AreEqual(fib.result, 14472334024676221);
        }
    }
}
