using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class GenericList<T> : IEnumerable<T>
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
