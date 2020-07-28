using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace SingleLinkedList
{
    class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes");
           
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                
                p = p.link;
                n++;

            }
            Console.WriteLine("Number of nodes in the list=" + n);
            }
    public void Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                {
                    break;
                }
                
                p = p.link;
                
                position++;
            }
            if (p == null)
            {
                Console.WriteLine(x + "not found in the list");
                
            }
       else
            {
                Console.WriteLine(x + "is at position" + position);
              
            }
       }
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;

        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);
            if(start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while (p.link != null)
            {
                p = p.link;

            }
            p.link = temp;
        }
   
   
    public void AtLastNode()
        {
            Node p = start;
            while (p.link != null)
            {
                p = p.link;

            }
            Console.WriteLine(" at last node is: " + p.info);
        }
    
    public void AtSecondLastNode()
        {
            Node p = start;
            while (p.link.link != null)
            {
                p = p.link;
            }
            Console.WriteLine(" at Second last node is " + p.info);

        }
    public void predecessorOfGivenNode(int x)
        {
            Node p = start;
            while (p.link != null)
            {
                if(p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }
            Console.WriteLine("predecessor of given node is: " + p.info);
        }
    public void NodeAtParticularPosition(int x)
        {
            Node p = start;
            for(int i =1; i<x && p!=null; i++)
            {
                p = p.link;
            }
            Console.WriteLine("Element at" + x + " position is : " + p.info);
        }
        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                {
                    break;
                }
                p = p.link;

            }
            if (p == null)
            {
                Console.WriteLine(x + "not present in the list");
            }
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;

            }
        }
        public void InsertBefore(int data, int x)
        {
            Node temp;
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
                if (start.info == x)
                {
                    temp = new Node(data);
                    temp.link = start;
                    start = temp;
                    return;

                }
                Node p = start;
                while (p.link != null)
                {
                    if (p.link.info == x)
                    {
                        break;
                    }
                    p = p.link;
                }
                if (p.link == null)
                {
                    Console.WriteLine(x + "is not present in list");
                }
                else
                {
                    temp = new Node(data);
                    temp.link = p.link;
                    p.link = temp;

                }

            }
        }
       public void InsertAtPosition(int data,int x)
            {
                Node temp;
                Node p = start;
                if (x == 1)
                {
                    temp = new Node(data);
                    temp.link = start.link;
                    start.link = temp;
                    return;
                }
           for(int i=1; i<x-1 && p != null; i++)
                {
                    p = p.link;
                }
                if (p == null)
                {
                    Console.WriteLine(x + "is not presennt in the list");

                }
                else
                {
                    temp = new Node(data);
                    temp.link = p.link;
                    p.link = temp;
                }
            }

        public void DeleteFirstNode()
        {
            if (start == null)

                return;
            start = start.link;
        }
        public void DeleteLastNode() 
        {
            if (start == null)
                return;
            if(start.link == null)
            {
                start = null;
                return;
            }
            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;

            
        }
       public void DeleteNode(int x)
        {
            if(start == null)
            {
                Console.WriteLine("List empty");
                return;
            }
       if(start.info == x)
            {
                start = start.link;
                return;
            }
            Node p = start;
            while (p.link != null)
            {
                if(p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(" given element " + x + " is not present in the list");

            }
            else
            {
                p.link = p.link.link;
            }
        }
    public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;

            }
            start = prev;
        }
    
        public void BubbleSort()
        {
            Node p, q, end;
            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }
    }
    
    }
    
    
   

