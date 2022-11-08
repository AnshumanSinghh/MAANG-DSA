using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_11_CSharp
{
    class QueueUsingStack
    {
        Stack<int?> Input = new Stack<int?>();
        Stack<int?> Output = new Stack<int?>();
        /*
         * Enqueue:
         * Time Complexity: O(1)
         * 
         * Dequeue and Peek:
         * Time Complexity: O(N) only once, after that O(1) [as we are pushing all elements from Input to Output once]
         * OR better say Amortized O(1)
         * 
         * Space Complexity: O(2N) fro all.
         * 
         * Intuition: Push all data in Input Stack. While Deleting for first time push all elements from Input
         * to Output. Now, we will have data in Output in reverse order. So, pop() from end will give actual
         * element which was added at first (will follow FIFO).
         */
        public void Enqueue(int data)
        {
            Input.Push(data);
            Console.WriteLine($"Pushed: {data}");
        }

        public int? Dequeue()
        {
            if (Output.Count == 0)  // if Output Stack is empty
            {
                Peek(); // calling Peek() will add elements to Output Stack
            }
            var first = Output.Count == 0 ? null : Output.Pop();
            Console.WriteLine($"Dequeue: {first}");
            return first;
        }

        public int? Peek()
        {
            if (Output.Count == 0)
            {
                var c = Input.Count;
                while (c > 0)
                {
                    var last = Input.Pop();
                    Output.Push(last);
                    c--;
                }
            }
            var first = Output.Count == 0 ? null : Output.Peek();
            Console.WriteLine($"Peek: {first}");
            return first;
        }

        public bool Empty()
        {
            var isEmpty = (Input.Count + Output.Count) == 0;
            Console.WriteLine($"Is Empty: {isEmpty}");
            return isEmpty;
        }
    }
}
