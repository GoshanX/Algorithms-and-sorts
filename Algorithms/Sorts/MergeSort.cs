using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{   
    /// <summary>
    /// Merge sort in place (complexity O(logn))
    /// </summary>
    /// <typeparam name="T">type of values</typeparam>
    public class MergeSort<T> : Algorithm where T : IComparable
    {
       public IList<T> result;
        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="_list">unsorted sequence</param>
        public MergeSort(IEnumerable<T> _list)
        {
            result = _list.ToList();
        }
        /// <summary>
        /// Recursive algorithm 
        /// </summary>
        /// <param name="left">Start index unsorted sequence</param>
        /// <param name="right">Finish index unsorted sequence</param>
        private void MSort(int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MSort(left, middle);
                MSort(middle + 1, right);
                Merge(left, right);
            }

        }
        /// <summary>
        /// Merge two sort sequence (old + new part)
        /// </summary>
        /// <param name="first">start index</param>
        /// <param name="last">finish index</param>
        private void Merge(int first, int last)
        {
            int middle, start, final;
            var result = new List<T>();
            middle = (first + last) / 2;
            start = first;
            final = middle + 1;

            for (int j = first; j <= last; j++)
            {
                if ((start <= middle) && ((final > last) || (this.result[start].CompareTo(this.result[final]) < 0)))
                {
                    result.Add(this.result[start]);
                    start++;
                }
                else
                {
                    result.Add(this.result[final]);
                    final++;
                }
            }
            int k = 0;
            for (int j = first; j <= last; j++)
            {
                this.result[j] = result[k];
                k++;
            }
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute()
        {
            MSort(0, result.Count() - 1);
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>

        public override string GetName()
        {
            return "Merge Sort";
        }
    }
}
