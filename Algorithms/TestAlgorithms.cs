using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorithms
{
    public class TestAlgorithms
    {

        public static List<int> generateList = new List<int>();
        public static void GenerateRandomList(int count, int maxSize)
        {
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                generateList.Add(r.Next(maxSize));
            }
        }
        public static void Main()
        {
            //Generate unsorted sequence
            GenerateRandomList(100000, 10000);
            //Init objects for Sort
            //var insertSort = new InsertionSort<int>(generateList);
            var mSort = new MergeSort<int>(generateList);
            var qSort = new QuickSort<int>(generateList);
            var hSort = new HeapSort<int>(generateList);
            var sSort = new StandartSort<int>(generateList);

            var listClasses = new List<Algorithm>() { hSort,mSort, qSort,sSort };

            var diag = new Diagnostic();
            //Compute all algorithms
            diag.TimeExecution(listClasses);

        }
    }
}

