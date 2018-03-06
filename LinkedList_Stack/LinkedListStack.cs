/*
*****************************************
* LinkedListStack.cs           2018     *
*                                       *
* Simple example of Stack using         *
* LinkedList                            *
*                                       *
* Jason Thatcher                        *
*****************************************
*/

using System;

namespace LinkedList_Stack
{
    class LinkedListStack<T>
    {
        protected class Node
        {
            public Node next;
            public T value;
        }

        Node head;
        Node tail;

        public LinkedListStack()
        {

        }

        public void Push(T value)
        {
            Node n = new Node();
            n.value = value;
            
            if(IsEmpty())
            {
                head = n;
                head.next = tail;
            }
            else if(!IsEmpty() && tail == null)
            {
                head.next = n;
                tail = n;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
        }

        public T Pop()
        {
            Node temp = head;
            T result;

            if(head == null)
            {
                throw new LinkedListStackEmptyException("Cannot Pop(). Stack is empty");
            }

            else if (head.next == tail)
            {
                result = tail.value;
                head.next = null;
                tail = head;
            }
            else if(head.next == null)
            {
                result = head.value;
                head = null;
            }
            else
            {
                //find penultimate
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                result = temp.next.value;

                temp.next = null;
                tail = temp;
            }

            return result;          
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
