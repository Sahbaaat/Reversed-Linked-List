using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n :");
            int x = Convert.ToInt32(Console.ReadLine());
            LinkList linklist = Program.LinkListGeneration(x);
            printlinklist(linklist);                            //prints the original linkedlist
            RecursiveReverse(linklist.first);                //call the recursive reverse method
            Console.WriteLine();
            Console.Write(newfirst.value);                    //print the first node of reversed linked list
            Console.Write("->");
            printlinklist(a);                                   //print the reversed linked list
            Console.ReadKey();

        }
        public static void printlinklist(LinkList l)          //aa method for printing the linkedlist
        {
            Node f = l.first;
            for (int i = 0; i < l.size; i++)
            {

                Console.Write(f.value);
                Console.Write("->");
                f = f.next;
            }
            Console.Write("null");

        }
        public  static LinkList LinkListGeneration(int n)              //Creates a linked list
        {
            Random rndm = new Random();
            LinkList list = new LinkList();
            for (int i = 0; i < n; i++)
            {
                int Random = rndm.Next(0, 100);
                list.Insert(list, Random);
            }

            return list;
        }

        public static Node newfirst;
        static LinkList a;
        public static void RecursiveReverse(Node first)           //reverse the linked list by using recursion
        {
             a = new LinkList();
            newfirst = new Node(0, null);

            if (first.next == null)                          //checks if there is one node in the linked list
            {
                newfirst = first;      //the new first node of reversed linked list
                return ;
            }
            
            RecursiveReverse(first.next);

            Node q = first.next;
            q.next = first;
            first.next = null;
            a.Insert(a, first.value);           // 'a' is our reversed linked list


        }
    }

}
