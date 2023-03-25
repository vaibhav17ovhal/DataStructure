using DataStructure;
using System;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure");
            //xLinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
            //LinkedList.Add(30);
            //linkedList.Add(70);
            //linkedList.Display();

            //linkedList.AddInReverseOrder(70);
            //linkedList.AddInReverseOrder(30);
            //linkedList.AddInReverseOrder(56);
            //linkedList.Display();

            //linkedList.InsertAtParticularPosition(1,30);
            //linkedList.Display();

            //linkedList.RemoveFirstNode();
            //linkedList.Display();

            //linkedList.RemoveLastNode();
            //linkedList.Display();

            //linkedList.Search(30);
            //linkedList.Display();

            //int position = linkedList.Search(30);
            //linkedList.InsertAtParticularPosition(position + 1 , 40);
            //linkedList.Display();
            //Console.WriteLine();
            //int searchDelete = linkedList.Search(40);
            //linkedList.DeleteNodeAtParticularPosition(searchDelete);
            //linkedList.Display();

            //LinkedListStack stack = new LinkedListStack();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);
            //stack.Display();

            //stack.Peak();
            //stack.Pop();
            //stack.Display();

            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
