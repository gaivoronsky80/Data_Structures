using System;

namespace Singly_Linked_List
{
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList()
        {
            Head = null;
        }
        public void Add(int value)
        {
            SllNode newNode = new SllNode(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                SllNode runner = Head;
                while (runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }

        public void Remove()
        {
            SllNode runner = Head;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner = null;
        }
        public void PrintValues()
        {
            SllNode runner = Head;
            while (runner.Next != null)
            {
                Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
            Console.WriteLine(runner.Value);
        }
        public void Find(int num)
        {
            SllNode runner = Head;
            int counter = 0;
            while (runner.Value != num)
            {
                if (runner.Next == null)
                {
                    Console.WriteLine($"The number { num } does not exist in your list.");
                    return;
                }
                else
                {
                    runner = runner.Next;
                    counter += 1;
                }
            }
            Console.WriteLine($"The number { num } was found at index { counter }!");
        }
        public void RemoveAt(int num)
        {
            int counter = 0;
            SllNode runner = Head;
            if (num == 0)
            {
                Head = runner.Next;
                return;
            }
            while (counter != num -1)
            {
                if (runner.Next == null)
                {
                    Console.WriteLine("Index is out of list bounds.");
                    return;
                }
                counter++;
                runner = runner.Next;
            }
            runner.Next = runner.Next.Next;
        }
    }
}