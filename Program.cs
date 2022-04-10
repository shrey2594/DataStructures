using System;
using System.Collections;


namespace DataStructureDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();
            linkedList.Append(56);    //Append is same as AddLast
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
            linkedList.Order();
            linkedList.Display();
            //linkedList.AddLast(56);
            //linkedList.AddLast(30);
            //linkedList.AddLast(76);
            //linkedList.Display();
            //linkedList.AddFirst(30);
            //linkedList.AddFirst(56);
            //linkedList.AddFirst(76);
            //linkedList.Display();
            //linkedList.DeleteFirstNode();
            //linkedList.Display();
        }
        
    }
}