using DataStructure.Assignment5;
using DataStructure.Assignment_6;
using DataStructure.Assignment_7;
using DataStructure.DivideAndConquer;
using DataStructure.Sorting_Algos;
using DataStructure.Sorting_Algos.BinaryHeap;
using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binary Search:
            //var arr = new List<int> { -23, 40, 55, 61, 72, 81, 89, 134, 143 };
            //BinarySearch bSearch = new BinarySearch();
            //Console.WriteLine(bSearch.Find(arr, 0, arr.Count - 1, 89));
            //Console.ReadKey();

            //Find First Infinity in finite list:
            //var nums = new List<int> { -23, 40, 55, 1, 2, 27, -89, 999999, 999999, 999999, 999999, 999999 };
            //var nums = new List<int> { -23, 40, 55, 1, 2, 27, -89, 34, 43, 99, 999999, 999999, 999999, 999999, 999999 };
            //BS_Q1 bS_Q1 = new BS_Q1();
            //Console.WriteLine(bS_Q1.SearchFirstInfinity(nums, 0, nums.Count-1));
            //Console.ReadKey();

            // Find First Infinity in an infinite list:
            //var nums2 = new List<int> { -23, 40, 55, 1, 2, 27, -89, 34, 43, 99, 999999, 999999, 999999, 999999, 999999, 999999, 999999 };
            //BS_Q2 bS_Q2 = new BS_Q2();
            //Console.WriteLine(bS_Q2.SearchFirstInfinityInInfiniteList(nums2, 0));
            //Console.ReadKey();

            // Find Pair:
            //var nums3 = new List<int> { 20, 40, 60, 70, 80, 90, 120, 210, 240 };
            //BS_Q3 bS_Q3 = new BS_Q3();
            //Console.WriteLine(bS_Q3.FindPairForTheGivenSum(nums3, 330));
            //Console.WriteLine(bS_Q3.FindPairForTheGivenSum_2(nums3, 330));
            //Console.ReadKey();

            // Find best time to sell stock:
            //var prices = new List<int> { 7, 3, 1, 4, 6, 9 };
            //var prices = new List<int> { 7, 1, 5, 3, 6, 4 };
            //BestTimeToSellStock bestTimeToSell = new BestTimeToSellStock();
            //Console.WriteLine(bestTimeToSell.FindMaxProfit(prices));
            //Console.WriteLine(bestTimeToSell.FindBestDayToBuyAndSellStockForMaxProfit(prices));
            //Console.ReadKey();

            // Move Zeroes at End:
            //var array = new List<int> { 7, 0, 1, 0, 6, 9 };
            //var array = new List<int> { 2, 4, 7, 0, 1, 6, 9, 0, 0};
            //MoveZeroes moveZeroes = new MoveZeroes();
            //Console.Write('[');
            //foreach (var num in moveZeroes.MoveZeroesToEnd(array))
            //{
            //    Console.Write(num + ", ");
            //}
            //Console.Write(']');
            //Console.ReadKey();


            // 2D Array:
            //var nums4 = new List<List<int>>() {
            //                                    new List<int>{ 2, 5, 7, 9 },
            //                                    new List<int>{ 13, 17, 23, 29 },
            //                                    new List<int>{ 40, 43, 47, 52 },
            //                                    new List<int>{ 80, 89, 97, 108 }
            //                                    };
            //SearchElementIn2DArray searchElementIn2DArray = new SearchElementIn2DArray();
            //Console.WriteLine(searchElementIn2DArray.CheckIfElementExists(nums4, 40));
            //Console.WriteLine(searchElementIn2DArray.CheckIfElementExists_2(nums4, 29));
            //Console.ReadKey();

            //ComputeSquareRoot computeSquareRoot = new ComputeSquareRoot();
            //var x = 837465734;
            //var x1 = 34874;
            //var x2 = 866578;
            //Console.WriteLine(computeSquareRoot.SquareRoot(2, x / 3, x));
            //Console.WriteLine(computeSquareRoot.SquareRoot_2(x));

            //PerfectSquare perfectSquare = new PerfectSquare();
            //Console.WriteLine(perfectSquare.CheckIfPerfectSquare(2, (x / 2), x));  // if we take x/2 -1. Then for x = 4 it will fail.
            //Console.ReadKey();

            //FirstBadVersion firstBadVersion = new FirstBadVersion();
            //var nums5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1};
            //Console.WriteLine(firstBadVersion.GetFirstBadVersion(nums5, 0, nums5.Count)); 
            //Console.WriteLine(firstBadVersion.FirstBadVersion_2(nums5)); 
            //Console.ReadKey();

            // Ternary Search:
            //var arr2 = new List<int> { -23, 40, 55, 61, 72, 81, 89, 134, 143, 150, 170, 190 };
            //TernarySearch tSearch = new TernarySearch();
            //Console.WriteLine(tSearch.SearchElement(arr2, 0, arr2.Count-1, 89));
            //Console.ReadKey();

            // Divide and Conquer - Find min and Max
            //var arr3 = new List<int> { -23, 40, 55, 61, 72, 81, 89, 134, 143, 150, 170, 190 };
            //FindMinAndMaxInArray findMinAndMax = new FindMinAndMaxInArray();
            //var answer = findMinAndMax.FindMinAndMax(arr3, 0, arr3.Count - 1);
            //Console.WriteLine(answer);

            /* Binary Heap */
            // insertion
            //Heapq heapq = new Heapq();
            //heapq.HeapPush(50);
            //heapq.HeapPush(55);
            //heapq.HeapPush(53);
            //heapq.HeapPush(52);
            //heapq.HeapPush(54);
            //heapq.Peek();

            // Binary Heap deletion
            //heapq.HeapPop();
            //heapq.Peek();

            // Binary Heap : Creating Heap
            //var arr5 = new List<int> { -1, 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17 };  // neglect -1 added for 1 based indexing
            //heapq.BuildHeap(arr5, arr5.Count, false);

            /* SORTING */
            // Bubble Sorting
            //var arr4 = new List<int> {120, 81, 89, 134, 143, 150, 170, 190, -23, 40, 55, 61, 72};
            //BubbleSort bSort = new BubbleSort();
            //bSort.Sort(arr4);

            //SelectionSort sSort = new SelectionSort();
            //sSort.Sort(arr4);


            /* ASSIGNMENT - 6 */
            //var arr5 = new List<int> { 1, 3, 7, 9, 12, 10, 8, 16, 18, 22, 27 };
            //BuildMinHeap buildMinHeap = new BuildMinHeap();
            //buildMinHeap.MinHeap(arr5, arr5.Count);

            //KMostFrequentWords kMostFrequent = new KMostFrequentWords();
            //var names = new List<string> { "priya", "bhatia", "akshay", "arpit", "priya", "arpit", "bhatia", "bhatia" };
            //var names = new List<string> { "1", "1", "1", "2", "2", "3", "40", "40", "40", "40", "40", "10", "10", "12", "12", "7", "7", "7", "7" };
            //kMostFrequent.GetKMostFrequnetWords(names, names.Count, 3);

            //K_ClosestPoints k_Closest = new K_ClosestPoints();
            //var coorDinates = new List<List<int>> { new List<int> { 3, 3}, new List<int> { 5, -1}, new List<int> { -2, 4} };
            //k_Closest.GetKClosestPoints(coorDinates, 2);

            //ThreePointsClosestSum pointsClosest = new ThreePointsClosestSum();
            //var arr6 = new List<int> { 1, 2, 3, 4};

            //Collinear collinear = new Collinear();
            //var points = new List<List<int>>() {
            //                                    new List<int>{ 1, 1},
            //                                    new List<int>{ 1, 4},
            //                                    new List<int>{ 1, 5 }
            //                                };
            //Console.WriteLine(collinear.CheckIfCollinear(points));

            E_Commerce eCommerce = new E_Commerce();
            var products = new List<string> { "yellowShirt", "redHat", "blackShirt", "bluePants", "redHat", "pinkHat", 
                                               "blackShirt", "yellowShirt", "greenPants", "greenPants", "greenPants"};
            eCommerce.FeatureProduct(products);

            Console.ReadKey();
        }
    }
}
