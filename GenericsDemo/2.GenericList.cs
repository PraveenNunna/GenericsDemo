using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public interface IGenericList<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);
    }
    class GenericList<T> : IEnumerable<T>, IGenericList<T>
    {
        private class Node
        {
            public Node next { get; set; }
            public T Data { get; set; }
            public Node(T data)
            {
                this.Data = data;
                next = null;
            }
        }
        private Node Head;

        public void Add(T item)
        {
            if (Head == null)
            {
                Head = new Node(item);
            }
            else
            {
                var itemToAdd = new Node(item);
                itemToAdd.next = Head;
                Head = itemToAdd;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.next;
            }
        }
    }

    public class UsingGenericList
    {
        public void AddItemToList()
        {
            var list = new GenericList<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

// We can apply constraints on type T. We can specify whether we need a class, struct or a base class to be the type. So that, we can get intelligence on the type mentioned with in the Generic class.

// For example, in the above example, we can say  GenericList<T> : IEnumerable<T>, IGenericList<T> where T: IEmployee. only implementations of IEmployee can be created using this generic list.
// So we can use methods available in IEmployee in the generic class.