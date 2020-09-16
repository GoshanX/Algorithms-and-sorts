using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;

namespace Algorithms
{
    /// <summary>
    /// Calculating the Fibonacci number (linear complexity)
    /// </summary>
    public class Fibonacci : Algorithm
    {
        readonly int n;
        public BigInteger result;
        public int resultLastDigit;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_n">Sequence element number</param>
        public Fibonacci(int _n)
        {
            n = _n;
        }

        /// <summary>
        /// Calculate FIbonacci element
        /// </summary>
        /// <returns></returns>
        void CalculateFibonacci()
        {
            var values = new List<BigInteger>() { 0, 1 };

            for (int numberOfSequence = 2; numberOfSequence <= n; numberOfSequence++)
            {
                values.Add(values[numberOfSequence - 1] + values[numberOfSequence - 2]);
            }
            result = values[n];
        }
        /// <summary>
        /// Calculate last Digit in Fibonacci element
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        void CalculateLastDigitFibonacci(int n)
        {
            var values = new List<int>() { 0, 1 };

            for (int numberOfSequence = 2; numberOfSequence <= n; numberOfSequence++)
            {
                values.Add(values[numberOfSequence - 1] % 100 + values[numberOfSequence - 2] % 100);
            }
            resultLastDigit = values[n] % 10;
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute()
        {
            CalculateFibonacci();
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Fibonacci(" + n + ")";
        }
    }
}
