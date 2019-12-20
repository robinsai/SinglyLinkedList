﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    class Node<T>
    {
        public T Value;

        public Node<T> Next;
        public Node(T value) 
        {
            Value = value;
        }
        public Node(T value, Node<T> next) 
        {
            Value = value;
            Next = next; 
        }
    }
}
