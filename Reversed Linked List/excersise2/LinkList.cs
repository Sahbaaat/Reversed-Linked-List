using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise2
{
    class LinkList
    {
        public Node first;                   //the first node of the linked list
        public Node last;                   //the last node of the linked list
        public int size;
        public LinkList()
        {
            first = null;
            last = null;
            size = 0;

        }
        public  LinkList Insert(LinkList l,int n)         //adds a new item to the list
        {
            Node newnode = new Node(n, null);
            if (first == null)                 //if the linked list is empty
            {
                first = newnode;
                last = first;
                l.size = 1;
            }
            else
            {
                last.next = newnode;
                last = last.next;
                l.size++;
            }
            return l;
        }

    }
}
