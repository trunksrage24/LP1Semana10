using System;
using System.Collections.Generic;

namespace StringCollections
{
    /// <summary>
    /// class Program where all types of lists are made
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //list with List
            List<string> list = new List<string>();
            list.Add("Ola");
            list.Add("Bon Giorno");
            list.Add("Adeus");
            list.Add("Adeus");
            list.Add("Hello");

            Console.WriteLine("List: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //list with Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Ola");
            stack.Push("Bon Giorno");
            stack.Push("Adeus");
            stack.Push("Adeus");
            stack.Push("Hello");

            Console.WriteLine("Stack: ");
            while (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //list with Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ola");
            queue.Enqueue("Bon Giorno");
            queue.Enqueue("Adeus");
            queue.Enqueue("Adeus");
            queue.Enqueue("Hello");

            Console.WriteLine("Queue: ");
            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //list with HashSet
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Ola");
            hashSet.Add("Bon Giorno");
            hashSet.Add("Adeus");
            hashSet.Add("Adeus");
            hashSet.Add("Hello");

            Console.WriteLine("HashSet: ");
            foreach (string item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
