
namespace Algorithms
{
    /// <summary>
    ///  Greatest Common Divisor - Euclid`s algorithm (logN complexity)
    /// </summary>
    public class GCD : Algorithm
    {
        readonly int a;
        readonly int b;
        public int result;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_a"> First value for search GCD(a,b)</param>
        /// <param name="_b">Secomd value for search GCD(a,b)</param>
        public GCD(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        /// <summary>
        /// Recursive Euclid`s algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int EuclidGCD(int a,int b)
        {
            if (a == 0) return result = b;
            if (b == 0) return result = a;
            if (a >= b) return result = EuclidGCD(a % b, b);
            if (a < b)  return result = EuclidGCD(a, b % a);
            result = 1;
            return result;
        }
        /// <summary>
        /// Override base method for execution
        /// </summary>
        public override void Compute()
        {
            EuclidGCD(a,b);
        }
        /// <summary>
        /// Override method for getting name
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "НОД(" + a + ", " + b + ")";
        }
    }
}
