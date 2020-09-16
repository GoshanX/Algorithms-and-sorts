using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    /// <summary>
    /// Standart sort list in .NET Framework 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class StandartSort<T> : Algorithm where T:IComparable
    {
        List<T> list = new List<T>();
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_list">unsorted sequence</param>
        public StandartSort(IEnumerable<T> _list)
        {
            list = _list.ToList();
        }
        /// <summary>
        /// Sort List
        /// </summary>
        void Sort()
        {
            list.Sort();
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute()
        {
            Sort();
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Standart SortList .NET";
        }
    }
}
