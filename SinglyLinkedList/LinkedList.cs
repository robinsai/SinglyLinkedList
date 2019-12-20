using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{

    class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        void nodeDoesntExist(Node<T> node)

        {
            if (Search(node) == null)
            {
                throw new Exception("node doesnt exist");

            }

        }
        public Node<T> Search(Node<T> nodeToLookFor)
        {
            Node<T> current = Head;
            bool nodeNotFound = false;
            while (current != null)
            {

                if (current == nodeToLookFor)
                {
                    return current;

                }
            }
            return current;
        }
        public int count { get; private set; }
        bool isItNull(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                return true;
            }
            else
            {
                return false;
            }
        }
        public LinkedList()
        {

        }
        public void AddFirst(T value)
        {
            if (isItNull(value)) { }

            else
            {
                Node<T> temp = Head;
                Head = new Node<T>(value, temp);
                //Head.Next = temp;
            }
            count++;
        }
        public void AddLast(T value)
        {

            if (isItNull(value)) { }

            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current = new Node<T>(value);
            }

        }
        public void AddBefore(Node<T> nodeBefore, T value)
        {
            nodeDoesntExist(nodeBefore);
            Node<T> newNode = new Node<T>(value);
            Node<T> current = Head;
            while (current.Next != nodeBefore)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }
        public void AddAfter(Node<T> nodeAfter, T value)
        {
            nodeDoesntExist(nodeAfter);
            Node<T> current = Head;
            Node<T> newNode = new Node<T>(value);
            while (current != nodeAfter)
            {
                current = current.Next;

            }
            newNode.Next = current.Next;
            current.Next = newNode;


        }
       public bool RemoveFirst()
        {

            if(Head == null)
            {
                return false;
            }
            else
            {
                Head.Next = Head;
                return true;
            }
        }
        public bool RemoveLast()
        {
          
            if (Head == null)
            {
                return false;
            }
            else
            {
                Node<T> current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }
                current = null;
                return true;
            }
        }
        //Remove
        //Clear
        //Contains;'
    }
}




