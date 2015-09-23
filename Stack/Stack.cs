using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        private List<T> list;

        public Stack()
        {
            list = new List<T>();
        }

        public T Pop()
        {
            T t = list.Last();

            list.RemoveAt(list.Count - 1);

            return t;
        }

        public void Push(T t)
        {
            list.Add(t);
        }

        public T Peek()
        {
            return list.Last();
        }

        public int Size()
        {
            return list.Count();
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}
