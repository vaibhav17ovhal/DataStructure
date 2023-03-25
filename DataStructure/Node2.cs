using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node2<T>
    {
        public T data;
        public Node2<T> next;
        public Node2(T value)
        {
            this.data = value;
        }
    }
}


