using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_generic_classess
{
    class linkedList_1<T>
    {
        class LinkedNode
        {
            private LinkedNode next;
            private T data;

            public LinkedNode(T t)
            {
                next = null;
                data = t;

            }
            public LinkedNode Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public T Data

            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }
        }
        private LinkedNode head;
        public linkedList_1()
        {
            head = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedNode current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        }
        public void AddNode(T t)
        {
            LinkedNode node = new LinkedNode(t);
            node.Next = head;
            head = node;
        }
        

    }

}
