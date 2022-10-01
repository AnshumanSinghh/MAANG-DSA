namespace DataStructure.Assignment5
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


        // Modifying above approach to decrease the range further
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
                    /*
                     Sqrt will lie betwn 2, n/3 if n >= 3^2.
                     Sqrt will lie betwn 2, n/4 if n >= 4^2.
                     Sqrt will lie betwn 2, n/10 if n >= 10^2.
                     So, Sqrt will lie betwn 2, n/divider if n >= divider^2.

                     Note:- For every smallest odd digit numbers :
                     1 digit = 1 (perfect sqrt = 1) = = 10^0
                     3 digit = 100 (perfect sqrt = 10) = 10^1
                     5 digit = 10000 (perfect sqrt = 100) = 10^2 = 10 ^((5-1)/2)
                     7 digit = 1000000 (perfect sqrt = 1000) = 10^3 = 10 ^((7-1)/2)
                     9 digit = 100000000 (perfect sqrt = 10000) = 10^4 = 10 ^((9-1)/2)

                     Power Calculation:- 
                     -->For power = 4 = (9-1)/2  [no. of times we have to add +2 to 1 to get 9]. So, 
                        for n it will be (n-1)/2

                     Now,
                     For n digit smallest number, PowerOf10 = 10 ^ ((n - 1)/2)

                     Now, since we are taking smallest odd digit number's sqrt as divider. So, any
                     number greater than that number and smaller than next smallest odd digit number
                     will have sqrt <= N / 10^PowerOf10 [Where N = no. whose sqrt has to be evaluated].

                     Ex:- For example, number of digits = 3 and 4, sqrt will be <= (number / 10)  ~[next smallest odd digit number = 10000]
                     900 = sqrt(30) <= 900/10 = 90
                     9000 = sqrt(94.86) <= 9000/10 = 90

                     for number of digits = 5 and 6 : sqrt <= (number / 100)  ~[next smallest odd digit number = 1000000]
                     90000 = sqrt(300) <= 90000/100 = 900
                     900000 = sqrt(948.683) <= 900000/100 = 9000
                     */
                    var PowerOf10 = (value - 1) / 2;  

                    divider = (int)System.Math.Pow(10, PowerOf10); 
                }
            }
        }
        // Time Complexity will be Log(number / Divider) with base 2. Divider depends on the
        // number of digits. For Ex: 9 digit numbers it will be O(Log(number/10000)) where base is 2.
        // For < 3 digit numbers it will be O(Log(number/3)) where base is 2.
        public int SquareRoot_2(int x)
        {
            //Better than any other Algorithms.
            var obj = new ComputeSquareRoot();
            obj.Divider = x.ToString().Length;
            return obj.SquareRoot(2, x / obj.Divider, x);
        }
    }
}
