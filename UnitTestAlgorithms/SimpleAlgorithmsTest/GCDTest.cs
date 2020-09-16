using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAlgorithms.SimpleAlgorithmsTest
{
    [TestClass]
    public class GCDTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            //Arrange
            Algorithms.GCD gcd = new Algorithms.GCD(66,121);

            //Act
            gcd.Compute();

            //Assert
            Assert.AreEqual(gcd.result, 11);
        }

    }
}
