using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment1
{
    class PerfectSquare
    {
        public string CheckIfPerfectSquare(int left, int right, int x)
        {
            var mid = left + (right - left) / 2;
            var multiplier = x / mid;

            if ((x == 1) || (x == 2) || (left > right))
            {
                return $"False, closest number = {mid}";
            }

            else if(multiplier == mid)  // SquareRoot has been evaluated successfully
            {
                if (x % multiplier == 0)
                {
                    return $"True, {x} is perfect square of {mid}";
                }
                return $"False, closest number = {mid}";
            }
            else if (mid < multiplier)  // increase the mid, as multiplier is greater we should consider
                                        // increasing the left value. This will reduce the search range 
                                        // as well as increase the mid value.
            {
                left = mid + 1;
            }
            else  // decrease the mid, as multiplier is lesser we should consider
                  // decreasing the right value. This will reduce the search range 
                  // as well as decrease the mid value.
            {
                right = mid - 1;
            }
            return CheckIfPerfectSquare(left, right, x);
        }
    }
}
