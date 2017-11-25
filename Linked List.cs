using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Node {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.WriteLine("|" + data +"|");

            if (next != null) {
                next.Print(); 
            }
        }


        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }

            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }

            else
            {
                next.AddToEnd(data);
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }

            else {
                next.AddToEnd(data);

            }

        }
    }

    public class MyList {

        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }

            else
            {
                headNode.AddToEnd(data);
            }

        }


        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }

            else if (data < headNode.data)
            {
                AddToBegining(data);
            }

            else
            {
                headNode.AddSorted(data);
            }
        }

        public void AddToBegining(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }

        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }

       


    }


    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            /*  list.AddToEnd(9);
                list.AddToEnd(19);
                list.AddToEnd(29);
                list.AddToEnd(39);
                list.AddToEnd(49);

                list.AddToBegining(9);
                list.AddToBegining(19);
                list.AddToBegining(29);
                list.AddToBegining(39);
                list.AddToBegining(49);
                */

            list.AddSorted(9);
            list.AddSorted(5);
            list.AddSorted(7);
            list.AddSorted(11);

            list.Print();

        }

    }
}
