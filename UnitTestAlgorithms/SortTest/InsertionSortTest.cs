using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAlgorithms.SortTest
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void ComputeTestInt()
        {
            //Arange
            Algorithms.TestAlgorithms.GenerateRandomList(100, 100000);
            List<int> unsorted = Algorithms.TestAlgorithms.generateList;
            Algorithms.InsertionSort<int> insertionSort = new Algorithms.InsertionSort<int>(unsorted);

            //Act
            insertionSort.Compute();
            unsorted.Sort();
            var sorted = unsorted;

            //Assert
            Assert.AreEqual(sorted.SequenceEqual(insertionSort.result), true);
        }
        [TestMethod]
        public void ComputeTestString()
        {
            //Arange
            List<string> unsorted = new List<string>() { "asd", "e13da", "79", "asdasda", "dddd" };
            Algorithms.InsertionSort<string> insertionSort = new Algorithms.InsertionSort<string>(unsorted);

            //Act
            insertionSort.Compute();
            unsorted.Sort();
            var sorted = unsorted;

            //Assert
            Assert.AreEqual(sorted.SequenceEqual(insertionSort.result), true);
        }
    }
}
