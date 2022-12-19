
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
    }
    class program
    {
        static void Main(string[] args)
        {
        }
    }
}
