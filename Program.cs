using System;

namespace Stacks_Queque_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("-----Welcome To The Stacks And Queues Program-----");
            Console.WriteLine("----------------------------------------");
          /*  
           //Calling Class and Adding Data in Stack
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.WriteLine("--------------------------------------");

            //Peek Value from Stack
            linkedListStack.Peek();
            Console.WriteLine("----------------------------");
            linkedListStack.Pop();
            //Pop value till Stack will empty
            linkedListStack.IsEmpty();
            */

            //Calling Class and Adding Data in Queue
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("----------------");
            //Display Queue
            linkedListQueue.Display();

            //Dequeue from queue
            linkedListQueue.Dequeue();
            //Empty Dequeue
            linkedListQueue.IsEmpty();
            //Display Queue
            linkedListQueue.Display();
            Console.WriteLine("----------------");

            Console.ReadLine();
        }
    }
}
