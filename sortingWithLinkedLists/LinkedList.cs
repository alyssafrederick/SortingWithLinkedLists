using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingWithLinkedLists
{
    class LinkedList<T> where T : IComparable
    {
        Node<T> head;
        public int Size;

        public T this[int index]
        {
            get
            {
                Node<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.nextnode;
                }
                return current.Value;
            }
            set
            {
                Node<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.nextnode;
                }
                current.Value = value;
            }
        }

        public Node<T> First
        {
            get
            {
                return head;
            }
        }

        public Node<T> Last
        {
            get
            {
                return head.lastNode;
            }
        }

        public void Add(T value)
        {
            //if head is null, insert and move on
            if (head == null)
            {
                head = new Node<T>(value);
                head.nextnode = head;
                head.lastNode = head;
                return;
            }

            //if head isn't null find the end of list
            if (head != null)
            {
                //make a temp value
                Node<T> temp = head;

                //you can move back instead of iterating forward
                //while the nextnode is the head then keep going through the list
                while (temp.nextnode != head)
                {
                    temp = temp.nextnode;
                }

                temp.nextnode = new Node<T>(value);

                temp.nextnode.nextnode = head;
                head.lastNode = temp.nextnode;
                temp.nextnode.lastNode = temp;
            }

            Size++;
        }

        public void AddAfter(T value, int index)
        {
            Node<T> temp = head;
            int count = 0; //should be 0

            //find the index to place the newNode after
            while (count < index - 1)
            {
                temp = temp.nextnode;
                count++;
            }

            //just creating a name for the new node
            Node<T> newNode = new Node<T>(value);

            //setting the newNode's nextnode and lastnode
            newNode.nextnode = temp.nextnode;
            newNode.lastNode = temp;

            //connecting the newNode's nextnode and lastnode to the newNode
            temp.nextnode.lastNode = newNode;
            temp.nextnode = newNode;

            Size++;
        }

        public void AddBefore(T value, int index)
        {
            Node<T> temp = head;
            int count = 0; //should be 0

            //find the index to place the newNode after
            while (count < index - 1)
            {
                temp = temp.nextnode;
                count++;
            }

            //just creating a name for the new node
            Node<T> newNode = new Node<T>(value);

            //setting the newNode's nextnode and lastnode 
            newNode.nextnode = temp;
            newNode.lastNode = temp.lastNode;

            //connecting the newNode's nextnode and lastnode to the newNode
            temp.lastNode.nextnode = newNode;
            temp.lastNode = newNode;

            Size++;
        }

        public void AddToStart(T value)
        {
            if (head == null)
            {
                Add(value);
            }

            else
            {
                //just creating a name for the new node
                Node<T> newNode = new Node<T>(value);

                //setting the newNode's nextnode and lastnode 
                newNode.nextnode = head;
                newNode.lastNode = head.lastNode;

                //connecting the newNode's nextnode and lastnode to the newNode
                head.lastNode.nextnode = newNode;
                head.lastNode = newNode;

                //changing the head to the newNode
                head = newNode;
            }


            Size++;
        }

        public bool Find(int value)
        {
            Node<T> temp = head;

            //going through the list until you come back to the head or find the value
            while (temp.nextnode != head && temp.Value.CompareTo(value) != 0)
            {
                temp = temp.nextnode;
            }

            //if you find the number then output true
            if (temp.Value.CompareTo(value) == 0)
            {
                return true;
            }

            //if you are at the head again aka if you did not find the value then output false
            else
            {
                return false;
            }
        }

        //public bool switched;
        //public void Switch(T value)
        //{
        //    Node<T> temp = head;

        //    if (head.Value.CompareTo(value) > head.nextnode.Value.CompareTo(value))
        //    {
        //        head.nextnode = head.nextnode.nextnode;
        //        head.nextnode.nextnode.lastNode = head;
        //        head.lastNode.nextnode = head.nextnode;
        //        head.nextnode.lastNode = head.lastNode;
        //        head.nextnode.nextnode = head;
        //        head.lastNode = head.nextnode;

        //        switched = true;
        //    }
        //}

    }
}
