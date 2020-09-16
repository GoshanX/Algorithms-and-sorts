using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    /// <summary>
    /// Quick sort (faster than merhe sort, O(logn) complexity)
    /// </summary>
    /// <typeparam name="T">type of values</typeparam>
    public class QuickSort<T> : Algorithm where T : IComparable
    {
        public IList<T> result;
        public long time = 0;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_list">unsorted sequence</param>
        public QuickSort(IEnumerable<T> _list)
        {
            result = _list.ToList();
        }
        /// <summary>
        /// Search for element, which is left by less and which is more to the right 
        /// </summary>
        /// <param name="left">start index</param>
        /// <param name="right">finish index</param>
        /// <returns></returns>
        int Partition(int left,int right)
        {
            var j = left-1;
            for(int i=left;i < right; i++)
            {
                if (result[i].CompareTo(result[right]) < 0)
                {
                    j++;
                    result.Swap(j, i);
                }
            }
            j++;
            result.Swap(right, j);
           
            return j;
        }
        /// <summary>
        /// Recursive quick sort
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        void QSort(int left,int right)
        {
            if (left > right) return;
            var middle = Partition(left, right);
            QSort(left, middle - 1);
            QSort(middle + 1, right);
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute() 
        {
            QSort(0, result.Count-1);
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Quick Sort";
        }
    }
    
}
