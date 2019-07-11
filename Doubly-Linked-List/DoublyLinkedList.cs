using System;

namespace Doubly_Linked_List
{
    public class DoublyLinkedList
    {
        public DllNode Head;
        public DoublyLinkedList()
        {
            Head = null;
        }
        public void Add(int value)
        {
            DllNode newNode = new DllNode(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                DllNode runner = Head;
                DllNode prev = Head;
                while (runner.Next != null)
                {
                    prev = runner;
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }
        public void PrintValues()
        {
            DllNode runner = Head;
            DllNode prev = Head;
            while (runner.Next != null)
            {
                Console.WriteLine(runner.Value);
                prev = runner;
                runner = runner.Next;
            }
            Console.WriteLine(runner.Value);
        }
        public bool Remove(int value)
        {
            DllNode runner = Head;
            int counter = 0;
            if (Head.Value == value && runner.Next != null)
            {
                Head = runner.Next;
                Console.WriteLine($"{ value } was removed from index { counter }");
                return true;
            }
            else if (Head.Value == value)
            {
                Head = null;
                Console.WriteLine($"{ value } was removed from index { counter }");
                return true;
            }
            while (runner.Next.Value != value)
            {
                if (runner.Next == null)
                {
                    Console.WriteLine("That number does not exist in your list.");
                    return false;
                }
                runner = runner.Next;
                counter++;
            }
            runner.Next = runner.Next.Next;
            Console.WriteLine($"{ value } was removed from index { counter + 1 }");
            return true;
        }
    }
}