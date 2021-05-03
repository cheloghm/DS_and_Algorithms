using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms.DS_Arrays.LinkedList
{
    public class NodeD
    {
        public int value { get; set; }
        public NodeD next { get; set; }
        public NodeD previous { get; set; }

        public NodeD(int value)
        {
            this.value = value;
            this.next = null;
            this.previous = null;
        }
    }

    public class DoublyLinkedList
    {
        private NodeD head;
        private NodeD tail;
        private int length;

        public DoublyLinkedList(int value)
        {
            this.head = new NodeD(value);
            this.tail = this.head;
            this.length = 1;
        }

        public void append(int value)
        {
            NodeD newNodeD = new NodeD(value);
            newNodeD.previous = this.tail;
            this.tail.next = newNodeD;
            this.tail = newNodeD;
            this.length++;
        }

        public void prepend(int value)
        {
            NodeD newNodeD = new NodeD(value);
            newNodeD.next = this.head;
            this.head.previous = newNodeD;
            this.head = newNodeD;
            this.length++;
        }

        public void insert(int index, int value)
        {
            index = wrapIndex(index);
            if (index == 0)
            {
                prepend(value);
                return;
            }

            if (index == length - 1)
            {
                append(value);
                return;
            }

            NodeD newNodeD = new NodeD(value);

            NodeD leader = traverseToIndex(index - 1);
            NodeD follower = leader.next;

            leader.next = newNodeD;
            newNodeD.previous = leader;
            newNodeD.next = follower;
            follower.previous = newNodeD;

            this.length++;

        }

        public void remove(int index)
        {
            index = wrapIndex(index);
            if (index == 0)
            {
                head = head.next;
                return;
            }

            NodeD leader = traverseToIndex(index - 1);
            NodeD NodeDToRemove = leader.next;
            leader.next = NodeDToRemove.next;
            NodeDToRemove.next.previous = leader;
            this.length--;
        }

        public void printList()
        {
            if (this.head == null)
            {
                return;
            }
            NodeD current = this.head;
            while (current != null)
            {
                Console.Write("-->" + current.value);
                current = current.next;
            }
            Console.WriteLine();
        }

        public int getLength()
        {
            return this.length;
        }

        public NodeD getHead()
        {
            return this.head;
        }

        public NodeD getTail()
        {
            return this.tail;
        }

        private int wrapIndex(int index)
        {
            return Math.Max(Math.Min(index, this.length - 1), 0);
        }

        private NodeD traverseToIndex(int index)
        {
            int counter = 0;
            index = wrapIndex(index);
            NodeD currentNodeD = head;
            while (counter != index)
            {
                currentNodeD = currentNodeD.next;
                counter++;
            }
            return currentNodeD;
        }
    }
}
