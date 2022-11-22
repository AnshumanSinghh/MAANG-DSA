using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_12_CSharp
{
    class PostOrder
    {
        Node root;

        void PostOrderIterative()
        {
            if (root != null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();

            var curr = root;
            while (curr != null || stack.Count != 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

            }
        }
    }
}
