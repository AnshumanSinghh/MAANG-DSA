using DataStructure.Assignment5;
using DataStructure.Assignment_6;
using DataStructure.Assignment_7;
using DataStructure.DivideAndConquer;
using DataStructure.Sorting_Algos;
using DataStructure.Sorting_Algos.BinaryHeap;
using System;
using System.Collections.Generic;
using DataStructure.Assignment_8_CSharp;
using DataStructure.Assignment_9_CSharp;
using DataStructure.LinkedLists.SinglyLinkedList;
using DataStructure.Assignment_10_CSharp;
using DataStructure.Assignment_11_CSharp;

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

            /* ASSIGNMENT 5 */
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
            //InsertionSorting insertion = new InsertionSorting();
            //insertion.Sort(arr5);

            // Bubble Sorting
            //var arr4 = new List<int> {120, 81, 89, 134, 143, 150, 170, 190, -23, 40, 55, 61, 72};
            //BubbleSort bSort = new BubbleSort();
            //bSort.Sort(arr4);

            //SelectionSort sSort = new SelectionSort();
            //sSort.Sort(arr4);

            //// MergeSort
            //MergeSorting mergeSorting = new MergeSorting();
            //var arr7 = new List<int> { 50, 70, 6, 13, 80, 62, 98, 27 };
            //var sortedArr = mergeSorting.MergeSort(arr7, 0, arr7.Count - 1);
            //foreach (var ele in sortedArr)
            //{
            //    Console.Write(ele + ", ");
            //}

            // QuickSorting
            //QuickSorting quickSorting = new QuickSorting();
            //var arr8 = new List<int> { 50, 70, 6, 13, 80, 62, 98, 27 };
            ////var sortedArr1 = quickSorting.QuickSort(arr8, 0, arr8.Count - 1);
            //var quickSorting = new RandomisedQuickSort();
            //var sortedArr1 = quickSorting.QuickSort(arr8, 0, arr8.Count - 1);
            //foreach (var ele in sortedArr1)
            //{
            //    Console.Write(ele + ", ");
            //}

            /* ASSIGNMENT - 6 */
            //var arr5 = new List<int> { 1, 3, 7, 9, 12, 10, 8, 16, 18, 22, 27 };
            //BuildMinHeap buildMinHeap = new BuildMinHeap();
            //buildMinHeap.MinHeap(arr5, arr5.Count);

            //KMostFrequentWords kMostFrequent = new KMostFrequentWords();
            //var names = new List<string> { "priya", "bhatia", "akshay", "arpit", "priya", "arpit", "bhatia", "bhatia" };
            ////var names = new List<string> { "1", "1", "1", "2", "2", "3", "40", "40", "40", "40", "40", "10", "10", "12", "12", "7", "7", "7", "7" };
            //kMostFrequent.GetKMostFrequnetWords(names, names.Count, 3);

            //K_ClosestPoints k_Closest = new K_ClosestPoints();
            //var coorDinates = new List<List<int>> { new List<int> { 3, 3 }, new List<int> { 5, -1 }, new List<int> { -2, 4 }, new List<int> { -2, 1 } };
            //k_Closest.GetKClosestPoints(coorDinates, 2);


            /*ASSIGNMENT 7*/
            //ThreePointsClosestSum pointsClosest = new ThreePointsClosestSum();
            //var arr6 = new List<int> { 1, 2, 3, 4 };
            //Console.WriteLine($"Closest Sum: {pointsClosest.GetThreePoints(arr6, 6)}");

            //Collinear collinear = new Collinear();
            //var points = new List<List<int>>() {
            //                                    new List<int>{ 1, 1},
            //                                    new List<int>{ 1, 4},
            //                                    new List<int>{ 1, 5 }
            //                                };
            //Console.WriteLine(collinear.CheckIfCollinear(points));

            //E_Commerce eCommerce = new E_Commerce();
            //var products = new List<string> { "yellowShirt", "redHat", "blackShirt", "bluePants", "redHat", "pinkHat", 
            //                                   "blackShirt", "yellowShirt", "greenPants", "greenPants", "greenPants"};
            //eCommerce.FeatureProduct(products);

            //E_Commerce_2 eCommerce2 = new E_Commerce_2();
            //eCommerce2.FeatureProduct(products);

            //SortTheAlmostSortedArray sortTheAlmostSorted = new SortTheAlmostSortedArray();
            //var arr6 = new List<int> { 1, 2, 3, 4, 10, 8, 9 };
            //sortTheAlmostSorted.InsertionSort(arr6);


            /* ASSIGNMENT 8 */
            // Sort Colors: Ques2
            //SortTheColors sortTheColors = new SortTheColors();
            //var colors = new List<int> { 2, 0, 2, 1, 1, 0 };
            //var ans = sortTheColors.Sort(colors);
            //foreach (var color in ans)
            //{
            //    Console.Write(color + ", ");
            //}

            // KthLargestOrSmallest
            //KthLargestOrSmallestSolver kthQuesSolver = new KthLargestOrSmallestSolver();
            //var nums = new List<int> { 40, 25, 68, 79, 52, 66, 89, 97 };

            //// KthSmallest - Ques1
            //kthQuesSolver.Solve(nums, 2, "KthSmallest");

            //// KthLargest - Ques3
            //kthQuesSolver = new KthLargestOrSmallestSolver();
            //kthQuesSolver.Solve(nums, 2, "KthLargest");

            // KthLargest - Ques1
            //KthLargestOrSmallest_2 kthLargestOrSmallest_2 = new KthLargestOrSmallest_2("KthSmallest"); 
            //var ans = kthLargestOrSmallest_2.GetKthLargestOrSmallest(nums, 2, 0, nums.Count - 1);
            //// KthSmallest - Ques3
            //kthLargestOrSmallest_2 = new KthLargestOrSmallest_2("KthLargest");
            //var ans2 = kthLargestOrSmallest_2.GetKthLargestOrSmallest(nums, 2, 0, nums.Count - 1);
            //Console.WriteLine($"KthSmallest element = {ans} and Kthlargest element = {ans2}");

            // Find Majority ELements: Q4
            //MajorityElement majorityElement = new MajorityElement();
            //var nums2 = new List<int> { 2, 1, 2, 1, 2, 1, 2 };
            ////var nums2 = new List<int> { 2, 2, 1, 1, 1, 2, 2 };
            //Console.WriteLine(majorityElement.GetTheMajorityElement(nums2));

            // Peak Element: Q5
            //PeakElement peakElement = new PeakElement();
            //var arr6 = new List<int> { 1, 2, 3, 1, 5, 4, 3, 2};
            //var arr6 = new List<int> { 5, 4, 3, 2, 1, 2, 3, 4 };
            //var arr6 = new List<int> { 1, 2, 3, 4, 1 };
            //var arr6 = new List<int> { 1, 2, 1, 4, 5, 6 };
            //Console.WriteLine(peakElement.GetPeakElement(arr6));


            /* ASSIGNMENT 9 */
            //CalculatePower calculatePower = new CalculatePower();
            //Console.WriteLine(calculatePower.Power(4, -3));

            //MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            //var n = new List<int> { -5, 3, 6, 12, 15}; // 1, 2, 3, 4, 7, 8, 9, 15
            //var m = new List<int> { -12, -10, -6, -3, 4, 10};
            ////Console.WriteLine(medianOfTwoSortedArrays.Median(n, m));
            //Console.WriteLine(medianOfTwoSortedArrays.Median_2(n, m));

            //DivideTwoIntegers divideTwoIntegers = new DivideTwoIntegers();
            ////Console.WriteLine(divideTwoIntegers.Divide(30, -5));
            //Console.WriteLine(divideTwoIntegers.Divide_2(30, -5));

            //MatrixMultiplication matrixMultiplication = new MatrixMultiplication();
            //StrassenMatrixMultiplication strassenMatrix = new StrassenMatrixMultiplication();
            //int[,] arrayA = { { 1, 1, 1, 1 },
            //            { 2, 2, 2, 2 },
            //            { 3, 3, 3, 3 },
            //            { 2, 2, 2, 2 } };

            //int[,] arrayB = { { 1, 1, 1, 1 },
            //            { 2, 2, 2, 2 },
            //            { 3, 3, 3, 3 },
            //            { 2, 2, 2, 2 } };
            //var n = arrayA.GetLength(0);
            ////var result = matrixMultiplication.Multiply(arrayA, arrayB, n);
            //var result = strassenMatrix.Strassen(arrayA, arrayB, n);
            //for (var row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)  // no. of columns = (arrayA.Length / arrayA.GetLength(0))
            //    {
            //        Console.Write(result[row, col] + ", ");
            //    }
            //    Console.WriteLine();
            //}

            //NumberOfInversions numberOfInversions = new NumberOfInversions();
            //var numbers = new List<int> { 70, 50, 60, 10, 20, 30, 80, 15};
            //Console.WriteLine(numberOfInversions.GetNumberOfInversion(numbers, 0, numbers.Count - 1));

            /* SINGLY LINKED LIST */
            //var sList = new SinglyLinkedList();
            /* Insertion at Begining */
            //sList.Prepend(50);
            //sList.Prepend(40);
            //sList.Prepend(30);
            //sList.Prepend(20);
            //sList.Prepend(10);

            /* Insertion at End */
            //sList.Append(50);
            //sList.Append(40);
            //sList.Append(30);
            //sList.Append(20);
            //sList.Append(10);

            /* Insert After given Node */
            //sList.InsertAfter(sList.First, 30);
            //sList.InsertAfter(sList.First, 20);
            //sList.InsertAfter(sList.First, 10);

            /* Printing all elments */
            //sList.Peek();

            /* Deletion at Begining */
            //sList.DeleteAtBegining();
            //sList.DeleteAtBegining();

            /* Deletion at End */
            //sList.Pop();
            //sList.Pop();

            /* Delete a given Node */
            //sList.Delete(sList.First.next.next);

            //Console.WriteLine("Linked List after deletion: ");
            //sList.Peek();

            /* ASSIGNMENT 10 */
            //ReverseTheLinkedList reverseTheLinkedList = new ReverseTheLinkedList();
            //var list = new List<int> { 10, 20, 30, 40, 50, 150, 250 };
            //reverseTheLinkedList.Reverse(list);

            //DetectCycleInLinkedList linkedList = new DetectCycleInLinkedList();
            //linkedList.InsertAtEnd(10);
            //linkedList.InsertAtEnd(20);
            //linkedList.InsertAtEnd(30);
            //linkedList.InsertAtEnd(40);
            //linkedList.head.next.next.next = linkedList.head; // making last node to point first
            //Console.WriteLine(linkedList.CheckIfCycleExists());
            //Console.WriteLine(linkedList.CheckIfCycleExists_2());

            //CircularLinkedList circularLinkedList = new CircularLinkedList();
            //circularLinkedList.Append(10);
            //circularLinkedList.Append(20);
            //circularLinkedList.Append(30);
            //circularLinkedList.Append(40);
            //circularLinkedList.Peek();
            //circularLinkedList.Peek_2();

            PalindromeLinkedList palindromeLinkedList = new PalindromeLinkedList();
            //palindromeLinkedList.Append(1);
            //palindromeLinkedList.Append(2);
            //palindromeLinkedList.Append(3);
            //palindromeLinkedList.Append(4);
            //palindromeLinkedList.Append(5);
            //palindromeLinkedList.Append(6);
            //palindromeLinkedList.Append(5);
            //palindromeLinkedList.Append(4);
            //palindromeLinkedList.Append(3);
            //palindromeLinkedList.Append(2);
            //palindromeLinkedList.Append(1);
            //var count = 0;
            //Random random = new Random();
            //while (count < 1000)
            //{
            //    //var data = random.Next(0, 10);
            //    int data = 0;
            //    if (count <  250)
            //    {
            //        data = 1;
            //    }
            //    else if (count > 740)
            //    {
            //        data = 1;
            //    }
            //    else
            //    {
            //        data = 0;
            //    }
            //    palindromeLinkedList.Append(data);
            //    count++;
            //}
            //Console.WriteLine(palindromeLinkedList.IsPalindrome()); // completed
            ////Console.WriteLine(palindromeLinkedList.IsPalindrome_2());  // incomplete

            //SortLinkedList sortLinkedList = new SortLinkedList();
            //sortLinkedList.Append(1);
            //sortLinkedList.Append(1);
            //sortLinkedList.Append(0);
            //sortLinkedList.Append(1);
            //sortLinkedList.Append(0);
            //sortLinkedList.Append(2);
            //sortLinkedList.Append(2);
            //sortLinkedList.Append(0);
            //sortLinkedList.Append(2);
            //sortLinkedList.Append(0);
            //sortLinkedList.Append(0);
            //sortLinkedList.Sort();
            //sortLinkedList.Print();

            //RemoveNthNodeFromLast removeNthNode = new RemoveNthNodeFromLast();
            //removeNthNode.Append(1);
            //removeNthNode.Append(2);
            //removeNthNode.Append(3);
            //removeNthNode.Append(4);
            //removeNthNode.Append(5);
            //removeNthNode.DeleteNthNodeFromLast(3);

            /* ASSIGNMENT - 11 */
            //StackUsingQueue stackUsingQueue = new StackUsingQueue();
            //stackUsingQueue.Push(1);
            //stackUsingQueue.Push(2);
            //stackUsingQueue.Push(3);
            //stackUsingQueue.Push(4);
            //stackUsingQueue.Top();
            //stackUsingQueue.Pop();
            //stackUsingQueue.Pop();
            //stackUsingQueue.Empty();

            QueueUsingStack queueUsingStack = new QueueUsingStack();
            queueUsingStack.Enqueue(1);
            queueUsingStack.Enqueue(2);
            queueUsingStack.Enqueue(3);
            queueUsingStack.Enqueue(4);
            queueUsingStack.Enqueue(5);
            var p1 = queueUsingStack.Peek();
            queueUsingStack.Dequeue();
            queueUsingStack.Dequeue();
            queueUsingStack.Enqueue(10);
            queueUsingStack.Dequeue();
            queueUsingStack.Empty();
            var p2 = queueUsingStack.Peek();

            Console.ReadKey();
        }
    }
}
