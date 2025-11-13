using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.CustomCollections.Interfaces;

namespace UserList.CustomCollections.Inplemetnation
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private LinkedListNode<T>? head;
        private LinkedListNode<T>? tail;
        private readonly IEqualityComparer<T> comparer;

        public LinkedList(IEqualityComparer<T>? comparer = null)
        {
            this.comparer = comparer ?? EqualityComparer<T>.Default;
        }

        public int Count { get; private set; }
        public ILinkedListNode<T>? First => head;
        public ILinkedListNode<T>? Last => tail;

        public void AddFirst(T value)
        {
            var node = new LinkedListNode<T>(value);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.Next = head;
                head.Previous = node;
                head = node;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            var node = new LinkedListNode<T>(value);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }
            Count++;
        }

        public void Clear()
        {
            head = tail = null;
            Count = 0;
        }

        public bool Contains(T value) => Find(value) != null;

        public ILinkedListNode<T>? Find(T value)
        {
            var current = head;
            while (current != null)
            {
                if (comparer.Equals(current.Value, value))
                    return current;
                current = (LinkedListNode<T>?)current.Next;
            }
            return null;
        }

        public ILinkedListNode<T>? FindLast(T value)
        {
            var current = tail;
            while (current != null)
            {
                if (comparer.Equals(current.Value, value))
                    return current;
                current = (LinkedListNode<T>?)current.Previous;
            }
            return null;
        }

        public bool Remove(T value)
        {
            var node = Find(value) as LinkedListNode<T>;
            if (node == null) return false;

            RemoveNode(node);
            return true;
        }

        public void RemoveFirst()
        {
            if (head == null) return;

            if (head.Next != null)
                ((LinkedListNode<T>)head.Next).Previous = null;
            else
                tail = null;

            head = (LinkedListNode<T>?)head.Next;
            Count--;
        }

        public void RemoveLast()
        {
            if (tail == null) return;

            if (tail.Previous != null)
                ((LinkedListNode<T>)tail.Previous).Next = null;
            else
                head = null;

            tail = (LinkedListNode<T>?)tail.Previous;
            Count--;
        }

        private void RemoveNode(LinkedListNode<T> node)
        {
            if (node.Previous != null)
                ((LinkedListNode<T>)node.Previous).Next = node.Next;
            else
                head = (LinkedListNode<T>?)node.Next;

            if (node.Next != null)
                ((LinkedListNode<T>)node.Next).Previous = node.Previous;
            else
                tail = (LinkedListNode<T>?)node.Previous;

            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = (LinkedListNode<T>?)current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
