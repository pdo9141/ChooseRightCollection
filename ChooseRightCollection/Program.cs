using System;
using System.Collections.Generic;
using System.Linq;

namespace ChooseRightCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deprecated Collections
            // ArrayList (use List<T> instead)
            // Hashtable (use Dictionary<TKey, TValue> instead)
            // Queue (use Queue<T> instead) 
            // SortedList (use SortedList<T> instead)
            // Stack  (use Stack<T> instead)

            // Concurrent Collections
            // ConcurrentQueue (Thread - safe version of a queue (FIFO))
            // ConcurrentStack (Thread - safe version of a stack(LIFO))
            // ConcurrentBag (Thread - safe unordered collection of objects. Optimized for situations where a thread may be bother reader and writer)
            // ConcurrentDictionary (Thread - safe version of a dictionary. Optimized for multiple readers (allows multiple readers under same lock))
            // BlockingCollection (Wrapper collection that implement producers &consumers paradigm. Readers can block until items are available to read.
            // Writers can block until space is available to write (if bounded).

            //GenericLinkedList();
            //GenericSortedDictionary();
            //GenericSortedList();
            //GenericHashSet();
            GenericSortedSet();
            Console.Read();
        }

        private static void GenericDictionary()
        {
            // Dictionary<TKey, TValue>
            // Unordered, lookup by key, best for high performance lookups
        }

        private static void GenericSortedDictionary()
        {
            // SortedDictionary<TKey, TValue>
            // Sorted, lookup by key, compromise of Dictionary speed and ordering, uses binary search tree

            SortedDictionary<string, int> sort = new SortedDictionary<string, int>();

            sort.Add("zebra", 5);
            sort.Add("cat", 2);
            sort.Add("dog", 9);
            sort.Add("mouse", 4);
            sort.Add("programmer", 100);

            foreach (KeyValuePair<string, int> p in sort)
                Console.WriteLine("{0} = {1}", p.Key, p.Value);
        }

        private static void GenericSortedList()
        {
            // SortedList<T>
            // Sorted, lookup by key, same as List<T> but slower since sorted

            SortedList<string, int> sorted = new SortedList<string, int>();
            sorted.Add("perls", 3);
            sorted.Add("dot", 1);
            sorted.Add("net", 2);

            foreach (var pair in sorted)
                Console.WriteLine(pair);
        }

        private static void GenericList()
        {
            // List<T>
            // User has precise control over element ordering, lookup via index, best for smaller lists where direct access required and no sorting
            // You can access by index very quickly but inserting and removing in the beginning or middle of list is very costly
        }

        private static void GenericLinkedList()
        {
            // LinkedList<T>
            // User has precise control over element ordering, no direct access, best for list where inserting/deleting in middle is common and no direct access required
            // You can insert and remove in the middle of list very quickly, you lose ability to index items by position quickly

            LinkedList<string> linked = new LinkedList<string>();
            linked.AddLast("one");
            linked.AddLast("two");
            linked.AddLast("three");

            LinkedListNode<string> node = linked.Find("one");
            linked.AddAfter(node, "inserted");

            foreach (var value in linked)
                Console.WriteLine(value);
        }

        private static void GenericHashSet()
        {
            // HashSet<T>
            // Unordered, lookup via key, unique unordered collection , like a Dictionary except key and value are same object
            // Unordered collection of unique items. Logically very similar to having Dictionary<TKey, TValue> where the key and value refer to same object
            // Like Dictionary, the type T should have a valid implementation of GetHashCode() and Equals()

            // Use to remove duplicates
            string[] array1 = { "cat", "dog", "cat", "leopard", "tiger", "cat" };
            Console.WriteLine(string.Join(",", array1));
            var hash = new HashSet<string>(array1);
            string[] array2 = hash.ToArray();
            Console.WriteLine(string.Join(",", array2));

            // Overlaps, check if any values overlap
            int[] array3 = { 1, 2, 3 };
            int[] array4 = { 3, 4, 5 };
            int[] array5 = { 9, 10, 11 };

            HashSet<int> set = new HashSet<int>(array3);
            bool a = set.Overlaps(array4);
            bool b = set.Overlaps(array5);
            Console.WriteLine(a);
            Console.WriteLine(b);

            // SymmetricExceptWith, changes HashSet so that it contains only the elements in one or the other collection, not both
            char[] array6 = { 'a', 'b', 'c' };
            char[] array7 = { 'b', 'c', 'd' };
            var hash1 = new HashSet<char>(array6);
            hash1.SymmetricExceptWith(array7);
            Console.WriteLine(hash1.ToArray());
        }

        private static void GenericSortedSet()
        {
            // SortedSet<T>
            // Sorted, lookup via key, unique sorted collection, like SortedDictionary except key and value are same object
            // Like HashSet but sorted, analagous to SortedDictionary<TKey, TValue> to Dictionary<TKey, TValue>

            SortedSet<string> set = new SortedSet<string>();

            set.Add("perls");
            set.Add("net");
            set.Add("dot");
            set.Add("sam");

            set.Remove("sam");

            foreach (string val in set)
                Console.WriteLine(val);            
        }

        private static void GenericStack()
        {
            // Stack<T>
            // last-in-first-out (LIFO)
            // Only top, essentially same as List<T> except only process as LIFO
        }

        private static void GenericQueue()
        {
            // Queue<T>
            // first-in-first-out (FIFO)
            // Only front, essentially same as List<T> except only process as FIFO
        }
    }
}
