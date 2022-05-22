using System;

class CustomLinkedList 
{
    Node head;
    public class Node 
    {
        public int data;
        public Node next;
        public Node(int d) { data = d; }
    }

    public void deleteKthNodeFromEnd(int k) 
    {

        if (head == null || k == 0) 
        {
            return;
        }
        
        // [a, b, c, d]
        // k = 2
        Node first = head;
        Node second = head;

        for (int i = 0; i < k; i++) 
        {
            second = second.next;
            if (second.next == null)
            {
                // K >= Length of List
                if (i == k - 1) 
                {
                    head = head.next;
                }
                return;
            }
        }

        // second = c

        while(second.next != null) 
        {
            first = first.next;
            second = second.next;
        }

        // first = b
        // second = d

        // [a, b, c, d]
        // k = 2

        first.next = first.next.next;
    }

    public void displayContents() 
    {
        Node current = head;

        while(current != null) 
        {
            Console.Write(current.data + "->");
            current = current.next;
        }
    }

    static void Main(string[] args) 
    {
        CustomLinkedList linkedList = new CustomLinkedList();
        Node firstNode = new Node(3);
        Node secondNode = new Node(4);
        Node thirdNode = new Node(5);
        Node fourthNode = new Node(6);

        linkedList.head = firstNode;
        firstNode.next = secondNode;
        secondNode.next = thirdNode;
        thirdNode.next = fourthNode;

        linkedList.displayContents();
        linkedList.deleteKthNodeFromEnd(2);
        Console.WriteLine();
        linkedList.displayContents();
    }
}
