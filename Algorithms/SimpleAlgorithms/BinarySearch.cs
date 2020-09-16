using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    /// <summary>
    /// Search element in the sorted sequence (<log2n complexity)
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    public class BinarySearch<T> : Algorithm where T : IComparable
    {
        readonly IEnumerable<T> list;
        readonly object element;
        public int resultIndex;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_list">Sort sequence</param>
        /// <param name="_element">element for search</param>
        public BinarySearch(IEnumerable<T> _list, object _element)
        {
            list = _list;
            element = _element;
        }
        /// <summary>
        /// Find the index of the element
        /// </summary>
        /// <returns>index the index of the element found</returns>
        int CalculateBinarySearch()
        {
            int left = 0;
            int right = list.Count() - 1;
            int middleIndex;

            while (left <= right)
            {
                middleIndex = (left + right + 1) / 2;
                if (list.ElementAt(middleIndex).Equals(element))
                {
                    return resultIndex = middleIndex;
                }
                else if (list.ElementAt(middleIndex).CompareTo(element) > 0)
                {
                    right = middleIndex - 1;
                }
                else
                {
                    left = middleIndex + 1;
                }
            }
            return resultIndex = -1;
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute()
        {
            CalculateBinarySearch();
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Binary Search";
        }
    }
}
