using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.CustomCollections.Interfaces;

namespace UserList.CustomCollections.Inplemetnation
{
    public class LinkedListNode<T> : ILinkedListNode<T>
    {
        public T Value { get; set; }
        public ILinkedListNode<T>? Next { get; set; }
        public ILinkedListNode<T>? Previous { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}
