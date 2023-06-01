using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }
        
        public void InsertFirst(int data)
        {
            // Create the node
            Node newNode = new Node();
            // Put the data in the node
            newNode.Data = data;
            // Put the old node in the next property
            newNode.Next = First;
            // assign the new node to the first property
            First = newNode;
        }

        public Node DeleteFirst()
        {
            // Save the reference to the node we want to delete
            Node temp = First;
            // Delete the node by pointing the first property to the second node
            First = First.Next;
            // Return the deleted node
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through list...");
            Node current = First;

            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while(current.Next != null)
            {
                current = current.Next;
            }

            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}
