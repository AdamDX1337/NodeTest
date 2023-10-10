using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeTest
{
    public class Node
    {
        public int num;
        public Node next;
        public Node(int number)
        {
            num = number;
            next = null;
        }
    }

    public class LinkedListA
    {
        public static Node mainNode;

        public static void Push(int number)
        {
            Node node = new Node(number);
            if (mainNode != null)
            {
                Node currentNode = mainNode;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = node;
            }
            else
            {
                mainNode = node;
            }
        }

        public static void Pop()
        {
            if (mainNode != null)
            {
                Node currentNode = mainNode;
                while (currentNode.next.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = null;
            }
            else
            {
                Console.WriteLine("Empty List");
            }
        }

        public static void Peek()
        {
            if (mainNode == null)
            {
                Console.WriteLine("Empty List");
            }
            else
            {
                Node current = mainNode;
                while (current.next != null)
                {
                    current = current.next;
                }
                Console.WriteLine(current.num);
            }
        }
    }
}
