using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise2
{
    class Node
    {
        public int value;           //the data that the node need to store   
        public Node next;        //address of the next node
        public Node(int v,Node n)
        {
            value = v;
            next = n;
        }
    }
}
