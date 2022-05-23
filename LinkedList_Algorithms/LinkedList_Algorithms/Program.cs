using System;


class CustomLinkedList {

    Node head;
    public class Node {
        public int data;
        public Node next;
        public Node(int d) { data = d; }
    }

    public void deleteBackHalf() {

        if (head == null || head.next == null) {
            head = null;
        }

        Node slow = head;
        Node fast = head;
        Node prev = null;

        while(fast != null && fast.next != null) {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = null;
    }

    public void displayContents() {
        Node current = head;

        while(current != null) {
            Console.Write(current.data + "->");
            current = current.next;
        }
    }

    static void Main(string[] args) {
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
        linkedList.deleteBackHalf();
        Console.WriteLine();
        linkedList.displayContents();
    }

}
