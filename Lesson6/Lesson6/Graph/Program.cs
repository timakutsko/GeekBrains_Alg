using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");

            graph.AddEdge("A", "B", 10);
            graph.AddEdge("A", "C", 5);
            graph.AddEdge("B", "C", 1);
            graph.AddEdge("C", "D", 3);
            graph.AddEdge("C", "E", 7);
            graph.AddEdge("E", "F", 3);

            Console.WriteLine("BFS result:");
            graph.BFS_OrederTraves("F");
            graph.ResetIsChecker();
            Console.WriteLine(new string('\uFF3F', Console.WindowWidth));
            Console.WriteLine("DFS result:");
            graph.DFS_OrederTraves("F");

        }
    }
}
