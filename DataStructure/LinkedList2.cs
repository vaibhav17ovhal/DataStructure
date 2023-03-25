﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList2<T>
    {
        public Node2<T> head;
        public void Add(T data)
        {
            Node2<T> node = new Node2<T>(data);
            if (this.head == null)
            {
                this.head = node;
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void AddInReverseOrder(T data)
        {
            Node2<T> newNode = new Node2<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node2<T> temp = this.head;
                head = newNode;
                head.next = temp;
            }
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
        public void InsertAtParticularPosition(int position, T data)
        {
            Node2<T> newestNode = new Node2<T>(data);
            if (this.head == null)
            {
                this.head = newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return;
            }
            Node2<T> previous = null;
            Node2<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                previous = current;
                current = current.next;
                count++;
            }
            newestNode.next = previous.next;
            previous.next = newestNode;
        }
        public void RemoveFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            this.head = this.head.next;
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            if (head.next == null)
            {
                this.head = null;
            }
            Node2<T> NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
        }
        public int Search(T value)
        {
            Node2<T> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    Console.WriteLine(count + " position");
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Node2<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            Node2<T> next = temp.next;
            temp.next = next;
            //Size();
        }
        public void Size()
        {
            Node2<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of the Linked List is: " + count);
        }

    }
}

