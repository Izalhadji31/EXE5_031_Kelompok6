using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class Queue
    {
        public Node muh, syafrizal;

        public Queue()
        {
            muh = null;
            syafrizal = null;
        }
        public void Insert()
        {
            string add;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element :");
            add = Console.ReadLine();
            newnode.name = add;
            newnode.next = syafrizal;
            if(muh == null)
            {
                muh = newnode;
                syafrizal = newnode;
                return;
            }
            syafrizal.next = newnode;
            syafrizal = newnode;
        }
        public void Delete()
        {
            if(muh == null)
            {
                Console.WriteLine("\nList is Empty");
                return;
            }
            syafrizal = syafrizal.next;
            if (muh == null)
                syafrizal = null;
        }
        public void Display()
        {
            if(muh == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return ;
            }
            Node display;
            for(display = muh; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class program
    {

    }
    
}
