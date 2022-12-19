
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_Queues
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node diva, nafisyah;

        public queue()
        {
            diva = null;
            nafisyah = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element:");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (diva == null)
            {
                diva = newnode;
                nafisyah = newnode;
                return;
            }
            nafisyah.next = newnode;
            nafisyah = newnode;
        }
        public void delete()
        {
            if (diva == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            diva = diva.next;
            if (diva == null)
                nafisyah = null;
        }
        public void display()
        {
            if (diva == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node display;
            for (display = diva; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert Element");
                    Console.WriteLine("2. Delete Element");
                    Console.WriteLine("3. Display Element");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the value entered.");
                }
            }
        }
    }
}
