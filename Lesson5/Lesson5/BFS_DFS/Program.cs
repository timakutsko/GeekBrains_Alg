using System;

namespace BFS_DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create btree
            BinaryTree btree = new BinaryTree();
            int[] arr = new int[] { 50, 20, 8, 21, 22, 10, 11, 7, 55, 65, 59, 66 };
            foreach (int i in arr)
            {
                btree.Add(i);
            }
            // BFS_DFS finder
            var bfs_find = btree.BFS_Find(20);
            var dfs_find = btree.DFS_Find(66);

        }
    }
}
