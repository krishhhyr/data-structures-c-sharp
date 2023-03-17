using System.Collections;

namespace Queues
{
    internal class Program
    {
        // Used to emulate a queue with an array
        public static int[] queue = new int[5];
        public static int front = -1;
        public static int rear = -1;
        

        static void Main(string[] args)
        {
           
        }

        #region Linear-Queue
        // This adds an item to a linear queue
        static void Enqueue(int item) 
        {
            if ((front == -1) && (rear == -1))
            {
                front = 0; rear = 0;
                queue[rear] = item;
            }
            else 
            {
                int temp = rear + 1;
                if (temp == queue.Length)
                {
                    Console.WriteLine("Queue Full");
                }
                else 
                {
                    rear++;
                    queue[rear] = item;
                }
            }
                    
        }
        // This removes an item from a linear queue
        static void Dequeue(int item) 
        {
            // Checks if the queue is empty
            if ((front == -1) && (rear == -1))
            {
                Console.WriteLine("Queue Empty");
            }
            else 
            {
                item = queue[front];
                if (front == rear)
                {
                    front = -1; rear = -1;
                }
                else 
                {
                    front++;
                }
            }
        }
        #endregion
    }
}