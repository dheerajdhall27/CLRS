using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ElementaryDataStructures.LinkedLists;

internal class Node<T>
{
    public Node<T>? Previous { get; set; }

    public Node<T>? Next { get; set; }

    public T Value { get; set; }

    public Node(T value)
    {
        Previous = null;
        Next = null;
        this.Value = value;
    }

    public override string ToString()
    {
        if(Value == null)
        {
            return string.Empty;
        }

        return Value.ToString();
    }
}

