using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Node
    {
        public string Value { get; set; }
        public List<Edge> Edges { get; set; } //исходящие связи
        public bool IsChecked = false; // Маркер для обхода
        
        public Node (string value)
        {
            Value = value;
            Edges = new List<Edge>();
        }
        
        private void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }

        public void AddEdge(Node node, int edgeWeight)
        {
            AddEdge(new Edge(node, edgeWeight));
        }

        public override string ToString() => Value;
    }
}
