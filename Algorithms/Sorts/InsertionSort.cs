using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    /// <summary>
    /// Sort by inserts  (O(n^2) complexity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InsertionSort<T> : Algorithm where T:IComparable
    {
        public IList<T> result;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_list">unsorted sequence</param>
        public InsertionSort(IEnumerable<T> _list)
        {
            result = _list.ToList();
        }

        /// <summary>
        /// Sort by inserts
        /// </summary>
        private void InsertSort()
        {
            int j = 0;
            for(int i = 1; i < result.Count(); i++)
            {
                j = i;
                while(j > 0 && result.ElementAt(j).CompareTo(result.ElementAt(j - 1)) < 0)
                {
                    //Swap two element by index
                    result.Swap(j-1, j);
                    j--;
                }
            }
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute()
        {
            InsertSort();
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Insert Sort";
        }
    }
}
