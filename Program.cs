using System;

namespace MyStackGenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <string> myStack = new Stack <string> ();
            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");

            string item1 = myStack.Pop();
            string item2 = myStack.Peek();

            myStack.Clear();

            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.ReadLine();
        }
    }
}
