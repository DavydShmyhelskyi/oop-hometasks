using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.CustomCollections.Interfaces;

namespace UserList.CustomCollections.Core
{
    public class LinkedListNode<T> : ILinkedListNode<T>
    {
        public T Value { get; set; }
        public ILinkedListNode<T>? Next { get; internal set; }
        public ILinkedListNode<T>? Previous { get; internal set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}
