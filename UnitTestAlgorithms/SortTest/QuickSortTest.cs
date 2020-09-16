using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestAlgorithms.SortTest
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void ComputeTestInt()
        {
            //Arange
            Algorithms.TestAlgorithms.GenerateRandomList(100000, 100000);
            List<int> unsorted = Algorithms.TestAlgorithms.generateList;
            Algorithms.QuickSort<int> quickSort = new Algorithms.QuickSort<int>(unsorted);

            //Act
            quickSort.Compute();
            unsorted.Sort();
            var sorted = unsorted;

            //Assert
            Assert.AreEqual(sorted.SequenceEqual(quickSort.result), true);
        }
        [TestMethod]
        public void ComputeTestString()
        {
            //Arange
            List<string> unsorted = new List<string>() { "asd", "e13da", "79", "asdasda", "dddd" };
            Algorithms.QuickSort<string> mergeSort = new Algorithms.QuickSort<string>(unsorted);

            //Act
            mergeSort.Compute();
            unsorted.Sort();
            var sorted = unsorted;

            //Assert
            Assert.AreEqual(sorted.SequenceEqual(mergeSort.result), true);
        }
    }
}
