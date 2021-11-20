using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var LList = new MyLinkedList();
            LList.AddNode(1);
            LList.AddNode(2);
            LList.AddNode(5);
            LList.AddNode(10);
            Console.WriteLine(LList.GetCount());
            var findNode = LList.FindNode(5);
            LList.AddNodeAfter(findNode, 7);
            Console.WriteLine(LList.GetCount());
            var removeNode = LList.FindNode(5);
            LList.RemoveNode(removeNode);
            Console.WriteLine(LList.GetCount());
            LList.RemoveNode(1);
            Console.WriteLine(LList.GetCount());
        }
    }
}
