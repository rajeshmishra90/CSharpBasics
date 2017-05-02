using System;

namespace BasicsPractice
{
    public class MyLinkedList<T>
    {
        public MyLinkedList<T> Next { get; set; }
        public T Data { get; set; }

        public MyLinkedList(T data)
        {
            this.Data = data;
        }
    }

    public class MyStack<T>
    {
        private MyLinkedList<T> Head { get; set; }

        public void Push(T data)
        {
            var node = new MyLinkedList<T>(data);
            if (Head == null)
            {
                node.Next = null;
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public MyLinkedList<T> Pop()
        {
            if (Head == null)
                throw new Exception("Stack is empty.");
            var node = new MyLinkedList<T>(Head.Data);
            Head = Head.Next;
            return node;
        }
    }

    public class MyQueue<T>
    {
        private MyLinkedList<T> Front { get; set; }
        private MyLinkedList<T> End { get; set; }

        public void Enqueue(T data)
        {
            var node = new MyLinkedList<T>(data);
            if (End != null)
            {
                End.Next = node;
            }
            else
            {
                Front = node;
            }
            End = node;
        }

        public MyLinkedList<T> Dequeue()
        {
            if (Front == null)
                throw new Exception("stack is empty");
            else
            {
                var node = Front;
                Front = Front.Next;
                return node;
            }
        }
    }

    internal class Pallindrome
    {
        private static MyStack<char> stack = new MyStack<char>();
        private static MyQueue<char> queue = new MyQueue<char>();

        private static void MainR(String[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Pallindrome obj = new Pallindrome();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                char pop = obj.popCharacter();
                char deq = obj.dequeueCharacter();
                if (pop != deq)
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }

        private char dequeueCharacter()
        {
            return queue.Dequeue().Data;
        }

        private char popCharacter()
        {
            return stack.Pop().Data;
        }

        private void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        private void pushCharacter(char c)
        {
            stack.Push(c);
        }
    }
}