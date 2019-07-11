using System;

namespace Singly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.Add(5);
            myList.Add(10);
            myList.Add(117);
            // myList.Find(100);
            // myList.Find(117);
            myList.RemoveAt(1);
            myList.Find(10);
            myList.PrintValues();
        }
    }
}
