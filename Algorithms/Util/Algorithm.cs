using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Base class for all slgorithm
    /// </summary>
    public abstract class Algorithm
    {
        /// <summary>
        /// Execution of the algorithm
        /// </summary>
        abstract public void Compute();
        /// <summary>
        /// Get full algorithm`s name
        /// </summary>
        /// <returns></returns>
        abstract public string GetName();
    }
}
