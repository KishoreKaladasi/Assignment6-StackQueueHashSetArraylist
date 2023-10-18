using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_StackQueueHashSetArraylist
{
    public class Stackk
    {


        static void Main(string[] args)
        {
            WorkingWithStack();
            WorkingWithQueue();
            WorkingWithHashtable();
            WorkingWithArrayList();

            Console.ReadLine();

        }

        private static void WorkingWithArrayList()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("adding data into ArrayList");
            al.Add(100);
            al.Add("zim");
            al.Add(55);
            al.Add("zam");
            al.Add(5.23f);
            al.Add(6);
            al.Add(7.55);
            al.Add(8);
            al.Add(9);
            al.Add(10.55);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************************");
            object elementToFind = "zam";


            if (al.Contains(elementToFind))
            {
                Console.WriteLine("Element found in the ArrayList.");
                al.Remove(elementToFind);
                Console.WriteLine("Element removed in the ArrayList.");

            }
            else
            {
                Console.WriteLine("Element not found in the ArrayList.");
            }
            Console.WriteLine("after removing finded data the arrylist looks like :");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("************************************");
            Object[] array = new object[al.Count];
            al.CopyTo(array);



            int[] intArray = al.OfType<int>().ToArray();

            Console.WriteLine("Integers extracted from ArrayList:");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reverse and sorting the int array");
            Array.Sort(intArray);

            Array.Reverse(intArray);
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }

        private static void WorkingWithHashtable()
        {
            Hashtable t = new Hashtable();
            Console.WriteLine("data after adding");
            t.Add(1, "Jim");
            t.Add(100, 'A');
            //t.Add("1", 32234.33d);
            t.Add(2, 3.14f);
            t.Add(3, 122);
            foreach (DictionaryEntry item in t)
            {
                Console.WriteLine(item.Key + "   " + item.Value);

            }
            t.Remove(1);
            Console.WriteLine("data after removing");
            foreach (DictionaryEntry item in t)
            {
                Console.WriteLine(item.Key + "   " + item.Value);

            }

            Console.WriteLine("-----Show copied elements----- ");
            object[] objarr = new object[t.Count];
            t.CopyTo(objarr, 0);
            IEnumerator eObj = objarr.GetEnumerator();
            object o = null;
            while (eObj.MoveNext())
            {
                o = eObj.Current;
                Console.WriteLine(o);


            }
        }

        private static void WorkingWithQueue()
        {
            Console.WriteLine("add data");
            Queue q = new Queue();
            q.Enqueue(21);
            q.Enqueue(22);
            q.Enqueue("kishore");
            q.Enqueue(23.55f);
            q.Enqueue("rathod");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************************");
            Console.WriteLine("remove data by dequeue");
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************************");
            Console.WriteLine("finding count of queue");
            int cnt = q.Count;
            Console.WriteLine(cnt);
            Console.WriteLine("************************************");
            Console.WriteLine("peek returns first element of queue");
            object ob1 = q.Peek();
            Console.WriteLine(ob1);
            Console.WriteLine("************************************");
            Console.WriteLine("TrimToSize to queue");
            q.TrimToSize();
            Console.WriteLine("Data After TrimToSize to queue");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private static void WorkingWithStack()
        {
            Console.WriteLine("add data");
            Stack s1 = new Stack();
            s1.Push(10);
            s1.Push("rathod");
            s1.Push("kishore");
            s1.Push(40);
            s1.Push(2352.65f);
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************************");
            Console.WriteLine("pop data");
            s1.Pop();
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************************");
            Console.WriteLine("removing a particular data");
            Stack s2 = new Stack();
            foreach (var item in s1)
            {
                if (item != "rathod")
                {
                    s2.Push(item);
                }
            }
            Console.WriteLine("stack after deleting rathod data");
            foreach (var item in s2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************************");
            Console.WriteLine("peek returns top most element in stack");
            //s2.Peek();
            //for printing particular opertaion u need a object ----to print
            Object ob = s2.Peek();
            Console.WriteLine(ob);
            Console.WriteLine("************************************");
            //Console.WriteLine("clearing stack");
            //s2.Clear(); 
        }
    }

}
