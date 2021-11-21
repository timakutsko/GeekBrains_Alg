using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_DFS
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public void Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
        }

        public Node BFS_Find(int value)
        {
            var bfs_queue = new Queue<Node>();
            Node root = this.Root;
            bfs_queue.Enqueue(root);
            
            while (bfs_queue.Count > 0)
            {
                var currentNode = bfs_queue.Dequeue();
                if (currentNode == null)
                {
                    continue;
                }
                bfs_queue.Enqueue(currentNode.LeftNode);
                bfs_queue.Enqueue(currentNode.RightNode);
                if (currentNode.Data == value) return currentNode;
            }
            return null;
        }

        public Node DFS_Find(int value)
        {
            var dfs_stack = new Stack<Node>();
            Node root = this.Root;
            dfs_stack.Push(root);

            while (dfs_stack.Count > 0)
            {
                var currentNode = dfs_stack.Pop();
                if (currentNode == null)
                {
                    continue;
                }
                dfs_stack.Push(currentNode.LeftNode);
                dfs_stack.Push(currentNode.RightNode);
                if (currentNode.Data == value) return currentNode;
            }
            return null;
        }
    }
}
