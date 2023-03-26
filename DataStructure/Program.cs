using DataStructure;
using DelegatesAndEvents;
using System;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure");
            //LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
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

            //LinkedListQueue queue = new LinkedListQueue();
            //queue.Enqueue(56);
            //queue.Enqueue(30);
            //queue.Enqueue(70);
            //queue.Display();

            //queue.Dequeue();
            //queue.Display();

            //LinkedListOperation operation = new LinkedListOperation();
            //operation.ReadFile2("C:\\Users\\Dell\\Desktop\\BL Exercise\\DataStructure\\DataStructure\\ABC.txt");

            //BinarySearch search = new BinarySearch();
            //search.ReadFile("C:\\Users\\Dell\\Desktop\\BL Exercise\\DataStructure\\DataStructure\\ABC.txt");

            InsertionSort sort1 = new InsertionSort();
            sort1.ReadFile1("C:\\Users\\Dell\\Desktop\\BL Exercise\\DataStructure\\DataStructure\\ABC.txt");
        }
    }
}
