using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAlgorithms.SortTest
{
    [TestClass]
    public class HeapSortTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            //Arange
            Algorithms.TestAlgorithms.GenerateRandomList(100000, 100000);
            List<int> unsorted = Algorithms.TestAlgorithms.generateList;
            Algorithms.HeapSort<int> hSort = new Algorithms.HeapSort<int>(unsorted);

            //Act
            hSort.Compute();
            unsorted.Sort();
            var sorted = unsorted;
           
            //Assert
            Assert.AreEqual(sorted.SequenceEqual(hSort.result), true);
        }
        [TestMethod]
        public void ComputeTestString()
        {
            //Arange
            List<string> unsorted = new List<string>() { "asd", "e13da", "79", "asdasda", "dddd" };
            Algorithms.HeapSort<string> insertionSort = new Algorithms.HeapSort<string>(unsorted);

            //Act
            insertionSort.Compute();
            unsorted.Sort();
            var sorted = unsorted;
            
            //Assert
            Assert.AreEqual(sorted.SequenceEqual(insertionSort.result), true);
        }
    }
}
