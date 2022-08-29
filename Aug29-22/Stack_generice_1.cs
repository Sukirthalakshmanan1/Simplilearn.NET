using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_generic_classess
{
    class UserStack<T>
    {
        internal static readonly int max = 1000;
        T[] stack = new T[max];
        int top;

        internal bool isStackEmpty()
        {

            return (top < 0);
        }

        public UserStack()
        {
            top = -1;
        }

        public void Push(T data)
        {
            if (top >= max)
            {
                Console.WriteLine("No space on the stack");
                return;
            }
            else
            {
                stack[++top] = data;

            }
        }

        public void Pop()
        {
            //int value = 0;
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                T value = stack[top--];
                Console.WriteLine(value);
            }
        }
        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                T value = stack[top];
                Console.WriteLine(value);
            }
        }

        internal void PrintStackElements()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
