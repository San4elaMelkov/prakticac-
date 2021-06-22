using System;
using System.Collections;
using System.Collections.Generic;

namespace praktikaMelkov
{
    internal partial class laba16
    {
        public static void print()
        {
            var list = new OrderList<int>();
            list.Add(2);
            list.Add(10);
            list.Add(4);
            Console.WriteLine(list.ListFrom(4));
        }

        public partial class Node<T> where T : IComparable<T>
        {
            public Node(T data)
            {
                Data = data;
            }

            public T Data { get; set; }
            public Node<T> Next { get; set; }
            public Node<T> NextValue { get; set; }
        }

        internal partial class OrderList<T> : IEnumerable<T> where T : struct, IComparable<T>
        {
            private Node<T> head;
            private Node<T> tail;
            private int countField;

            public int Count
            {
                get
                {
                    return countField;
                }
            }

            public bool IsEmpty
            {
                get
                {
                    return countField == 0;
                }
            }

            // добвление в начало
            public void Add(T data)
            {
                var node = new Node<T>(data);
                node.Next = head;
                var current = head;
                while (current is object)
                {
                    if (current.Data.CompareTo(node.Data) > -1 && current.NextValue == null)
                    {
                        node.NextValue = current;
                    }

                    current = current.Next;
                }

                head = node;
                if (countField == 0)
                {
                    head.NextValue = node;
                    tail = head;
                }
                    
                countField += 1;
            }

            public bool Remove(T data)
            {
                var current = head;
                Node<T> previous = null;
                while (current is object)
                {
                    if (current.Data.Equals(data))
                    {
                        // Если узел в середине или в конце
                        if (previous is object)
                        {
                            previous.Next = current.Next;
                            if (current.Next is null)
                                tail = previous;
                        }
                        else
                        {
                            head = head.Next;
                            if (head is null)
                                tail = null;
                        }

                        countField -= 1;
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }

                return false;
            }

            public IEnumerator<T> GetEnumerator()
            {
                var current = head;
                while (current is object)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }

            public string ListFrom(T data)
            {
                var current = head;
                string str = "";
                while (current is object)
                {
                    if (current.Data.CompareTo(data) > -1)
                    {
                        str += $"{current.Data} ";
                    }

                    current = current.NextValue;
                }

                return str;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)this).GetEnumerator();
            }
        }
    }
}