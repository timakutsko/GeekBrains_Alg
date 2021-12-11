using System;

namespace BTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            var arrInt = new int[] { 50, 20, 8, 21, 22, 10, 11, 7, 55, 65, 59, 66};
            foreach(int i in arrInt)
            {
                binaryTree.Add(i);
            }
            var a = binaryTree.Find(6);
            var b = binaryTree.Find(100);
            binaryTree.Remove(8);
            binaryTree.Remove(100);
            binaryTree.Print(binaryTree.Root, " ");
        }
    }
}
