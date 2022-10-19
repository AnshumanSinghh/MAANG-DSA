using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_9_CSharp
{
    class DivideTwoIntegers
    {
        /*
         * We know that multiplication is repeated addition and division is repeated subtraction. So,
         * we will keep subtracting until the divisor becomes lesser than dividend.
         * 
         * Time Complexity: O(dividend / divisor)
         * Space Complexity: O(1)
         */
        public double Divide(double dividend, double divisor)
        {
            var sign = ((dividend < 0) ^ (divisor < 0)) ? -1 : 1; // if either dividend or divisor is negative then
                                                                  // only sign will be negative otherwise positive.
            var absDividend = Math.Abs(dividend);
            var absDivisor = Math.Abs(divisor);
            var quotient = 0;
            while (absDividend >= absDivisor)
            {
                absDividend -= absDivisor;
                quotient += 1;
            }

            if (sign == -1)
            {
                return -quotient;
            }
            return quotient;
        }

        /*
         * TIme Complexity: O((log a)^2)  [Bcz each left shift operation takes O(log a) time]
         * Time Complexity: O(1)
         * 
         * Notes:
         * k << i = k * 2 ^ i  [left shift of a number]
         * k >> i = k / 2 ^ i  [right shift of a number]
         */
        public long Divide_2(long dividend, long divisor)
        {
            var sign = ((dividend < 0) ^ (divisor < 0)) ? -1 : 1; // if either dividend or divisor is negative then
                                                                  // only sign will be negative otherwise positive.

            var absDividend = Math.Abs(dividend);
            var absDivisor = Math.Abs(divisor);
            long quotient = 0, temp = 0;

            for (int i = 31; i > -1; i--)  // for 32 bits
            {
                if (temp + (absDivisor << i) <= absDividend)
                {
                    temp += absDivisor << i;
                    quotient += 1 << i;  // Here, 1 << i is equivalent to Pow(2, i)
                }
            }
            if (sign == -1)
            {
                return -quotient;
            }
            return quotient;
        }
    }
}
