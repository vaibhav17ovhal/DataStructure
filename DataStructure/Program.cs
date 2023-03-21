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
            //linkedList.Add(30);
            linkedList.Add(70);
            //linkedList.Display();

            //linkedList.AddInReverseOrder(70);
            //linkedList.AddInReverseOrder(30);
            //linkedList.AddInReverseOrder(56);
            //linkedList.Display();

            linkedList.InsertAtParticularPosition(1,30);
            linkedList.Display();
        }
    }
}
