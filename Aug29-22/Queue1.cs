using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Custom_generic_classess
{
    
        public class Queue
        {
            private int front, rear, capacity;
            private int[] queue;

            public Queue(int c)
            {
                front = rear = 0;
                capacity = c;
                queue = new int[capacity];
            }

            
            public void queueEnqueue(int data)
            {
                
                if (capacity == rear)
                {
                    Console.Write("\nQueue is full\n");
                    return;
                }

                
                else
                {
                    queue[rear] = data;
                    rear++;
                Console.WriteLine("Added successfully !!");
                }
                return;
            }

           
            public void queueDequeue()
            {
               
                if (front == rear)
                {
                    Console.Write("\nQueue is empty\n");
                    return;
                }

              
                else
                {
                    for (int i = 0; i < rear - 1; i++)
                    {
                        queue[i] = queue[i + 1];
                    }

                   
                    if (rear < capacity)
                        queue[rear] = 0;

                    
                    rear--;
                Console.WriteLine("Dequeued Successfully !!");

            }
            return;
            }

            
            public void queueDisplay()
            {
                int i;
                if (front == rear)
                {
                    Console.Write("\nQueue is Empty\n");
                    return;
                }

                
                for (i = front; i < rear; i++)
                {
                    Console.Write(" {0}  ", queue[i]);
                }
                return;
            }

           
            public void queueFront()
            {
                if (front == rear)
                {
                    Console.Write("\nQueue is Empty\n");
                    return;
                }
                Console.Write("\nFront Element is: {0}", queue[front]);
                return;
            }
        }

   public class Queue1
    {

        
        public static void Main(String[] args)
            {
            Console.WriteLine("Enter no of elements to be in queue:");
            int n=Convert.ToInt32(Console.ReadLine());
            int a;
            Queue q = new Queue(n);
            char c;
            
            Console.WriteLine("Enter {0} elements:",n);
            for(int i = 0; i < n; i++)
            {
                 a=Convert.ToInt32(Console.ReadLine());  
                q.queueEnqueue(a);
            }
            Console.WriteLine("-----------------------------------");

            do
            {
                Console.WriteLine("Enter ur choice \n 1.Peek element \n 2.Enqueue \n 3.Dequeue \n 4.Display");
            int n1 = Convert.ToInt32(Console.ReadLine());
            
           
                switch (n1)
                {
                    case 1:
                        
                        q.queueFront();

                        break;
                    case 2:
                        Console.WriteLine("Enter element to add:");
                        a = Convert.ToInt32(Console.ReadLine());
                        q.queueEnqueue(a);
                        
                        break;
                       
                    case 3:
                        q.queueDequeue();
                        
                        Console.WriteLine("-----------------------------------");

                        Console.WriteLine("Displaying the queue:");

                        q.queueDisplay();
                        break;
                    case 4:
                        Console.WriteLine("Displaying the queue:");

                        q.queueDisplay();

                        break;

                }
                Console.WriteLine("\nDo u  want to continue press y or Y:");
                c = Convert.ToChar(Console.ReadLine());

            } while (c == 'Y' || c == 'y');
            Console.ReadKey();
        }
       
        }

        
    
}