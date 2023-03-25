using DataStructure;
using System;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();

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

            int position = linkedList.Search(30);
            linkedList.InsertAtParticularPosition(position + 1 , 40);
            linkedList.Display();
            Console.WriteLine();
            int searchDelete = linkedList.Search(40);
            linkedList.DeleteNodeAtParticularPosition(searchDelete);
            linkedList.Display();
        }
    }
}
