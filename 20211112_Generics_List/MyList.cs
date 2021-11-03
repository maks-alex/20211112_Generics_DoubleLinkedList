using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211112_Generics_List
{
    public sealed class MyList<T>
    {
        private Node<T> _head = null;
        private Node<T> _tail = null;
        private int _size = 0;

        protected int Size { get => _size; set => _size = value; }
        protected int Head { get => _size; set => _size = value; }
        public MyList()
        { }

        //вывод на экран содержимого списка PrintForward;
        public void PrintForward()
        {
            Node<T> tmp = _head;
            Console.Write("PrintForward : ");
            while (tmp != null)
            {
                Console.Write($"{tmp.Data} ");
                tmp = tmp.Next;
            }
            Console.WriteLine();
        }

        //вывод на экран содержимого списка PrintBackward;
        public void PrintBackward()
        {
            Node<T> tmp = _tail;
            Console.Write("PrintBackward: ");
            while (tmp != null)
            {
                Console.Write($"{tmp.Data} ");
                tmp = tmp.Prev;
            }
            Console.WriteLine();
        }

        //добавление элемента в конец списка;
        public void PushBack(T val)
        {
            Node<T> tmp = new Node<T>(val);
            if (_size == 0)
            {
                _head = tmp;
                _tail = tmp;
            }
            else
            {
                tmp.Prev = _tail;
                _tail.Next = tmp;
                _tail = tmp;
            }
            _size++;
        }

        //добавление элемента в начало списка;
        public void PushFront(T val)
        {
            Node<T> tmp = new Node<T>(val);
            if (_size == 0)
            {
                _head = tmp;
                _tail = tmp;
            }
            else
            {
                tmp.Next = _head;
                _head.Prev = tmp;
                _head = tmp;
            }
            _size++;
        }
        
        //удаление элемента с начала списка;
        public void PopFront()
        {
            if (_size == 0)
            {
                return;
            }
            else if (_size == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node<T> tmp = _head;
                _head = tmp.Next;
                _head.Prev = null;
                tmp.Next = null;
            }
            _size--;
        }

        //удаление элемента с конца списка;
        public void PopBack()
        {
            if (_size == 0)
            {
                return;
            }
            else if (_size == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node<T> tmp = _tail;
                _tail = tmp.Prev;
                _tail.Next = null;
                tmp.Prev = null;
            }
            _size--;
        }

        //добавление элемента в указанную позицию;
        public void Insert (T val, int pos)
        {
            if (pos < 0 || pos > _size)
            {
                return;
            }
            else if (pos == 0)
            {
                PushFront(val);
            }
            else if (pos == _size)
            {
                PushBack(val);
            }
            else
            {
                Node<T> tmp = new Node<T>(val);
                Node<T> cur = _head;
                for (int i = 0; i < pos - 1; i++)
                {
                    cur = cur.Next;
                }
                tmp.Next = cur.Next;
                tmp.Prev = cur;
                cur.Next.Prev = tmp;
                cur.Next = tmp;
                _size++;
            }

        }

        //добавление диапазона элементов в указанную позицию;
        public void InsertList(MyList<T> list, int pos)
        {
            int listSize = list.Size;



        }

        //удаление элемента из указанной позиции;
        public void Remove (int pos)
        {
            if (pos < 0 || pos > _size)
            {
                return;
            }
            else if (pos == 0)
            {
                PopFront();
            }
            else if (pos == _size)
            {
                PopBack();
            }
            else
            {
                Node<T> cur = _head;
                for (int i = 0; i < pos - 1; i++)
                {
                    cur = cur.Next;
                }
                Node<T> tmp = cur.Next;
                cur.Next = tmp.Next;
                tmp.Next.Prev = cur;
                tmp.Next = null;
                tmp.Prev = null;
            }
        }





    }
}
