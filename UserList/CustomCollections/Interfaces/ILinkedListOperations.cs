using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.CustomCollections.Interfaces
{
    public interface ILinkedListOperations<T>
    {
        void AddFirst(T value);
        void AddLast(T value);
        bool Remove(T value);
        void RemoveFirst();
        void RemoveLast();
        void Clear();

        bool Contains(T value);
        ILinkedListNode<T>? Find(T value);
        ILinkedListNode<T>? FindLast(T value);
    }
}
