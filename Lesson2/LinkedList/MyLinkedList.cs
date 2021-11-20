using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class MyLinkedList : ILinkedList
    {
        public Node StartNode { get; set; }
        
        public Node EndNode { get; set; }

        public void AddNode(int value)
        {
            var node = new Node() { Value = value, };
            if (StartNode == null)
            {
                StartNode = node;
            }
            else
            {
                EndNode.NextNode = node;
                node.PrevNode = EndNode;
            }
            EndNode = node;
        }

        public Node FindNode(int searchValue)
        {
            Node currentNode = StartNode;
            if (currentNode.Value == searchValue)
            {
                return currentNode;
            }
            else
            {
                while(currentNode.Value != searchValue)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node() { Value = value, };
            newNode.PrevNode = node;
            newNode.NextNode = node.NextNode;
            node.NextNode.PrevNode = newNode;
            node.NextNode = newNode;
        }

        public int GetCount()
        {
            Node currentNode = StartNode;
            int cnt = 1;
            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
                cnt++;
            }
            return cnt;
        }

        public void RemoveNode(int index)
        {
            Node currentNode = StartNode;
            int cnt = 1;
            while (cnt < index)
            {
                currentNode = currentNode.NextNode;
                cnt++;
            }
            this.RemoveNode(currentNode);
        }

        public void RemoveNode(Node node)
        {
            if (node.PrevNode == null)
            {
                node.NextNode.PrevNode = null;
                StartNode = node.NextNode;
            }
            else if (node.NextNode == null)
            {
                node.PrevNode.NextNode = null;
                EndNode= node.PrevNode;
            }
            else
            {
                node.NextNode.PrevNode = node.PrevNode;
                node.PrevNode.NextNode = node.NextNode;
            }
        }
    }
}
