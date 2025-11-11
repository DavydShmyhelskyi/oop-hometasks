using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.CustomCollections.Interfaces
{
    public interface ILinkedListNode<T>
    {
        T Value { get; set; }
        ILinkedListNode<T>? Next { get; }
        ILinkedListNode<T>? Previous { get; }
    }
}
