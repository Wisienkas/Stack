using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackUtil
    {
        public static string ReverseString(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s.ToCharArray())
                stack.Push(c);

            String reverse = "";
            while (!stack.IsEmpty())
                reverse += stack.Pop();

            return reverse;
        }

        public static bool IsPalindrome(string palindrome)
        {
            palindrome = palindrome.Replace(" ", "");
            palindrome = palindrome.Replace(".", "");
            palindrome = palindrome.Replace(",", "");

            return palindrome.Equals(ReverseString(palindrome));
        }
    }

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
