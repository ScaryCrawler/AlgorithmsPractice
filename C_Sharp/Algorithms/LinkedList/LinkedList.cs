using System;

namespace LinkedList
{
    public class LinkedList<T>
    {
        internal class Node
        {
            public T Data { get; private set; }

            public Node Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node Head { get; set; }

        public void AddNode(T data)
        {
            if (Head == null)
            {
                Head = new Node(data);
                return;
            }
            
            var newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void PrintList() => PrintNode(Head);
        
        private void PrintNode(Node node)
        {
            Console.WriteLine(node.Data);
            
            if (node.Next != null)
                PrintNode(node.Next);
        }
    }
}