
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedListQueue2<T>
    {
        Node2<T> head = null;
        public void Enqueue(T data)
        {
            Node2<T> node = new Node2<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node2<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        public void Display()
        {
            Node2<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public int Size()
        {
            Node2<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            return count;
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty, Deletion is not possible");
                return;
            }
            else
            {
                Console.WriteLine("Value Dequeued is {0}", this.head.data);
                this.head = this.head.next;
            }
        }
    }
}

