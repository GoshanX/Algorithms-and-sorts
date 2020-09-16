using System;
using System.Collections.Generic;

namespace Algorithms
{
    /// <summary>
    /// Algorithm use priority queue structure (O(logn) complexity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HeapSort<T> : Algorithm where T : IComparable
    {
        PriorityQueue<T> priorityQueue;
        public IList<T> result;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_list">unsorted sequence</param>
        public HeapSort(IEnumerable<T> _list)
        {
            priorityQueue = new PriorityQueue<T>();
            result = new List<T>();
            //Init priority queue
            foreach(var el in _list)
            {
                priorityQueue.Enqueue(el);
            }
        }
        /// <summary>
        /// Sort 
        /// </summary>
        void HSort()
        {
            int countPriority = priorityQueue.Count;
            for(int i = 0; i < countPriority; i++)
            {
                //extract min element in queue
                result.Add(priorityQueue.Dequeue());
            }
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute()
        {
            HSort();
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Heap Sort";
        }
    }
}
