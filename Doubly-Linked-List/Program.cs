using System;

namespace Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList myList = new DoublyLinkedList();
            myList.Add(5);
            myList.Add(24);
            myList.Add(100);
            myList.Add(53);
            Console.WriteLine(myList.Remove(53));
            myList.PrintValues();
        }
    }
}
