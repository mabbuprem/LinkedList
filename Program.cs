using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure");
            ManipulateList manipulateList = new ManipulateList();
            manipulateList.Insert(56);
            manipulateList.Insert(30);
            manipulateList.Insert(70);
            manipulateList.SearchInsert(30, 40);
            manipulateList.Display();

        }
    }
}
