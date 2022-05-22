using System;

namespace Stacks_Queque_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("-----Welcome To The Stacks And Queues Program-----");
            //Calling Class and Adding Data in Stack
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            //Display Message
            linkedListStack.Display();
            Console.ReadLine();
        }
    }
}
