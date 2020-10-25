using System;
using System.Collections.Generic;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkList Data-Struture");
            LinkedList list = new LinkedList();
            list.Add1(56);
            list.Add1(30);
            list.Add1(70);
            list.Display();
            list = new LinkedList();
            list.Add2(70);
            list.Add2(30);
            list.Add2(56);
            list.Display();
            list = new LinkedList();
            list.Add1(56);
            list.Add1(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
            Console.WriteLine("First element popped out of the Linked List- " + list.RemoveFirstNode().data);
            list.Display();
        }
    }
}
