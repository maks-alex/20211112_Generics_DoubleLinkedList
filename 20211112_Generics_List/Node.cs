using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211112_Generics_List
{
    public class Node<T>
    {
        public Node<T> _prev = null;
        public T _data;
        public Node<T> _next = null;

        public Node<T> Prev { get => _prev; set => _prev = value; }
        public T Data { get => _data; set => _data = value; }
        public Node<T> Next { get => _next; set => _next = value; }
        public Node (T data)
        {
            _data = data;
        }
    }
}
