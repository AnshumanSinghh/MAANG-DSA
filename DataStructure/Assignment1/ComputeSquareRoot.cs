namespace DataStructure.Assignment1
{
    class ComputeSquareRoot
    {
        /// <summary>
        /// Performs a binary search in range (2, number/3) to find the Square Root of a number.
        /// Time Complexity = O(log(n/3)) where base is 2.
        /// </summary>
        /// <param name="left"> left number of the range in which we have to find sqrt
        /// initially it will be 2.</param>
        /// <param name="right"> For any number greater than 2 the square root will lie 
        /// between 2 and n/2. But we can also take 2 to n / 3 as for any number >= 9 Sqrt will lie
        /// between 2 and number/3. Initially it will be number/3</param>
        /// <param name="x"> Number for which we have to find Square Root.</param>
        /// <returns>The approx square root of a given number.</returns>
        private int counter = 0;
        public int SquareRoot(int left, int right, int x)
        {
            var mid = left + (right - left) / 2;
            var multiplier = x / mid;  // mid * mid = x; So, mid = x / mid; otherwise mid * mid
                                       // will be out of memory
            counter++;
            if (x == 1)
            {
                return 1;
            }
            else if ((multiplier == mid) || (left >= right))  // In case of 2 <= number <= 5. left will be always
                                                              // greater. In other cases any or both will be true
                                                              // for this comparision (multiplier == mid) || (left >= right)
            {
                System.Console.WriteLine($"Method called {counter} times.");
                return multiplier <= mid ? multiplier : mid;
            }
            else if (multiplier < mid)  
            {
                right = mid - 1; // multiplier will be bigger when mid will be decreased
            }
            else 
            {
                left = mid + 1; // multiplier will be lesser when mid will be increased
            }
            return SquareRoot(left, right, x);
        }


        // Midifying above approach to decrease the range further
        private int divider = -1;
        
        public int Divider
        {
            get
            {
                if (divider != -1)
                {
                    return divider;
                }
                return 3;
            }

            set 
            {
                if (value < 3)
                {
                    divider = 3;
                }
                else
                {
                    var numberOfTimes = ((value - 3) / 2) + 1;  // for odd no. of digits > 3. SquareRoot
                                                                // will lie before power of 10. For example,
                                                                // number of digits = 3, sqrt will be <= (number / 10)
                                                                // for 5 : sqrt <= (number / 100), for 9: sqrt <= (number / 10000)
                    divider = (int)System.Math.Pow(10, numberOfTimes); 
                }
            }
        }
        // Time Complexity will be Log(number / Divider) with base 2. Divider depends on the
        // number of digits. For 9 digit numbers it will be O(Log(number/10000)) where base is 2.
        // For < 3 digit numbers it will be O(Log(number/3)) where base is 2.
        public int SquareRoot_2(int x)
        {
            var obj = new ComputeSquareRoot();
            obj.Divider = x.ToString().Length;
            return obj.SquareRoot(2, x / obj.Divider, x);
        }
    }
}
