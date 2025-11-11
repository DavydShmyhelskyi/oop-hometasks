using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.CustomCollections.Interfaces
{
    public interface ILinkedList<T> : ILinkedListOperations<T>, IEnumerable<T>
    {
        int Count { get; }
        ILinkedListNode<T>? First { get; }
        ILinkedListNode<T>? Last { get; }
    }
}
