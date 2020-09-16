using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAlgorithms.SimpleAlgorithmsTest
{ 
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void ComputeTestInt()
        {
            //Arrange
            List<int> testList = new List<int>() { -12, -3, 0, 2, 5, 17, 27, 32, 44, 79, 102, 3334, 33323, 100000000 };
            Algorithms.BinarySearch<int> binarySearch = new Algorithms.BinarySearch<int>(testList, 79);

            //Act
            binarySearch.Compute();

            //Assert
            Assert.AreEqual(binarySearch.resultIndex, 9);

        }
        [TestMethod]
        public void ComputeTestString()
        {
            //Arrange
            List<string> testList = new List<string>() { "aaa","aab","cca","www","wzz" };
            Algorithms.BinarySearch<string> binarySearch = new Algorithms.BinarySearch<string>(testList, "www");

            //Act
            binarySearch.Compute();

            //Assert
            Assert.AreEqual(binarySearch.resultIndex, 3);

        }
    }
}
