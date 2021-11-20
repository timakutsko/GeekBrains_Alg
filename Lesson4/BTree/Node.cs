using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    class Node
    {
        public int Value { get; set; }
        public Node RightChild { get; set; }
        public Node LeftChild { get; set; }
        public Node Root { get; set; }
        
        public Node (int v)
        {
            Value = v;
        }

        public Node Insert(Node nd, int v)
        {
            /*
            Node insert(x : Node, z : T):
                if x == null
                    return Node(z)                        // подвесим Node с key = z
                else if z < x.key
                    x.left = insert(x.left, z)
                else if z > x.key
                    x.right = insert(x.right, z)
                return x
            */
            if (nd == null)
            {
                return new Node(v);
            }
            else if (v < nd.Value)
            {
                nd.LeftChild = Insert(nd, v);
            }
            else if (v > nd.Value)
            {
                nd.RightChild = Insert(nd, v);
            }
            return nd;

        }
    }

}
