using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SingleLinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice,data,x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Display List");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert an element in empty list/At beginning of the list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete a node");
                Console.WriteLine("12.Reverse the List");
                Console.WriteLine("13.Bubble Sort of the list");


                Console.Write(" enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
               
                if (choice == 19)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.Write("enter the element to be searched");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    case 4:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 5:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data,x);
                        break;
                    case 7:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element position at which to insert");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, x);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.Write("enter the element to be deleted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 13:
                        list.BubbleSort();
                        break;
                }

            }
        }
    }
}
