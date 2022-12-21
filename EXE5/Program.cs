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
            newnode.next = null;
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
        static void Main(string[] args)
        {
            Queue qe = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Menambahkan data ke dalam list");
                    Console.WriteLine("2. menghapus Data dari dalam list");
                    Console.WriteLine("3. Melihat Semua data di dalam list");
                    Console.WriteLine("4. Exit");
                    Console.Write("Masukkan pilihan anda (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            qe.Insert();
                            break;
                        case '2':
                            qe.Delete();
                            break;
                        case '3':
                            qe.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Wrong Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nCheck for the value entered");
                }
            }
        }
    }
    
}
