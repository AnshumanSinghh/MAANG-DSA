namespace DataStructure.Assignment1
{
    class ComputeSquareRoot
    {
        public int SquareRoot(int left, int right, int x)
        {
            var mid = left + (right - left) / 2;
            var multiplier = x / mid;  // mid * mid = x; So, mid = x / mid; otherwise mid * mid
                                       // will be out of memory

            if ((x == 1) || (x == 2))
            {
                return 1;
            }

            else if ((multiplier == mid) || (left == right))
            {
                return multiplier <= mid ? multiplier : mid;
            }
            else if (multiplier < mid)  
            {
                right = mid - 1; // rem will be bigger when mid will be decreased
            }
            else 
            {
                left = mid + 1; // rem will be lesser when mid will be increased
            }
            return SquareRoot(left, right, x);
        }
    }
}
