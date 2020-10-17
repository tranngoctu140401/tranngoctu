using System;

namespace Bai_3_Bai_TH_1
{
    class Stack
    {
        private int top;
        private int[] stack;
        public Stack()
        {
            top = -1;
            stack = new int[20];
        }
        public Stack (int n)
        {
            top = -1;
            stack = new int[n];
        }
        public bool rong()
        {
            return top == -1;
        }
        public bool day()
        {
            return top == stack.Length - 1;
        }
        public void push(int x)
        {
            if (day())
                Console.WriteLine("stack day");
            else
                stack[++top] = x;
        }
        public int pop()
        {
            if (rong()) throw new Exception("stack rong");
            else
            {
                int x = stack[top--];
                return x;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(6);
            stack.push(8);
            stack.pop();
            Console.ReadKey();
        }
    }
}
