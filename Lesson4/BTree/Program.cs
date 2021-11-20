using System;

namespace BTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            var BTree = new Node(50);
            foreach(int i in array)
            {
                BTree = BTree.Insert(BTree, i);
            }
           

        }
    }
}
