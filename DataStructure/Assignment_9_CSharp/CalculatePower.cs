using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_9_CSharp
{
    class CalculatePower
    {
        /*
         * Every number can be written in form power x. For example:
         * case-1, Suppose n = 4 (even number) and x = 5. So, it can be written as 5^4 = 5^2 * 5^2. Which means
         * if we have value of 5^2 we can directly return the result by multiplying it by 5^2.
         * 
         * Case-2, Suppose n = 5 (odd number) and x = 5. So, it can be written as 5^5 = 5^4 * 5^1 = 5 * (5^2)^2.
         * Again if we have value of 5^2 then we can calculate 5^5 (5^4 = 5^2 * 5^2 and if we multiply 5 it will
         * evakluate 5^5).
         * 
         * Case-3, Suppose n = -3 and x = 5. It can be written as 5^(-3) = 1 / 5^3. Now, if we calculate 5^3
         * usingt Case-1 (if n is even) or case-2 (if n is odd) and return 1 / 5^3 (evaluated_value).
         */
        /// <summary>
        /// Using modified Binary Search to find the Power x raised to the power of n. 
        /// </summary>
        /// <param name="x">Base of power : Type = Double</param>
        /// <param name="n">Exponent : Type =Integer only</param>
        /// <remarks>
        ///     <para>
        ///         Time Complexity: O(log n).
        ///     </para>
        ///     Space Complexity:O(1) [No extra space required]
        /// </remarks>
        /// <returns>Power of X raied to the power of n.</returns>
        public double Power(double x, int n)
        {
            double result = 1;
            var absoluteN = Math.Abs(n); // take absolute of n as n can be negative
            while (absoluteN > 0)
            {
                if (absoluteN % 2 == 0) // if 'n' is Even 
                {
                    x = x * x; // then sqaure the x [to evaluate x^(2*k) where k is maximum number of
                               // sqaure of 2 possible for given number. Ex: 3^25 = 3 * 3^(2*12) here k = 12].

                    absoluteN /= 2;  // Above, we are calculating Square of x & storing it in x. So, 1st it will be
                                     // x^2, 2nd time (x^2)^2) = x^4, 3rd time = (x^4)^2 = x^8, kth time = x^(2^k).
                                     // So, we are dividing 'absoluteN' by 2 [as we are calculating sqaure]
                }
                else // if 'n' is Odd
                {
                    result *= x;  // it menas it is of form x * x^(2^k) and we have already calculated x^(2^k). So,
                                  // multiply it with 'x'
                    absoluteN -= 1; // now make 'absoluteN' as even and it will be possible only when we subtract
                                    // 1 from it (subtracting 1 from Odd numbers converts that number into Even number).
                }
            }
            return n < 0 ? 1 / result : result; // now if Exponenet is negative then return (1 / result) or return result
                                                // otherwise.
        }
    }
}
