using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head=newNode;
            }
            else
            {
                Node lastNode=GetLastNode();
                lastNode.next=newNode;
                newNode.next=null;
                //newNode=lastNode;
            }
        }

        private Node GetLastNode()
        {
            Node tempHead = head;
            while (tempHead.next != null)
            {
                tempHead = tempHead.next;
            }
            return tempHead;
        }

        public void Display()
        {
            Console.WriteLine("\nDisplaying added nodes");
            Node temp=this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write("" + temp.data + "->");
                    temp=temp.next;
                }
            }
        }

        public void AddFirst(int data)   //append and add at last is the same
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head=newNode;
        }

        public void Append(int data)
        {
            AddLast(data);
        }

        public void DeleteFirstNode()        //delete the first node
        {
            if(head==null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                int deletedNode = head.data;
                head = head.next;
                Console.WriteLine("\n{0} is deleted from list", deletedNode);
            }
        }

        public void DeleteLastNode()
        {
            Node newNode = head;
            if (newNode == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else if (newNode.next == null)
            {
                Console.WriteLine("\n{0} is deleted from list and the list is now empty", newNode.data);
                newNode = null;
            }
            else
            {

                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
            }
                
        }
        public void Search(int value)
        {
            int count=0;
            Node temp=head;
            while(temp!=null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("The value is at the {0} position.",count+1);
                    break;
                }
                else
                {
                    count++;
                    temp = temp.next;
                }
            }
        }

        public void Order()
        {
            Node temp = this.head;
            Console.WriteLine("\nThe value is at the {0} position.", this.head.data);
            Node move = null;
            while (temp.next != null)
            {
                move=temp.next;
                while (move.next != null)
                {
                    if (temp.data > move.data)
                    {
                        int swap = temp.data;
                        temp.data = move.data;
                        move.data = swap;
                    }
                    move = move.next;
                }
                temp=temp.next;
            }
        }
    }
}
