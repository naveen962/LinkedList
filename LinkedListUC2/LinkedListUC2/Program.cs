using System;
using System.Collections.Generic;

namespace LinkedListUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(70);
            ll.AddFirst(30);
            ll.AddFirst(56);

            foreach(int ele in ll)
            {
                Console.Write(" " + ele + " ");
            }
        }
    }
}
