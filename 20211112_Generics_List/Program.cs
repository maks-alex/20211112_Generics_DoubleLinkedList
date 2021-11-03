using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211112_Generics_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Создать обобщенный класс двунаправленного списка (List).
Для класса List реализовать следующие методы:
▪ добавление элемента в конец списка;                   +
▪ добавление элемента в указанную позицию;              +
▪ добавление диапазона элементов в указанную позицию;
▪ удаление элемента с начала списка;                    +
▪ удаление элемента из указанной позиции;               +
▪ удаление диапазона элементов из указанной позиции;
▪ вывод на экран содержимого списка;                    + 
             */

            MyList<int> list = new MyList<int>();
            
            Console.WriteLine("\nPushBack");
            list.PushBack(3);
            list.PushBack(4);
            list.PushBack(5);
            list.PushBack(6);
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();
           
            Console.WriteLine("\nPushFront");
            list.PushFront(2);
            list.PushFront(1);
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();

            Console.WriteLine("\nPopFront");
            list.PopFront();
            list.PopFront();
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();
            //to check correctness of last element removing
            //list.PopFront();
            //list.PopFront();
            //list.PopFront();
            //list.PopFront();
            //list.PrintForward();
            //list.PrintBackward();

            Console.WriteLine("\nPopBack");
            list.PopBack();
            list.PopBack();
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();
            //to check correctness of last element removing
            //list.PopBack();
            //list.PrintForward();
            //list.PrintBackward();
            //list.PopBack();
            //list.PrintForward();
            //list.PrintBackward();

            Console.WriteLine();
            Console.WriteLine("\nAdd elements 6, 7");
            list.PushBack(6);
            list.PushBack(7);
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();

            Console.WriteLine("\nInsert");
            Console.WriteLine("\nInsert one element > list.Insert(5, 2);");
            list.Insert(5, 2);
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();
            Console.WriteLine("\nInsert one element > list.Insert(2, 0);");
            list.Insert(2, 0);
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();
            Console.WriteLine("\nInsert one element > list.Insert(8, 6);");
            list.Insert(8, 6);
            Console.WriteLine($"Size = {list.Size}");
            list.PrintForward();
            list.PrintBackward();

            Console.WriteLine("\nRemove");
            Console.WriteLine("\nRemove one element > list.Remove(0);");
            list.Remove(0);
            list.PrintForward();
            list.PrintBackward();

            Console.WriteLine("\nRemove one element > list.Remove(6);");
            list.Remove(6);
            list.PrintForward();
            list.PrintBackward();

            Console.WriteLine("\nRemove one element > list.Remove(2);");
            list.Remove(2);
            list.PrintForward();
            list.PrintBackward();




            Console.WriteLine();
        }
    }
}
