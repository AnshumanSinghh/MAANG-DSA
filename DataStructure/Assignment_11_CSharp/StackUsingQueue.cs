using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_11_CSharp
{
    /*
     * Time Complexity: O(N)
     * Space Complexity: O(N) [using only one Queue]
     */
    class StackUsingQueue
    {
        Queue<int> queue_1 = new Queue<int>();

        public void Push(int data)
        {
            queue_1.Enqueue(data);
            Console.WriteLine($"Pushed: {data}");

            var count = queue_1.Count - 1;
            for (int i = 0; i < count; i++)
            {
                var first = queue_1.Dequeue();
                queue_1.Enqueue(first);
            }
        }

        public int Pop()
        {
            var last = queue_1.Dequeue();
            Console.WriteLine($"Popped: {last}");
            return last;
        }

        public int Top()
        {
            var top = queue_1.Peek();
            Console.WriteLine($"Top element is: {top}");
            return top;
        }

        public bool Empty()
        {
            var isEmpty = queue_1.Count == 0;
            Console.WriteLine($"Is Empty: {isEmpty}");
            return isEmpty;
        }
    }
}
