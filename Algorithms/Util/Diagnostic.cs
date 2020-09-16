using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    /// <summary>
    /// Class for measuring the runnung time of the algorithm
    /// </summary>
    class Diagnostic
    {
        Stopwatch stopWatch;
        /// <summary>
        /// Method displays the time results of the algorithms
        /// </summary>
        /// <param name="algorithms">set of algorithm</param>
        public void TimeExecution(List<Algorithm> algorithms)
        {
            foreach (var alg in algorithms)
            {
                stopWatch = new Stopwatch();

                stopWatch.Start();
                alg.Compute();
                stopWatch.Stop();

                Console.WriteLine("Time " + alg.GetName() + " = " + stopWatch.ElapsedMilliseconds + "ms");
            }
            Console.ReadLine();
        }
    }
}
