using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{   
    /// <summary>
    /// Extension class IList.
    /// </summary>
    static class IListExtensions
    {
        /// <summary>
        /// Swap two elements by index in IList
        /// </summary>
        /// <typeparam name="T">Type value</typeparam>
        /// <param name="list">list of values</param>
        /// <param name="indexA">First index to swap</param>
        /// <param name="indexB">Second index to swap</param>
        static public void Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            //return list;
        }
        
       
    }
}
